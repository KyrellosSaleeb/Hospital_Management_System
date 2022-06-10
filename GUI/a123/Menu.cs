/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 7:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace a123
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			Application.Exit();				
		}
		
		
		void btn_DOCTOR(object sender, EventArgs e)
		{
			DoctorForm df = new DoctorForm();
			df.Show();
			this.Close();
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
		void btn_Main_Menu(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
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
	}
}
