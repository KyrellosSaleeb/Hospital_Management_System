/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 9:32 AM
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
	/// Description of Form7.
	/// </summary>
	public partial class MedicineForm : Form
	{
		static string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		SqlConnection con = new SqlConnection();
		public MedicineForm()
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
		
		void btn_Main_Menu(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();
		}

        private void button14_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(cs);
			con.Open();
			if (con.State == System.Data.ConnectionState.Open)
			{
				string query = "INSERT INTO Medicine ( medName,medPrice,patientId ) VALUES ( '" + textBox_Mname.Text + "','" + textBox_Mprice.Text + "','"+fk.Text.ToString()+"' )";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();
				cmd.Parameters.AddWithValue("@medName", textBox_Mname.Text);
				cmd.Parameters.AddWithValue("@medPrice", textBox_Mprice.Text);
				if (textBox_Mname.Text == "")
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
				textBox_Mname.Text = "";
				fk.Text = "";

				MessageBox.Show("Medicine Added Successfully");
				dataGridView1.DataSource = LoadMedinTable();
			}
		}

        private void button11_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			DataTable dt = new DataTable();
			string query = "SELECT * FROM Medicine  WHERE medName LIKE'%" + textBox_Search.Text + "%'";
			con.Open();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();
			dataGridView1.DataSource = dt;
		}

        private void button17_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = LoadMedinTable();

		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			textBox_Mname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			textBox_Mprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
		}
    }
}
