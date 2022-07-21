using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop : Pin
    {
        public Bishop(string field, int id, string color) : base(field, id, color)
        {


        }
        protected Boolean Empty_Straight_Line(int[] coordinates) //checks if there is any game  piece on the fields between the orign and destination, this does not include origin and destination fields
        {

           // Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array

            if (Math.Abs(coordinates[2])==1 || Math.Abs(coordinates[3])== 1) //if moving by one there is no problem of other piece standing in the way
            {
                return true;
            }
            else if(Math.Abs(coordinates[2]) == 2 || Math.Abs(coordinates[3]) == 2)
            {

                
                    if(Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]/2, coordinates[3] / 2)))
                {

                    return false;

                }
                else
                {
                    return true;
                }

            }
            else if (Math.Abs(coordinates[2]) == 3 || Math.Abs(coordinates[3]) == 3)
            {


                if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]/3, coordinates[3]/3)))
                {

                    return false;

                }
                else if(Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*2/3, coordinates[3]*2/3)))
                {

                    return false;

                }
                else
                {
                    return true;
                }

            }
            else if (Math.Abs(coordinates[2]) == 4 || Math.Abs(coordinates[3]) == 4)
            {


                if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]/4, coordinates[3]/4)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*2/4, coordinates[3]*2/4)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*3/4, coordinates[3]*3/4)))
                {

                    return false;

                }
                else
                {
                    return true;
                }

            }
            else if (Math.Abs(coordinates[2]) == 5 || Math.Abs(coordinates[3]) == 5)
            {


                if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]/5, coordinates[3]/5)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*2/5, coordinates[3]*2/5)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*3/5, coordinates[3]*3/5)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*4/5, coordinates[3]*4/5)))
                {

                    return false;

                }
                else
                {
                    return true;
                }

            }
            else if (Math.Abs(coordinates[2]) == 6 || Math.Abs(coordinates[3]) == 6)
            {


                if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]/6, coordinates[3]/6)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*2/6, coordinates[3]*2/6)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*3/6, coordinates[3]*3/6)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*4/6, coordinates[3]*4/6)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*5/6, coordinates[3]*5/6)))
                {

                    return false;

                }
                else
                {
                    return true;
                }

            }
            else if (Math.Abs(coordinates[2]) == 7 || Math.Abs(coordinates[3]) == 7)
            {


                if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]/7, coordinates[3]/7)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*2/7, coordinates[3]*2/7)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*3/7, coordinates[3]*3/7)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*4/7, coordinates[3]*4/7)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*5/7, coordinates[3]*5/7)))
                {

                    return false;

                }
                else if (Game_Board.Occupied_Fields.ContainsKey(Assembler(coordinates[0], coordinates[1], coordinates[2]*6/7, coordinates[3]*6/7)))
                {

                    return false;

                }
                else
                {
                    return true;
                }

            }
            else
            {

                return false; //moves by at least 8,so moves off the gameboard, so invalid move

            }

        }


        public override Boolean Can_Move(string destination)
        {

            int[] coordinates = new int[4];

            Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array

            if (Math.Abs(coordinates[3]) == Math.Abs(coordinates[2]) & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true) & Empty_Straight_Line(coordinates)==true) //can move if empty field or enemy and if all fields in the way are empty, moves diagonally only
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

            if (Math.Abs(coordinates[3]) == Math.Abs(coordinates[2])  & Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves diagonally only
            {

                return true;

            }
            else
            {

                return false;

            }

        }
    }
}
