using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Medcine_ManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            panel2.Height = this.Height;
          //  llableProfile.Links link = new lin
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            sales.MdiParent = this;
            sales.Show();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            frmCompany company = new frmCompany();
            company.MdiParent = this;
            company.Width = this.Width-250;
            company.Height = this.Height-220;
            company.Show();

            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmCompany")
                {
                    frm.Focus();
                    FormFound = true;
                }
                else
                {
                    FormFound = false;
                }
            }
                //if (FormFound == false)
                //{
                //    Form2 f = new form2();
                //    f.Show();
                //}
            
 
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.MdiParent = this;
            customer.Show();

        }

        private void btnCustomerPayment_Click(object sender, EventArgs e)
        {
            frmCompanyPayment customerPayment = new frmCompanyPayment();
            customerPayment.MdiParent = this;
            customerPayment.Show();

        }

        private void btnCustomerRecipit_Click(object sender, EventArgs e)
        {
            frmCustomerRecipit customerRecipit = new frmCustomerRecipit();
            customerRecipit.MdiParent = this;
            customerRecipit.Show();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            frmMedicine medicine = new frmMedicine();
            medicine.MdiParent = this;
            medicine.Show();
        }

        private void btnPurches_Click(object sender, EventArgs e)
        {
            frmPurchase purchase = new frmPurchase();
            purchase.MdiParent = this;
            purchase.Location = new Point(208, 173);
            purchase.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // link.LinkData = "http://www.dotnetperls.com/";
            //Process.Start(e.Link.LinkData as string);
            
        }
    }
}
