/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 11:48 PM
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
	/// Description of AdminPatientForm.
	/// </summary>
	public partial class AdminPatientForm : Form
	{
		static string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public AdminPatientForm()
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
			AdminNurseForm nf = new AdminNurseForm();
			nf.Show();
			this.Close();
		}
		
		void btn_DOCTOR(object sender, EventArgs e)
		{
			AdminDoctorForm df = new AdminDoctorForm();
			df.Show();
			this.Close();
		}
		
		
		void btn_Room(object sender, EventArgs e)
		{
			AdminRoomForm rf = new AdminRoomForm();
			rf.Show();
			this.Close();
		}
		
		void btn_DEPT(object sender, EventArgs e)
		{
			AdminDepartmentForm depf = new AdminDepartmentForm();
			depf.Show();
			this.Close();
		}
		
		void btn_Menu(object sender, EventArgs e)
		{
			AdminMenu mef = new AdminMenu();
			mef.Show();
			this.Close();
		}
		void btn_Medicine(object sender, EventArgs e)
		{
			AdminMedicineForm mf = new AdminMedicineForm();
			mf.Show();
			this.Close();
		}
		
		void Main_menuClick(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();		
		}

        private void button8_Click(object sender, EventArgs e)
        {

        }

		private void button14_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(cs);
			con.Open();

			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Patient (patientFName,patientLName,patientAddress,patientEmail,patientTel,DoctorId) VALUES ( '" + textBox_Fname.Text.ToString() + "','" + textBox_Lname.Text.ToString() + "','" + textBox_Add.Text.ToString() + "','" + textBox_Email.Text.ToString() + "','" + textBox_Tel.Text.ToString() + "', '"+fk.Text.ToString()+"')";
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
				if (fk.Text == "")
				{
					MessageBox.Show("Invalid Email");
				}
				con.Close();

				textBox_Fname.Text = "";
				textBox_Lname.Text = "";
				textBox_Add.Text = "";
				textBox_Email.Text = "";
				textBox_Tel.Text = "";
				fk.Text = "";

				MessageBox.Show("Patient Added Successfully");
				dataGridView1.DataSource = LoadPatientTable();
			}
		}
        private void button15_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
			string query = "UPDATE Patient SET  patientFName='" + textBox_Fname.Text.ToString() + "', patientLName='" + textBox_Lname.Text.ToString() + "', patientAddress='" + textBox_Add.Text.ToString() + "',patientEmail='" + textBox_Email.Text.ToString() + "',patientTel='" + textBox_Tel.Text.ToString() + "',DoctorId='"+fk.Text.ToString()+"' WHERE patientId=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
			SqlCommand cmd = new SqlCommand(query, con);
	
			cmd.ExecuteNonQuery();

			if (textBox_Fname.Text == "")
			{
				MessageBox.Show("Invalid dName ");
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
			if (fk.Text == "")
			{
				MessageBox.Show("Invalid Email");
			}

			con.Close();

			textBox_Fname.Text = "";
			textBox_Lname.Text = "";
			textBox_Add.Text = "";
			textBox_Email.Text = "";
			textBox_Tel.Text = "";
			fk.Text = "";

			MessageBox.Show("updated successfully");
			dataGridView1.DataSource = LoadPatientTable();

		}

		private void button16_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
			string query = "DELETE FROM Patient WHERE(patientId=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Removed Successfully");
		}

        private void button18_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = LoadPatientTable();
		}

        private void button19_Click(object sender, EventArgs e)
        {
		
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Patient WHERE patientFName LIKE'%" + textBox6.Text + "%'";
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();
			dataGridView1.DataSource = dt;
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			textBox_Fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox_Lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox_Add.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox_Email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox_Tel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
		}

        private void textBox_Fname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
