/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 7:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace a123
{
	partial class DoctorForm
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
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Deptname = new System.Windows.Forms.TextBox();
            this.button_searchN = new System.Windows.Forms.Button();
            this.textBox_search_name = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_ref = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox_Demail = new System.Windows.Forms.TextBox();
            this.textBox_Dadd = new System.Windows.Forms.TextBox();
            this.textBox_Dtel = new System.Windows.Forms.TextBox();
            this.textBox_Lname = new System.Windows.Forms.TextBox();
            this.textBox_Fname = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button_doctor = new System.Windows.Forms.Button();
            this.button_patient = new System.Windows.Forms.Button();
            this.button_nurse = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_department = new System.Windows.Forms.Button();
            this.button_medicine = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label_menu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fk = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_exit.Location = new System.Drawing.Point(1239, -4);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 38);
            this.label_exit.TabIndex = 11;
            this.label_exit.Text = "x";
            this.label_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_exit.Click += new System.EventHandler(this.Label4Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.fk);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.textBox_Deptname);
            this.panel1.Controls.Add(this.button_searchN);
            this.panel1.Controls.Add(this.textBox_search_name);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_ref);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.textBox_Demail);
            this.panel1.Controls.Add(this.textBox_Dadd);
            this.panel1.Controls.Add(this.textBox_Dtel);
            this.panel1.Controls.Add(this.textBox_Lname);
            this.panel1.Controls.Add(this.textBox_Fname);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(168, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 553);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
            // 
            // textBox_Deptname
            // 
            this.textBox_Deptname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Deptname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Deptname.ForeColor = System.Drawing.Color.Black;
            this.textBox_Deptname.Location = new System.Drawing.Point(117, 268);
            this.textBox_Deptname.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Deptname.Name = "textBox_Deptname";
            this.textBox_Deptname.Size = new System.Drawing.Size(273, 23);
            this.textBox_Deptname.TabIndex = 72;
            this.textBox_Deptname.TextChanged += new System.EventHandler(this.textBox_Deptname_TextChanged);
            // 
            // button_searchN
            // 
            this.button_searchN.FlatAppearance.BorderSize = 0;
            this.button_searchN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_searchN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button_searchN.ForeColor = System.Drawing.Color.White;
            this.button_searchN.Location = new System.Drawing.Point(27, 405);
            this.button_searchN.Margin = new System.Windows.Forms.Padding(4);
            this.button_searchN.Name = "button_searchN";
            this.button_searchN.Size = new System.Drawing.Size(344, 37);
            this.button_searchN.TabIndex = 71;
            this.button_searchN.Text = "Search Using Name";
            this.button_searchN.UseVisualStyleBackColor = false;
            // 
            // textBox_search_name
            // 
            this.textBox_search_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search_name.ForeColor = System.Drawing.Color.Black;
            this.textBox_search_name.Location = new System.Drawing.Point(20, 448);
            this.textBox_search_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search_name.Name = "textBox_search_name";
            this.textBox_search_name.Size = new System.Drawing.Size(359, 23);
            this.textBox_search_name.TabIndex = 40;
            this.textBox_search_name.TextChanged += new System.EventHandler(this.TextBox6TextChanged);
            // 
            // button_search
            // 
            this.button_search.FlatAppearance.BorderSize = 2;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(128, 486);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(133, 50);
            this.button_search.TabIndex = 39;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.Button15Click);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 2;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(149, 356);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(96, 50);
            this.button_add.TabIndex = 38;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button16Click);
            // 
            // button_ref
            // 
            this.button_ref.FlatAppearance.BorderSize = 2;
            this.button_ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_ref.ForeColor = System.Drawing.Color.White;
            this.button_ref.Location = new System.Drawing.Point(963, 2);
            this.button_ref.Margin = new System.Windows.Forms.Padding(4);
            this.button_ref.Name = "button_ref";
            this.button_ref.Size = new System.Drawing.Size(139, 50);
            this.button_ref.TabIndex = 36;
            this.button_ref.Text = "REFRESH";
            this.button_ref.UseVisualStyleBackColor = false;
            this.button_ref.Click += new System.EventHandler(this.button_ref_Click);
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
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(0, 260);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(108, 31);
            this.button13.TabIndex = 22;
            this.button13.Text = "Depart.";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Button13Click);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(0, 220);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 31);
            this.button12.TabIndex = 19;
            this.button12.Text = "Email";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Button12Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 178);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(108, 31);
            this.button11.TabIndex = 19;
            this.button11.Text = "Address";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Button11Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 138);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(87, 31);
            this.button10.TabIndex = 19;
            this.button10.Text = "Tel.";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Button10Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 101);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 31);
            this.button9.TabIndex = 19;
            this.button9.Text = "LName";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button9Click);
            // 
            // textBox_Demail
            // 
            this.textBox_Demail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Demail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Demail.ForeColor = System.Drawing.Color.Black;
            this.textBox_Demail.Location = new System.Drawing.Point(116, 223);
            this.textBox_Demail.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Demail.Name = "textBox_Demail";
            this.textBox_Demail.Size = new System.Drawing.Size(273, 23);
            this.textBox_Demail.TabIndex = 18;
            this.textBox_Demail.TextChanged += new System.EventHandler(this.TextBox5TextChanged);
            // 
            // textBox_Dadd
            // 
            this.textBox_Dadd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Dadd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Dadd.ForeColor = System.Drawing.Color.Black;
            this.textBox_Dadd.Location = new System.Drawing.Point(116, 181);
            this.textBox_Dadd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Dadd.Name = "textBox_Dadd";
            this.textBox_Dadd.Size = new System.Drawing.Size(273, 23);
            this.textBox_Dadd.TabIndex = 18;
            this.textBox_Dadd.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
            // 
            // textBox_Dtel
            // 
            this.textBox_Dtel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Dtel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Dtel.ForeColor = System.Drawing.Color.Black;
            this.textBox_Dtel.Location = new System.Drawing.Point(116, 145);
            this.textBox_Dtel.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Dtel.Name = "textBox_Dtel";
            this.textBox_Dtel.Size = new System.Drawing.Size(273, 23);
            this.textBox_Dtel.TabIndex = 18;
            this.textBox_Dtel.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
            // 
            // textBox_Lname
            // 
            this.textBox_Lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Lname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Lname.ForeColor = System.Drawing.Color.Black;
            this.textBox_Lname.Location = new System.Drawing.Point(116, 103);
            this.textBox_Lname.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Lname.Name = "textBox_Lname";
            this.textBox_Lname.Size = new System.Drawing.Size(273, 23);
            this.textBox_Lname.TabIndex = 18;
            this.textBox_Lname.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
            // 
            // textBox_Fname
            // 
            this.textBox_Fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Fname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Fname.ForeColor = System.Drawing.Color.Black;
            this.textBox_Fname.Location = new System.Drawing.Point(116, 60);
            this.textBox_Fname.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Fname.Name = "textBox_Fname";
            this.textBox_Fname.Size = new System.Drawing.Size(273, 23);
            this.textBox_Fname.TabIndex = 18;
            this.textBox_Fname.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 53);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 31);
            this.button8.TabIndex = 17;
            this.button8.Text = "FName";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8Click);
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
            this.button6.Text = "Doctor";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button_doctor
            // 
            this.button_doctor.BackColor = System.Drawing.SystemColors.Control;
            this.button_doctor.FlatAppearance.BorderSize = 0;
            this.button_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_doctor.ForeColor = System.Drawing.Color.Black;
            this.button_doctor.Location = new System.Drawing.Point(0, 73);
            this.button_doctor.Margin = new System.Windows.Forms.Padding(4);
            this.button_doctor.Name = "button_doctor";
            this.button_doctor.Size = new System.Drawing.Size(160, 65);
            this.button_doctor.TabIndex = 14;
            this.button_doctor.Text = "Doctor";
            this.button_doctor.UseVisualStyleBackColor = false;
            // 
            // button_patient
            // 
            this.button_patient.BackColor = System.Drawing.SystemColors.Control;
            this.button_patient.FlatAppearance.BorderSize = 0;
            this.button_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_patient.ForeColor = System.Drawing.Color.Black;
            this.button_patient.Location = new System.Drawing.Point(0, 165);
            this.button_patient.Margin = new System.Windows.Forms.Padding(4);
            this.button_patient.Name = "button_patient";
            this.button_patient.Size = new System.Drawing.Size(160, 65);
            this.button_patient.TabIndex = 14;
            this.button_patient.Text = "Patient";
            this.button_patient.UseVisualStyleBackColor = false;
            this.button_patient.Click += new System.EventHandler(this.btn_PATIENT);
            // 
            // button_nurse
            // 
            this.button_nurse.BackColor = System.Drawing.SystemColors.Control;
            this.button_nurse.FlatAppearance.BorderSize = 0;
            this.button_nurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_nurse.ForeColor = System.Drawing.Color.Black;
            this.button_nurse.Location = new System.Drawing.Point(0, 257);
            this.button_nurse.Margin = new System.Windows.Forms.Padding(4);
            this.button_nurse.Name = "button_nurse";
            this.button_nurse.Size = new System.Drawing.Size(160, 65);
            this.button_nurse.TabIndex = 14;
            this.button_nurse.Text = "Nurse";
            this.button_nurse.UseVisualStyleBackColor = false;
            this.button_nurse.Click += new System.EventHandler(this.btn_NURSE);
            // 
            // button_room
            // 
            this.button_room.BackColor = System.Drawing.SystemColors.Control;
            this.button_room.FlatAppearance.BorderSize = 0;
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_room.ForeColor = System.Drawing.Color.Black;
            this.button_room.Location = new System.Drawing.Point(0, 350);
            this.button_room.Margin = new System.Windows.Forms.Padding(4);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(160, 65);
            this.button_room.TabIndex = 14;
            this.button_room.Text = "Room";
            this.button_room.UseVisualStyleBackColor = false;
            this.button_room.Click += new System.EventHandler(this.btn_Room);
            // 
            // button_department
            // 
            this.button_department.BackColor = System.Drawing.SystemColors.Control;
            this.button_department.FlatAppearance.BorderSize = 0;
            this.button_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_department.ForeColor = System.Drawing.Color.Black;
            this.button_department.Location = new System.Drawing.Point(0, 442);
            this.button_department.Margin = new System.Windows.Forms.Padding(4);
            this.button_department.Name = "button_department";
            this.button_department.Size = new System.Drawing.Size(160, 65);
            this.button_department.TabIndex = 14;
            this.button_department.Text = "Department";
            this.button_department.UseVisualStyleBackColor = false;
            this.button_department.Click += new System.EventHandler(this.btn_DEPT);
            // 
            // button_medicine
            // 
            this.button_medicine.BackColor = System.Drawing.SystemColors.Control;
            this.button_medicine.FlatAppearance.BorderSize = 0;
            this.button_medicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_medicine.ForeColor = System.Drawing.Color.Black;
            this.button_medicine.Location = new System.Drawing.Point(0, 534);
            this.button_medicine.Margin = new System.Windows.Forms.Padding(4);
            this.button_medicine.Name = "button_medicine";
            this.button_medicine.Size = new System.Drawing.Size(148, 65);
            this.button_medicine.TabIndex = 15;
            this.button_medicine.Text = "Medicine";
            this.button_medicine.UseVisualStyleBackColor = false;
            this.button_medicine.Click += new System.EventHandler(this.btn_Medicine);
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderSize = 2;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(732, 1);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(104, 41);
            this.button17.TabIndex = 25;
            this.button17.Text = "REFRESH";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // label_menu
            // 
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_menu.Location = new System.Drawing.Point(0, -1);
            this.label_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(172, 47);
            this.label_menu.TabIndex = 57;
            this.label_menu.Text = "MENU";
            this.label_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_menu.Click += new System.EventHandler(this.btn_MENU);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(552, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 47);
            this.label1.TabIndex = 58;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.btn_Main_Menu);
            // 
            // fk
            // 
            this.fk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fk.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fk.ForeColor = System.Drawing.Color.Black;
            this.fk.Location = new System.Drawing.Point(118, 308);
            this.fk.Margin = new System.Windows.Forms.Padding(4);
            this.fk.Name = "fk";
            this.fk.Size = new System.Drawing.Size(273, 23);
            this.fk.TabIndex = 74;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(4, 305);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 31);
            this.button7.TabIndex = 73;
            this.button7.Text = "PatientID";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.button_medicine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_department);
            this.Controls.Add(this.button_room);
            this.Controls.Add(this.button_nurse);
            this.Controls.Add(this.button_patient);
            this.Controls.Add(this.button_doctor);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 229);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_searchN;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_search;
		private System.Windows.Forms.TextBox textBox_search_name;
		private System.Windows.Forms.Button button_ref;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.TextBox textBox_Fname;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TextBox textBox_Lname;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox textBox_Dtel;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.TextBox textBox_Dadd;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.TextBox textBox_Demail;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button_medicine;
		private System.Windows.Forms.Button button_department;
		private System.Windows.Forms.Button button_room;
		private System.Windows.Forms.Button button_nurse;
		private System.Windows.Forms.Button button_patient;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button_doctor;
		private System.Windows.Forms.Label label_menu;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.TextBox textBox_Deptname;
        private System.Windows.Forms.TextBox fk;
        private System.Windows.Forms.Button button7;
    }
}
