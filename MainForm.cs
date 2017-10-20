/*
 * Created by SharpDevelop.
 * User: landini
 * Date: 10/20/2017
 * Time: 11:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;


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
		private string sSelectedPath;
		void Browse_buttonClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
			ofd.Multiselect = false;
			if(ofd.ShowDialog() == DialogResult.OK)
			{
				sSelectedPath = ofd.FileName;
				selection_text.Text = sSelectedPath;
				submit_button.Enabled = true;
			}
		}
		private int position;
		private int count;
		byte[] byteArray;
		
		void ParseAudio(){
			byte[] ba;
		}
		
		void Submit_buttonClick(object sender, EventArgs e)
		{
			SoundPlayer song = new SoundPlayer(sSelectedPath);
			song.Play();
			ParseAudio();
		}
	}
}
