namespace SalonKrasotiIS
{
    partial class AutorizForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lablCapcha = new System.Windows.Forms.Label();
            this.capchaTEXT = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passTBOX = new System.Windows.Forms.TextBox();
            this.loginTbox = new System.Windows.Forms.TextBox();
            this.regBUTTON = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 51);
            this.panel2.TabIndex = 28;
            // 
            // lablCapcha
            // 
            this.lablCapcha.AutoSize = true;
            this.lablCapcha.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lablCapcha.Location = new System.Drawing.Point(141, 182);
            this.lablCapcha.Name = "lablCapcha";
            this.lablCapcha.Size = new System.Drawing.Size(56, 22);
            this.lablCapcha.TabIndex = 37;
            this.lablCapcha.Text = "Капча";
            // 
            // capchaTEXT
            // 
            this.capchaTEXT.Location = new System.Drawing.Point(121, 219);
            this.capchaTEXT.Name = "capchaTEXT";
            this.capchaTEXT.Size = new System.Drawing.Size(100, 20);
            this.capchaTEXT.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 74);
            this.panel3.TabIndex = 35;
            // 
            // passTBOX
            // 
            this.passTBOX.Location = new System.Drawing.Point(135, 101);
            this.passTBOX.Name = "passTBOX";
            this.passTBOX.Size = new System.Drawing.Size(99, 20);
            this.passTBOX.TabIndex = 34;
            // 
            // loginTbox
            // 
            this.loginTbox.Location = new System.Drawing.Point(135, 73);
            this.loginTbox.Name = "loginTbox";
            this.loginTbox.Size = new System.Drawing.Size(99, 20);
            this.loginTbox.TabIndex = 33;
            // 
            // regBUTTON
            // 
            this.regBUTTON.AutoSize = true;
            this.regBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.regBUTTON.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regBUTTON.Location = new System.Drawing.Point(96, 297);
            this.regBUTTON.Name = "regBUTTON";
            this.regBUTTON.Size = new System.Drawing.Size(162, 22);
            this.regBUTTON.TabIndex = 32;
            this.regBUTTON.Text = "Зарегистрироваться";
            this.regBUTTON.Click += new System.EventHandler(this.regBUTTON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15F);
            this.label1.Location = new System.Drawing.Point(62, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Логин";
            // 
            // entButt
            // 
            this.entButt.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entButt.Location = new System.Drawing.Point(135, 255);
            this.entButt.Name = "entButt";
            this.entButt.Size = new System.Drawing.Size(74, 31);
            this.entButt.TabIndex = 29;
            this.entButt.Text = "Войти";
            this.entButt.UseVisualStyleBackColor = true;
            this.entButt.Click += new System.EventHandler(this.entButt_Click);
            // 
            // AutorizForm
            // 
            this.ClientSize = new System.Drawing.Size(327, 444);
            this.Controls.Add(this.lablCapcha);
            this.Controls.Add(this.capchaTEXT);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.passTBOX);
            this.Controls.Add(this.loginTbox);
            this.Controls.Add(this.regBUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entButt);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutorizForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AutorizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwLabel;
        private System.Windows.Forms.Label autorizLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button registButton;
        private System.Windows.Forms.Label captchaLabel;
        private System.Windows.Forms.TextBox captchaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lablCapcha;
        private System.Windows.Forms.TextBox capchaTEXT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passTBOX;
        private System.Windows.Forms.TextBox loginTbox;
        private System.Windows.Forms.Label regBUTTON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button entButt;
    }
}

