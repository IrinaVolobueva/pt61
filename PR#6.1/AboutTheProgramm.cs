using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._1
{
    public partial class AboutTheProgramm : Form
    {
        public AboutTheProgramm()
        {
            InitializeComponent();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link.LinkVisited = true;
            System.Diagnostics.Process.Start("https://e.mail.ru/inbox/?app_id_mytracker=58519&authid=lq9pb4ex.2t9&back=1&dwhsplit=s10273.b1ss12743s&from=login%2Cnavi%2Cnavi%2Cnavi%2Cnavi&x-login-auth=1");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
