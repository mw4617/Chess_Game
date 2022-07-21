using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Knight :Pin
    {

        public Knight(string field, int id, string color) : base(field,id,color)
        {



        }

        public override Boolean Can_Move(string destination) //destination field on gameboard received from user
        {

            int[] coordinates = new int[4];

            Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array

  



            if (coordinates[3] == 2  & coordinates[2] == 1 & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination,field)==true)) //can move if empty field or enemy, goes 1 right and 2 up
            {

                return true;

            }
            else if (coordinates[3] == 2 & coordinates[2] == -1 & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true))
            {

                return true;

            }
            else if (coordinates[3] == -2 & coordinates[2] == -1 & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true)) 
            {

                return true;

            }
            else if (coordinates[3] == -2 & coordinates[2] == 1 & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true))
            {

                return true;

            }
            else if (coordinates[3] == 1 & coordinates[2] == 2 & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true))
            {

                return true;

            }
            else if (coordinates[3] == 1 & coordinates[2] == -2 & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true))
            {

                return true;

            }
            else if (coordinates[3] == -1 & coordinates[2] == -2 & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true))
            {

                return true;

            }
            else if (coordinates[3] == -1 & coordinates[2] == 2 & (Game_Board.Occupied_Fields.ContainsKey(destination) == false || Enemy(destination, field) == true))
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





            if (coordinates[3] == 2 & coordinates[2] == 1) //can move if empty field or enemy, goes 1 right and 2 up
            {

                return true;

            }
            else if (coordinates[3] == 2 & coordinates[2] == -1)
            {

                return true;

            }
            else if (coordinates[3] == -2 & coordinates[2] == -1)
            {

                return true;

            }
            else if (coordinates[3] == -2 & coordinates[2] == 1)
            {

                return true;

            }
            else if (coordinates[3] == 1 & coordinates[2] == 2)
            {

                return true;

            }
            else if (coordinates[3] == 1 & coordinates[2] == -2)
            {

                return true;

            }
            else if (coordinates[3] == -1 & coordinates[2] == -2)
            {

                return true;

            }
            else if (coordinates[3] == -1 & coordinates[2] == 2)
            {

                return true;

            }
            else
            {

                return false;

            }




        }

        //public override Boolean Can_Check(string destination) //can check a if king where to stand on this field
        //{

        //    int[] coordinates = new int[4];

        //    Origin_And_Destination(destination).CopyTo(coordinates, 0); //populating coordinates array





        //    if (coordinates[3] == 2 & coordinates[2] == 1 ) 
        //    {

        //        return true;

        //    }
        //    else if (coordinates[3] == 2 & coordinates[2] == -1 )
        //    {

        //        return true;

        //    }
        //    else if (coordinates[3] == -2 & coordinates[2] == -1 )
        //    {

        //        return true;

        //    }
        //    else if (coordinates[3] == -2 & coordinates[2] == 1 )
        //    {

        //        return true;

        //    }
        //    else if (coordinates[3] == 1 & coordinates[2] == 2 )
        //    {

        //        return true;

        //    }
        //    else if (coordinates[3] == 1 & coordinates[2] == -2 )
        //    {

        //        return true;

        //    }
        //    else if (coordinates[3] == -1 & coordinates[2] == -2 )
        //    {

        //        return true;

        //    }
        //    else if (coordinates[3] == -1 & coordinates[2] == 2 )
        //    {

        //        return true;

        //    }
        //    else
        //    {

        //        return false;

        //    }




        //}
    }
}
