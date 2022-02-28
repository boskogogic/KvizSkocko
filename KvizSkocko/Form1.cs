using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools;


/*
	NAPOMENA !!!
	Nakon zatvorenog prozora od prethodnog pogodjenog OSTANE VRIJEME !! 
	Regulisai da se vrijeme "unisti".
*/

namespace KvizSkocko
{
	public partial class Form1 : Form
	{
		public static PocetakIgre forma = new PocetakIgre();
		// arrays for remembering input combination of each row.
		public static int[] rememberCombinationTable1 = new int[4];
		public static int[] rememberCombinationTable2 = new int[4];
		public static int[] rememberCombinationTable3 = new int[4];
		public static int[] rememberCombinationTable4 = new int[4];
		public static int[] rememberCombinationTable5 = new int[4];
		public static int[] rememberCombinationTable6 = new int[4];


		private static BusinessLogic businessLogic = new BusinessLogic();
		//for timer 
		public int totalSeconds = 100;

		public Form1()
		{
			InitializeComponent();
			this.getBusinessLogic().randomiseFinalCombination();
		}


		BusinessLogic getBusinessLogic()
		{
			return businessLogic;
		}

		/** Methods for putting characters into the rows. */
		private void Skocko_Click(object sender, EventArgs e)
		{
			/**	First table Layout */
			if (this.button1CheckBox1.Name != "Cekirano")
			{
				if (this.button1TableLayout1.Name == "button1TableLayout1")
				{
					this.button1TableLayout1.Image = Properties.Resources.SmajliPrepravljen;
					this.button1TableLayout1.Name = "SmajliPrepravljen";
					rememberCombinationTable1[0] = 1;

				}
				else if (this.button1TableLayout1.Name != "button1TableLayout1" && this.button2TableLayout1.Name == "button2TableLayout1")
				{
					this.button2TableLayout1.Image = Properties.Resources.SmajliPrepravljen;
					this.button2TableLayout1.Name = "SmajliPrepravljen";
					rememberCombinationTable1[1] = 1;
				}

				else if (this.button2TableLayout1.Name != "button2TableLayout1" && this.button3TableLayout1.Name == "button3TableLayout1")
				{
					this.button3TableLayout1.Image = Properties.Resources.SmajliPrepravljen;
					this.button3TableLayout1.Name = "SmajliPrepravljen";
					rememberCombinationTable1[2] = 1;

				}
				else
				{
					if (this.button4TableLayout1.Name == "button4TableLayout1")
					{
						this.button4TableLayout1.Image = Properties.Resources.SmajliPrepravljen;
						this.button4TableLayout1.Name = "SmajliPrepravljen";
						rememberCombinationTable1[3] = 1;
					}
				}
			}

			/**	Second table Layout */
			if (this.button1CheckBox2.Name != "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout2.Name == "button1TableLayout2")
				{
					this.button1TableLayout2.Image = Properties.Resources.SmajliPrepravljen;
					this.button1TableLayout2.Name = "SmajliPrepravljen";
					rememberCombinationTable2[0] = 1;

				}
				else if (this.button1TableLayout2.Name != "button1TableLayout2" && this.button2TableLayout2.Name == "button2TableLayout2")
				{
					this.button2TableLayout2.Image = Properties.Resources.SmajliPrepravljen;
					this.button2TableLayout2.Name = "SmajliPrepravljen";
					rememberCombinationTable2[1] = 1;
				}

				else if (this.button2TableLayout2.Name != "button2TableLayout2" && this.button3TableLayout2.Name == "button3TableLayout2")
				{
					this.button3TableLayout2.Image = Properties.Resources.SmajliPrepravljen;
					this.button3TableLayout2.Name = "SmajliPrepravljen";
					rememberCombinationTable2[2] = 1;

				}
				else
				{
					if (this.button4TableLayout2.Name == "button4TableLayout2")
					{
						this.button4TableLayout2.Image = Properties.Resources.SmajliPrepravljen;
						this.button4TableLayout2.Name = "SmajliPrepravljen";
						rememberCombinationTable2[3] = 1;
					}
				}
			}
			/* Third table layout. */
			if (this.button1CheckBox3.Name != "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout3.Name == "button1TableLayout3")
				{
					this.button1TableLayout3.Image = Properties.Resources.SmajliPrepravljen;
					this.button1TableLayout3.Name = "SmajliPrepravljen";
					rememberCombinationTable3[0] = 1;

				}
				else if (this.button1TableLayout3.Name != "button1TableLayout3" && this.button2TableLayout3.Name == "button2TableLayout3")
				{
					this.button2TableLayout3.Image = Properties.Resources.SmajliPrepravljen;
					this.button2TableLayout3.Name = "SmajliPrepravljen";
					rememberCombinationTable3[1] = 1;
				}

				else if (this.button2TableLayout3.Name != "button2TableLayout3" && this.button3TableLayout3.Name == "button3TableLayout3")
				{
					this.button3TableLayout3.Image = Properties.Resources.SmajliPrepravljen;
					this.button3TableLayout3.Name = "SmajliPrepravljen";
					rememberCombinationTable3[2] = 1;

				}
				else
				{
					if (this.button4TableLayout3.Name == "button4TableLayout3")
					{
						this.button4TableLayout3.Image = Properties.Resources.SmajliPrepravljen;
						this.button4TableLayout3.Name = "SmajliPrepravljen";
						rememberCombinationTable3[3] = 1;
					}

				}
			}
			/* Fourth table layout. */
			if (this.button1CheckBox4.Name != "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout4.Name == "button1TableLayout4")
				{
					this.button1TableLayout4.Image = Properties.Resources.SmajliPrepravljen;
					this.button1TableLayout4.Name = "SmajliPrepravljen";
					rememberCombinationTable4[0] = 1;

				}
				else if (this.button1TableLayout4.Name != "button1TableLayout4" && this.button2TableLayout4.Name == "button2TableLayout4")
				{
					this.button2TableLayout4.Image = Properties.Resources.SmajliPrepravljen;
					this.button2TableLayout4.Name = "SmajliPrepravljen";
					rememberCombinationTable4[1] = 1;
				}

				else if (this.button2TableLayout4.Name != "button2TableLayout4" && this.button3TableLayout4.Name == "button3TableLayout4")
				{
					this.button3TableLayout4.Image = Properties.Resources.SmajliPrepravljen;
					this.button3TableLayout4.Name = "SmajliPrepravljen";
					rememberCombinationTable4[2] = 1;

				}
				else
				{
					if (this.button4TableLayout4.Name == "button4TableLayout4")
					{
						this.button4TableLayout4.Image = Properties.Resources.SmajliPrepravljen;
						this.button4TableLayout4.Name = "SmajliPrepravljen";
						rememberCombinationTable4[3] = 1;
					}

				}
			}
			/* Fifth table layout. */
			if (this.button1CheckBox5.Name != "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout5.Name == "button1TableLayout5")
				{
					this.button1TableLayout5.Image = Properties.Resources.SmajliPrepravljen;
					this.button1TableLayout5.Name = "SmajliPrepravljen";
					rememberCombinationTable5[0] = 1;

				}
				else if (this.button1TableLayout5.Name != "button1TableLayout5" && this.button2TableLayout5.Name == "button2TableLayout5")
				{
					this.button2TableLayout5.Image = Properties.Resources.SmajliPrepravljen;
					this.button2TableLayout5.Name = "SmajliPrepravljen";
					rememberCombinationTable5[1] = 1;
				}

				else if (this.button2TableLayout5.Name != "button2TableLayout5" && this.button3TableLayout5.Name == "button3TableLayout5")
				{
					this.button3TableLayout5.Image = Properties.Resources.SmajliPrepravljen;
					this.button3TableLayout5.Name = "SmajliPrepravljen";
					rememberCombinationTable5[2] = 1;

				}
				else
				{
					if (this.button4TableLayout5.Name == "button4TableLayout5")
					{
						this.button4TableLayout5.Image = Properties.Resources.SmajliPrepravljen;
						this.button4TableLayout5.Name = "SmajliPrepravljen";
						rememberCombinationTable5[3] = 1;
					}

				}
			}
			/* Sixth table layout. */
			if (this.button1CheckBox6.Name != "Cekirano" && this.button1CheckBox5.Name == "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout6.Name == "button1TableLayout6")
				{
					this.button1TableLayout6.Image = Properties.Resources.SmajliPrepravljen;
					this.button1TableLayout6.Name = "SmajliPrepravljen";
					rememberCombinationTable6[0] = 1;

				}
				else if (this.button1TableLayout6.Name != "button1TableLayout6" && this.button2TableLayout6.Name == "button2TableLayout6")
				{
					this.button2TableLayout6.Image = Properties.Resources.SmajliPrepravljen;
					this.button2TableLayout6.Name = "SmajliPrepravljen";
					rememberCombinationTable6[1] = 1;
				}

				else if (this.button2TableLayout6.Name != "button2TableLayout6" && this.button3TableLayout6.Name == "button3TableLayout6")
				{
					this.button3TableLayout6.Image = Properties.Resources.SmajliPrepravljen;
					this.button3TableLayout6.Name = "SmajliPrepravljen";
					rememberCombinationTable6[2] = 1;

				}
				else
				{
					if (this.button4TableLayout6.Name == "button4TableLayout6")
					{
						this.button4TableLayout6.Image = Properties.Resources.SmajliPrepravljen;
						this.button4TableLayout6.Name = "SmajliPrepravljen";
						rememberCombinationTable6[3] = 1;
					}

				}
			}
		}

