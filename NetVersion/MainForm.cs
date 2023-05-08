/*
 * Created by SharpDevelop.
 * User: rnapoles
 * Date: 13/10/2019
 * Time: 12:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetVersion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			StringBuilder sb = new StringBuilder();
			//sb.Append(VersionNetFramework.GetVersionDicription());
			sb.Append(VersionNetFramework.GetVersionFromRegistry());
			sb.Append(VersionNetFramework.Get45or451FromRegistry());
			sb.Append(VersionNetFramework.GetUpdateHistory());
			
			richTextBox1.Text = sb.ToString();
			richTextBox1.Focus();
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
