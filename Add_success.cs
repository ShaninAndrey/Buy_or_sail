using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buy_Or_Sail
{
    public partial class Add_success : Form
    {
        add_advertisment first;
        Form1 second;
        int k;

        public Add_success(add_advertisment First)
        {
            first = First;
            k = 1;
            InitializeComponent();
        }
        public Add_success(Form1 First)
        {
            second = First;
            k = 2;
            InitializeComponent();
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            if (k == 1) first.add(); else second.delete_adv();
            this.Close();
        }
    }
}