		private void Tref_Click(object sender, EventArgs e)
		{
			/*	Firt table layout. */
			if (this.button1CheckBox1.Name != "Cekirano")
			{
				/**	First table Layout */
				if (this.button1TableLayout1.Name == "button1TableLayout1")
				{
					this.button1TableLayout1.Image = Properties.Resources.TrefPrepravljen;
					this.button1TableLayout1.Name = "TrefPrepravljen";
					rememberCombinationTable1[0] = 2;

				}
				else if (this.button1TableLayout1.Name != "button1TableLayout1" && this.button2TableLayout1.Name == "button2TableLayout1")
				{
					this.button2TableLayout1.Image = Properties.Resources.TrefPrepravljen;
					this.button2TableLayout1.Name = "TrefPrepravljen";
					rememberCombinationTable1[1] = 2;
				}

				else if (this.button2TableLayout1.Name != "button2TableLayout2" && this.button3TableLayout1.Name == "button3TableLayout1")
				{
					this.button3TableLayout1.Image = Properties.Resources.TrefPrepravljen;
					this.button3TableLayout1.Name = "TrefPrepravljen";
					rememberCombinationTable1[2] = 2;

				}
				else
				{
					if (this.button4TableLayout1.Name == "button4TableLayout1")
					{
						this.button4TableLayout1.Image = Properties.Resources.TrefPrepravljen;
						this.button4TableLayout1.Name = "TrefPrepravljen";
						rememberCombinationTable1[3] = 2;
					}

				}
			}
			/**	Second table Layout */
			if (this.button1CheckBox2.Name != "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout2.Name == "button1TableLayout2")
				{
					this.button1TableLayout2.Image = Properties.Resources.TrefPrepravljen;
					this.button1TableLayout2.Name = "TrefPrepravljen";
					rememberCombinationTable2[0] = 2;

				}
				else if (this.button1TableLayout2.Name != "button1TableLayout2" && this.button2TableLayout2.Name == "button2TableLayout2")
				{
					this.button2TableLayout2.Image = Properties.Resources.TrefPrepravljen;
					this.button2TableLayout2.Name = "TrefPrepravljen";
					rememberCombinationTable2[1] = 2;
				}

				else if (this.button2TableLayout2.Name != "button2TableLayout2" && this.button3TableLayout2.Name == "button3TableLayout2")
				{
					this.button3TableLayout2.Image = Properties.Resources.TrefPrepravljen;
					this.button3TableLayout2.Name = "TrefPrepravljen";
					rememberCombinationTable2[2] = 2;

				}
				else
				{
					if (this.button4TableLayout2.Name == "button4TableLayout2")
					{
						this.button4TableLayout2.Image = Properties.Resources.TrefPrepravljen;
						this.button4TableLayout2.Name = "TrefPrepravljen";
						rememberCombinationTable2[3] = 2;
					}

				}
			}
			/* Third table layout. */
			if (this.button1CheckBox3.Name != "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout3.Name == "button1TableLayout3")
				{
					this.button1TableLayout3.Image = Properties.Resources.TrefPrepravljen;
					this.button1TableLayout3.Name = "TrefPrepravljen";
					rememberCombinationTable3[0] = 2;

				}
				else if (this.button1TableLayout3.Name != "button1TableLayout3" && this.button2TableLayout3.Name == "button2TableLayout3")
				{
					this.button2TableLayout3.Image = Properties.Resources.TrefPrepravljen;
					this.button2TableLayout3.Name = "TrefPrepravljen";
					rememberCombinationTable3[1] = 2;
				}

				else if (this.button2TableLayout3.Name != "button2TableLayout3" && this.button3TableLayout3.Name == "button3TableLayout3")
				{
					this.button3TableLayout3.Image = Properties.Resources.TrefPrepravljen;
					this.button3TableLayout3.Name = "TrefPrepravljen";
					rememberCombinationTable3[2] = 2;

				}
				else
				{
					if (this.button4TableLayout3.Name == "button4TableLayout3")
					{
						this.button4TableLayout3.Image = Properties.Resources.TrefPrepravljen;
						this.button4TableLayout3.Name = "TrefPrepravljen";
						rememberCombinationTable3[3] = 2;
					}

				}
			}
			/* Fourth table layout. */
			if (this.button1CheckBox4.Name != "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout4.Name == "button1TableLayout4")
				{
					this.button1TableLayout4.Image = Properties.Resources.TrefPrepravljen;
					this.button1TableLayout4.Name = "TrefPrepravljen";
					rememberCombinationTable4[0] = 2;

				}
				else if (this.button1TableLayout4.Name != "button1TableLayout4" && this.button2TableLayout4.Name == "button2TableLayout4")
				{
					this.button2TableLayout4.Image = Properties.Resources.TrefPrepravljen;
					this.button2TableLayout4.Name = "TrefPrepravljen";
					rememberCombinationTable4[1] = 2;
				}

				else if (this.button2TableLayout4.Name != "button2TableLayout4" && this.button3TableLayout4.Name == "button3TableLayout4")
				{
					this.button3TableLayout4.Image = Properties.Resources.TrefPrepravljen;
					this.button3TableLayout4.Name = "TrefPrepravljen";
					rememberCombinationTable4[2] = 2;

				}
				else
				{
					if (this.button4TableLayout4.Name == "button4TableLayout4")
					{
						this.button4TableLayout4.Image = Properties.Resources.TrefPrepravljen;
						this.button4TableLayout4.Name = "TrefPrepravljen";
						rememberCombinationTable4[3] = 2;
					}

				}
			}
			/* Fifth table layout. */
			if (this.button1CheckBox5.Name != "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout5.Name == "button1TableLayout5")
				{
					this.button1TableLayout5.Image = Properties.Resources.TrefPrepravljen;
					this.button1TableLayout5.Name = "TrefPrepravljen";
					rememberCombinationTable5[0] = 2;

				}
				else if (this.button1TableLayout5.Name != "button1TableLayout5" && this.button2TableLayout5.Name == "button2TableLayout5")
				{
					this.button2TableLayout5.Image = Properties.Resources.TrefPrepravljen;
					this.button2TableLayout5.Name = "TrefPrepravljen";
					rememberCombinationTable5[1] = 2;
				}

				else if (this.button2TableLayout5.Name != "button2TableLayout5" && this.button3TableLayout5.Name == "button3TableLayout5")
				{
					this.button3TableLayout5.Image = Properties.Resources.TrefPrepravljen;
					this.button3TableLayout5.Name = "TrefPrepravljen";
					rememberCombinationTable5[2] = 2;

				}
				else
				{
					if (this.button4TableLayout5.Name == "button4TableLayout5")
					{
						this.button4TableLayout5.Image = Properties.Resources.TrefPrepravljen;
						this.button4TableLayout5.Name = "TrefPrepravljen";
						rememberCombinationTable5[3] = 2;
					}

				}
			}
			/* Sixth table layout. */
			if (this.button1CheckBox6.Name != "Cekirano" && this.button1CheckBox5.Name == "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout6.Name == "button1TableLayout6")
				{
					this.button1TableLayout6.Image = Properties.Resources.TrefPrepravljen;
					this.button1TableLayout6.Name = "TrefPrepravljen";
					rememberCombinationTable6[0] = 2;

				}
				else if (this.button1TableLayout6.Name != "button1TableLayout6" && this.button2TableLayout6.Name == "button2TableLayout6")
				{
					this.button2TableLayout6.Image = Properties.Resources.TrefPrepravljen;
					this.button2TableLayout6.Name = "TrefPrepravljen";
					rememberCombinationTable6[1] = 2;
				}

				else if (this.button2TableLayout6.Name != "button2TableLayout6" && this.button3TableLayout6.Name == "button3TableLayout6")
				{
					this.button3TableLayout6.Image = Properties.Resources.TrefPrepravljen;
					this.button3TableLayout6.Name = "TrefPrepravljen";
					rememberCombinationTable6[2] = 2;

				}
				else
				{
					if (this.button4TableLayout6.Name == "button4TableLayout6")
					{
						this.button4TableLayout6.Image = Properties.Resources.TrefPrepravljen;
						this.button4TableLayout6.Name = "TrefPrepravljen";
						rememberCombinationTable6[3] = 2;
					}
				}
			}
		}

