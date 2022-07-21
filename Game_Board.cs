using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	class Game_Board
	{


		public static string[][] board = new string[17][];

		public static string[][] colors = new string[17][]; //defines color of each element on the gameboard

		public void Create_WireFrame()
		{
			//string[] temp1 = new string[33];
			//string[] temp2 = new string[33];

			for (int i = 0; i < 15; i = i + 2)
			{


				//for (int j=0;j<=32;j++)
				// {
				//  if (j % 4 == 0)
				//  {
				//temp1[j] = "|";

				// temp2[j] = "|";
				//  }
				// else if ((j + 1) % 4 == 1 || (j + 1) % 4 == 2)
				//  {

				// temp1[j] = "-";

				// temp2[j] = " ";

				// }
				//  else
				//  {

				// temp1[j] = "-";

				//  temp2[j] = " ";

				// }
				//  }

				// board[i] = temp1;

				// board[i+1] = temp2;
				board[i] = new string[] { "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|" };

				board[i + 1] = new string[] { "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|" };

			}
			// board[16] = temp1;
			board[16] = new string[] { "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|", "-", "-", "--", "|" };


		}

		public void Intalise_Colors() //Intialising Display Colors Of Gameboard Elements
        {

			for (int i = 0; i < 17; i++)
            {
				colors[i]= new string[]{ "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " ", "|" };
				
				for (int j = 0; j < 33; j++)
				{
					colors[i][j] = "DarkBlue";
                }

			}

        }

		private static int i_max;

		private static int j_max;


		private void GetDimensions()
		{

			i_max = board.Length;

			j_max = board[0].Length;

		}


		private static Queue<string> Letters = new Queue<string>();

		private static Queue<string> Numbers = new Queue<string>();

		private static Queue<string> Fields = new Queue<string>();

		public static List<string> gameBoardFields = new List<string>();

		public static Hashtable Reference_Fields = new Hashtable(); //Maps Letters to numbers

		public static IDictionary<string, int> Mapping = new Dictionary<string, int>();

		public static IDictionary<string, int> Occupied_Fields = new Dictionary<string, int>();

		public static Queen[] Pin_Queens = new Queen[16];  //array containing queens made from pins

		public static int Queens_Added=0;

		public static IDictionary<int, int> Queen_ID_Postion = new Dictionary<int, int>(); //stores the id of pin versus index in the Pin_Queens array

		private int[] xy = new int[3]; //Stores xy corridates of field reference e.g. A8 to be added to the hashtable

		public void Create_Game_Board()
		{
			GetDimensions();

			Letters.Enqueue("A"); Numbers.Enqueue("1"); 
			Letters.Enqueue("B"); Numbers.Enqueue("2"); 
			Letters.Enqueue("C"); Numbers.Enqueue("3"); 
			Letters.Enqueue("D"); Numbers.Enqueue("4"); 
			Letters.Enqueue("E"); Numbers.Enqueue("5");
			Letters.Enqueue("F"); Numbers.Enqueue("6"); 
			Letters.Enqueue("G"); Numbers.Enqueue("7"); 
			Letters.Enqueue("H"); Numbers.Enqueue("8");

			Mapping.Add("A", 1); Mapping.Add("B", 2);
            Mapping.Add("C", 3); Mapping.Add("D", 4);
			Mapping.Add("E", 5); Mapping.Add("F", 6);
			Mapping.Add("G", 7); Mapping.Add("H", 8);


			string i_temp;

			string j_temp;

			for (int i = 1; i <= 8; i++)
			{
				i_temp = Numbers.Dequeue();

				for (int j = 1; j <= 8; j++)
				{

					j_temp = Letters.Dequeue();

					Fields.Enqueue(j_temp + i_temp);

					Letters.Enqueue(j_temp);


					
				}
			}

			for (int i = i_max; i >= 1; i--)
			{

				for (int j = 1; j <= j_max; j++)
				{

					if ((j - 3) % 4 == 0 && (i) % 2 == 0)

					{

						board[i - 1][j - 1] = Fields.Dequeue();

						gameBoardFields.Add(board[i - 1][j - 1]);

						xy[0] = i;

						xy[1] = j;

						xy[2] = 0; // ID of game pin,set to zero as na game pin at the point

						Reference_Fields.Add(board[i - 1][j - 1],xy); //creates dictionsary that stores field references and the coordinates on the game board of that ref

					   

					}

				}

			}

		}

	   public void displayGameBoard()
		{

			for (int i = 1; i <= i_max; i++)
			{

				for (int j = 1; j <= j_max; j++)
				{
                    switch (colors[i-1][j-1]) //setting color to correct color
					{ case "DarkBlue": Console.ForegroundColor = ConsoleColor.DarkBlue;
							break;
					  case "White":
							Console.ForegroundColor = ConsoleColor.White;
							break;
				      case "Black":
							Console.ForegroundColor = ConsoleColor.Black;
							break;
					}

					

					Console.Write(board[i - 1][j - 1]);
					
				}

				Console.WriteLine("");

			}

			

		}



	}
}
