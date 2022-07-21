using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pin
    {
        public string field { get; set; } // e.g A8

        protected string color { get; set; }// color of game piece on bord

        protected bool movesUp { get; set; } //checks if the pin moves up on gameboard

        public bool hasMoved { get; set; } //check if pin has moved

        public int id { get; }

        protected string name; // pi - for pin

        //public Hashtable Mapping = new Hashtable(); //Gives number to each letters


        //public static IDictionary<string, int> Mapping = new Dictionary<string, int>();

        public Pin(string field, int id,string color)
        {
            

            this.field = field;

            this.id = id;

            this.color = color; //intialising color on board

            this.name =(this.GetType().Name).Substring(0,2); //name on gameboard, first 2 characters of class

            this.hasMoved = false; //has not moved by default

            Game_Board.Occupied_Fields.Add(field, id); // adds the field number and the id of the game pin asscoiated with it

            //int[] Array = (int[])Game_Board.Reference_Fields[field];

            int i = 17 - 2 * (field[1]-'0'); int j = 4 * Game_Board.Mapping[field[0].ToString()] - 2; //for use in gameboard array

            //Console.WriteLine(i); Console.WriteLine(j);

            Game_Board.board[i][j] = this.name; // intialising the pin on the game board

            Game_Board.colors[i][j] = this.color;

            if (String.Equals("White", this.color))
            {

                this.movesUp = false;

            }

            else
            {

                this.movesUp = true;

            }
        }


        protected int[] Origin_And_Destination(string destination) //returns coordinates of pin location and destination
        {
            int[] coordinates = new int[4]; 

            coordinates[0] = Game_Board.Mapping[this.field[0].ToString()]; //x - coordinate of piece

            coordinates[1] = (this.field[1]-'0'); //y - coordinate of pice

            coordinates[2] = Game_Board.Mapping[destination[0].ToString()] - coordinates[0]; //x distance

            coordinates[3] = (destination[1]-'0') - coordinates[1]; // y distance

            return coordinates;

        }
        protected string Assembler(int x_coordinate,int y_coordinate, int x_move, int y_move) //returns board field shifted by x and y from current field
        {
            string Letter="NA"; //intalising field as not applicable
            switch(x_coordinate + x_move)
                { case 1:Letter = "A";
                    break;
                  case 2:Letter = "B";
                    break;
                  case 3:Letter = "C";
                    break;
                  case 4:Letter = "D";
                    break;
                  case 5:Letter = "E";
                    break;
                  case 6:Letter = "F";
                    break;
                  case 7:Letter = "G";
                    break;
                  case 8:Letter = "H";
                    break;
              
            }

            if (!Letter.Equals("NA"))
            {
                if(y_coordinate+y_move<=8 & y_coordinate + y_move>=1) //if on the board
                { 
                    int y = y_coordinate + y_move;

                    Letter = Letter + y.ToString();

                }
                else
                {
                    Letter = "NA";
                }
               
                
            }
         
            return Letter;

        }

        protected bool Enemy(string destination,string field) //checks if move to field can be completed, as enemy is standing there.
        {

            if (this.id % 2 == Game_Board.Occupied_Fields[destination] % 2) //whites have odd ids, blacks even
            {
                
                    return false;
            }
            else 
            {
                    
                    return true; 
                
             }
         }
            

        

        protected int Sign(Boolean movesUp)
        {

            if (movesUp)
            {

                int sign = 1; //postive sign

                return sign;

            }
            else
            {

                int sign = -1; //negative sign

                return sign;

            }

        }

        public virtual Boolean Can_Move(string destination) //can the pin move to destination field on gameboard received from user
        {

            int[] coordinates = new int[4];

            Origin_And_Destination(destination).CopyTo(coordinates,0); //populating coordinates array

            int sign = Sign(movesUp); // get's the sign depending if moves up or down

            

                if (coordinates[3] == 1*sign & coordinates[2]==0 & Game_Board.Occupied_Fields.ContainsKey(destination) == false) //if moves by 1 up , checks the field is empty
                {

                    return true;

                }
                else if (coordinates[3] == 2*sign & coordinates[2] == 0 & Game_Board.Occupied_Fields.ContainsKey(destination) == false & Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1],0,1*sign)) == false & hasMoved==false) //checks if field above and the field above it are empty, also checks if the pin left it's starting postion already
                {

                    return true;

                }
                else if (coordinates[3] == 1*sign & Math.Abs(coordinates[2])==1 & Game_Board.Occupied_Fields.ContainsKey(destination) == true) //checks if there is an enemy piece in the field above to the left or right, if so move is possible
                {

                    if(Enemy(destination, this.field) == true)

                    {

                    return true;

                    }

                    else 

                    {

                    return false; //field is occupied, put the piece, is a friendly piece, so can not move that field

                    }

                }
                else 
                { 
                    
                    return false; 
                
                }

                
            

        }

        public virtual Boolean Can_Check(string destination) //can check the king if the king were to be on this field next turn
        {

            int[] coordinates = new int[4];

            Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array

            int sign = Sign(movesUp); // get's the sign depending if moves up or down



            if (coordinates[3] == 1 * sign & Math.Abs(coordinates[2]) == 1) //checks if there is an enemy piece in the field above to the left or right, if so move is possible
            {
                
                    return true;

            }
            else
            {

                return false;

            }




        }

        public void Move(string destination)
        {

            if (Can_Move(destination))
                {

                Game_Board.Occupied_Fields.Remove(this.field); //removes current filed from occupied fields as the pawn leaves the space

                int i = (this.field[1] - '0');

                int j = Game_Board.Mapping[this.field[0].ToString()];

                Game_Board.board[17 - 2 * i][4 * j- 2] = this.field; //updating the board, the field now becomes empty

                Game_Board.colors[17 - 2 * i][4 * j - 2] = "DarkBlue"; //updating  color of empty field to gameboard color

                if (Game_Board.Occupied_Fields.ContainsKey(destination) == true) //If there was a game piece already on the board in the spot moved to, this piece is removed.
                {
                    Program.Match.Remove(Game_Board.Occupied_Fields[destination]); //removes the piece from match dictionary

                    Game_Board.Occupied_Fields.Remove(destination); //removes it from occupied fields dictionary

                    //sets field of the removed pawn to 'NA' not applicable. Needs a collection of all object names and their ids

                }

                Game_Board.Occupied_Fields.Add(destination, id); //the spot moved is now refernced in occupied fields.

                this.field = destination; //updates the information inside pawn that this field is occupied

                i = (destination[1] - '0'); //converting to int

                j = Game_Board.Mapping[destination[0].ToString()];

                Game_Board.board[17 - 2 * i][4 * j - 2] = this.name; //updating the board, the new gameboard field now contains the pin

                Game_Board.colors[17 - 2 * i][4 * j - 2] = this.color; //updating  color of the new occupied field to color of the game piece 

                this.hasMoved = true; //has moved from base position and can no longer move by 2
            }
            

            
        }

    }

}