		private void Pik_Click(object sender, EventArgs e)
		{
			/**	First table Layout. */
			if (this.button1CheckBox1.Name != "Cekirano")
			{
				if (this.button1TableLayout1.Name == "button1TableLayout1")
				{
					this.button1TableLayout1.Image = Properties.Resources.PikKONACNI;
					this.button1TableLayout1.Name = "PikKONACNI";
					rememberCombinationTable1[0] = 3;

				}
				else if (this.button1TableLayout1.Name != "button1TableLayout1" && this.button2TableLayout1.Name == "button2TableLayout1")
				{
					this.button2TableLayout1.Image = Properties.Resources.PikKONACNI;
					this.button2TableLayout1.Name = "PikKONACNI";
					rememberCombinationTable1[1] = 3;
				}

				else if (this.button2TableLayout1.Name != "button2TableLayout2" && this.button3TableLayout1.Name == "button3TableLayout1")
				{
					this.button3TableLayout1.Image = Properties.Resources.PikKONACNI;
					this.button3TableLayout1.Name = "PikKONACNI";
					rememberCombinationTable1[2] = 3;

				}
				else
				{
					if (this.button4TableLayout1.Name == "button4TableLayout1")
					{
						this.button4TableLayout1.Image = Properties.Resources.PikKONACNI;
						this.button4TableLayout1.Name = "PikKONACNI";
						rememberCombinationTable1[3] = 3;
					}

				}
			}
			/**	Second table Layout */
			if (this.button1CheckBox2.Name != "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout2.Name == "button1TableLayout2")
				{
					this.button1TableLayout2.Image = Properties.Resources.PikKONACNI;
					this.button1TableLayout2.Name = "PikKONACNI";
					rememberCombinationTable2[0] = 3;

				}
				else if (this.button1TableLayout2.Name != "button1TableLayout2" && this.button2TableLayout2.Name == "button2TableLayout2")
				{
					this.button2TableLayout2.Image = Properties.Resources.PikKONACNI;
					this.button2TableLayout2.Name = "PikKONACNI";
					rememberCombinationTable2[1] = 3;
				}

				else if (this.button2TableLayout2.Name != "button2TableLayout2" && this.button3TableLayout2.Name == "button3TableLayout2")
				{
					this.button3TableLayout2.Image = Properties.Resources.PikKONACNI;
					this.button3TableLayout2.Name = "PikKONACNI";
					rememberCombinationTable2[2] = 3;

				}
				else
				{
					if (this.button4TableLayout2.Name == "button4TableLayout2")
					{
						this.button4TableLayout2.Image = Properties.Resources.PikKONACNI;
						this.button4TableLayout2.Name = "PikKONACNI";
						rememberCombinationTable2[3] = 3;
					}
				}
			}
			/* Third table layout. */
			if (this.button1CheckBox3.Name != "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout3.Name == "button1TableLayout3")
				{
					this.button1TableLayout3.Image = Properties.Resources.PikKONACNI;
					this.button1TableLayout3.Name = "PikKONACNI";
					rememberCombinationTable3[0] = 3;

				}
				else if (this.button1TableLayout3.Name != "button1TableLayout3" && this.button2TableLayout3.Name == "button2TableLayout3")
				{
					this.button2TableLayout3.Image = Properties.Resources.PikKONACNI;
					this.button2TableLayout3.Name = "PikKONACNI";
					rememberCombinationTable3[1] = 3;
				}

				else if (this.button2TableLayout3.Name != "button2TableLayout3" && this.button3TableLayout3.Name == "button3TableLayout3")
				{
					this.button3TableLayout3.Image = Properties.Resources.PikKONACNI;
					this.button3TableLayout3.Name = "PikKONACNI";
					rememberCombinationTable3[2] = 3;

				}
				else
				{
					if (this.button4TableLayout3.Name == "button4TableLayout3")
					{
						this.button4TableLayout3.Image = Properties.Resources.PikKONACNI;
						this.button4TableLayout3.Name = "PikKONACNI";
						rememberCombinationTable3[3] = 3;
					}
				}
			}
			/* Fourth table layout. */
			if (this.button1CheckBox4.Name != "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout4.Name == "button1TableLayout4")
				{
					this.button1TableLayout4.Image = Properties.Resources.PikKONACNI;
					this.button1TableLayout4.Name = "PikKONACNI";
					rememberCombinationTable4[0] = 3;

				}
				else if (this.button1TableLayout4.Name != "button1TableLayout4" && this.button2TableLayout4.Name == "button2TableLayout4")
				{
					this.button2TableLayout4.Image = Properties.Resources.PikKONACNI;
					this.button2TableLayout4.Name = "PikKONACNI";
					rememberCombinationTable4[1] = 3;
				}

				else if (this.button2TableLayout4.Name != "button2TableLayout4" && this.button3TableLayout4.Name == "button3TableLayout4")
				{
					this.button3TableLayout4.Image = Properties.Resources.PikKONACNI;
					this.button3TableLayout4.Name = "PikKONACNI";
					rememberCombinationTable4[2] = 3;

				}
				else
				{
					if (this.button4TableLayout4.Name == "button4TableLayout4")
					{
						this.button4TableLayout4.Image = Properties.Resources.PikKONACNI;
						this.button4TableLayout4.Name = "PikKONACNI";
						rememberCombinationTable4[3] = 3;
					}
				}
			}
			/* Fifth table layout. */
			if (this.button1CheckBox5.Name != "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout5.Name == "button1TableLayout5")
				{
					this.button1TableLayout5.Image = Properties.Resources.PikKONACNI;
					this.button1TableLayout5.Name = "PikKONACNI";
					rememberCombinationTable5[0] = 3;

				}
				else if (this.button1TableLayout5.Name != "button1TableLayout5" && this.button2TableLayout5.Name == "button2TableLayout5")
				{
					this.button2TableLayout5.Image = Properties.Resources.PikKONACNI;
					this.button2TableLayout5.Name = "PikKONACNI";
					rememberCombinationTable5[1] = 3;
				}

				else if (this.button2TableLayout5.Name != "button2TableLayout5" && this.button3TableLayout5.Name == "button3TableLayout5")
				{
					this.button3TableLayout5.Image = Properties.Resources.PikKONACNI;
					this.button3TableLayout5.Name = "PikKONACNI";
					rememberCombinationTable5[2] = 3;

				}
				else
				{
					if (this.button4TableLayout5.Name == "button4TableLayout5")
					{
						this.button4TableLayout5.Image = Properties.Resources.PikKONACNI;
						this.button4TableLayout5.Name = "PikKONACNI";
						rememberCombinationTable5[3] = 3;
					}
				}
			}
			/* Sixth table layout. */
			if (this.button1CheckBox6.Name != "Cekirano" && this.button1CheckBox5.Name == "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout6.Name == "button1TableLayout6")
				{
					this.button1TableLayout6.Image = Properties.Resources.PikKONACNI;
					this.button1TableLayout6.Name = "PikKONACNI";
					rememberCombinationTable6[0] = 3;

				}
				else if (this.button1TableLayout6.Name != "button1TableLayout6" && this.button2TableLayout6.Name == "button2TableLayout6")
				{
					this.button2TableLayout6.Image = Properties.Resources.PikKONACNI;
					this.button2TableLayout6.Name = "PikKONACNI";
					rememberCombinationTable6[1] = 3;
				}

				else if (this.button2TableLayout6.Name != "button2TableLayout6" && this.button3TableLayout6.Name == "button3TableLayout6")
				{
					this.button3TableLayout6.Image = Properties.Resources.PikKONACNI;
					this.button3TableLayout6.Name = "PikKONACNI";
					rememberCombinationTable6[2] = 3;

				}
				else
				{
					if (this.button4TableLayout6.Name == "button4TableLayout6")
					{
						this.button4TableLayout6.Image = Properties.Resources.PikKONACNI;
						this.button4TableLayout6.Name = "PikKONACNI";
						rememberCombinationTable6[3] = 3;
					}
				}
			}
		}

		private void Srce_Click(object sender, EventArgs e)
		{
			/**	First table Layout */
			if (this.button1CheckBox1.Name != "Cekirano")
			{
				if (this.button1TableLayout1.Name == "button1TableLayout1")
				{
					this.button1TableLayout1.Image = Properties.Resources.SrcePrepravljeno;
					this.button1TableLayout1.Name = "SrcePrepravljeno";
					rememberCombinationTable1[0] = 4;

				}
				else if (this.button1TableLayout1.Name != "button1TableLayout1" && this.button2TableLayout1.Name == "button2TableLayout1")
				{
					this.button2TableLayout1.Image = Properties.Resources.SrcePrepravljeno;
					this.button2TableLayout1.Name = "SrcePrepravljeno";
					rememberCombinationTable1[1] = 4;
				}

				else if (this.button2TableLayout1.Name != "button2TableLayout2" && this.button3TableLayout1.Name == "button3TableLayout1")
				{
					this.button3TableLayout1.Image = Properties.Resources.SrcePrepravljeno;
					this.button3TableLayout1.Name = "SrcePrepravljeno";
					rememberCombinationTable1[2] = 4;

				}
				else
				{
					if (this.button4TableLayout1.Name == "button4TableLayout1")
					{
						this.button4TableLayout1.Image = Properties.Resources.SrcePrepravljeno;
						this.button4TableLayout1.Name = "SrcePrepravljeno";
						rememberCombinationTable1[3] = 4;
					}
				}
			}
			/**	Second table Layout */
			if (this.button1CheckBox2.Name != "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout2.Name == "button1TableLayout2")
				{
					this.button1TableLayout2.Image = Properties.Resources.SrcePrepravljeno;
					this.button1TableLayout2.Name = "SrcePrepravljeno";
					rememberCombinationTable2[0] = 4;

				}
				else if (this.button1TableLayout2.Name != "button1TableLayout2" && this.button2TableLayout2.Name == "button2TableLayout2")
				{
					this.button2TableLayout2.Image = Properties.Resources.SrcePrepravljeno;
					this.button2TableLayout2.Name = "SrcePrepravljeno";
					rememberCombinationTable2[1] = 4;
				}

				else if (this.button2TableLayout2.Name != "button2TableLayout2" && this.button3TableLayout2.Name == "button3TableLayout2")
				{
					this.button3TableLayout2.Image = Properties.Resources.SrcePrepravljeno;
					this.button3TableLayout2.Name = "SrcePrepravljeno";
					rememberCombinationTable2[2] = 4;

				}
				else
				{
					if (this.button4TableLayout2.Name == "button4TableLayout2")
					{
						this.button4TableLayout2.Image = Properties.Resources.SrcePrepravljeno;
						this.button4TableLayout2.Name = "SrcePrepravljeno";
						rememberCombinationTable2[3] = 4;
					}
				}
			}
			/* Third table layout. */
			if (this.button1CheckBox3.Name != "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout3.Name == "button1TableLayout3")
				{
					this.button1TableLayout3.Image = Properties.Resources.SrcePrepravljeno;
					this.button1TableLayout3.Name = "SrcePrepravljeno";
					rememberCombinationTable3[0] = 4;

				}
				else if (this.button1TableLayout3.Name != "button1TableLayout3" && this.button2TableLayout3.Name == "button2TableLayout3")
				{
					this.button2TableLayout3.Image = Properties.Resources.SrcePrepravljeno;
					this.button2TableLayout3.Name = "SrcePrepravljeno";
					rememberCombinationTable3[1] = 4;
				}

				else if (this.button2TableLayout3.Name != "button2TableLayout3" && this.button3TableLayout3.Name == "button3TableLayout3")
				{
					this.button3TableLayout3.Image = Properties.Resources.SrcePrepravljeno;
					this.button3TableLayout3.Name = "SrcePrepravljeno";
					rememberCombinationTable3[2] = 4;

				}
				else
				{
					if (this.button4TableLayout3.Name == "button4TableLayout3")
					{
						this.button4TableLayout3.Image = Properties.Resources.SrcePrepravljeno;
						this.button4TableLayout3.Name = "SrcePrepravljeno";
						rememberCombinationTable3[3] = 4;
					}
				}
			}
			/* Fourth table layout. */
			if (this.button1CheckBox4.Name != "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout4.Name == "button1TableLayout4")
				{
					this.button1TableLayout4.Image = Properties.Resources.SrcePrepravljeno;
					this.button1TableLayout4.Name = "SrcePrepravljeno";
					rememberCombinationTable4[0] = 4;

				}
				else if (this.button1TableLayout4.Name != "button1TableLayout4" && this.button2TableLayout4.Name == "button2TableLayout4")
				{
					this.button2TableLayout4.Image = Properties.Resources.SrcePrepravljeno;
					this.button2TableLayout4.Name = "SrcePrepravljeno";
					rememberCombinationTable4[1] = 4;
				}

				else if (this.button2TableLayout4.Name != "button2TableLayout4" && this.button3TableLayout4.Name == "button3TableLayout4")
				{
					this.button3TableLayout4.Image = Properties.Resources.SrcePrepravljeno;
					this.button3TableLayout4.Name = "SrcePrepravljeno";
					rememberCombinationTable4[2] = 4;

				}
				else
				{
					if (this.button4TableLayout4.Name == "button4TableLayout4")
					{
						this.button4TableLayout4.Image = Properties.Resources.SrcePrepravljeno;
						this.button4TableLayout4.Name = "SrcePrepravljeno";
						rememberCombinationTable4[3] = 4;
					}
				}	
			}
			/* Fifth table layout. */
			if (this.button1CheckBox5.Name != "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout5.Name == "button1TableLayout5")
				{
					this.button1TableLayout5.Image = Properties.Resources.SrcePrepravljeno;
					this.button1TableLayout5.Name = "SrcePrepravljeno";
					rememberCombinationTable5[0] = 4;

				}
				else if (this.button1TableLayout5.Name != "button1TableLayout5" && this.button2TableLayout5.Name == "button2TableLayout5")
				{
					this.button2TableLayout5.Image = Properties.Resources.SrcePrepravljeno;
					this.button2TableLayout5.Name = "SrcePrepravljeno";
					rememberCombinationTable5[1] = 4;
				}

				else if (this.button2TableLayout5.Name != "button2TableLayout5" && this.button3TableLayout5.Name == "button3TableLayout5")
				{
					this.button3TableLayout5.Image = Properties.Resources.SrcePrepravljeno;
					this.button3TableLayout5.Name = "SrcePrepravljeno";
					rememberCombinationTable5[2] = 4;

				}
				else
				{
					if (this.button4TableLayout5.Name == "button4TableLayout5")
					{
						this.button4TableLayout5.Image = Properties.Resources.SrcePrepravljeno;
						this.button4TableLayout5.Name = "SrcePrepravljeno";
						rememberCombinationTable5[3] = 4;
					}
				}
			}
			/* Sixth table layout. */
			if (this.button1CheckBox6.Name != "Cekirano" && this.button1CheckBox5.Name == "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout6.Name == "button1TableLayout6")
				{
					this.button1TableLayout6.Image = Properties.Resources.SrcePrepravljeno;
					this.button1TableLayout6.Name = "SrcePrepravljeno";
					rememberCombinationTable6[0] = 4;

				}
				else if (this.button1TableLayout6.Name != "button1TableLayout6" && this.button2TableLayout6.Name == "button2TableLayout6")
				{
					this.button2TableLayout6.Image = Properties.Resources.SrcePrepravljeno;
					this.button2TableLayout6.Name = "SrcePrepravljeno";
					rememberCombinationTable6[1] = 4;
				}

				else if (this.button2TableLayout6.Name != "button2TableLayout6" && this.button3TableLayout6.Name == "button3TableLayout6")
				{
					this.button3TableLayout6.Image = Properties.Resources.SrcePrepravljeno;
					this.button3TableLayout6.Name = "SrcePrepravljeno";
					rememberCombinationTable6[2] = 4;

				}
				else
				{
					if (this.button4TableLayout6.Name == "button4TableLayout6")
					{
						this.button4TableLayout6.Image = Properties.Resources.SrcePrepravljeno;
						this.button4TableLayout6.Name = "SrcePrepravljeno";
						rememberCombinationTable6[3] = 4;
					}
				}
			}
		}

