using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *	@author Bosko Gogic
 *	@version .net core 6.0
 *	
 *	Class KvizSkocko which represents one of the games ("Skocko") from TV Show "Slagalica" RTS, Serbia.
 *	In this class contain all bussiness logic for named game.
 * 
 */	
namespace KvizSkocko
{
	class BusinessLogic
	{
		Random randomNumberGenerator = new Random();
		private int[] finalCombination = new int[4];

		public BusinessLogic()
		{
			this.randomiseFinalCombination();
		}
		/*
		 *	Method randomiseNumbers for randomising finalCombination
		 *	each time you want to play new game.
		 */
		public void randomiseFinalCombination()
		{
			finalCombination[0] = randomNumberGenerator.Next(1, 7);//bigger or equal to 1, less than 7
			finalCombination[1] = randomNumberGenerator.Next(1, 7);
			finalCombination[2] = randomNumberGenerator.Next(1, 7);
			finalCombination[3] = randomNumberGenerator.Next(1, 7);
		}

		public int returnSingleArrayValue(int index)
		{
			return finalCombination[index];
		}

		/*
		*	Method checkRowCombination for checking does the combination
		*	in one row are equal to finalCombination. If it is equal, 
		*	
		*	@param combination - combination of characters which is 
		*	choosen by user.
		*
		*/
		public int[] checkRowCombination(int[] combination)
		{
			//1 = equal 
			//2 = equal but wrong place
			//3 = not equal
			//MessageBox.Show("Kombinacija je: " + finalCombination[0] + " " + finalCombination[1] + " " + finalCombination[2] + " " + finalCombination[3]);

			//int[] finalCombination = new int[4];

			int i = 0;
			int j = 0;
			int[] equality = new int[20];
			int equalityCounter = 0;
			bool flag = true;
			int[] rememberCombination = new int[4];
			int[] rememberFinalCombination = new int[4];

			for (int z = 0; z < 20; z++)
			{
				equality[z] = 20;
			}
				/*finalCombination[0] = 2;
				finalCombination[1] = 3;
				finalCombination[2] = 3;
				finalCombination[3] = 2;

				combination[0] = 1;
				combination[1] = 2;
				combination[2] = 1;
				combination[3] = 1;*/

				int temporary = 10;

				int positionCombination = 0;
				int positionFinal = 0;

			for (int k = 0; k < 4; k++)
			{
				rememberFinalCombination[k] = finalCombination[k];
				
				rememberCombination[k] = combination[k];
			}

				//prva petlja za jednaka mjesta
				while (i < 4 && j < 4)
				{

					if (combination[i] == finalCombination[j])
					{
						Console.WriteLine("While prvi Prvi IF");
						equality[equalityCounter++] = 1;
						combination[i] = temporary++;
						finalCombination[j] = temporary + 10;
					temporary *= 10;
						positionCombination = i;
					}

					i++;
					j++;

				}
				//druga petlja za razlicita mjesta
				Console.WriteLine("Nizovi su: " + combination[0] + " " + combination[1] + " " + combination[2] + " " + combination[3]);
				Console.WriteLine("Nizovi su: " + finalCombination[0] + " " + finalCombination[1] + " " + finalCombination[2] + " " + finalCombination[3]);

				i = 0;
				j = 0;

				while (i < 4)
				{
					while (j < 4 && flag == true)
					{
						if (combination[i] == finalCombination[j])
						{
							Console.WriteLine("While drugi Prvi IF");

							equality[equalityCounter++] = 2;

							flag = false;
							finalCombination[j] = temporary + 20;
						temporary *= 10;
						}
						j++;
					}

					Console.WriteLine("While treci Prvi IF");


					if (flag == true)
					{
						equality[equalityCounter++] = 3;
					}
					j = 0;
					flag = true;
					i++;
				}

			int[] finalEquality = new int[4];
			Array.Sort(equality);
			finalEquality[0] = equality[0];
			finalEquality[1] = equality[1];
			finalEquality[2] = equality[2];
			finalEquality[3] = equality[3];

			for (int k = 0; k < 4; k++)
			{
				finalCombination[k] = rememberFinalCombination[k];
				combination[k] = rememberCombination[k];
			}
			Array.Sort(finalEquality);
			return finalEquality;
				
			}

	}

}
