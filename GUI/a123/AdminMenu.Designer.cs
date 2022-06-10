/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/30/2021
 * Time: 12:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace a123
{
	partial class AdminMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button_doctor = new System.Windows.Forms.Button();
			this.label_exit = new System.Windows.Forms.Label();
			this.button_department = new System.Windows.Forms.Button();
			this.button_room = new System.Windows.Forms.Button();
			this.button_nurse = new System.Windows.Forms.Button();
			this.label_menu = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button_admin_menu = new System.Windows.Forms.Button();
			this.button_patient = new System.Windows.Forms.Button();
			this.button_medicine = new System.Windows.Forms.Button();
			this.Main_menu = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(61, 135);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(290, 197);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// button_doctor
			// 
			this.button_doctor.BackColor = System.Drawing.SystemColors.Control;
			this.button_doctor.FlatAppearance.BorderSize = 0;
			this.button_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_doctor.ForeColor = System.Drawing.Color.Black;
			this.button_doctor.Location = new System.Drawing.Point(1, 61);
			this.button_doctor.Name = "button_doctor";
			this.button_doctor.Size = new System.Drawing.Size(120, 53);
			this.button_doctor.TabIndex = 69;
			this.button_doctor.Text = "Doctor";
			this.button_doctor.UseVisualStyleBackColor = false;
			this.button_doctor.Click += new System.EventHandler(this.btn_DOCTOR);
			// 
			// label_exit
			// 
			this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_exit.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label_exit.Location = new System.Drawing.Point(930, -3);
			this.label_exit.Name = "label_exit";
			this.label_exit.Size = new System.Drawing.Size(26, 31);
			this.label_exit.TabIndex = 62;
			this.label_exit.Text = "x";
			this.label_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_exit.Click += new System.EventHandler(this.Label4Click);
			// 
			// button_department
			// 
			this.button_department.BackColor = System.Drawing.SystemColors.Control;
			this.button_department.FlatAppearance.BorderSize = 0;
			this.button_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_department.ForeColor = System.Drawing.Color.Black;
			this.button_department.Location = new System.Drawing.Point(1, 357);
			this.button_department.Name = "button_department";
			this.button_department.Size = new System.Drawing.Size(120, 53);
			this.button_department.TabIndex = 68;
			this.button_department.Text = "Department";
			this.button_department.UseVisualStyleBackColor = false;
			this.button_department.Click += new System.EventHandler(this.Button_departmentClick);
			// 
			// button_room
			// 
			this.button_room.BackColor = System.Drawing.SystemColors.Control;
			this.button_room.FlatAppearance.BorderSize = 0;
			this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_room.ForeColor = System.Drawing.Color.Black;
			this.button_room.Location = new System.Drawing.Point(1, 283);
			this.button_room.Name = "button_room";
			this.button_room.Size = new System.Drawing.Size(120, 53);
			this.button_room.TabIndex = 65;
			this.button_room.Text = "Room";
			this.button_room.UseVisualStyleBackColor = false;
			this.button_room.Click += new System.EventHandler(this.Button_roomClick);
			// 
			// button_nurse
			// 
			this.button_nurse.BackColor = System.Drawing.SystemColors.Control;
			this.button_nurse.FlatAppearance.BorderSize = 0;
			this.button_nurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_nurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_nurse.ForeColor = System.Drawing.Color.Black;
			this.button_nurse.Location = new System.Drawing.Point(1, 209);
			this.button_nurse.Name = "button_nurse";
			this.button_nurse.Size = new System.Drawing.Size(120, 53);
			this.button_nurse.TabIndex = 66;
			this.button_nurse.Text = "Nurse";
			this.button_nurse.UseVisualStyleBackColor = false;
			this.button_nurse.Click += new System.EventHandler(this.Button_nurseClick);
			// 
			// label_menu
			// 
			this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_menu.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label_menu.Location = new System.Drawing.Point(1, 2);
			this.label_menu.Name = "label_menu";
			this.label_menu.Size = new System.Drawing.Size(129, 38);
			this.label_menu.TabIndex = 64;
			this.label_menu.Text = "MENU";
			this.label_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_menu.Click += new System.EventHandler(this.Label_menuClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button_admin_menu);
			this.panel1.Location = new System.Drawing.Point(127, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(829, 449);
			this.panel1.TabIndex = 63;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(378, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(396, 213);
			this.label1.TabIndex = 17;
			this.label1.Text = "HOSPITAL\r\nMANAGEMENT\r\nSYSTEM";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_admin_menu
			// 
			this.button_admin_menu.BackColor = System.Drawing.SystemColors.Highlight;
			this.button_admin_menu.FlatAppearance.BorderSize = 0;
			this.button_admin_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_admin_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.button_admin_menu.ForeColor = System.Drawing.Color.White;
			this.button_admin_menu.Location = new System.Drawing.Point(0, 0);
			this.button_admin_menu.Name = "button_admin_menu";
			this.button_admin_menu.Size = new System.Drawing.Size(838, 43);
			this.button_admin_menu.TabIndex = 16;
			this.button_admin_menu.Text = "ADMIN MENU";
			this.button_admin_menu.UseVisualStyleBackColor = false;
			// 
			// button_patient
			// 
			this.button_patient.BackColor = System.Drawing.SystemColors.Control;
			this.button_patient.FlatAppearance.BorderSize = 0;
			this.button_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_patient.ForeColor = System.Drawing.Color.Black;
			this.button_patient.Location = new System.Drawing.Point(1, 135);
			this.button_patient.Name = "button_patient";
			this.button_patient.Size = new System.Drawing.Size(120, 53);
			this.button_patient.TabIndex = 67;
			this.button_patient.Text = "Patient";
			this.button_patient.UseVisualStyleBackColor = false;
			this.button_patient.Click += new System.EventHandler(this.Button_patientClick);
			// 
			// button_medicine
			// 
			this.button_medicine.BackColor = System.Drawing.SystemColors.Control;
			this.button_medicine.FlatAppearance.BorderSize = 0;
			this.button_medicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button_medicine.ForeColor = System.Drawing.Color.Black;
			this.button_medicine.Location = new System.Drawing.Point(1, 431);
			this.button_medicine.Name = "button_medicine";
			this.button_medicine.Size = new System.Drawing.Size(111, 53);
			this.button_medicine.TabIndex = 70;
			this.button_medicine.Text = "Medicine";
			this.button_medicine.UseVisualStyleBackColor = false;
			this.button_medicine.Click += new System.EventHandler(this.Button_medicineClick);
			// 
			// Main_menu
			// 
			this.Main_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Main_menu.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Main_menu.Location = new System.Drawing.Point(409, 2);
			this.Main_menu.Name = "Main_menu";
			this.Main_menu.Size = new System.Drawing.Size(129, 38);
			this.Main_menu.TabIndex = 71;
			this.Main_menu.Text = "Main MENU";
			this.Main_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Main_menu.Click += new System.EventHandler(this.Main_menuClick);
			// 
			// AdminMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(957, 497);
			this.Controls.Add(this.Main_menu);
			this.Controls.Add(this.button_doctor);
			this.Controls.Add(this.label_exit);
			this.Controls.Add(this.button_department);
			this.Controls.Add(this.button_room);
			this.Controls.Add(this.button_nurse);
			this.Controls.Add(this.label_menu);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button_patient);
			this.Controls.Add(this.button_medicine);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminMenuForm";
			this.Load += new System.EventHandler(this.AdminMenuLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label Main_menu;
		private System.Windows.Forms.Button button_medicine;
		private System.Windows.Forms.Button button_patient;
		private System.Windows.Forms.Button button_admin_menu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label_menu;
		private System.Windows.Forms.Button button_nurse;
		private System.Windows.Forms.Button button_room;
		private System.Windows.Forms.Button button_department;
		private System.Windows.Forms.Label label_exit;
		private System.Windows.Forms.Button button_doctor;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		void Panel1Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
	}
}
