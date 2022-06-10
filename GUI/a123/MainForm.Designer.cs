/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 3:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace a123
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.combo_role = new System.Windows.Forms.ComboBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.Exit_btn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(720, 450);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(321, 65);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.btn_LOGIN);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
            // 
            // label_Login
            // 
            this.label_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Login.Location = new System.Drawing.Point(720, 26);
            this.label_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(321, 47);
            this.label_Login.TabIndex = 4;
            this.label_Login.Text = "LOGIN";
            this.label_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Login.Click += new System.EventHandler(this.Label1Click);
            // 
            // combo_role
            // 
            this.combo_role.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.combo_role.BackColor = System.Drawing.SystemColors.Window;
            this.combo_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.combo_role.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.combo_role.FormattingEnabled = true;
            this.combo_role.Items.AddRange(new object[] {
            "Manager",
            "Client"});
            this.combo_role.Location = new System.Drawing.Point(720, 87);
            this.combo_role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_role.Name = "combo_role";
            this.combo_role.Size = new System.Drawing.Size(320, 38);
            this.combo_role.TabIndex = 5;
            this.combo_role.Text = "SELECT ROLE";
            this.combo_role.SelectedIndexChanged += new System.EventHandler(this.ComboBox);
            // 
            // label_username
            // 
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_username.Location = new System.Drawing.Point(493, 228);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(321, 82);
            this.label_username.TabIndex = 6;
            this.label_username.Text = "USERNAME";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_username.Click += new System.EventHandler(this.Label2Click);
            // 
            // label_pass
            // 
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_pass.Location = new System.Drawing.Point(493, 313);
            this.label_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(321, 82);
            this.label_pass.TabIndex = 7;
            this.label_pass.Text = "PASSWORD";
            this.label_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pass.Click += new System.EventHandler(this.Label3Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBox_password.ForeColor = System.Drawing.Color.Black;
            this.textBox_password.Location = new System.Drawing.Point(780, 329);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(389, 46);
            this.textBox_password.TabIndex = 8;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.ForeColor = System.Drawing.Color.Black;
            this.textBox_username.Location = new System.Drawing.Point(780, 244);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(389, 46);
            this.textBox_username.TabIndex = 9;
            this.textBox_username.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Exit_btn.Location = new System.Drawing.Point(1183, 0);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(35, 38);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "x";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_btn.Click += new System.EventHandler(this.btn_EXIT);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1219, 567);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.combo_role);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.button_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(-224, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a123";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label Exit_btn;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.Label label_pass;
		private System.Windows.Forms.Label label_username;
		private System.Windows.Forms.ComboBox combo_role;
		private System.Windows.Forms.Label label_Login;
		private System.Windows.Forms.Button button_login;
		private System.Windows.Forms.TextBox textBox_username;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
