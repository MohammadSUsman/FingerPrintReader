using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxGrFingerXLib;
using GrFingerXLib;
using System.Runtime.InteropServices;

namespace FingerPrintReader
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr ptr);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);
        public TRawImage raw;
        TTemplate tpt = new TTemplate();
        public Form1()
        {
            InitializeComponent();
        }

        private void axGrFingerXCtrl1_SensorPlug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent e)
        {
            axGrFingerXCtrl1.CapStartCapture(e.idSensor);
        }

        private void axGrFingerXCtrl1_SensorUnplug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent e)
        {
            axGrFingerXCtrl1.CapStopCapture(e.idSensor);
        }

        private void axGrFingerXCtrl1_FingerDown(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent e)
        {

        }

        private void axGrFingerXCtrl1_ImageAcquired(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent e)
        {
            raw.img = e.rawImage;
            raw.height = (int)e.height;
            raw.width = (int)e.width;
            raw.Res = e.res;

            tpt._size = (int)GRConstants.GR_MAX_SIZE_TEMPLATE;
            IntPtr hdc = GetDC(System.IntPtr.Zero);
            Image handle = null;
            axGrFingerXCtrl1.CapRawImageToHandle(ref e.rawImage, e.width, e.height, hdc.ToInt32(), ref handle);
            if (handle != null)
            {
                axGrFingerXCtrl1.Extract(ref raw.img, raw.width, raw.height, raw.Res, ref tpt._tpt, ref tpt._size, (int)GRConstants.GR_DEFAULT_CONTEXT);
                axGrFingerXCtrl1.BiometricDisplay(ref tpt._tpt, ref raw.img, raw.width, raw.height, raw.Res, hdc.ToInt32(), ref handle, (int)GRConstants.GR_NO_CONTEXT);
                pictureBox1.Image = handle;
                pictureBox1.Update();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            axGrFingerXCtrl1.CapFinalize();
            axGrFingerXCtrl1.Finalize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axGrFingerXCtrl1.Initialize();
            axGrFingerXCtrl1.CapInitialize();
        }
    }
}
