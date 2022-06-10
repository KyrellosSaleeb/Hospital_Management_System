/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 11:54 PM
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
	/// Description of AdminDepartmentForm.
	/// </summary>
	public partial class AdminDepartmentForm : Form
	{
		static string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public AdminDepartmentForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		public DataTable LoadDepartTable()
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			string query = "SELECT * FROM Department";
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

		void btn_Medicine(object sender, EventArgs e)
		{
			AdminMedicineForm mf = new AdminMedicineForm();
			mf.Show();
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
			DoctorForm df = new DoctorForm();
			df.Show();
			this.Close();
		}
		void Main_menuClick(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();
		}



		void ButtonSearch(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(cs);
			
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Department WHERE DeptName LIKE'%" + textBox_search.Text + "%'";
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();
			dataGridView1.DataSource = dt;
			if (textBox_search.Text == "Jack")
			{
				MessageBox.Show("Found");
			}
			else
			{
				MessageBox.Show("not Found");
			}
		}



		void TextBox4TextChanged(object sender, System.EventArgs e)
		{


		}


		void TextBox1TextChanged(object sender, EventArgs e)
		{

		}

		void Button14Click(object sender, EventArgs e)
		{
			


			SqlConnection con = new SqlConnection(cs);
			con.Open();

			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Department (DeptName) VALUES ( '" + textBox_deptname.Text.ToString() + "', '"+fk.Text.ToString()+"')";
				SqlCommand c = new SqlCommand(query, con);
				c.ExecuteNonQuery();
				if (textBox_deptname.Text == "")
				{
					MessageBox.Show("Invalid Name ");
				}
				if (fk.Text == "")
				{
					MessageBox.Show("Invalid Name ");
				}
				con.Close();

				textBox_deptname.Text = "";
				fk.Text = "";
				MessageBox.Show("Department Added Successfully");
				dataGridView1.DataSource = LoadDepartTable();
			}

		}

		void Button15Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
			string query = "UPDATE Department SET  DeptName='" + textBox_deptname.Text.ToString() + "',DoctorId='" + fk.Text.ToString() + "' WHERE DeptId=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("updated successfully");
			dataGridView1.DataSource = LoadDepartTable();

			if (textBox_deptname.Text == "")
			{
				MessageBox.Show("Invalid Name ");
			}
			if (fk.Text == "")
			{
				MessageBox.Show("Invalid Name ");
			}
			con.Close();

			textBox_deptname.Text = "";
			fk.Text = "";
		}

		void Button16Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
			string query = "DELETE FROM Department WHERE(DeptId=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Removed Successfully");
		}

		void Button17Click(object sender, EventArgs e)
		{

			dataGridView1.DataSource = LoadDepartTable();
		}

		private void textBox_deptname_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox_deptname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

		}
	}
}
