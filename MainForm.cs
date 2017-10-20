/*
 * Created by SharpDevelop.
 * User: landini
 * Date: 10/20/2017
 * Time: 9:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Volubility
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
		}
		private string sSelectFileName;
		void Browse_buttonClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter ="wav files (*.wav)|*.wav|All files(*.*)|*.*";
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				sSelectFileName = ofd.FileName;
				path_selector.Text = sSelectFileName;
			}
		}
	}
}
