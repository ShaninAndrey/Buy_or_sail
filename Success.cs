﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buy_Or_Sail
{
    public partial class Success : Form
    {
        add_advertisment first;
        Form1 second;
        advertisment_viev third;
        int k;

        public Success(add_advertisment First)
        {
            first = First;
            k = 1;
            this.MaximizeBox = false;
            InitializeComponent();
            this.Text = "Add advertisment";
            label3.Visible = true;
        }
        public Success(Form1 First)
        {
            second = First;
            k = 2;
            InitializeComponent();
            this.Text = "Delete advertisments";
            this.MaximizeBox = false;
            label2.Visible = true;
        }
        public Success(advertisment_viev First)
        {
            third = First;
            k = 3;
            InitializeComponent();
            this.Text = "Save Advertisment";
            this.MaximizeBox = false;
            label1.Visible = true;
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            if (k == 1) first.add();
            else
                if (k == 2) second.delete_adv();
                else
                    third.save_advertisment();
            this.Close();
        }
    }
}
