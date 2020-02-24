namespace InsysAlphaList
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.DatabaseCB = new System.Windows.Forms.ComboBox();
            this.ServerTxtbox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CheckConnBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(39, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(39, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::InsysAlphaList.Properties.Resources.db_32;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(31, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 25);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.BackColor = System.Drawing.Color.White;
            this.UsernameTxtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtbox.ForeColor = System.Drawing.Color.LightGray;
            this.UsernameTxtbox.Location = new System.Drawing.Point(68, 59);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(183, 31);
            this.UsernameTxtbox.TabIndex = 2;
            this.UsernameTxtbox.Text = "Username";
            this.UsernameTxtbox.Enter += new System.EventHandler(this.UsernameTxtbox_Enter);
            this.UsernameTxtbox.Leave += new System.EventHandler(this.UsernameTxtbox_Leave);
            this.UsernameTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.UsernameTxtbox_Validating);
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.BackColor = System.Drawing.Color.White;
            this.PasswordTxtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtbox.ForeColor = System.Drawing.Color.LightGray;
            this.PasswordTxtbox.Location = new System.Drawing.Point(68, 105);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.Size = new System.Drawing.Size(183, 31);
            this.PasswordTxtbox.TabIndex = 3;
            this.PasswordTxtbox.Text = "Password";
            this.PasswordTxtbox.Enter += new System.EventHandler(this.PasswordTxtbox_Enter);
            this.PasswordTxtbox.Leave += new System.EventHandler(this.PasswordTxtbox_Leave);
            // 
            // DatabaseCB
            // 
            this.DatabaseCB.BackColor = System.Drawing.Color.White;
            this.DatabaseCB.Enabled = false;
            this.DatabaseCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DatabaseCB.FormattingEnabled = true;
            this.DatabaseCB.Location = new System.Drawing.Point(63, 219);
            this.DatabaseCB.Name = "DatabaseCB";
            this.DatabaseCB.Size = new System.Drawing.Size(188, 29);
            this.DatabaseCB.TabIndex = 5;
            // 
            // ServerTxtbox
            // 
            this.ServerTxtbox.BackColor = System.Drawing.Color.White;
            this.ServerTxtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerTxtbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ServerTxtbox.Location = new System.Drawing.Point(68, 12);
            this.ServerTxtbox.Name = "ServerTxtbox";
            this.ServerTxtbox.Size = new System.Drawing.Size(183, 31);
            this.ServerTxtbox.TabIndex = 1;
            this.ServerTxtbox.Text = "Server Name";
            this.ServerTxtbox.Enter += new System.EventHandler(this.ServerTxtbox_Enter);
            this.ServerTxtbox.Leave += new System.EventHandler(this.ServerTxtbox_Leave);
            this.ServerTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.ServerTxtbox_Validating);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(39, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // CheckConnBtn
            // 
            this.CheckConnBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckConnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckConnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckConnBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckConnBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckConnBtn.Image = ((System.Drawing.Image)(resources.GetObject("CheckConnBtn.Image")));
            this.CheckConnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckConnBtn.Location = new System.Drawing.Point(26, 160);
            this.CheckConnBtn.Name = "CheckConnBtn";
            this.CheckConnBtn.Size = new System.Drawing.Size(236, 38);
            this.CheckConnBtn.TabIndex = 4;
            this.CheckConnBtn.Text = "Check Connection";
            this.CheckConnBtn.UseVisualStyleBackColor = false;
            this.CheckConnBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.Enabled = false;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBtn.ForeColor = System.Drawing.Color.White;
            this.ConnectBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConnectBtn.Image")));
            this.ConnectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConnectBtn.Location = new System.Drawing.Point(26, 255);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(236, 38);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.CheckConnBtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ServerTxtbox);
            this.Controls.Add(this.DatabaseCB);
            this.Controls.Add(this.PasswordTxtbox);
            this.Controls.Add(this.UsernameTxtbox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox UsernameTxtbox;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.ComboBox DatabaseCB;
        private System.Windows.Forms.TextBox ServerTxtbox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button CheckConnBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

