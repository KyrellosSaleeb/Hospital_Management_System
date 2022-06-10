/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 3:57 AM
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
using System.Configuration;


namespace a123
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
		public string cs = @"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True";
		
		/*string cnstr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString.ToString();
		con.ConnectionString = cnstr;
                con.Open();*/
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public DataTable LoadloginTable()
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
			DataTable dt = new DataTable();
			string query = "SELECT * FROM login";
			SqlCommand cmd = new SqlCommand(query, con);
			cmd.ExecuteNonQuery();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			con.Close();

			return dt;
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
					
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void MaskedTextBox1MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
		
		
		void btn_EXIT(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void btn_LOGIN(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L15KNA0;Initial Catalog=Hospital;Integrated Security=True");
			con.Open();
			//USERNAME,PASS from logged where username='" + textBox_username.Text + "'and pass='" + textBox_password.Text + "'", con);
			//cmd.ExecuteNonQuery();
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM logged  WHERE USERNAME='" + textBox_username.Text + "' AND PASS='" + textBox_password.Text + "'", con);
			DataTable d = new DataTable();
			sda.Fill(d);

			if (d.Rows.Count > 0 )
			{

				if (combo_role.SelectedItem.ToString() == "Manager")
				{
					AdminMenu mef = new AdminMenu();
					mef.Show();
					this.Hide();
				}
				else
				{
					Menu mf = new Menu();
					mf.Show();
					this.Close();
				}

			}
			else
			{
				textBox_username.Text = "";
				textBox_password.Text = "";
				MessageBox.Show("Invalid Username or Password!");

			}
			con.Close();

		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox(object sender, EventArgs e)
		{
			
		}
	}
}
