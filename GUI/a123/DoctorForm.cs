/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 7:54 AM
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
	/// Description of Form2.
	/// </summary>
	public partial class DoctorForm : Form
	{
		static string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public DoctorForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		public DataTable LoadDoctorTable()
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Doctor";
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
		
		void btn_PATIENT(object sender, EventArgs e)
		{
			PatientForm pf = new PatientForm();
			pf.Show();
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
		
		void btn_Medicine(object sender, EventArgs e)
		{
			MedicineForm mf = new MedicineForm();
			mf.Show();
			this.Close();
		}
		
		
		void btn_MENU(object sender, EventArgs e)
		{
			Menu mef = new Menu();
			mef.Show();
			this.Close();
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Doctor WHERE DoctorFName LIKE '%" + textBox_search_name.Text + "%'";
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();
			dataGridView1.DataSource = dt;
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(cs);
			con.Open();

			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Doctor (DoctorFName,DoctorLName,DoctorAddress,DoctorEmail,DoctorTel,DeptName ) VALUES ( '" + textBox_Fname.Text.ToString() + "','" + textBox_Lname.Text.ToString() + "','" + textBox_Dadd.Text.ToString() + "','" + textBox_Demail.Text.ToString() + "','" + textBox_Dtel.Text.ToString() + "','" + textBox_Deptname.Text.ToString() + "')";
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
				if (textBox_Dtel.Text == "")
				{
					MessageBox.Show("Invalid Tel");
				}
				if (textBox_Dadd.Text == "")
				{
					MessageBox.Show("Invalid address");
				}
				if (textBox_Demail.Text == "")
				{
					MessageBox.Show("Invalid Email");
				}
				con.Close();

				textBox_Fname.Text = "";
				textBox_Lname.Text = "";
				textBox_Dadd.Text = "";
				textBox_Demail.Text = "";
				textBox_Dtel.Text = "";
				textBox_Deptname.Text = "";

				MessageBox.Show("Doctor Added Successfully");
				dataGridView1.DataSource = LoadDoctorTable();
			}
		}
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void btn_Main_Menu(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();
		}

        private void button_ref_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = LoadDoctorTable();

		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			textBox_Fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox_Lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			textBox_Dadd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox_Demail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox_Dtel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			textBox_Deptname.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
		}

        private void textBox_Deptname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
