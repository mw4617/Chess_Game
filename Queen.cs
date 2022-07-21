using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : Bishop
    {

        public Queen(string field, int id, string color) : base(field, id, color)
        {


        }
        public override Boolean Can_Move(string destination)
        {

            int[] coordinates = new int[4];

            Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array

            if (Math.Abs(coordinates[3]) == Math.Abs(coordinates[2]) & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true) & Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves diagonally only
            {

                return true;

            }
            else if ((Math.Abs(coordinates[3]) > 0 & coordinates[2] == 0) & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true) & Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves to horizontally 
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

            if (Math.Abs(coordinates[3]) == Math.Abs(coordinates[2]) & Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves diagonally only
            {

                return true;

            }
            else if ((Math.Abs(coordinates[3]) > 0 & coordinates[2] == 0) &  Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves to horizontally 
            {

                return true;

            }
            else if ((Math.Abs(coordinates[2]) > 0 & coordinates[3] == 0) &  Empty_Straight_Line(coordinates) == true) //can move if empty field or enemy and if all fields in the way are empty, moves vericially only
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
