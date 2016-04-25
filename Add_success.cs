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

        public Add_success(add_advertisment First, string s)
        {
            first = First;
            InitializeComponent();
            label1.Text = s;
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            first.add();
            this.Close();
        }
    }
}
