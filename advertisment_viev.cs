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
    public partial class advertisment_viev : Form
    {
        public advertisment_viev(Advertisment A, Form1 form)
        {
            InitializeComponent();
            Text1.Text = A.Text;
            Content1.Text = A.Content;
            User_name.Text = A.User_name;
            Telephone.Text = form.DB.Users[User_name.Text].Telephone;
        }
    }
}
