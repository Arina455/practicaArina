namespace СВГК
{
    partial class Autorization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.input_captcha = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pass_word = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Label();
            this.captcha = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.change_captcha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.visiblepassword = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.captcha_img = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captcha_img)).BeginInit();
            this.SuspendLayout();
            // 
            // input_captcha
            // 
            this.input_captcha.AutoSize = true;
            this.input_captcha.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_captcha.Location = new System.Drawing.Point(221, 187);
            this.input_captcha.Name = "input_captcha";
            this.input_captcha.Size = new System.Drawing.Size(188, 33);
            this.input_captcha.TabIndex = 29;
            this.input_captcha.Text = "Введите капчу:";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(33, 117);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(162, 43);
            this.login.TabIndex = 28;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(231, 117);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(149, 43);
            this.password.TabIndex = 27;
            // 
            // pass_word
            // 
            this.pass_word.AutoSize = true;
            this.pass_word.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_word.Location = new System.Drawing.Point(226, 81);
            this.pass_word.Name = "pass_word";
            this.pass_word.Size = new System.Drawing.Size(111, 33);
            this.pass_word.TabIndex = 25;
            this.pass_word.Text = "Пароль:";
            // 
            // log_in
            // 
            this.log_in.AutoSize = true;
            this.log_in.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_in.Location = new System.Drawing.Point(30, 81);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(93, 33);
            this.log_in.TabIndex = 24;
            this.log_in.Text = "Логин:";
            // 
            // captcha
            // 
            this.captcha.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captcha.Location = new System.Drawing.Point(227, 314);
            this.captcha.Multiline = true;
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(170, 40);
            this.captcha.TabIndex = 23;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(171, 364);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(95, 56);
            this.enter.TabIndex = 22;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // change_captcha
            // 
            this.change_captcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.change_captcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_captcha.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_captcha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.change_captcha.Location = new System.Drawing.Point(70, 223);
            this.change_captcha.Name = "change_captcha";
            this.change_captcha.Size = new System.Drawing.Size(126, 85);
            this.change_captcha.TabIndex = 21;
            this.change_captcha.Text = "Сменить капчу";
            this.change_captcha.UseVisualStyleBackColor = false;
            this.change_captcha.Click += new System.EventHandler(this.change_captcha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "СРЕДНЕВОЛЖСКАЯ ГАЗОВАЯ КОМПАНИЯ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // visiblepassword
            // 
            this.visiblepassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visiblepassword.BackgroundImage = global::СВГК.Properties.Resources.png_clipart_computer_icons_eye_eye_people_color;
            this.visiblepassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.visiblepassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visiblepassword.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.visiblepassword.Location = new System.Drawing.Point(379, 117);
            this.visiblepassword.Name = "visiblepassword";
            this.visiblepassword.Size = new System.Drawing.Size(37, 43);
            this.visiblepassword.TabIndex = 32;
            this.visiblepassword.UseVisualStyleBackColor = false;
            this.visiblepassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::СВГК.Properties.Resources.n_U9fnNHzgA;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(110, 166);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(217, 192);
            this.logo.TabIndex = 31;
            this.logo.TabStop = false;
            // 
            // captcha_img
            // 
            this.captcha_img.Location = new System.Drawing.Point(227, 223);
            this.captcha_img.Name = "captcha_img";
            this.captcha_img.Size = new System.Drawing.Size(170, 85);
            this.captcha_img.TabIndex = 26;
            this.captcha_img.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 600000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(462, 454);
            this.Controls.Add(this.visiblepassword);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_captcha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.captcha_img);
            this.Controls.Add(this.pass_word);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.change_captcha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Autorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captcha_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_captcha;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox captcha_img;
        private System.Windows.Forms.Label pass_word;
        private System.Windows.Forms.Label log_in;
        private System.Windows.Forms.TextBox captcha;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button change_captcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button visiblepassword;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

