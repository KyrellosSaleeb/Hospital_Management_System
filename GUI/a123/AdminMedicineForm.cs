/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 11:35 PM
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
	/// Description of AdminMedicineForm.
	/// </summary>
	public partial class AdminMedicineForm : Form
	{
		static string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public AdminMedicineForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public DataTable LoadMedinTable()
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Medicine";
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

		void btn_PATIENT(object sender, EventArgs e)
		{
			AdminPatientForm pf = new AdminPatientForm();
			pf.Show();
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
		void btn_DOCTOR(object sender, EventArgs e)
		{
			AdminDoctorForm df = new AdminDoctorForm();
			df.Show();
			this.Close();
		}


		void Main_menuClick(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();
		}

		private void button_edit_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(cs);
			con.Open();
			string query = "UPDATE Medicine SET  medName='" + textBoxMname.Text + "',medPrice='" + textBox_Mprice.Text + "',patientId='"+fk.Text.ToString()+"'  WHERE  medId=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
			SqlCommand cmd = new SqlCommand(query, con);

			cmd.ExecuteNonQuery();
			if (textBoxMname.Text == "")
			{
				MessageBox.Show("Invalid Name ");
			}
			if (textBox_Mprice.Text == "")
			{
				MessageBox.Show("Invalid Name ");
			}
			if (fk.Text == "")
			{
				MessageBox.Show("Invalid Name ");
			}
			con.Close();
			MessageBox.Show("updated successfully");
			dataGridView1.DataSource = LoadMedinTable();



		}

		private void button_add_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(cs);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Medicine ( medName,medPrice,patientId ) VALUES ( '" + textBoxMname.Text + "','" + textBox_Mprice.Text + "'.'"+fk.Text.ToString()+"' )";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();
				cmd.Parameters.AddWithValue("@medName", textBoxMname.Text);
				cmd.Parameters.AddWithValue("@medPrice", textBox_Mprice.Text);
				if (textBoxMname.Text == "")
				{
					MessageBox.Show("Invalid Name ");
				}
				if (textBox_Mprice.Text == "")
				{
					MessageBox.Show("Invalid Name ");
				}
				if (fk.Text == "")
				{
					MessageBox.Show("Invalid Name ");
				}
				con.Close();

				textBox_Mprice.Text = "";
				textBoxMname.Text = "";
				fk.Text = "";

				MessageBox.Show("Medicine Added Successfully");
				dataGridView1.DataSource = LoadMedinTable();
			}
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
			string query = "DELETE FROM Medicine WHERE(medId=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Removed Successfully");
		}

		private void textBox_search_TextChanged(object sender, EventArgs e)
		{

		}

		private void button_search_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Medicine  WHERE medName LIKE'%" + textBox_search.Text + "%'";
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();
			dataGridView1.DataSource = dt;
		}

		private void button_ref_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = LoadMedinTable();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBoxMname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox_Mprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


		}
	}
}
