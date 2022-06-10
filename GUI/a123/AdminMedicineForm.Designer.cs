/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 11:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace a123
{
	partial class AdminMedicineForm
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_menu = new System.Windows.Forms.Label();
            this.button_doctor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_searchN = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_ref = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox_Mprice = new System.Windows.Forms.TextBox();
            this.textBoxMname = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button_department = new System.Windows.Forms.Button();
            this.button_patient = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.button_medicine = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_nurse = new System.Windows.Forms.Button();
            this.Main_menu = new System.Windows.Forms.Label();
            this.fk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.Black;
            this.textBox_search.Location = new System.Drawing.Point(16, 425);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(359, 23);
            this.textBox_search.TabIndex = 37;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label_menu
            // 
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_menu.Location = new System.Drawing.Point(1, 1);
            this.label_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(172, 47);
            this.label_menu.TabIndex = 65;
            this.label_menu.Text = "MENU";
            this.label_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_menu.Click += new System.EventHandler(this.btn_Menu);
            // 
            // button_doctor
            // 
            this.button_doctor.BackColor = System.Drawing.SystemColors.Control;
            this.button_doctor.FlatAppearance.BorderSize = 0;
            this.button_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_doctor.ForeColor = System.Drawing.Color.Black;
            this.button_doctor.Location = new System.Drawing.Point(1, 74);
            this.button_doctor.Margin = new System.Windows.Forms.Padding(4);
            this.button_doctor.Name = "button_doctor";
            this.button_doctor.Size = new System.Drawing.Size(160, 65);
            this.button_doctor.TabIndex = 63;
            this.button_doctor.Text = "Doctor";
            this.button_doctor.UseVisualStyleBackColor = false;
            this.button_doctor.Click += new System.EventHandler(this.btn_DOCTOR);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button_searchN);
            this.panel1.Controls.Add(this.button_del);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_ref);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.fk);
            this.panel1.Controls.Add(this.textBox_Mprice);
            this.panel1.Controls.Add(this.textBoxMname);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(169, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 553);
            this.panel1.TabIndex = 58;
            // 
            // button_searchN
            // 
            this.button_searchN.FlatAppearance.BorderSize = 0;
            this.button_searchN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_searchN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button_searchN.ForeColor = System.Drawing.Color.White;
            this.button_searchN.Location = new System.Drawing.Point(20, 375);
            this.button_searchN.Margin = new System.Windows.Forms.Padding(4);
            this.button_searchN.Name = "button_searchN";
            this.button_searchN.Size = new System.Drawing.Size(344, 38);
            this.button_searchN.TabIndex = 65;
            this.button_searchN.Text = "Search Using Name";
            this.button_searchN.UseVisualStyleBackColor = false;
            // 
            // button_del
            // 
            this.button_del.FlatAppearance.BorderSize = 2;
            this.button_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_del.ForeColor = System.Drawing.Color.White;
            this.button_del.Location = new System.Drawing.Point(237, 278);
            this.button_del.Margin = new System.Windows.Forms.Padding(4);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(139, 50);
            this.button_del.TabIndex = 39;
            this.button_del.Text = "DELETE";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_edit
            // 
            this.button_edit.FlatAppearance.BorderSize = 2;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(128, 278);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(96, 50);
            this.button_edit.TabIndex = 38;
            this.button_edit.Text = "EDIT";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_search
            // 
            this.button_search.FlatAppearance.BorderSize = 2;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(128, 473);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(133, 50);
            this.button_search.TabIndex = 36;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(720, 524);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 2;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(19, 278);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(96, 50);
            this.button_add.TabIndex = 23;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_ref
            // 
            this.button_ref.FlatAppearance.BorderSize = 2;
            this.button_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_ref.ForeColor = System.Drawing.Color.White;
            this.button_ref.Location = new System.Drawing.Point(963, 1);
            this.button_ref.Margin = new System.Windows.Forms.Padding(4);
            this.button_ref.Name = "button_ref";
            this.button_ref.Size = new System.Drawing.Size(139, 50);
            this.button_ref.TabIndex = 35;
            this.button_ref.Text = "REFRESH";
            this.button_ref.UseVisualStyleBackColor = false;
            this.button_ref.Click += new System.EventHandler(this.button_ref_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 136);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(87, 31);
            this.button10.TabIndex = 19;
            this.button10.Text = "Price";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 57);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 31);
            this.button9.TabIndex = 19;
            this.button9.Text = "Name";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // textBox_Mprice
            // 
            this.textBox_Mprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Mprice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mprice.ForeColor = System.Drawing.Color.Black;
            this.textBox_Mprice.Location = new System.Drawing.Point(116, 143);
            this.textBox_Mprice.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Mprice.Name = "textBox_Mprice";
            this.textBox_Mprice.Size = new System.Drawing.Size(273, 23);
            this.textBox_Mprice.TabIndex = 18;
            // 
            // textBoxMname
            // 
            this.textBoxMname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMname.ForeColor = System.Drawing.Color.Black;
            this.textBoxMname.Location = new System.Drawing.Point(116, 60);
            this.textBoxMname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMname.Name = "textBoxMname";
            this.textBoxMname.Size = new System.Drawing.Size(273, 23);
            this.textBoxMname.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1117, 53);
            this.button6.TabIndex = 16;
            this.button6.Text = "Medicine";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button_department
            // 
            this.button_department.BackColor = System.Drawing.SystemColors.Control;
            this.button_department.FlatAppearance.BorderSize = 0;
            this.button_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_department.ForeColor = System.Drawing.Color.Black;
            this.button_department.Location = new System.Drawing.Point(1, 438);
            this.button_department.Margin = new System.Windows.Forms.Padding(4);
            this.button_department.Name = "button_department";
            this.button_department.Size = new System.Drawing.Size(160, 65);
            this.button_department.TabIndex = 62;
            this.button_department.Text = "Department";
            this.button_department.UseVisualStyleBackColor = false;
            this.button_department.Click += new System.EventHandler(this.btn_DEPT);
            // 
            // button_patient
            // 
            this.button_patient.BackColor = System.Drawing.SystemColors.Control;
            this.button_patient.FlatAppearance.BorderSize = 0;
            this.button_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_patient.ForeColor = System.Drawing.Color.Black;
            this.button_patient.Location = new System.Drawing.Point(1, 165);
            this.button_patient.Margin = new System.Windows.Forms.Padding(4);
            this.button_patient.Name = "button_patient";
            this.button_patient.Size = new System.Drawing.Size(160, 65);
            this.button_patient.TabIndex = 61;
            this.button_patient.Text = "Patient";
            this.button_patient.UseVisualStyleBackColor = false;
            this.button_patient.Click += new System.EventHandler(this.btn_PATIENT);
            // 
            // label_exit
            // 
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_exit.Location = new System.Drawing.Point(1240, -4);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 38);
            this.label_exit.TabIndex = 57;
            this.label_exit.Text = "x";
            this.label_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_exit.Click += new System.EventHandler(this.Label4Click);
            // 
            // button_medicine
            // 
            this.button_medicine.BackColor = System.Drawing.SystemColors.Control;
            this.button_medicine.FlatAppearance.BorderSize = 0;
            this.button_medicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_medicine.ForeColor = System.Drawing.Color.Black;
            this.button_medicine.Location = new System.Drawing.Point(1, 529);
            this.button_medicine.Margin = new System.Windows.Forms.Padding(4);
            this.button_medicine.Name = "button_medicine";
            this.button_medicine.Size = new System.Drawing.Size(148, 65);
            this.button_medicine.TabIndex = 64;
            this.button_medicine.Text = "Medicine";
            this.button_medicine.UseVisualStyleBackColor = false;
            // 
            // button_room
            // 
            this.button_room.BackColor = System.Drawing.SystemColors.Control;
            this.button_room.FlatAppearance.BorderSize = 0;
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_room.ForeColor = System.Drawing.Color.Black;
            this.button_room.Location = new System.Drawing.Point(1, 347);
            this.button_room.Margin = new System.Windows.Forms.Padding(4);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(160, 65);
            this.button_room.TabIndex = 59;
            this.button_room.Text = "Room";
            this.button_room.UseVisualStyleBackColor = false;
            this.button_room.Click += new System.EventHandler(this.btn_Room);
            // 
            // button_nurse
            // 
            this.button_nurse.BackColor = System.Drawing.SystemColors.Control;
            this.button_nurse.FlatAppearance.BorderSize = 0;
            this.button_nurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_nurse.ForeColor = System.Drawing.Color.Black;
            this.button_nurse.Location = new System.Drawing.Point(1, 256);
            this.button_nurse.Margin = new System.Windows.Forms.Padding(4);
            this.button_nurse.Name = "button_nurse";
            this.button_nurse.Size = new System.Drawing.Size(160, 65);
            this.button_nurse.TabIndex = 60;
            this.button_nurse.Text = "Nurse";
            this.button_nurse.UseVisualStyleBackColor = false;
            this.button_nurse.Click += new System.EventHandler(this.btn_NURSE);
            // 
            // Main_menu
            // 
            this.Main_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_menu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Main_menu.Location = new System.Drawing.Point(548, 1);
            this.Main_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(172, 47);
            this.Main_menu.TabIndex = 69;
            this.Main_menu.Text = "Main MENU";
            this.Main_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Main_menu.Click += new System.EventHandler(this.Main_menuClick);
            // 
            // fk
            // 
            this.fk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fk.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fk.ForeColor = System.Drawing.Color.Black;
            this.fk.Location = new System.Drawing.Point(116, 214);
            this.fk.Margin = new System.Windows.Forms.Padding(4);
            this.fk.Name = "fk";
            this.fk.Size = new System.Drawing.Size(273, 23);
            this.fk.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "PatientID";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AdminMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 612);
            this.Controls.Add(this.Main_menu);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.button_doctor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_department);
            this.Controls.Add(this.button_patient);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_medicine);
            this.Controls.Add(this.button_room);
            this.Controls.Add(this.button_nurse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMedicineForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label Main_menu;
		private System.Windows.Forms.Button button_searchN;
		private System.Windows.Forms.Button button_nurse;
		private System.Windows.Forms.Button button_room;
		private System.Windows.Forms.Button button_medicine;
		private System.Windows.Forms.Label label_exit;
		private System.Windows.Forms.Button button_patient;
		private System.Windows.Forms.Button button_department;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBoxMname;
		private System.Windows.Forms.TextBox textBox_Mprice;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button_ref;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button_search;
		private System.Windows.Forms.Button button_edit;
		private System.Windows.Forms.Button button_del;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_doctor;
		private System.Windows.Forms.Label label_menu;
		private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fk;
    }
}
