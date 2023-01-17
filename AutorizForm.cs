using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonKrasotiIS.Entity;

namespace SalonKrasotiIS
{
    public partial class AutorizForm : Form
    {
        public AutorizForm()
        {
            
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#ffffff");
            registButton.BackColor = ColorTranslator.FromHtml("#89d2bc");
            enterButton.BackColor = ColorTranslator.FromHtml("#89d2bc");
            Random rnd = new Random();
            int value = rnd.Next(1000, 10000);
            captchaLabel.Text = value.ToString();
        }
        SalonKrasotiDB db = new SalonKrasotiDB();

        public Пользователи USER { get; private set; }
        public Клиент user { get; set; }
        public Authorization Клиент { get; private set; }
        public Authorization FORMA { get; set; }
        private void enterButton_Click(object sender, EventArgs e)
        {
            string logiUser = loginTextBox.Text;
            string passUser = passwTextBox.Text;

            Пользователи usr = db.Пользователи.SingleOrDefault(m => m.Логин == logiUser);
            if ((usr != null) && (usr.Пароль == passUser))
            {
                if (captchaLabel.Text != captchaTextBox.Text)
                {
                    MessageBox.Show("Не верная капча");
                    return;
                }

                USER = usr;
                if (usr.IDРоли == 1)
                {
                    adminForm admin = new adminForm();
                    admin.Show();
                    this.Hide();
                }
                else if (usr.IDРоли == 2)
                {
                    SotrudnikForm parih = new SotrudnikForm();
                    parih.Show();
                    this.Hide();
                }
                else if (usr.IDРоли == 3)
                {
                    SotrudnikForm rest = new SotrudnikForm();
                    rest.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Роли{usr.IDРоли} в системе нет");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем не существует");
                return;
            }
        }

        private void registButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrForm registrForm = new registrForm();
            registrForm.Show();
        }
    }
}
