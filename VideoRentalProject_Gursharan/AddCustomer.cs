﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalProject_Gursharan
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                DatabaseFunctions database = new DatabaseFunctions();
                database.addnewcustomer(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Customer Added");
                Dispose();
            }
        }
    }
}
