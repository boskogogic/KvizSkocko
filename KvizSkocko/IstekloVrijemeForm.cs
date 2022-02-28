using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *	@author Bosko Gogic
 *	@version .net core 6.0
 *	
 *	Class IstekloVrijemeForm which is class of IstekloVrijeme Form
 *	which display message and final combination when user is out of time.
 * 
 */

namespace KvizSkocko
{
	public partial class IstekloVrijemeForm : Form
	{

		//private Form1 forma = new Form1();
		private static int[] finalCombination = new int[4];

		public IstekloVrijemeForm(int valueFinalCombination1, int valueFinalCombination2, int valueFinalCombination3, int valueFinalCombination4)
		{
			InitializeComponent();
			finalCombination[0] = valueFinalCombination1;
			finalCombination[1] = valueFinalCombination2;
			finalCombination[2] = valueFinalCombination3;
			finalCombination[3] = valueFinalCombination4;
			initialisationFinalCombination();
		}

		/**	Method for initialisation and display final combination*/
		public void initialisationFinalCombination()
		{
			/*int[] finalCombination = new int[4];
			for (int i = 0; i < 4; i++) {

				finalCombination[i] = this.getForma().businessLogic.returnSingleArrayValue(i);
			}*/
			//MessageBox.Show("Vrijednosti su : " + finalCombination[0] + " " + finalCombination[1] + " " + finalCombination[2] + " " + finalCombination[3]);

			if (finalCombination[0] == 1)
			{
				this.button1.Image = Properties.Resources.SmajliPrepravljen;
			}
			else if (finalCombination[0] == 2)
			{
				this.button1.Image = Properties.Resources.TrefPrepravljen;
			}
			else if (finalCombination[0] == 3)
			{
				this.button1.Image = Properties.Resources.PikKONACNI;
			}
			else if (finalCombination[0] == 4)
			{
				this.button1.Image = Properties.Resources.SrcePrepravljeno;
			}
			else if (finalCombination[0] == 5)
			{
				this.button1.Image = Properties.Resources.KaroPrepravljen;
			}
			else if (finalCombination[0] == 6)
			{
				this.button1.Image = Properties.Resources.ZvijezdaPrepravljena;
			}
			else
			{
				this.button1.Image = Properties.Resources.Podloga;
			}

			if (finalCombination[1] == 1)
			{
				this.button2.Image = Properties.Resources.SmajliPrepravljen;
			}
			else if (finalCombination[1] == 2)
			{
				this.button2.Image = Properties.Resources.TrefPrepravljen;
			}
			else if (finalCombination[1] == 3)
			{
				this.button2.Image = Properties.Resources.PikKONACNI;
			}
			else if (finalCombination[1] == 4)
			{
				this.button2.Image = Properties.Resources.SrcePrepravljeno;
			}
			else if (finalCombination[1] == 5)
			{
				this.button2.Image = Properties.Resources.KaroPrepravljen;
			}
			else if (finalCombination[1] == 6)
			{
				this.button2.Image = Properties.Resources.ZvijezdaPrepravljena;
			}

			if (finalCombination[2] == 1)
			{
				this.button3.Image = Properties.Resources.SmajliPrepravljen;
			}
			else if (finalCombination[2] == 2)
			{
				this.button3.Image = Properties.Resources.TrefPrepravljen;
			}
			else if (finalCombination[2] == 3)
			{
				this.button3.Image = Properties.Resources.PikKONACNI;
			}
			else if (finalCombination[2] == 4)
			{
				this.button3.Image = Properties.Resources.SrcePrepravljeno;
			}
			else if (finalCombination[2] == 5)
			{
				this.button3.Image = Properties.Resources.KaroPrepravljen;
			}
			else if (finalCombination[2] == 6)
			{
				this.button3.Image = Properties.Resources.ZvijezdaPrepravljena;
			}


			if (finalCombination[3] == 1)
			{
				this.button4.Image = Properties.Resources.SmajliPrepravljen;
			}
			else if (finalCombination[3] == 2)
			{
				this.button4.Image = Properties.Resources.TrefPrepravljen;
			}
			else if (finalCombination[3] == 3)
			{
				this.button4.Image = Properties.Resources.PikKONACNI;
			}
			else if (finalCombination[3] == 4)
			{
				this.button4.Image = Properties.Resources.SrcePrepravljeno;
			}
			else if (finalCombination[3] == 5)
			{
				this.button4.Image = Properties.Resources.KaroPrepravljen;
			}
			else if (finalCombination[3] == 6)
			{
				this.button4.Image = Properties.Resources.ZvijezdaPrepravljena;
			}

		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			new PocetakIgre().Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
