using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_7
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		void Pic_imagen1Click(object sender, EventArgs e)
		{
			PictureBox auxpic = (PictureBox)sender;
			pic_imagen6.Image = auxpic.Image;
		}
		
	}
}



