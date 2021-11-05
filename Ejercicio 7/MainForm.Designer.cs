/*
 * Created by SharpDevelop.
 * User: LAB-02
 * Date: 27/9/2021
 * Time: 19:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_7
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pic_imagen4;
		private System.Windows.Forms.PictureBox pic_imagen3;
		private System.Windows.Forms.PictureBox pic_imagen2;
		private System.Windows.Forms.PictureBox pic_imagen1;
		private System.Windows.Forms.PictureBox pic_imagen5;
		private System.Windows.Forms.PictureBox pic_imagen6;
		
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
			this.pic_imagen4 = new System.Windows.Forms.PictureBox();
			this.pic_imagen3 = new System.Windows.Forms.PictureBox();
			this.pic_imagen2 = new System.Windows.Forms.PictureBox();
			this.pic_imagen1 = new System.Windows.Forms.PictureBox();
			this.pic_imagen5 = new System.Windows.Forms.PictureBox();
			this.pic_imagen6 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen6)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_imagen4
			// 
			this.pic_imagen4.Image = ((System.Drawing.Image)(resources.GetObject("pic_imagen4.Image")));
			this.pic_imagen4.Location = new System.Drawing.Point(546, 216);
			this.pic_imagen4.Name = "pic_imagen4";
			this.pic_imagen4.Size = new System.Drawing.Size(100, 50);
			this.pic_imagen4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen4.TabIndex = 0;
			this.pic_imagen4.TabStop = false;
			this.pic_imagen4.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_imagen3
			// 
			this.pic_imagen3.Image = ((System.Drawing.Image)(resources.GetObject("pic_imagen3.Image")));
			this.pic_imagen3.Location = new System.Drawing.Point(546, 160);
			this.pic_imagen3.Name = "pic_imagen3";
			this.pic_imagen3.Size = new System.Drawing.Size(100, 50);
			this.pic_imagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen3.TabIndex = 1;
			this.pic_imagen3.TabStop = false;
			this.pic_imagen3.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_imagen2
			// 
			this.pic_imagen2.Image = ((System.Drawing.Image)(resources.GetObject("pic_imagen2.Image")));
			this.pic_imagen2.Location = new System.Drawing.Point(546, 104);
			this.pic_imagen2.Name = "pic_imagen2";
			this.pic_imagen2.Size = new System.Drawing.Size(100, 50);
			this.pic_imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen2.TabIndex = 2;
			this.pic_imagen2.TabStop = false;
			this.pic_imagen2.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_imagen1
			// 
			this.pic_imagen1.Image = ((System.Drawing.Image)(resources.GetObject("pic_imagen1.Image")));
			this.pic_imagen1.Location = new System.Drawing.Point(546, 48);
			this.pic_imagen1.Name = "pic_imagen1";
			this.pic_imagen1.Size = new System.Drawing.Size(100, 50);
			this.pic_imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen1.TabIndex = 3;
			this.pic_imagen1.TabStop = false;
			this.pic_imagen1.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_imagen5
			// 
			this.pic_imagen5.Image = ((System.Drawing.Image)(resources.GetObject("pic_imagen5.Image")));
			this.pic_imagen5.Location = new System.Drawing.Point(546, 272);
			this.pic_imagen5.Name = "pic_imagen5";
			this.pic_imagen5.Size = new System.Drawing.Size(100, 50);
			this.pic_imagen5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen5.TabIndex = 4;
			this.pic_imagen5.TabStop = false;
			this.pic_imagen5.Click += new System.EventHandler(this.Pic_imagen1Click);
			// 
			// pic_imagen6
			// 
			this.pic_imagen6.Location = new System.Drawing.Point(172, 48);
			this.pic_imagen6.Name = "pic_imagen6";
			this.pic_imagen6.Size = new System.Drawing.Size(305, 274);
			this.pic_imagen6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen6.TabIndex = 5;
			this.pic_imagen6.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 393);
			this.Controls.Add(this.pic_imagen6);
			this.Controls.Add(this.pic_imagen5);
			this.Controls.Add(this.pic_imagen1);
			this.Controls.Add(this.pic_imagen2);
			this.Controls.Add(this.pic_imagen3);
			this.Controls.Add(this.pic_imagen4);
			this.Name = "MainForm";
			this.Text = "Ejercicio 7";
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen6)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
