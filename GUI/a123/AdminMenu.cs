/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/30/2021
 * Time: 12:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace a123
{
	/// <summary>
	/// Description of AdminMenuForm.
	/// </summary>
	public partial class AdminMenu : Form
	{
		public AdminMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void btn_DOCTOR(object sender, EventArgs e)
		{
			AdminDoctorForm df = new AdminDoctorForm();
			df.Show();
			this.Close();
		}
		void Button_medicineClick(object sender, EventArgs e)
		{
			AdminMedicineForm mf = new AdminMedicineForm();
			mf.Show();
			this.Close();
		}
		
		void Button_departmentClick(object sender, EventArgs e)
		{
			AdminDepartmentForm depf = new AdminDepartmentForm();
			depf.Show();
			this.Close();
		}
		
		void Button_roomClick(object sender, EventArgs e)
		{
			AdminRoomForm rf = new AdminRoomForm();
			rf.Show();
			this.Close();
		}
		
		void Button_nurseClick(object sender, EventArgs e)
		{
			AdminNurseForm nf = new AdminNurseForm();
			nf.Show();
			this.Close();
		}
		
		void Button_patientClick(object sender, EventArgs e)
		{
			AdminPatientForm pf = new AdminPatientForm();
			pf.Show();
			this.Close();
		}
		
		void Label_menuClick(object sender, EventArgs e)
		{
			AdminMenu mef = new AdminMenu();
			mef.Show();
			this.Close();
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		

		
		void AdminMenuLoad(object sender, EventArgs e)
		{
			
		}
		
		void Main_menuClick(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			this.Close();			
		}
	}
}
