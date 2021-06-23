namespace СВГК
{
    partial class Barcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode));
            this.btnBarcode = new System.Windows.Forms.Button();
            this.textBarcode = new System.Windows.Forms.TextBox();
            this.pictureBarcode = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarcode.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBarcode.Location = new System.Drawing.Point(50, 207);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(167, 60);
            this.btnBarcode.TabIndex = 0;
            this.btnBarcode.Text = "Сгенерировать";
            this.btnBarcode.UseVisualStyleBackColor = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // textBarcode
            // 
            this.textBarcode.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBarcode.Location = new System.Drawing.Point(238, 165);
            this.textBarcode.Multiline = true;
            this.textBarcode.Name = "textBarcode";
            this.textBarcode.Size = new System.Drawing.Size(161, 32);
            this.textBarcode.TabIndex = 2;
            this.textBarcode.Text = "0093758265916583";
            // 
            // pictureBarcode
            // 
            this.pictureBarcode.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBarcode.Location = new System.Drawing.Point(152, 25);
            this.pictureBarcode.Name = "pictureBarcode";
            this.pictureBarcode.Size = new System.Drawing.Size(161, 107);
            this.pictureBarcode.TabIndex = 1;
            this.pictureBarcode.TabStop = false;
            this.pictureBarcode.Click += new System.EventHandler(this.pictureBarcode_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(238, 207);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(176, 60);
            this.save.TabIndex = 3;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Код проекта:";
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(463, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBarcode);
            this.Controls.Add(this.pictureBarcode);
            this.Controls.Add(this.btnBarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Штрих-код";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.PictureBox pictureBarcode;
        private System.Windows.Forms.TextBox textBarcode;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
    }
}