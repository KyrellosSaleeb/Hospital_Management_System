/*
 * Created by SharpDevelop.
 * User: kyrellos
 * Date: 12/29/2021
 * Time: 5:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace a123
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class LoadingForm : Form
	{
		public LoadingForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		


	int starter = 0;
		void Timer1Tick(object sender, EventArgs e)
		{
			starter +=1;
			progressBar1.Value = starter;
			if(progressBar1.Value==100){
				progressBar1.Value = 0;
				timer1.Stop();
				MainForm log = new MainForm();
				this.Hide();
				log.Show();
			}
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
