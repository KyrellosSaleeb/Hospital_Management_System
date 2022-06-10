/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 9:30 AM
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
	/// Description of Form6.
	/// </summary>
	public partial class DepartmentForm : Form
	{
		static string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public DepartmentForm()
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
		
		void btn_Medicine(object sender, EventArgs e)
		{
			MedicineForm mf = new MedicineForm();
			mf.Show();
			this.Close();
		}
		
		void btn_Menu(object sender, EventArgs e)
		{
			Menu mef = new Menu();
			mef.Show();
			this.Close();
		}
		void btn_DOCTOR(object sender, EventArgs e)
		{
			DoctorForm df = new DoctorForm();
			df.Show();
			this.Close();
		}
		
		
		void Button14Click(object sender, EventArgs e)
		{
			
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			
		}
		
		void btn_Main_Menu(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();
		}
		
		void DepartmentFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			
		}

        private void button12_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(cs);
			con.Open();

			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Department (DeptName,DoctorId) VALUES ( '" + textBox_deptname.Text.ToString() + "','"+fk.Text.ToString()+"')";
				SqlCommand c = new SqlCommand(query, con);
				c.ExecuteNonQuery();
				if (textBox_deptname.Text == "")
				{
					MessageBox.Show("Invalid DName ");
				}
				if (fk.Text == "")
				{
					MessageBox.Show("Invalid DName ");
				}
				con.Close();

				textBox_deptname.Text = "";
				fk.Text = "";

				MessageBox.Show("Department Added Successfully");
				dataGridView1.DataSource = LoadDepartTable();
			}
		}

        private void button11_Click(object sender, EventArgs e)
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
		
		}

        private void button17_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = LoadDepartTable();
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			textBox_deptname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
		}
    }
}