		private void Karo_Click(object sender, EventArgs e)
		{
			/**	First table Layout */
			if (this.button1CheckBox1.Name != "Cekirano")
			{
				if (this.button1TableLayout1.Name == "button1TableLayout1")
				{
					this.button1TableLayout1.Image = Properties.Resources.KaroPrepravljen;
					this.button1TableLayout1.Name = "KaroPrepravljen";
					rememberCombinationTable1[0] = 5;

				}
				else if (this.button1TableLayout1.Name != "button1TableLayout1" && this.button2TableLayout1.Name == "button2TableLayout1")
				{
					this.button2TableLayout1.Image = Properties.Resources.KaroPrepravljen;
					this.button2TableLayout1.Name = "KaroPrepravljen";
					rememberCombinationTable1[1] = 5;
				}

				else if (this.button2TableLayout1.Name != "button2TableLayout2" && this.button3TableLayout1.Name == "button3TableLayout1")
				{
					this.button3TableLayout1.Image = Properties.Resources.KaroPrepravljen;
					this.button3TableLayout1.Name = "KaroPrepravljen";
					rememberCombinationTable1[2] = 5;

				}
				else
				{
					if (this.button4TableLayout1.Name == "button4TableLayout1")
					{
						this.button4TableLayout1.Image = Properties.Resources.KaroPrepravljen;
						this.button4TableLayout1.Name = "KaroPrepravljen";
						rememberCombinationTable1[3] = 5;
					}
				}
			}
			/**	Second table Layout */
			if (this.button1CheckBox2.Name != "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout2.Name == "button1TableLayout2")
				{
					this.button1TableLayout2.Image = Properties.Resources.KaroPrepravljen;
					this.button1TableLayout2.Name = "KaroPrepravljen";
					rememberCombinationTable2[0] = 5;

				}
				else if (this.button1TableLayout2.Name != "button1TableLayout2" && this.button2TableLayout2.Name == "button2TableLayout2")
				{
					this.button2TableLayout2.Image = Properties.Resources.KaroPrepravljen;
					this.button2TableLayout2.Name = "KaroPrepravljen";
					rememberCombinationTable2[1] = 5;
				}

				else if (this.button2TableLayout2.Name != "button2TableLayout2" && this.button3TableLayout2.Name == "button3TableLayout2")
				{
					this.button3TableLayout2.Image = Properties.Resources.KaroPrepravljen;
					this.button3TableLayout2.Name = "KaroPrepravljen";
					rememberCombinationTable2[2] = 5;

				}
				else
				{
					if (this.button4TableLayout2.Name == "button4TableLayout2")
					{
						this.button4TableLayout2.Image = Properties.Resources.KaroPrepravljen;
						this.button4TableLayout2.Name = "KaroPrepravljen";
						rememberCombinationTable2[3] = 5;
					}
				}
			}
			/* Third table layout. */
			if (this.button1CheckBox3.Name != "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout3.Name == "button1TableLayout3")
				{
					this.button1TableLayout3.Image = Properties.Resources.KaroPrepravljen;
					this.button1TableLayout3.Name = "KaroPrepravljen";
					rememberCombinationTable3[0] = 5;

				}
				else if (this.button1TableLayout3.Name != "button1TableLayout3" && this.button2TableLayout3.Name == "button2TableLayout3")
				{
					this.button2TableLayout3.Image = Properties.Resources.KaroPrepravljen;
					this.button2TableLayout3.Name = "KaroPrepravljen";
					rememberCombinationTable3[1] = 5;
				}

				else if (this.button2TableLayout3.Name != "button2TableLayout3" && this.button3TableLayout3.Name == "button3TableLayout3")
				{
					this.button3TableLayout3.Image = Properties.Resources.KaroPrepravljen;
					this.button3TableLayout3.Name = "KaroPrepravljen";
					rememberCombinationTable3[2] = 5;

				}
				else
				{
					if (this.button4TableLayout3.Name == "button4TableLayout3")
					{
						this.button4TableLayout3.Image = Properties.Resources.KaroPrepravljen;
						this.button4TableLayout3.Name = "KaroPrepravljen";
						rememberCombinationTable3[3] = 5;
					}
				}
			}
			/* Fourth table layout. */
			if (this.button1CheckBox4.Name != "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout4.Name == "button1TableLayout4")
				{
					this.button1TableLayout4.Image = Properties.Resources.KaroPrepravljen;
					this.button1TableLayout4.Name = "KaroPrepravljen";
					rememberCombinationTable4[0] = 5;

				}
				else if (this.button1TableLayout4.Name != "button1TableLayout4" && this.button2TableLayout4.Name == "button2TableLayout4")
				{
					this.button2TableLayout4.Image = Properties.Resources.KaroPrepravljen;
					this.button2TableLayout4.Name = "KaroPrepravljen";
					rememberCombinationTable4[1] = 5;
				}

				else if (this.button2TableLayout4.Name != "button2TableLayout4" && this.button3TableLayout4.Name == "button3TableLayout4")
				{
					this.button3TableLayout4.Image = Properties.Resources.KaroPrepravljen;
					this.button3TableLayout4.Name = "KaroPrepravljen";
					rememberCombinationTable4[2] = 5;

				}
				else
				{
					if (this.button4TableLayout4.Name == "button4TableLayout4")
					{
						this.button4TableLayout4.Image = Properties.Resources.KaroPrepravljen;
						this.button4TableLayout4.Name = "KaroPrepravljen";
						rememberCombinationTable4[3] = 5;
					}
				}
			}
			/* Fifth table layout. */
			if (this.button1CheckBox5.Name != "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout5.Name == "button1TableLayout5")
				{
					this.button1TableLayout5.Image = Properties.Resources.KaroPrepravljen;
					this.button1TableLayout5.Name = "KaroPrepravljen";
					rememberCombinationTable5[0] = 5;

				}
				else if (this.button1TableLayout5.Name != "button1TableLayout5" && this.button2TableLayout5.Name == "button2TableLayout5")
				{
					this.button2TableLayout5.Image = Properties.Resources.KaroPrepravljen;
					this.button2TableLayout5.Name = "KaroPrepravljen";
					rememberCombinationTable5[1] = 5;
				}

				else if (this.button2TableLayout5.Name != "button2TableLayout5" && this.button3TableLayout5.Name == "button3TableLayout5")
				{
					this.button3TableLayout5.Image = Properties.Resources.KaroPrepravljen;
					this.button3TableLayout5.Name = "KaroPrepravljen";
					rememberCombinationTable5[2] = 5;

				}
				else
				{
					if (this.button4TableLayout5.Name == "button4TableLayout5")
					{
						this.button4TableLayout5.Image = Properties.Resources.KaroPrepravljen;
						this.button4TableLayout5.Name = "KaroPrepravljen";
						rememberCombinationTable5[3] = 5;
					}
				}
			}
			/* Sixth table layout. */
			if (this.button1CheckBox6.Name != "Cekirano" && this.button1CheckBox5.Name == "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout6.Name == "button1TableLayout6")
				{
					this.button1TableLayout6.Image = Properties.Resources.KaroPrepravljen;
					this.button1TableLayout6.Name = "KaroPrepravljen";
					rememberCombinationTable6[0] = 5;

				}
				else if (this.button1TableLayout6.Name != "button1TableLayout6" && this.button2TableLayout6.Name == "button2TableLayout6")
				{
					this.button2TableLayout6.Image = Properties.Resources.KaroPrepravljen;
					this.button2TableLayout6.Name = "KaroPrepravljen";
					rememberCombinationTable6[1] = 5;
				}

				else if (this.button2TableLayout6.Name != "button2TableLayout6" && this.button3TableLayout6.Name == "button3TableLayout6")
				{
					this.button3TableLayout6.Image = Properties.Resources.KaroPrepravljen;
					this.button3TableLayout6.Name = "KaroPrepravljen";
					rememberCombinationTable6[2] = 5;

				}
				else
				{
					if (this.button4TableLayout6.Name == "button4TableLayout6")
					{
						this.button4TableLayout6.Image = Properties.Resources.KaroPrepravljen;
						this.button4TableLayout6.Name = "KaroPrepravljen";
						rememberCombinationTable6[3] = 5;
					}
				}
			}
		}

