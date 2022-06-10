/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 8:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace a123
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class PatientForm : Form
	{
		static string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public PatientForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public DataTable LoadPatientTable()
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Patient";
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();

			return dt;


		}

		void Label4Click(object sender, EventArgs e)
		{
			Application.Exit();			
		}
		
		void btn_NURSE(object sender, EventArgs e)
		{
			NurseForm nf = new NurseForm();
			nf.Show();
			this.Close();
		}
		
		void btn_DOCTOR(object sender, EventArgs e)
		{
			DoctorForm df = new DoctorForm();
			df.Show();
			this.Close();
		}
		
		
		void btn_Room(object sender, EventArgs e)
		{
			RoomForm rf = new RoomForm();
			rf.Show();
			this.Close();
		}
		
		void btn_DEPT(object sender, EventArgs e)
		{
			DepartmentForm depf = new DepartmentForm();
			depf.Show();
			this.Close();
		}
		
		void btn_Menu(object sender, EventArgs e)
		{
			Menu mef = new Menu();
			mef.Show();
			this.Close();
		}
		void btn_Medicine(object sender, EventArgs e)
		{
			MedicineForm mf = new MedicineForm();
			mf.Show();
			this.Close();
		}
		void btn_Main_Menu(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();
		}

        private void button16_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(cs);
			con.Open();

			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Patient (patientFName,patientLName,patientAddress,patientEmail,patientTel ) VALUES ( '" + textBox_Fname.Text.ToString() + "','" + textBox_Lname.Text.ToString() + "','" + textBox_Add.Text.ToString() + "','" + textBox_Email.Text.ToString() + "','" + textBox_Tel.Text.ToString() + "')";
				SqlCommand c = new SqlCommand(query, con);
				c.ExecuteNonQuery();
				if (textBox_Fname.Text == "")
				{
					MessageBox.Show("Invalid DName ");
				}
				if (textBox_Lname.Text == "")
				{
					MessageBox.Show("Invalid LName ");
				}
				if (textBox_Tel.Text == "")
				{
					MessageBox.Show("Invalid Tel");
				}
				if (textBox_Add.Text == "")
				{
					MessageBox.Show("Invalid address");
				}
				if (textBox_Email.Text == "")
				{
					MessageBox.Show("Invalid Email");
				}
				con.Close();

				textBox_Fname.Text = "";
				textBox_Lname.Text = "";
				textBox_Add.Text = "";
				textBox_Email.Text = "";
				textBox_Tel.Text = "";


				MessageBox.Show("Patient Added Successfully");
				dataGridView1.DataSource = LoadPatientTable();
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Patient WHERE patientFName LIKE'%" + textBox_Search.Text + "%'";
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();
			dataGridView1.DataSource = dt;
		
		
	}

        private void button18_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = LoadPatientTable();

		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			textBox_Fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox_Lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox_Add.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox_Email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox_Tel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
		}
    }
}
