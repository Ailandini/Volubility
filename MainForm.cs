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
using System.IO;
using System.Text;
using System.Linq;
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
				
				byte[] ba = File.ReadAllBytes(sSelectedPath);
				string outp = ba[0].ToString();
				for(int i=1; i< ba.Length; i++){
					outp += "|";
					outp += ba[i].ToString();
					if(i == 3)
					{
						outp+= "\t\tRIFF\n";
					}
					if(i == 7)
					{
						outp+= "\tFile Size\n";
					}
					if(i == 14)
					{
						outp+= "\tfmt \n";
					}
					if(i == 19)
					{
						outp+= "\tfmt Header Length\n";
					}
					if(i == 21)
					{
						outp+= "\t\t\tFormat Type\n";
					}
					if(i == 23)
					{
						outp+= "\t\t\tChannels\n";
					}
					if(i == 27)
					{
						outp+= "\t\tSample Rate\n";
					}
					if(i == 31)
					{
						outp+= "\t\tByte Rate\n";
					}
					if(i == 33)
					{
						outp+= "\t\t\tBlock Align\n";
					}
					if(i == 39)
					{
						outp+= "\tData\n";
					}
					if(i == 43)
					{
						outp+= "\t\tChunk Size\n";
					}
						
					
					if(i == 11)
					{
						outp += "\tWAVE\n\n";
					}
					if(i == 35)
					{
						outp += "\t\t\tBits Per Sample\n\n";	
					}
					
				}
				
				File.WriteAllText("Bytes Organized", outp);
			}
			
		}
		private int position;
		private int count;
		byte[] byteArray;
		
		void ParseAudio(string sSelectedPath){
			FileStream fs = File.Open(sSelectedPath, FileMode.Open, FileAccess.Read);
			byteArray = File.ReadAllBytes(sSelectedPath);
			fs.Close();
			Console.WriteLine(Encoding.Default.GetString(byteArray));
		}
		
		void Submit_buttonClick(object sender, EventArgs e)
		{
			SoundPlayer song = new SoundPlayer(sSelectedPath);
			song.Play();
			//ParseAudio(sSelectedPath);
		}
	}
}
