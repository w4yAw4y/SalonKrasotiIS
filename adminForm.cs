using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonKrasotiIS
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void Usersbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminUSERSForm adminUSERSForm = new adminUSERSForm();
            adminUSERSForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminZAPISForm adminZAPISForm = new adminZAPISForm();
            adminZAPISForm.Show();
        }
    }
}
