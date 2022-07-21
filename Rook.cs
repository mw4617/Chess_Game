using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Rook : Bishop
    {

        public Rook(string field, int id, string color) : base(field, id, color)
        {

        }

        public override Boolean Can_Move(string destination)
        {

            int[] coordinates = new int[4];

            Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array

            if ((Math.Abs(coordinates[3]) > 0 & coordinates[2] == 0) & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true) & Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves to horizontally only
            {

                return true;

            }
            else if ((Math.Abs(coordinates[2]) > 0 & coordinates[3] == 0) & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true) & Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves vericially only
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public override Boolean Can_Check(string destination) //can check the king if the king were to be on this field next turn
        {

            int[] coordinates = new int[4];

            Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array

            if ((Math.Abs(coordinates[3]) > 0 & coordinates[2] == 0) & Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves to horizontally only
            {

                return true;

            }
            else if ((Math.Abs(coordinates[2]) > 0 & coordinates[3] == 0) & Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves vericially only
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public void Castling_Move(string destination) //rook makes castling move
        {

            
                Game_Board.Occupied_Fields.Remove(this.field); //removes current filed from occupied fields as the rook leaves the space

                int i = (this.field[1] - '0');

                int j = Game_Board.Mapping[this.field[0].ToString()];

                Game_Board.board[17 - 2 * i][4 * j - 2] = this.field; //updating the board, the field now becomes empty

                Game_Board.colors[17 - 2 * i][4 * j - 2] = "DarkBlue"; //updating  color of empty field to gameboard color


                Game_Board.Occupied_Fields.Add(destination, id); //the spot moved is now refernced in occupied fields.

                this.field = destination; //updates the information inside pawn that this field is occupied

                i = (destination[1] - '0'); //converting to int

                j = Game_Board.Mapping[destination[0].ToString()];

                Game_Board.board[17 - 2 * i][4 * j - 2] = this.name; //updating the board, the new gameboard field now contains the rook

                Game_Board.colors[17 - 2 * i][4 * j - 2] = this.color; //updating  color of the new occupied field to color of the game piece 

                this.hasMoved = true; //has moved becomes
            



        }

    }
}
