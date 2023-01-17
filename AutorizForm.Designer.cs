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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwLabel = new System.Windows.Forms.Label();
            this.autorizLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.registButton = new System.Windows.Forms.Button();
            this.captchaLabel = new System.Windows.Forms.Label();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(164, 62);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(60, 24);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин:";
            // 
            // passwLabel
            // 
            this.passwLabel.AutoSize = true;
            this.passwLabel.Location = new System.Drawing.Point(153, 110);
            this.passwLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwLabel.Name = "passwLabel";
            this.passwLabel.Size = new System.Drawing.Size(71, 24);
            this.passwLabel.TabIndex = 1;
            this.passwLabel.Text = "Пароль:";
            // 
            // autorizLabel
            // 
            this.autorizLabel.AutoSize = true;
            this.autorizLabel.Location = new System.Drawing.Point(248, 9);
            this.autorizLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autorizLabel.Name = "autorizLabel";
            this.autorizLabel.Size = new System.Drawing.Size(109, 24);
            this.autorizLabel.TabIndex = 2;
            this.autorizLabel.Text = "Авторизация";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(231, 62);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(180, 30);
            this.loginTextBox.TabIndex = 3;
            // 
            // passwTextBox
            // 
            this.passwTextBox.Location = new System.Drawing.Point(231, 110);
            this.passwTextBox.Name = "passwTextBox";
            this.passwTextBox.Size = new System.Drawing.Size(180, 30);
            this.passwTextBox.TabIndex = 4;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(79, 251);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(123, 39);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // registButton
            // 
            this.registButton.Location = new System.Drawing.Point(394, 251);
            this.registButton.Name = "registButton";
            this.registButton.Size = new System.Drawing.Size(123, 39);
            this.registButton.TabIndex = 6;
            this.registButton.Text = "Регистрация";
            this.registButton.UseVisualStyleBackColor = true;
            this.registButton.Click += new System.EventHandler(this.registButton_Click);
            // 
            // captchaLabel
            // 
            this.captchaLabel.AutoSize = true;
            this.captchaLabel.Location = new System.Drawing.Point(280, 152);
            this.captchaLabel.Name = "captchaLabel";
            this.captchaLabel.Size = new System.Drawing.Size(57, 24);
            this.captchaLabel.TabIndex = 7;
            this.captchaLabel.Text = "Капча";
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Location = new System.Drawing.Point(252, 192);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(118, 30);
            this.captchaTextBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 56);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalonKrasotiIS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // AutorizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this.captchaLabel);
            this.Controls.Add(this.registButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.autorizLabel);
            this.Controls.Add(this.passwLabel);
            this.Controls.Add(this.loginLabel);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AutorizForm";
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

