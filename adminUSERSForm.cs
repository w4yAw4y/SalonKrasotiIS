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
    public partial class adminUSERSForm : Form
    {
        public adminUSERSForm()
        {
            InitializeComponent();
        }

        private void adminUSERSForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm adminForm = new adminForm();
            adminForm.Show();
        }
    }
}
