using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King :Pin
    {
        public bool Castling { get; set; } //is castling move happening

        public string Tower_Field { get; set; } //if castling occurs, the field the tower would be on after castling

        public int Castling_Id { get; set; } //if castling occurs, the id of tower involved in castling
        public King(string field, int id, string color) : base(field, id, color)
        {

        }

        public override Boolean Can_Move(string destination) //destination field on gameboard received from user
        {

            int[] coordinates = new int[4];

            Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array



            if ((coordinates[3] == 0 & coordinates[2] == 0))
            {
                this.Castling = false; //not a castling move

                return false; //cannot do an empty move

            }
            else if ((Math.Abs(coordinates[3]) <= 1 & Math.Abs(coordinates[2]) <= 1) & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true)) //checks if there is an empty space, or enemy, can move only 1 in any direction
            {
                this.Castling = false; //not a castling move

                return true;

            }
            else if (this.color.Equals("White") & (destination.Equals("G8") || destination.Equals("C8")) & hasMoved == false) //white castling move
            {

                if (destination.Equals("G8") & Game_Board.Occupied_Fields.ContainsKey("F8") == false & Game_Board.Occupied_Fields.ContainsKey("G8") == false)
                {
                    this.Castling = true; //a castling move

                    this.Castling_Id = 27; //id of the rook

                    this.Tower_Field = "F8"; //the field the tower is on after castling

                    return true;

                }
                else if (destination.Equals("C8") & Game_Board.Occupied_Fields.ContainsKey("D8") == false & Game_Board.Occupied_Fields.ContainsKey("C8") == false & Game_Board.Occupied_Fields.ContainsKey("B8") == false)
                {

                    this.Castling = true; //a castling move

                    this.Castling_Id = 25; //id of the rook

                    this.Tower_Field = "D8"; //the field the tower is on after castling

                    return true;

                }

                return false;

            }
            else if (this.color.Equals("Black") & (destination.Equals("G1") || destination.Equals("C1")) & hasMoved == false) //black castling move
            {

                if (destination.Equals("G1") & Game_Board.Occupied_Fields.ContainsKey("F1") == false & Game_Board.Occupied_Fields.ContainsKey("G1") == false)
                {
                    this.Castling = true; //a castling move

                    this.Castling_Id = 28; //id of the rook

                    this.Tower_Field = "F1"; //the field the tower is on after castling

                    return true;

                }
                else if (destination.Equals("C1") & Game_Board.Occupied_Fields.ContainsKey("D1") == false & Game_Board.Occupied_Fields.ContainsKey("C1") == false & Game_Board.Occupied_Fields.ContainsKey("B1") == false)
                {
                    this.Castling = true; //a castling move

                    this.Castling_Id = 26;//id of the rook

                    this.Tower_Field = "D1"; //the field the tower is on after castling

                    return true;

                }

                return false;

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



            if ((coordinates[3] == 0 & coordinates[2] == 0))
            {

                return false; //cannot do an empty move

            }
            else if ((Math.Abs(coordinates[3]) <= 1 & Math.Abs(coordinates[2]) <= 1)) //checks if there is an empty space, or enemy, can move only 1 in any direction
            {

                return true;

            }
            else
            {

                return false;

            }




        }

        public string[] Escape_Fields() //List the fields around the king on the gameboard, including the field king is on (the king can not move to field he is already on, anyway)
        {
          
            
            string[] Fields = new string[9];

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int x_coordinate=0;
                    switch (this.field[0])
                    {
                        case 'A':
                            x_coordinate = 1;
                            break;
                        case 'B':
                            x_coordinate = 2;
                            break;
                        case 'C':
                            x_coordinate = 3;
                            break;
                        case 'D':
                            x_coordinate = 4;
                            break;
                        case 'E':
                            x_coordinate = 5;
                            break;
                        case 'F':
                            x_coordinate = 6;
                            break;
                        case 'G':
                            x_coordinate = 7;
                            break;
                        case 'H':
                            x_coordinate = 8;
                            break;

                    }

                    Fields[(j + 2) * 3 + i - 2] = Assembler(x_coordinate,(this.field[1]-'0'), i, j);
                }
            }

            
               return Fields;
            
            

        }

        //Returns 

    }


}
