using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medcine_ManagmentSystem
{
    public partial class frmCustomerRecipit : Form
    {
        public frmCustomerRecipit()
        {
            InitializeComponent();
        }

        private void CustomerRecipit_Load(object sender, EventArgs e)
        {
            getCustomerRecipit();
        }
        public void getCustomerRecipit()
        {
            dgvCustomerRecipit.DataSource = CustomerRecpit.getTable();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CustomerRecpit.Insert(txtVocherID.Text, txtDateAndTime.Text, Convert.ToDouble(txtAmount.Text), txtCompanyID.Text))
            {
                MessageBox.Show("Test");
                getCustomerRecipit();
            }
            else
            {
                MessageBox.Show("Unable");
            }
            
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CustomerRecpit.Update (txtVocherID.Text, txtDateAndTime.Text, Convert.ToDouble(txtAmount.Text), txtCompanyID.Text))
            {
                MessageBox.Show("update");
                getCustomerRecipit();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CustomerRecpit.Delete (txtVocherID.Text, txtDateAndTime.Text, Convert.ToDouble(txtAmount.Text), txtCompanyID.Text))
            {
                MessageBox.Show("delete");
                getCustomerRecipit();
            }
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (CustomerRecpit.Insert(Convert.ToInt32(txtVocherID.Text), (Convert.ToInt32(txtCompanyID.Text)), (Convert.ToInt32(txtAmount.Text)), txtDateAndTime.Text))
        //    {
        //        MessageBox.Show("data has been Update");
        //        getCustomerRecipit();
        //    }
        //    else
        //    {
        //        MessageBox.Show("data hasnot been Update");
        //    }
        //}
    }
}
