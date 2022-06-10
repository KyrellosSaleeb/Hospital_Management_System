/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 11:38 PM
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
	/// Description of AdminDoctorForm.
	/// </summary>
	public partial class AdminDoctorForm : Form
	{
		static string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public AdminDoctorForm()
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

		void btn_MENU(object sender, EventArgs e)
		{
			AdminMenu mef = new AdminMenu();
			mef.Show();
			this.Close();
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
		
		void btn_Medicine(object sender, EventArgs e)
		{
			AdminMedicineForm mf = new AdminMedicineForm();
			mf.Show();
			this.Close();
		}
		
		void Main_Menu(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();	
		}

		
		void Button14Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(cs);
			con.Open();

			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Doctor (DoctorFName,DoctorLName,DoctorAddress,DoctorEmail,DoctorTel,DeptName ) VALUES ( '"+ textBox_Fname.Text.ToString() + "','"+ textBox_Lname.Text.ToString() + "','"+ textBox_Dadd.Text.ToString() + "','"+ textBox_Demail.Text.ToString() + "','"+ textBox_Dtel.Text.ToString() + "','"+ textBox_Dept.Text.ToString() + "')";
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
				if (textBox_Dept.Text == "")
				{
					MessageBox.Show("Invalid Email");
				}
				con.Close();

				textBox_Fname.Text = "";
				textBox_Lname.Text = "";
				textBox_Dadd.Text = "";
				textBox_Demail.Text = "";
				textBox_Dtel.Text = "";
				textBox_Dept.Text = "";

				MessageBox.Show("Doctor Added Successfully");
				dataGridView1.DataSource = LoadDoctorTable();
			}	
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
            //			string query = "UPDATE Doctor SET DoctorLName=@DoctorLName,DoctorAddress=@DoctorAddress,DoctorEmail=@DoctorEmail,DoctorTel=@DoctorTel,DeptName=@DeptName WHERE DoctorLName=" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "";
            //			string query = "UPDATE Doctor SET  DoctorFName=@DoctorFName,DoctorLName=@DoctorLName,DoctorAddress=@DoctorAddress,DoctorEmail=@DoctorAddress,DoctorTel=@DoctorTel,DeptName=@DeptName WHERE DoctorFName=" + dataGridView1.CurrentRow.Cells[1].Value.ToString()+"";
            string query = "UPDATE Doctor SET  DoctorFName='" + textBox_Fname.Text.ToString() + "', DoctorLName='" + textBox_Lname.Text.ToString() + "', DoctorAddress='" + textBox_Dadd.Text.ToString() + "',DoctorEmail='" + textBox_Demail.Text.ToString() + "',DoctorTel='" + textBox_Dtel.Text.ToString() + "',DeptName='" + textBox_Dept.Text.ToString() + "' WHERE DoctorId=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
			SqlCommand cmd = new SqlCommand(query, con);
		//	cmd.Parameters.AddWithValue("@DoctorFName", textBox_Fname.Text); 
			//cmd.Parameters.AddWithValue("@DoctorLName", textBox_Lname.Text.ToString());
			//cmd.Parameters.AddWithValue("@DoctorAddress", textBox_Dadd.Text.ToString());
			//cmd.Parameters.AddWithValue("@DoctorEmail", textBox_Demail.Text.ToString());
			//cmd.Parameters.AddWithValue("@DoctorTel", textBox_Dtel.Text.ToString());
			//cmd.Parameters.AddWithValue("@DeptName", textBox_Dept.Text.ToString()); 
			cmd.ExecuteNonQuery();
			con.Close();

			MessageBox.Show("updated successfully");
			dataGridView1.DataSource = LoadDoctorTable();

			if (textBox_Fname.Text==""){
				MessageBox.Show("Invalid DName ");
			}
			if(textBox_Lname.Text==""){
				MessageBox.Show("Invalid LName ");
			}
			if(textBox_Dtel.Text==""){
				MessageBox.Show("Invalid Tel");
			}
			if(textBox_Dadd.Text==""){
				MessageBox.Show("Invalid address");
			}
			if(textBox_Demail.Text==""){
				MessageBox.Show("Invalid Email");
			}
			//comboBox1.SelectedValue.ToString()
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_Did_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Dname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
			string query = "DELETE FROM Doctor WHERE(DoctorId=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Removed Successfully");
		}

        private void textBox_Dadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Demail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Doctor WHERE DoctorFName LIKE '%" + textBox6.Text + "%'";
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
			textBox_Dadd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox_Demail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox_Dtel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			textBox_Dept.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

		}

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = LoadDoctorTable();
		}
    }
	
}
