/*
 * Created by SharpDevelop.
 * User: landini
 * Date: 10/20/2017
 * Time: 9:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Volubility
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button browse_button;
		private System.Windows.Forms.Button submit_button;
		private System.Windows.Forms.TextBox path_selector;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.browse_button = new System.Windows.Forms.Button();
			this.submit_button = new System.Windows.Forms.Button();
			this.path_selector = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// browse_button
			// 
			this.browse_button.Location = new System.Drawing.Point(408, 72);
			this.browse_button.Name = "browse_button";
			this.browse_button.Size = new System.Drawing.Size(75, 27);
			this.browse_button.TabIndex = 0;
			this.browse_button.Text = "Browse";
			this.browse_button.UseVisualStyleBackColor = true;
			this.browse_button.Click += new System.EventHandler(this.Browse_buttonClick);
			// 
			// submit_button
			// 
			this.submit_button.Location = new System.Drawing.Point(489, 72);
			this.submit_button.Name = "submit_button";
			this.submit_button.Size = new System.Drawing.Size(136, 27);
			this.submit_button.TabIndex = 1;
			this.submit_button.Text = "Let the magic happen!";
			this.submit_button.UseVisualStyleBackColor = true;
			// 
			// path_selector
			// 
			this.path_selector.Location = new System.Drawing.Point(12, 75);
			this.path_selector.Name = "path_selector";
			this.path_selector.Size = new System.Drawing.Size(390, 20);
			this.path_selector.TabIndex = 2;
			this.path_selector.Text = "-Please paste a path to a file or browse to it-";
			this.path_selector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(643, 131);
			this.Controls.Add(this.path_selector);
			this.Controls.Add(this.submit_button);
			this.Controls.Add(this.browse_button);
			this.Name = "MainForm";
			this.Text = "Volubility";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
