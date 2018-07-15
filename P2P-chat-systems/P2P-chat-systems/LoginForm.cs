using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2P_chat_systems
{
    public partial class LoginForm : Form
    {
        string userName = "";

        public string UserName
        {
            get { return userName; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userName = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please select a user name up to 32 characters.");
                return;
            }

            this.FormClosing -= LoginForm_FormClosing;
            this.Close();
        }
    }
}