		private void Zvijezda_Click(object sender, EventArgs e)
		{
			/**	First table Layout */
			if (this.button1CheckBox1.Name != "Cekirano")
			{
				if (this.button1TableLayout1.Name == "button1TableLayout1")
				{
					this.button1TableLayout1.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button1TableLayout1.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable1[0] = 6;

				}
				else if (this.button1TableLayout1.Name != "button1TableLayout1" && this.button2TableLayout1.Name == "button2TableLayout1")
				{
					this.button2TableLayout1.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button2TableLayout1.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable1[1] = 6;
				}

				else if (this.button2TableLayout1.Name != "button2TableLayout2" && this.button3TableLayout1.Name == "button3TableLayout1")
				{
					this.button3TableLayout1.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button3TableLayout1.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable1[2] = 6;

				}
				else
				{
					if (this.button4TableLayout1.Name == "button4TableLayout1")
					{
						this.button4TableLayout1.Image = Properties.Resources.ZvijezdaPrepravljena;
						this.button4TableLayout1.Name = "ZvijezdaPrepravljena";
						rememberCombinationTable1[3] = 6;
					}
				}
			}
			/**	Second table Layout */
			if (this.button1CheckBox2.Name != "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout2.Name == "button1TableLayout2")
				{
					this.button1TableLayout2.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button1TableLayout2.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable2[0] = 6;

				}
				else if (this.button1TableLayout2.Name != "button1TableLayout2" && this.button2TableLayout2.Name == "button2TableLayout2")
				{
					this.button2TableLayout2.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button2TableLayout2.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable2[1] = 6;
				}

				else if (this.button2TableLayout2.Name != "button2TableLayout2" && this.button3TableLayout2.Name == "button3TableLayout2")
				{
					this.button3TableLayout2.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button3TableLayout2.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable2[2] = 6;

				}
				else
				{
					if (this.button4TableLayout2.Name == "button4TableLayout2")
					{
						this.button4TableLayout2.Image = Properties.Resources.ZvijezdaPrepravljena;
						this.button4TableLayout2.Name = "ZvijezdaPrepravljena";
						rememberCombinationTable2[3] = 6;
					}
				}
			}
			/* Third table layout. */
			if (this.button1CheckBox3.Name != "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout3.Name == "button1TableLayout3")
				{
					this.button1TableLayout3.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button1TableLayout3.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable3[0] = 6;

				}
				else if (this.button1TableLayout3.Name != "button1TableLayout3" && this.button2TableLayout3.Name == "button2TableLayout3")
				{
					this.button2TableLayout3.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button2TableLayout3.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable3[1] = 6;
				}

				else if (this.button2TableLayout3.Name != "button2TableLayout3" && this.button3TableLayout3.Name == "button3TableLayout3")
				{
					this.button3TableLayout3.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button3TableLayout3.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable3[2] = 6;

				}
				else
				{
					if (this.button4TableLayout3.Name == "button4TableLayout3")
					{
						this.button4TableLayout3.Image = Properties.Resources.ZvijezdaPrepravljena;
						this.button4TableLayout3.Name = "ZvijezdaPrepravljena";
						rememberCombinationTable3[3] = 6;
					}
				}
			}
			/* Fourth table layout. */
			if (this.button1CheckBox4.Name != "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout4.Name == "button1TableLayout4")
				{
					this.button1TableLayout4.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button1TableLayout4.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable4[0] = 6;

				}
				else if (this.button1TableLayout4.Name != "button1TableLayout4" && this.button2TableLayout4.Name == "button2TableLayout4")
				{
					this.button2TableLayout4.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button2TableLayout4.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable4[1] = 6;
				}

				else if (this.button2TableLayout4.Name != "button2TableLayout4" && this.button3TableLayout4.Name == "button3TableLayout4")
				{
					this.button3TableLayout4.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button3TableLayout4.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable4[2] = 6;

				}
				else
				{
					if (this.button4TableLayout4.Name == "button4TableLayout4")
					{
						this.button4TableLayout4.Image = Properties.Resources.ZvijezdaPrepravljena;
						this.button4TableLayout4.Name = "ZvijezdaPrepravljena";
						rememberCombinationTable4[3] = 6;
					}
				}
			}
			/* Fifth table layout. */
			if (this.button1CheckBox5.Name != "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout5.Name == "button1TableLayout5")
				{
					this.button1TableLayout5.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button1TableLayout5.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable5[0] = 6;

				}
				else if (this.button1TableLayout5.Name != "button1TableLayout5" && this.button2TableLayout5.Name == "button2TableLayout5")
				{
					this.button2TableLayout5.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button2TableLayout5.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable5[1] = 6;
				}

				else if (this.button2TableLayout5.Name != "button2TableLayout5" && this.button3TableLayout5.Name == "button3TableLayout5")
				{
					this.button3TableLayout5.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button3TableLayout5.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable5[2] = 6;

				}
				else
				{
					if (this.button4TableLayout5.Name == "button4TableLayout5")
					{
						this.button4TableLayout5.Image = Properties.Resources.ZvijezdaPrepravljena;
						this.button4TableLayout5.Name = "ZvijezdaPrepravljena";
						rememberCombinationTable5[3] = 6;
					}
				}
			}
			/* Sixth table layout. */
			if (this.button1CheckBox6.Name != "Cekirano" && this.button1CheckBox5.Name == "Cekirano" && this.button1CheckBox4.Name == "Cekirano" && this.button1CheckBox3.Name == "Cekirano" && this.button1CheckBox2.Name == "Cekirano" && this.button1CheckBox1.Name == "Cekirano")
			{
				if (this.button1TableLayout6.Name == "button1TableLayout6")
				{
					this.button1TableLayout6.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button1TableLayout6.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable6[0] = 6;

				}
				else if (this.button1TableLayout6.Name != "button1TableLayout6" && this.button2TableLayout6.Name == "button2TableLayout6")
				{
					this.button2TableLayout6.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button2TableLayout6.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable6[1] = 6;
				}

				else if (this.button2TableLayout6.Name != "button2TableLayout6" && this.button3TableLayout6.Name == "button3TableLayout6")
				{
					this.button3TableLayout6.Image = Properties.Resources.ZvijezdaPrepravljena;
					this.button3TableLayout6.Name = "ZvijezdaPrepravljena";
					rememberCombinationTable6[2] = 6;

				}
				else
				{
					if (this.button4TableLayout6.Name == "button4TableLayout6")
					{
						this.button4TableLayout6.Image = Properties.Resources.ZvijezdaPrepravljena;
						this.button4TableLayout6.Name = "ZvijezdaPrepravljena";
						rememberCombinationTable6[3] = 6;
					}
				}
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		/** Method which initialised timer. */
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
			//totalSeconds = 100;

			if (totalSeconds > 0)
			{
				totalSeconds--;
				this.labelTime.Text = totalSeconds.ToString();

			}
			else
			{
				this.timer1.Stop();

				/** If user want to play new game after time elapsed. */
				/*string message = "Isteklo Vam je vrijeme!\n Da li zelite da ponovo igrate ? ";
				string title = "Vrijeme !";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;	
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/

				int[] finalCombination = new int[4];
				for (int i = 0; i < 4; i++)
				{
					finalCombination[i] = this.getBusinessLogic().returnSingleArrayValue(i);
				}
				for (int i = 0; i < 4; i++)
				{
					putFinalSymbol(i + 1, finalCombination[i]);
				}
				this.Hide();
				new IstekloVrijemeForm(finalCombination[0], finalCombination[1], finalCombination[2], finalCombination[3]).Show();
			}
		}

		/** Methods for every single table(row) when player want to check his single row combination. */
		private void button1CheckBox1_Click(object sender, EventArgs e)
		{
			this.button1CheckBox1.Name = "Cekirano";
			int[] equality = new int[4];
			equality = this.getBusinessLogic().checkRowCombination(rememberCombinationTable1);

			// If somewhone want to check results.
			//MessageBox.Show("Provjera finalnog niza: " + this.getBusinessLogic().returnSingleArrayValue(0) + " " + this.getBusinessLogic().returnSingleArrayValue(1) + " " + this.getBusinessLogic().returnSingleArrayValue(2) + " " + this.getBusinessLogic().returnSingleArrayValue(3));
			//MessageBox.Show("Provjera unesenog niza : " + rememberCombinationTable1[0] + " " + rememberCombinationTable1[1] + " " + rememberCombinationTable1[2] + " " + rememberCombinationTable1[3]);
			//MessageBox.Show("Provjera pogodjenog niza : " + equality[0] + " " + equality[1] + " " + equality[2] + " " + equality[3]);

			/** Situation when somewhone click on check box, but it is not full combination. */
			if (this.button1CheckBox1.Name == "Cekirano" && (this.button1TableLayout1.Name == "button1TableLayout1" || this.button2TableLayout1.Name == "button2TableLayout1" || this.button3TableLayout1.Name == "button3TableLayout1" || this.button4TableLayout1.Name == "button4TableLayout1"))
			{
				this.button1CheckBox1.Name = "button1CheckBox1";

			}
			/**	When somewhone get a right(final) combination. */
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 1))
			{
				/** If user want to play new game after he guess the final combination. */
				string message = "Bravo! Pogodili ste pravu kombinaciju i osvojili 50 poena!\n NOVA IGRA ";
				string title = "Pobjeda !";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;	
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}
				this.button1TableLayoutFinal.Image = this.button1TableLayout1.Image;
				this.button2TableLayoutFinal.Image = this.button2TableLayout1.Image;
				this.button3TableLayoutFinal.Image = this.button3TableLayout1.Image;
				this.button4TableLayoutFinal.Image = this.button4TableLayout1.Image;
				
			}
			/** Other opportunities and possible combinations. */
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 2))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.A_1_1_1_2;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.B_1_1_2_2;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.C_1_2_2_2;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.D_1_1_1_3;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.E_1_1_3_3;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.F_1_3_3_3;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.G_2_2_2_2;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.H_2_2_2_3;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.I_2_2_3_3;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.J_2_3_3_3;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.K_1_1_2_3;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.L_1_2_2_3;
			}
			else if (this.button1CheckBox1.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.M_1_2_3_3;
			}
			else
			{
				this.button1CheckBox2.Image = Properties.Resources.CheckBox;
				this.button1Provjera1.Image = Properties.Resources.N_3_3_3_3;
			}
		}

		private void button1CheckBox2_Click(object sender, EventArgs e)
		{
			this.button1CheckBox2.Name = "Cekirano";
			int[] equality = new int[4];
			equality = this.getBusinessLogic().checkRowCombination(rememberCombinationTable2);

			// If somewhone want to check results.
			//MessageBox.Show("Provjera finalnog niza: " + this.getBusinessLogic().returnSingleArrayValue(0) + " " + this.getBusinessLogic().returnSingleArrayValue(1) + " " + this.getBusinessLogic().returnSingleArrayValue(2) + " " + this.getBusinessLogic().returnSingleArrayValue(3));
			//MessageBox.Show("Provjera unesenog niza : " + rememberCombinationTable2[0] + " " + rememberCombinationTable2[1] + " " + rememberCombinationTable2[2] + " " + rememberCombinationTable2[3]);
			//MessageBox.Show("Provjera pogodjenog niza : " + equality[0] + " " + equality[1] + " " + equality[2] + " " + equality[3]);
			
			/** Situation when somewhone click on check box, but it is not full combination */
			if (this.button1CheckBox2.Name == "Cekirano" && (this.button1TableLayout2.Name == "button1TableLayout2" || this.button2TableLayout2.Name == "button2TableLayout2" || this.button3TableLayout2.Name == "button3TableLayout2" || this.button4TableLayout2.Name == "button4TableLayout2"))
			{
				this.button1CheckBox2.Name = "button1CheckBox2";
				//this.button1Provjera1.Image = Properties.Resources.B_1_1_2_2;
				//this.button1CheckBox2.Image = Properties.Resources.CheckBox;


			}/** Other opportunities and possible combinations */
			/**	When somewhone get a right(final) combination. */
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 1))
			{
				/** If user want to play new game after he guess the final combination. */
				string message = "Bravo! Pogodili ste pravu kombinaciju i osvojili 40 poena!\n NOVA IGRA  ";
				string title = "Pobjeda !";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}
				this.button1TableLayoutFinal.Image = this.button1TableLayout2.Image;
				this.button2TableLayoutFinal.Image = this.button2TableLayout2.Image;
				this.button3TableLayoutFinal.Image = this.button3TableLayout2.Image;
				this.button4TableLayoutFinal.Image = this.button4TableLayout2.Image;
				this.Hide();
			}
			/** Other opportunities and possible combinations. */
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 2))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.A_1_1_1_2;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.B_1_1_2_2;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.C_1_2_2_2;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.D_1_1_1_3;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.E_1_1_3_3;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.F_1_3_3_3;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.G_2_2_2_2;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.H_2_2_2_3;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.I_2_2_3_3;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.J_2_3_3_3;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.K_1_1_2_3;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.L_1_2_2_3;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.M_1_2_3_3;
			}
			else
			{
				this.button1CheckBox3.Image = Properties.Resources.CheckBox;
				this.button1Provjera2.Image = Properties.Resources.N_3_3_3_3;
			}
		}

		private void button1CheckBox3_Click(object sender, EventArgs e)
		{
			this.button1CheckBox3.Name = "Cekirano";
			int[] equality = new int[4];
			equality = this.getBusinessLogic().checkRowCombination(rememberCombinationTable3);
			
			// If somewhone want to check results.
			//MessageBox.Show("Provjera finalnog niza: " + this.getBusinessLogic().returnSingleArrayValue(0) + " " + this.getBusinessLogic().returnSingleArrayValue(1) + " " + this.getBusinessLogic().returnSingleArrayValue(2) + " " + this.getBusinessLogic().returnSingleArrayValue(3));
			//MessageBox.Show("Provjera unesenog niza : " + rememberCombinationTable3[0] + " " + rememberCombinationTable3[1] + " " + rememberCombinationTable3[2] + " " + rememberCombinationTable3[3]);
			//MessageBox.Show("Provjera pogodjenog niza : " + equality[0] + " " + equality[1] + " " + equality[2] + " " + equality[3]);


			/** Situation when somewhone click on check box, but there is not full combination */
			if (this.button1CheckBox3.Name == "Cekirano" && (this.button1TableLayout3.Name == "button1TableLayout3" || this.button2TableLayout3.Name == "button2TableLayout3" || this.button3TableLayout3.Name == "button3TableLayout3" || this.button4TableLayout3.Name == "button4TableLayout3"))
			{
				this.button1CheckBox3.Name = "button1CheckBox3";
				//this.button1Provjera1.Image = Properties.Resources.B_1_1_2_2;
				//this.button1CheckBox2.Image = Properties.Resources.CheckBox;


			}/** Other opportunities and possible combinations */
			/**	When somewhone get a right(final) combination. */
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 1))
			{
				/** If user want to play new game after he guess the final combination. */
				string message = "Bravo! Pogodili ste pravu kombinaciju i osvojili 30 poena!\n NOVA IGRA  ";
				string title = "Pobjeda !";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}
				this.button1TableLayoutFinal.Image = this.button1TableLayout3.Image;
				this.button2TableLayoutFinal.Image = this.button2TableLayout3.Image;
				this.button3TableLayoutFinal.Image = this.button3TableLayout3.Image;
				this.button4TableLayoutFinal.Image = this.button4TableLayout3.Image;
				this.Hide();
			}
			/** Other opportunities and possible combinations. */
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 2))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.A_1_1_1_2;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.B_1_1_2_2;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.C_1_2_2_2;
			}
			else if (this.button1CheckBox2.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.D_1_1_1_3;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.E_1_1_3_3;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.F_1_3_3_3;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.G_2_2_2_2;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.H_2_2_2_3;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.I_2_2_3_3;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.J_2_3_3_3;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.K_1_1_2_3;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.L_1_2_2_3;
			}
			else if (this.button1CheckBox3.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.M_1_2_3_3;
			}
			else
			{
				this.button1CheckBox4.Image = Properties.Resources.CheckBox;
				this.button1Provjera3.Image = Properties.Resources.N_3_3_3_3;
			}
		}

		private void button1CheckBox4_Click(object sender, EventArgs e)
		{
			this.button1CheckBox4.Name = "Cekirano";
			int[] equality = new int[4];
			equality = this.getBusinessLogic().checkRowCombination(rememberCombinationTable4);
			
			// If somewhone want to check results.
			//MessageBox.Show("Provjera finalnog niza: " + this.getBusinessLogic().returnSingleArrayValue(0) + " " + this.getBusinessLogic().returnSingleArrayValue(1) + " " + this.getBusinessLogic().returnSingleArrayValue(2) + " " + this.getBusinessLogic().returnSingleArrayValue(3));
			//MessageBox.Show("Provjera unesenog niza : " + rememberCombinationTable4[0] + " " + rememberCombinationTable4[1] + " " + rememberCombinationTable4[2] + " " + rememberCombinationTable4[3]);
			//MessageBox.Show("Provjera pogodjenog niza : " + equality[0] + " " + equality[1] + " " + equality[2] + " " + equality[3]);


			/** Situation when somewhone click on check box, but it is not full combination */
			if (this.button1CheckBox4.Name == "Cekirano" && (this.button1TableLayout4.Name == "button1TableLayout4" || this.button2TableLayout4.Name == "button2TableLayout4" || this.button3TableLayout4.Name == "button3TableLayout4" || this.button4TableLayout4.Name == "button4TableLayout4"))
			{
				this.button1CheckBox4.Name = "button1CheckBox4";
				//this.button1Provjera1.Image = Properties.Resources.B_1_1_2_2;
				//this.button1CheckBox2.Image = Properties.Resources.CheckBox;


			}/** Other opportunities and possible combinations */
			/**	When player's combination is equal to final combination. */
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 1))
			{
				/** If user want to play new game after he guess the final combination. */
				string message = "Bravo! Pogodili ste pravu kombinaciju i osvojili 20 poena!\n NOVA IGRA  ";
				string title = "Pobjeda !";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}
				this.button1TableLayoutFinal.Image = this.button1TableLayout3.Image;
				this.button2TableLayoutFinal.Image = this.button2TableLayout3.Image;
				this.button3TableLayoutFinal.Image = this.button3TableLayout3.Image;
				this.button4TableLayoutFinal.Image = this.button4TableLayout3.Image;
				this.Hide();
			}
			/** Other opportunities and possible combinations. */
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 2))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.A_1_1_1_2;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.B_1_1_2_2;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.C_1_2_2_2;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.D_1_1_1_3;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.E_1_1_3_3;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.F_1_3_3_3;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.G_2_2_2_2;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.H_2_2_2_3;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.I_2_2_3_3;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.J_2_3_3_3;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.K_1_1_2_3;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.L_1_2_2_3;
			}
			else if (this.button1CheckBox4.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.M_1_2_3_3;
			}
			else
			{
				this.button1CheckBox5.Image = Properties.Resources.CheckBox;
				this.button1Provjera4.Image = Properties.Resources.N_3_3_3_3;
			}
		}

		private void button1CheckBox5_Click(object sender, EventArgs e)
		{
			this.button1CheckBox5.Name = "Cekirano";
			int[] equality = new int[4];
			equality = this.getBusinessLogic().checkRowCombination(rememberCombinationTable5);
			
			// If somewhone want to check results.
			//MessageBox.Show("Provjera finalnog niza: " + this.getBusinessLogic().returnSingleArrayValue(0) + " " + this.getBusinessLogic().returnSingleArrayValue(1) + " " + this.getBusinessLogic().returnSingleArrayValue(2) + " " + this.getBusinessLogic().returnSingleArrayValue(3));
			//MessageBox.Show("Provjera unesenog niza : " + rememberCombinationTable5[0] + " " + rememberCombinationTable5[1] + " " + rememberCombinationTable5[2] + " " + rememberCombinationTable5[3]);
			//MessageBox.Show("Provjera pogodjenog niza : " + equality[0] + " " + equality[1] + " " + equality[2] + " " + equality[3]);

			/** Situation when somewhone click on check box, but it is not full combination */
			if (this.button1CheckBox5.Name == "Cekirano" && (this.button1TableLayout5.Name == "button1TableLayout5" || this.button2TableLayout5.Name == "button2TableLayout5" || this.button3TableLayout5.Name == "button3TableLayout5" || this.button4TableLayout5.Name == "button4TableLayout5"))
			{
				this.button1CheckBox5.Name = "button1CheckBox5";



			}
			/**	When player's combination is equal to final combination. */
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 1))
			{
				/** If user want to play new game after he guess the final combination. */
				string message = "Bravo! Pogodili ste pravu kombinaciju i osvojili 15 poena!\n NOVA IGRA  ";
				string title = "Pobjeda !";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}
				this.button1TableLayoutFinal.Image = this.button1TableLayout5.Image;
				this.button2TableLayoutFinal.Image = this.button2TableLayout5.Image;
				this.button3TableLayoutFinal.Image = this.button3TableLayout5.Image;
				this.button4TableLayoutFinal.Image = this.button4TableLayout5.Image;
				this.Hide();
			}
			/** Other opportunities and possible combinations */
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 2))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.A_1_1_1_2;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.B_1_1_2_2;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.C_1_2_2_2;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.D_1_1_1_3;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.E_1_1_3_3;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.F_1_3_3_3;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.G_2_2_2_2;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.H_2_2_2_3;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.I_2_2_3_3;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.J_2_3_3_3;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.K_1_1_2_3;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.L_1_2_2_3;
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.M_1_2_3_3;
			}
			else
			{
				this.button1CheckBox6.Image = Properties.Resources.CheckBox;
				this.button1Provjera5.Image = Properties.Resources.N_3_3_3_3;
			}

		}

		private void button1CheckBox6_Click(object sender, EventArgs e)
		{
			this.button1CheckBox6.Name = "Cekirano";
			int[] equality = new int[4];
			int[] finalCombination = new int[4];

			for (int i = 0; i < 4; i++)
			{
				finalCombination[i] = this.getBusinessLogic().returnSingleArrayValue(i);
			}
			equality = this.getBusinessLogic().checkRowCombination(rememberCombinationTable6);


			// If somewhone want to check results.
			//MessageBox.Show("Provjera finalnog niza: " + this.getBusinessLogic().returnSingleArrayValue(0) + " " + this.getBusinessLogic().returnSingleArrayValue(1) + " " + this.getBusinessLogic().returnSingleArrayValue(2) + " " + this.getBusinessLogic().returnSingleArrayValue(3));
			//MessageBox.Show("Provjera unesenog niza : " + rememberCombinationTable6[0] + " " + rememberCombinationTable6[1] + " " + rememberCombinationTable6[2] + " " + rememberCombinationTable6[3]);
			//MessageBox.Show("Provjera pogodjenog niza : " + equality[0] + " " + equality[1] + " " + equality[2] + " " + equality[3]);

			/** Situation when somewhone click on check box, but there is not full combination */
			if (this.button1CheckBox6.Name == "Cekirano" && (this.button1TableLayout6.Name == "button1TableLayout6" || this.button2TableLayout6.Name == "button2TableLayout6" || this.button3TableLayout6.Name == "button3TableLayout6" || this.button4TableLayout6.Name == "button4TableLayout6"))
			{
				this.button1CheckBox6.Name = "button1CheckBox6";
				//this.button1Provjera1.Image = Properties.Resources.B_1_1_2_2;
				//this.button1CheckBox2.Image = Properties.Resources.CheckBox;


			}/** Other opportunities and possible combinations */
			/**	When player's combination is equal to final combination. */
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 1))
			{
				/** If user want to play new game after he guess the final combination. */
				string message = "Bravo! Pogodili ste pravu kombinaciju i osvojili 10 poena!\n NOVA IGRA  ";
				string title = "Pobjeda !";
				MessageBoxButtons buttonsNewGame = MessageBoxButtons.YesNo;
				DialogResult resultNewGame = MessageBox.Show(message, title, buttonsNewGame);
				if (resultNewGame == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}
				this.Hide();
			}
			/** Other opportunities and possible combinations */
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 2))
			{
				this.button1Provjera6.Image = Properties.Resources.A_1_1_1_2;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";
				MessageBoxButtons buttonsNewGame = MessageBoxButtons.YesNo;
				DialogResult resultNewGame = MessageBox.Show(message, title, buttonsNewGame);
				if (resultNewGame == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1Provjera6.Image = Properties.Resources.B_1_1_2_2;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";
			MessageBoxButtons buttonsNewGame = MessageBoxButtons.YesNo;
				DialogResult resultNewGame = MessageBox.Show(message, title, buttonsNewGame);
				if (resultNewGame == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1Provjera6.Image = Properties.Resources.C_1_2_2_2;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;

				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 1 && equality[3] == 3))
			{
			
				this.button1Provjera6.Image = Properties.Resources.D_1_1_1_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1Provjera6.Image = Properties.Resources.E_1_1_3_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1Provjera6.Image = Properties.Resources.F_1_3_3_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 2))
			{
				this.button1Provjera6.Image = Properties.Resources.G_2_2_2_2;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1Provjera6.Image = Properties.Resources.H_2_2_2_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1Provjera6.Image = Properties.Resources.I_2_2_3_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 2 && equality[1] == 3 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1Provjera6.Image = Properties.Resources.J_2_3_3_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 1 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1Provjera6.Image = Properties.Resources.K_1_1_2_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox6.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 2 && equality[3] == 3))
			{
				this.button1Provjera6.Image = Properties.Resources.L_1_2_2_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else if (this.button1CheckBox5.Name == "Cekirano" && (equality[0] == 1 && equality[1] == 2 && equality[2] == 3 && equality[3] == 3))
			{
				this.button1Provjera6.Image = Properties.Resources.M_1_2_3_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";
				
				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			else
			{
			
				this.button1Provjera6.Image = Properties.Resources.N_3_3_3_3;
				/** If user want to play new game after he guess the final combination. */
				string message = "Nažalost niste uspjeli pogoditi konačnu kombinaciju!\n NOVA IGRA ";
				string title = "Poraz !";

				/*MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					new PocetakIgre().Show();
					this.Hide();
				}
				else
				{
					this.Hide();
				}*/
			}
			this.labelTime.Hide();
			for (int i = 0; i < 4; i++)
			{
				putFinalSymbol(i + 1, finalCombination[i]);
			}

			string messageNewGame = "NOVA IGRA ";
			string titleNewGame = "Nova igra !";

			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(messageNewGame, titleNewGame, buttons);
			if (result == DialogResult.Yes)
			{
				new PocetakIgre().Show();
				this.Hide();
			}
			else
			{
				this.Hide();
			}
	}

	/**	Method which show final combination in final row. */
			public void putFinalSymbol(int position, int index)
		{
			if (index == 1 && position == 1)
			{
				this.button1TableLayoutFinal.Image = Properties.Resources.SmajliPrepravljen;
			}
			else if (index == 2 && position == 1)
			{

				this.button1TableLayoutFinal.Image = Properties.Resources.TrefPrepravljen;
			}
			else if (index == 3 && position == 1)
			{

				this.button1TableLayoutFinal.Image = Properties.Resources.PikKONACNI;
			}
			else if (index == 4 && position == 1)
			{

				this.button1TableLayoutFinal.Image = Properties.Resources.SrcePrepravljeno;
			}
			else if (index == 5 && position == 1)
			{

				this.button1TableLayoutFinal.Image = Properties.Resources.KaroPrepravljen;
			}
			else if (index == 6 && position == 1)
			{

				this.button1TableLayoutFinal.Image = Properties.Resources.ZvijezdaPrepravljena;
			}
			else if (index == 1 && position == 2)
			{

				this.button2TableLayoutFinal.Image = Properties.Resources.SmajliPrepravljen;
			}
			else if (index == 2 && position == 2)
			{

				this.button2TableLayoutFinal.Image = Properties.Resources.TrefPrepravljen;
			}
			else if (index == 3 && position == 2)
			{

				this.button2TableLayoutFinal.Image = Properties.Resources.PikKONACNI;
			}
			else if (index == 4 && position == 2)
			{

				this.button2TableLayoutFinal.Image = Properties.Resources.SrcePrepravljeno;
			}
			else if (index == 5 && position == 2)
			{

				this.button2TableLayoutFinal.Image = Properties.Resources.KaroPrepravljen;
			}
			else if (index == 6 && position == 2)
			{

				this.button2TableLayoutFinal.Image = Properties.Resources.ZvijezdaPrepravljena;
			}
			else if (index == 1 && position == 3)
			{

				this.button3TableLayoutFinal.Image = Properties.Resources.SmajliPrepravljen;
			}
			else if (index == 2 && position == 3)
			{

				this.button3TableLayoutFinal.Image = Properties.Resources.TrefPrepravljen;
			}
			else if (index == 3 && position == 3)
			{

				this.button3TableLayoutFinal.Image = Properties.Resources.PikKONACNI;
			}
			else if (index == 4 && position == 3)
			{

				this.button3TableLayoutFinal.Image = Properties.Resources.SrcePrepravljeno;
			}
			else if (index == 5 && position == 3)
			{

				this.button3TableLayoutFinal.Image = Properties.Resources.KaroPrepravljen;
			}
			else if (index == 6 && position == 3)
			{

				this.button3TableLayoutFinal.Image = Properties.Resources.ZvijezdaPrepravljena;
			}
			else if (index == 1 && position == 4)
			{

				this.button4TableLayoutFinal.Image = Properties.Resources.SmajliPrepravljen;
			}
			else if (index == 2 && position == 4)
			{

				this.button4TableLayoutFinal.Image = Properties.Resources.TrefPrepravljen;
			}
			else if (index == 3 && position == 4)
			{

				this.button4TableLayoutFinal.Image = Properties.Resources.PikKONACNI;
			}
			else if (index == 4 && position == 4)
			{

				this.button4TableLayoutFinal.Image = Properties.Resources.SrcePrepravljeno;
			}
			else if (index == 5 && position == 4)
			{

				this.button4TableLayoutFinal.Image = Properties.Resources.KaroPrepravljen;
			}
			else if (index == 6 && position == 4)
			{

				this.button4TableLayoutFinal.Image = Properties.Resources.ZvijezdaPrepravljena;
			}

		}

		/**	Methods for disabling previous character in single row. */
		//First table.
		private void button1TableLayout1_Click_1(object sender, EventArgs e)
		{
			if (this.button1CheckBox1.Name != "Cekirano" && this.button2TableLayout1.Name == "button2TableLayout1")
			{
				this.button1TableLayout1.Image = Properties.Resources.Podloga;
				this.button1TableLayout1.Name = "button1TableLayout1";

			}
		}

		private void button2TableLayout1_Click_1(object sender, EventArgs e)
		{
			if (this.button1CheckBox1.Name != "Cekirano" && this.button3TableLayout1.Name == "button3TableLayout1")
			{
				this.button2TableLayout1.Image = Properties.Resources.Podloga;
				this.button2TableLayout1.Name = "button2TableLayout1";

			}
		}

		private void button3TableLayout1_Click_1(object sender, EventArgs e)
		{
			if (this.button1CheckBox1.Name != "Cekirano" && this.button4TableLayout1.Name == "button4TableLayout1")
			{
				this.button3TableLayout1.Image = Properties.Resources.Podloga;
				this.button3TableLayout1.Name = "button3TableLayout1";

			}
		}

		private void button4TableLayout1_Click_1(object sender, EventArgs e)
		{
			if (this.button1CheckBox1.Name != "Cekirano" && this.button3TableLayout1.Name != "button3TableLayut1" )
			{
				this.button4TableLayout1.Image = Properties.Resources.Podloga;
				this.button4TableLayout1.Name = "button4TableLayout1";

			}
		}
		
		//Second table.
		private void button1TableLayout2_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox2.Name != "Cekirano" && this.button2TableLayout2.Name == "button2TableLayout2")
			{
				this.button1TableLayout2.Image = Properties.Resources.Podloga;
				this.button1TableLayout2.Name = "button1TableLayout2";

			}
		}

		private void button2TableLayout2_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox2.Name != "Cekirano" && this.button3TableLayout2.Name == "button3TableLayout2")
			{
				this.button2TableLayout2.Image = Properties.Resources.Podloga;
				this.button2TableLayout2.Name = "button2TableLayout2";

			}
		}

		private void button3TableLayout2_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox2.Name != "Cekirano" && this.button4TableLayout2.Name == "button4TableLayout2")
			{
				this.button3TableLayout2.Image = Properties.Resources.Podloga;
				this.button3TableLayout2.Name = "button3TableLayout2";

			}
		}

		private void button4TableLayout2_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox2.Name != "Cekirano" && this.button3TableLayout2.Name != "button3TableLayut2")
			{
				this.button4TableLayout2.Image = Properties.Resources.Podloga;
				this.button4TableLayout2.Name = "button4TableLayout2";

			}
		}

		//Third table.
		private void button1TableLayout3_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox3.Name != "Cekirano" && this.button2TableLayout3.Name == "button2TableLayout3")
			{
				this.button1TableLayout3.Image = Properties.Resources.Podloga;
				this.button1TableLayout3.Name = "button1TableLayout3";

			}
		}

		private void button2TableLayout3_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox3.Name != "Cekirano" && this.button3TableLayout3.Name == "button3TableLayout3")
			{
				this.button2TableLayout3.Image = Properties.Resources.Podloga;
				this.button2TableLayout3.Name = "button2TableLayout3";

			}
		}

		private void button3TableLayout3_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox3.Name != "Cekirano" && this.button4TableLayout3.Name == "button4TableLayout3")
			{
				this.button3TableLayout3.Image = Properties.Resources.Podloga;
				this.button3TableLayout3.Name = "button3TableLayout3";

			}
		}

		private void button4TableLayout3_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox3.Name != "Cekirano" && this.button3TableLayout3.Name != "button3TableLayut3")
			{
				this.button4TableLayout3.Image = Properties.Resources.Podloga;
				this.button4TableLayout3.Name = "button4TableLayout3";

			}
		}

		//Fourth table.
		private void button1TableLayout4_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox4.Name != "Cekirano" && this.button2TableLayout4.Name == "button2TableLayout4")
			{
				this.button1TableLayout4.Image = Properties.Resources.Podloga;
				this.button1TableLayout4.Name = "button1TableLayout4";

			}
		}

		private void button2TableLayout4_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox4.Name != "Cekirano" && this.button3TableLayout4.Name == "button3TableLayout4")
			{
				this.button2TableLayout4.Image = Properties.Resources.Podloga;
				this.button2TableLayout4.Name = "button2TableLayout4";

			}
		}

		private void button3TableLayout4_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox4.Name != "Cekirano" && this.button4TableLayout4.Name == "button4TableLayout4")
			{
				this.button3TableLayout4.Image = Properties.Resources.Podloga;
				this.button3TableLayout4.Name = "button3TableLayout4";

			}
		}

		private void button4TableLayout4_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox4.Name != "Cekirano" && this.button3TableLayout4.Name != "button3TableLayut4")
			{
				this.button4TableLayout4.Image = Properties.Resources.Podloga;
				this.button4TableLayout4.Name = "button4TableLayout4";

			}
		}

		//Fifth table.
		private void button1TableLayout5_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox5.Name != "Cekirano" && this.button2TableLayout5.Name == "button2TableLayout5")
			{
				this.button1TableLayout5.Image = Properties.Resources.Podloga;
				this.button1TableLayout5.Name = "button1TableLayout5";

			}
		}

		private void button2TableLayout5_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox5.Name != "Cekirano" && this.button3TableLayout5.Name == "button3TableLayout5")
			{
				this.button2TableLayout5.Image = Properties.Resources.Podloga;
				this.button2TableLayout5.Name = "button2TableLayout5";

			}
		}

		private void button3TableLayout5_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox5.Name != "Cekirano" && this.button4TableLayout5.Name == "button4TableLayout5")
			{
				this.button3TableLayout5.Image = Properties.Resources.Podloga;
				this.button3TableLayout5.Name = "button3TableLayout5";

			}
		}

		private void button4TableLayout5_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox5.Name != "Cekirano" && this.button3TableLayout5.Name != "button3TableLayut5")
			{
				this.button4TableLayout5.Image = Properties.Resources.Podloga;
				this.button4TableLayout5.Name = "button4TableLayout5";

			}
		}

		//Sixth table.
		private void button1TableLayout6_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox6.Name != "Cekirano" && this.button2TableLayout6.Name == "button2TableLayout6")
			{
				this.button1TableLayout6.Image = Properties.Resources.Podloga;
				this.button1TableLayout6.Name = "button1TableLayout6";

			}
		}

		private void button2TableLayout6_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox6.Name != "Cekirano" && this.button3TableLayout6.Name == "button3TableLayout6")
			{
				this.button2TableLayout6.Image = Properties.Resources.Podloga;
				this.button2TableLayout6.Name = "button2TableLayout6";

			}
		}

		private void button3TableLayout6_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox6.Name != "Cekirano" && this.button4TableLayout6.Name == "button4TableLayout6")
			{
				this.button3TableLayout6.Image = Properties.Resources.Podloga;
				this.button3TableLayout6.Name = "button3TableLayout6";

			}
		}

		private void button4TableLayout6_Click(object sender, EventArgs e)
		{
			if (this.button1CheckBox6.Name != "Cekirano" && this.button3TableLayout6.Name != "button3TableLayut6")
			{
				this.button4TableLayout6.Image = Properties.Resources.Podloga;
				this.button4TableLayout6.Name = "button4TableLayout6";

			}
		}
	} 
}
