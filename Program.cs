using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    class Program
    {


        public static IDictionary<int, object> Match = new Dictionary<int, object>(); //storing ids and objects


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.Clear();

            Game_Board item = new Game_Board();

            item.Create_WireFrame();

            item.Intalise_Colors();

            item.Create_Game_Board();

            Pin A7 = new Pin("A7", 1, "White"); Match.Add(1, A7);
            Pin B7 = new Pin("B7", 3, "White"); Match.Add(3, B7);
            Pin C7 = new Pin("C7", 5, "White"); Match.Add(5, C7);
            Pin D7 = new Pin("D7", 7, "White"); Match.Add(7, D7);
            Pin E7 = new Pin("E7", 9, "White"); Match.Add(9, E7);
            Pin F7 = new Pin("F7", 11, "White"); Match.Add(11, F7);
            Pin G7 = new Pin("G7", 13, "White"); Match.Add(13, G7);
            Pin H7 = new Pin("H7", 15, "White"); Match.Add(15, H7);
            Knight B8 = new Knight("B8", 17, "White"); Match.Add(17, B8);
            Knight G8 = new Knight("G8", 19, "White"); Match.Add(19, G8);
            Bishop C8 = new Bishop("C8", 21, "White"); Match.Add(21, C8);
            Bishop F8 = new Bishop("F8", 23, "White"); Match.Add(23, F8);
            Rook A8 = new Rook("A8", 25, "White"); Match.Add(25, A8);
            Rook H8 = new Rook("H8", 27, "White"); Match.Add(27, H8);
            Queen D8 = new Queen("D8", 29, "White"); Match.Add(29, D8);
            King E8 = new King("E8", 31, "White"); Match.Add(31, E8);
            Pin A2 = new Pin("A2", 2, "Black"); Match.Add(2, A2);
            Pin B2 = new Pin("B2", 4, "Black"); Match.Add(4, B2);
            Pin C2 = new Pin("C2", 6, "Black"); Match.Add(6, C2);
            Pin D2 = new Pin("D2", 8, "Black"); Match.Add(8, D2);
            Pin E2 = new Pin("E2", 10, "Black"); Match.Add(10, E2);
            Pin F2 = new Pin("F2", 12, "Black"); Match.Add(12, F2);
            Pin G2 = new Pin("G2", 14, "Black"); Match.Add(14, G2);
            Pin H2 = new Pin("H2", 16, "Black"); Match.Add(16, H2);
            Knight B1 = new Knight("B1", 18, "Black"); Match.Add(18, B1);
            Knight G1 = new Knight("G1", 20, "Black"); Match.Add(20, G1);
            Bishop C1 = new Bishop("C1", 22, "Black"); Match.Add(22, C1);
            Bishop F1 = new Bishop("F1", 24, "Black"); Match.Add(24, F1);
            Rook A1 = new Rook("A1", 26, "Black"); Match.Add(26, A1);
            Rook H1 = new Rook("H1", 28, "Black"); Match.Add(28, H1);
            Queen D1 = new Queen("D1", 30, "Black"); Match.Add(30, D1);
            King E1 = new King("E1", 32, "Black"); Match.Add(32, E1);

            //Test Case 1

            //King E8 = new King("A8", 31, "White"); Match.Add(31, E8);
            //Knight B8 = new Knight("A5", 17, "White"); Match.Add(17, B8);
            //Bishop F1 = new Bishop("C6", 24, "Black"); Match.Add(24, F1);
            //Bishop C1 = new Bishop("C5", 22, "Black"); Match.Add(22, C1);
            //King E1 = new King("E1", 32, "Black"); Match.Add(32, E1);
            //Pin F2 = new Pin("C7", 12, "Black"); Match.Add(12, F2);

            //Test Case 2

            //Bishop F8 = new Bishop("D5", 23, "White"); Match.Add(23, F8);
            //Knight B8 = new Knight("B4", 17, "White"); Match.Add(17, B8);
            //Rook A8 = new Rook("A1", 25, "White"); Match.Add(25, A8);
            //Rook H8 = new Rook("D4", 27, "White"); Match.Add(27, H8);
            //Pin B2 = new Pin("B2", 4, "Black"); Match.Add(4, B2);
            //Pin C2 = new Pin("C2", 6, "Black"); Match.Add(6, C2);
            //Knight B1 = new Knight("B1", 18, "Black"); Match.Add(18, B1);
            //King E8 = new King("E8", 31, "White"); Match.Add(31, E8);
            //King E1 = new King("C1", 32, "Black"); Match.Add(32, E1);

            //Test case 3 Castling move - can be completed


            //Pin A7 = new Pin("A7", 1, "White"); Match.Add(1, A7);
            //Pin B7 = new Pin("B7", 3, "White"); Match.Add(3, B7);
            //Pin C7 = new Pin("C7", 5, "White"); Match.Add(5, C7);
            //Pin D7 = new Pin("D7", 7, "White"); Match.Add(7, D7);
            //Pin E7 = new Pin("E7", 9, "White"); Match.Add(9, E7);
            //Pin F7 = new Pin("F7", 11, "White"); Match.Add(11, F7);
            //Pin G7 = new Pin("G7", 13, "White"); Match.Add(13, G7);
            //Pin H7 = new Pin("H7", 15, "White"); Match.Add(15, H7);
            //Rook A8 = new Rook("A8", 25, "White"); Match.Add(25, A8);
            //Rook H8 = new Rook("H8", 27, "White"); Match.Add(27, H8);
            //King E8 = new King("E8", 31, "White"); Match.Add(31, E8);
            //Pin A2 = new Pin("A2", 2, "Black"); Match.Add(2, A2);
            //Pin B2 = new Pin("B2", 4, "Black"); Match.Add(4, B2);
            //Pin C2 = new Pin("C2", 6, "Black"); Match.Add(6, C2);
            //Pin D2 = new Pin("D2", 8, "Black"); Match.Add(8, D2);
            //Pin E2 = new Pin("E2", 10, "Black"); Match.Add(10, E2);
            //Pin F2 = new Pin("F2", 12, "Black"); Match.Add(12, F2);
            //Pin G2 = new Pin("G2", 14, "Black"); Match.Add(14, G2);
            //Pin H2 = new Pin("H2", 16, "Black"); Match.Add(16, H2);
            //Knight B1 = new Knight("B1", 18, "Black"); Match.Add(18, B1);
            //Knight G1 = new Knight("G1", 20, "Black"); Match.Add(20, G1);
            //Bishop C1 = new Bishop("C1", 22, "Black"); Match.Add(22, C1);
            //Bishop F1 = new Bishop("F1", 24, "Black"); Match.Add(24, F1);
            //Rook A1 = new Rook("A1", 26, "Black"); Match.Add(26, A1);
            //Rook H1 = new Rook("H1", 28, "Black"); Match.Add(28, H1);
            //Queen D1 = new Queen("D1", 30, "Black"); Match.Add(30, D1);
            //King E1 = new King("E1", 32, "Black"); Match.Add(32, E1);

            //Test case 4 Castling - impossible pieces in the way

            //Pin A7 = new Pin("A7", 1, "White"); Match.Add(1, A7);
            //Pin B7 = new Pin("B7", 3, "White"); Match.Add(3, B7);
            //Pin C7 = new Pin("C7", 5, "White"); Match.Add(5, C7);
            //Pin D7 = new Pin("D7", 7, "White"); Match.Add(7, D7);
            //Pin E7 = new Pin("E7", 9, "White"); Match.Add(9, E7);
            //Pin F7 = new Pin("F7", 11, "White"); Match.Add(11, F7);
            //Pin G7 = new Pin("G7", 13, "White"); Match.Add(13, G7);
            //Pin H7 = new Pin("H7", 15, "White"); Match.Add(15, H7);
            //Knight B8 = new Knight("B8", 17, "White"); Match.Add(17, B8);
            //Bishop F8 = new Bishop("F8", 23, "White"); Match.Add(23, F8);
            //Rook A8 = new Rook("A8", 25, "White"); Match.Add(25, A8);
            //Rook H8 = new Rook("H8", 27, "White"); Match.Add(27, H8);
            //King E8 = new King("E8", 31, "White"); Match.Add(31, E8);
            //Pin A2 = new Pin("A2", 2, "Black"); Match.Add(2, A2);
            //Pin B2 = new Pin("B2", 4, "Black"); Match.Add(4, B2);
            //Pin C2 = new Pin("C2", 6, "Black"); Match.Add(6, C2);
            //Pin D2 = new Pin("D2", 8, "Black"); Match.Add(8, D2);
            //Pin E2 = new Pin("E2", 10, "Black"); Match.Add(10, E2);
            //Pin F2 = new Pin("F2", 12, "Black"); Match.Add(12, F2);
            //Pin G2 = new Pin("G2", 14, "Black"); Match.Add(14, G2);
            //Pin H2 = new Pin("H2", 16, "Black"); Match.Add(16, H2);
            //Knight B1 = new Knight("B1", 18, "Black"); Match.Add(18, B1);
            //Knight G1 = new Knight("G1", 20, "Black"); Match.Add(20, G1);
            //Bishop C1 = new Bishop("C1", 22, "Black"); Match.Add(22, C1);
            //Bishop F1 = new Bishop("F1", 24, "Black"); Match.Add(24, F1);
            //Rook A1 = new Rook("A1", 26, "Black"); Match.Add(26, A1);
            //Rook H1 = new Rook("H1", 28, "Black"); Match.Add(28, H1);
            //Queen D1 = new Queen("D1", 30, "Black"); Match.Add(30, D1);
            //King E1 = new King("E1", 32, "Black"); Match.Add(32, E1);

            //Test case 5 Castling - impossible enemy pieces attack the fields king passes through

            //Rook A8 = new Rook("A8", 25, "White"); Match.Add(25, A8);
            //Rook H8 = new Rook("H8", 27, "White"); Match.Add(27, H8);
            //King E8 = new King("E8", 31, "White"); Match.Add(31, E8);
            //Pin A2 = new Pin("A2", 2, "Black"); Match.Add(2, A2);
            //Pin B2 = new Pin("B7", 4, "Black"); Match.Add(4, B2);
            //Pin C2 = new Pin("C2", 6, "Black"); Match.Add(6, C2);
            //Pin D2 = new Pin("D2", 8, "Black"); Match.Add(8, D2);
            //Pin E2 = new Pin("E2", 10, "Black"); Match.Add(10, E2);
            //Pin F2 = new Pin("F2", 12, "Black"); Match.Add(12, F2);
            //Pin G2 = new Pin("G7", 14, "Black"); Match.Add(14, G2);
            //Pin H2 = new Pin("H2", 16, "Black"); Match.Add(16, H2);
            //Knight B1 = new Knight("B1", 18, "Black"); Match.Add(18, B1);
            //Knight G1 = new Knight("G1", 20, "Black"); Match.Add(20, G1);
            //Bishop C1 = new Bishop("C1", 22, "Black"); Match.Add(22, C1);
            //Bishop F1 = new Bishop("F1", 24, "Black"); Match.Add(24, F1);
            //Rook A1 = new Rook("A1", 26, "Black"); Match.Add(26, A1);
            //Rook H1 = new Rook("H1", 28, "Black"); Match.Add(28, H1);
            //Queen D1 = new Queen("D1", 30, "Black"); Match.Add(30, D1);
            //King E1 = new King("E1", 32, "Black"); Match.Add(32, E1);

            //Test Case 6 - stalemate

            //Pin A7 = new Pin("B2", 1, "White"); Match.Add(1, A7);
            //Rook A8 = new Rook("C8", 25, "White"); Match.Add(25, A8);
            //Rook H8 = new Rook("E1", 27, "White"); Match.Add(27, H8);
            //King E8 = new King("E6", 31, "White"); Match.Add(31, E8);
            //Pin E2 = new Pin("E5", 10, "Black"); Match.Add(10, E2);
            //King E1 = new King("D4", 32, "Black"); Match.Add(32, E1);


            Play(item); //play the game


        }

        static bool In(string[] elements,string element) //checks if given element is in an array
        {

            foreach(string item in elements)
            {

                if(item.Equals(element))
                {

                    return true;

                }

            }
            return false;

        }

        static void Play_1()
        {
            string selectField;

            string moveField;

            selectField = Program.selectField_1();

            int id;

            id=Game_Board.Occupied_Fields[selectField]; //id of piece being selected

            Console.WriteLine("To which field do you want to move player 1?");

            moveField = Console.ReadLine();
           
            if (id%2==0)
            {
             Console.WriteLine("Please select a white piece player one.");

                Play_1();

                return; //stopping excution of function

            }

            if (Game_Board.gameBoardFields.Contains(moveField)==false)
            {

                Console.WriteLine("Selected field is not a valid move field.");

                Play_1();

                return; //stopping excution of function

            }

            if(!White_Move_Possible(selectField,moveField)) //can the game piece leave the selectField and move to the moveField without this putting the king under check
            {

                Console.WriteLine("Can not move this game piece to this field.");

                Play_1();

                return; //stopping excution of function

            }
                if (id <= 16)
            {

                if (((Pin)(Match[id])).Can_Move(moveField)==true)
                {
                    ((Pin)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field.");

                    Play_1();

                    return; //stopping excution of function
                }

            }
            else if (id <= 20)
            {
                if (((Knight)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Knight)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_1();

                    return; //stopping excution of function
                }
                    
            }
            else if (id <= 24)
            {
                if (((Bishop)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Bishop)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_1();

                    return; //stopping excution of function
                }

            }
            else if (id <= 28)
            {
                if (((Rook)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Rook)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_1();

                    return; //stopping excution of function
                }

            }
            else if (id <= 30 || id>32)
            {
                if (((Queen)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Queen)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_1();

                    return; //stopping excution of function
                }

            }
            else
            {
                if (((King)(Match[id])).Can_Move(moveField) == true)
                {
                    try
                    {
                        if (!((King)(Match[id])).Castling) //if not a castling move
                        {
                            ((King)(Match[id])).Move(moveField); //moving the king to select field
                        }
                        else if (!((Rook)(Match[((King)(Match[id])).Castling_Id])).hasMoved & Match.ContainsKey(((King)(Match[id])).Castling_Id) & !check_2()) //if the rook did not move and the rook was not destroyed and king is not under check
                        {

                            List<string> Danger_Fields = new List<string>(); //list containing the field king passes through and the destination field 

                            Danger_Fields = (separation_fields(((King)(Match[id])).field, moveField)); //adding the field through which king moves to the list

                            Danger_Fields.Add(moveField); //adding destination field

                            foreach (string field in Danger_Fields) //if any of those fields would be attacked by enemy pieces
                            {

                                if (check_next_turn_white(field))
                                {

                                    Console.WriteLine("Can not move to this field");

                                    Play_1();

                                    return; //stopping excution of function

                                }

                            }

                             //castling is allowed

                             ((King)(Match[id])).Move(moveField); //moving the king to select field

                            ((Rook)(Match[((King)(Match[id])).Castling_Id])).Castling_Move(((King)(Match[id])).Tower_Field); //moving the rook to the field as part of the castling move


                        }
                    }
                    catch(System.Collections.Generic.KeyNotFoundException)
                    {
                        Console.WriteLine("Can not move to this field");

                        Play_1();

                        return; //stopping excution of function
                    }
                   
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_1();

                    return; //stopping excution of function
                }

            }

                if (id<=16 & (moveField[1].Equals('1'))) //becomes a queen
            {
                Game_Board.Occupied_Fields.Remove(moveField); //Removing the pin from the move field

                Match.Remove(id); //removing the pin from match dictionary

                id = id + 32; //the id of the new queen on this postion

                //Game_Board.Occupied_Fields.Add(moveField, id);  //adding the queen on the movefield

                Game_Board.Pin_Queens[Game_Board.Queens_Added] = (new Queen(moveField, id, "White")); //creating the new queen

                Match.Add(id, Game_Board.Pin_Queens[Game_Board.Queens_Added]); //adding the queen to match dictionary

                Game_Board.Queen_ID_Postion.Add(id, Game_Board.Queens_Added); //stores the id of pin versus index in the Pin_Queens array

                Game_Board.Queens_Added++; //incrementing number of Queens added to the array

            }
        }

        static void Play_2()
        {
            string selectField;

            string moveField;

            selectField = Program.selectField_2();

            int id;

            id = Game_Board.Occupied_Fields[selectField]; //id of game piece being selcted

            Console.WriteLine("To which field do you want to move player 2?");

            moveField = Console.ReadLine();

            if (id%2==1)
            {
                Console.WriteLine("Please select a black piece player two.");

                Play_2();

                return; //stopping excution of function

            }

            if (Game_Board.gameBoardFields.Contains(moveField) == false)
            {

                Console.WriteLine("Selected field is not a valid move field.");

                Play_2();

                return; //stopping excution of function

            }

            if (!Black_Move_Possible(selectField, moveField)) //can the game piece leave the selectField and move to the moveField without this putting the king under check
            {

                Console.WriteLine("Can not move this game piece to this field.");

                Play_2();

                return; //stopping excution of function

            }

            if (id <= 16)
            {

                if (((Pin)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Pin)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_2();

                    return; //stopping excution of function
                }

            }
            else if (id <= 20)
            {
                if (((Knight)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Knight)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_2();

                    return; //stopping excution of function
                }

            }
            else if (id <= 24)
            {
                if (((Bishop)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Bishop)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_2();

                    return; //stopping excution of function
                }

            }
            else if (id <= 28)
            {
                if (((Rook)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Rook)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_2();

                    return; //stopping excution of function
                }

            }
            else if (id <= 30 || id>32)
            {
                if (((Queen)(Match[id])).Can_Move(moveField) == true)
                {
                    ((Queen)(Match[id])).Move(moveField); //moving the pin to select field
                }
                else
                {
                    Console.WriteLine("Can not move to this field");

                    Play_2();

                    return; //stopping excution of function
                }

            }
            else
            {
                try
                {
                    if (((King)(Match[id])).Can_Move(moveField) == true)
                    {
                        //((King)(Match[id])).Move(moveField); //moving the king to select field

                        if (!((King)(Match[id])).Castling) //if not a castling move
                        {
                            ((King)(Match[id])).Move(moveField); //moving the king to select field
                        }
                        else if (!((Rook)(Match[((King)(Match[id])).Castling_Id])).hasMoved & Match.ContainsKey(((King)(Match[id])).Castling_Id) & !check_1()) //if the rook did not move and the rook was not destroyed and king is not under check
                        {

                            List<string> Danger_Fields = new List<string>(); //list containing the field king passes through and the destination field 

                            Danger_Fields = (separation_fields(((King)(Match[id])).field, moveField)); //adding the field through which king moves to the list

                            Danger_Fields.Add(moveField); //adding destination field

                            foreach (string field in Danger_Fields) //if any of those fields would be attacked by enemy pieces
                            {

                                if (check_next_turn_black(field))
                                {

                                    Console.WriteLine("Can not move to this field");

                                    Play_2();

                                    return; //stopping excution of function

                                }

                            }

                             //castling is allowed

                             ((King)(Match[id])).Move(moveField); //moving the king to select field

                            ((Rook)(Match[((King)(Match[id])).Castling_Id])).Castling_Move(((King)(Match[id])).Tower_Field); //moving the rook to the field as part of the castling move


                        }

                    }


                    else
                    {
                        Console.WriteLine("Can not move to this field");

                        Play_2();

                        return; //stopping excution of function
                    }
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    Console.WriteLine("Can not move to this field");

                    Play_1();

                    return; //stopping excution of function
                }
            }

            if (id <= 16 & (moveField[1].Equals('8'))) //becomes a queen
            {
                Game_Board.Occupied_Fields.Remove(moveField); //Removing the pin from the move field

                Match.Remove(id); //removing the pin from match dictionary

                id = id + 32; //the id of the new queen on this postion

                //Game_Board.Occupied_Fields.Add(moveField, id);  //adding the queen on the movefield

                Game_Board.Pin_Queens[Game_Board.Queens_Added] = (new Queen(moveField, id, "Black")); //creating the new queen

                Match.Add(id, Game_Board.Pin_Queens[Game_Board.Queens_Added]); //adding the queen to match dictionary

                Game_Board.Queen_ID_Postion.Add(id, Game_Board.Queens_Added); //stores the id of pin versus index in the Pin_Queens array

                Game_Board.Queens_Added++; //incrementing number of Queens added to the array

            }
        }

        static string selectField_1() //get's the field user selects and checks if it's valid field
        {
            Console.WriteLine("On which field is the piece that you want to select player one?");

            string userInput = Console.ReadLine();

            if (Game_Board.Occupied_Fields.ContainsKey(userInput) == false)
            {

                Console.WriteLine("Invalid Field. Please try again.");

                userInput=selectField_1(); //asks to enter the field again

            }

            return userInput;

        }

        static string selectField_2() //get's the field user selects and checks if it's valid field
        {
            Console.WriteLine("On which field is the piece that you want to select, player two?");

            string userInput = Console.ReadLine();

            if (Game_Board.Occupied_Fields.ContainsKey(userInput) == false)
            {

                Console.WriteLine("Invalid Field. Please try again.");

                userInput = selectField_2(); //asks to enter the field again

            }

            return userInput;

        }
        static bool check_1() //is black king under check?
        {


            string kingField = ((King)(Match[32])).field; // the king is on this field

          


            for (int i = 1; i < 16; i=i+2) //checks if any hostile pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Pin)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            for (int i = 17; i < 20; i = i + 2) //checks if any knight  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Knight)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            for (int i = 21; i < 24; i = i + 2) //checks if any hostile bishop  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Bishop)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }

            }
            for (int i = 25; i < 28; i = i + 2) //checks if any hostile rook  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Rook)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            if (Match.ContainsKey(29))
            {
                if (((Queen)(Match[29])).Can_Move(kingField) == true) //checks if hostile Queen causes check on king
                {
                    return true;
                }
            }
            if (Match.ContainsKey(31))
            {
                if (((King)(Match[31])).Can_Move(kingField) == true) //checks if hostile King causes check on king
                {
                    return true;
                }
            }
            for (int i = 33; i < 48; i = i + 2) //checks if any hostile queen made from pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Queen)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        static bool white_defense(string Field) //can white team defend king by moving any game piece to this field
        {


            for (int i = 1; i < 16; i = i + 2) //checks if any white pin can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Pin)(Match[i])).Can_Move(Field) == true)
                    {
                        if (White_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
            }
            for (int i = 17; i < 20; i = i + 2) //checks if any white knight can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Knight)(Match[i])).Can_Move(Field) == true)
                    {
                        if (White_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
            }
            for (int i = 21; i < 24; i = i + 2) //checks if any white bishop can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Bishop)(Match[i])).Can_Move(Field) == true)
                    {
                        if (White_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }

            }
            for (int i = 25; i < 28; i = i + 2) //checks if any white rook can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Rook)(Match[i])).Can_Move(Field) == true)
                    {
                        if (White_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
            }
            if (Match.ContainsKey(29))
            {
                if (((Queen)(Match[29])).Can_Move(Field) == true) //checks if white queen can move to this field
                {
                    if (White_Move_Possible(get_field(29), Field)) //can game piece leave this field without this opening a new check path against the king
                    {
                        return true;
                    }
                }
            }
            if (Match.ContainsKey(31))
            {
                if (((King)(Match[31])).Can_Move(Field) == true) //check if white king can move to this field
                {
                    if (White_Move_Possible(get_field(31), Field))
                    {
                        return true;
                    }
                    
                }
            }
            for (int i = 33; i < 48; i = i + 2) //checks if any white Queen made from pin can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Queen)(Match[i])).Can_Move(Field) == true)
                    {
                        if (White_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
            }

            return false;

        }

       static bool check_2() //is white king under check?
        {


            string kingField = ((King)(Match[31])).field; // the king is on this field




            for (int i = 2; i < 17; i = i + 2) //checks if any hostile pin causes check on king
            {

                if (Match.ContainsKey(i))
                {
                    if (((Pin)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }

            }
            for (int i = 18; i < 21; i = i + 2) //checks if any knight  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Knight)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            for (int i = 22; i < 25; i = i + 2) //checks if any hostile bishop  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Bishop)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            for (int i = 26; i < 29; i = i + 2) //checks if any hostile rook  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Rook)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            if (Match.ContainsKey(30))
            {
                if (((Queen)(Match[30])).Can_Move(kingField) == true) //checks if hostile Queen causes check on king
                {
                    return true;
                }
            }
            if (Match.ContainsKey(32))
            {
                if (((King)(Match[32])).Can_Move(kingField) == true) //checks if hostile King causes check on king
                {
                    return true;
                }
            }
            for (int i = 34; i < 49; i = i + 2) //checks if any hostile queen made from pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Queen)(Match[i])).Can_Move(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        static string get_field(int id) //gets field of the game piece with a given id
        {
             
            

                if (id<17)
                {
                    
                        return ((Pin)(Match[id])).field;
                    
                }
                else if(id<21)
                {

                        return ((Knight)(Match[id])).field;

                }
                else if(id<25)
                { 
                     
                        return ((Bishop)(Match[id])).field;

                }
                else if(id<29)
                {

                  return ((Rook)(Match[id])).field;

                }
                else if(id<31 || id>32)
                {

                return ((Queen)(Match[id])).field;

                }
                else
                {
                
                return ((King)(Match[id])).field;

                }
        }

        static bool black_defense(string Field) //can black team defend king by moving to this field
        {


            for (int i = 2; i < 17; i = i + 2) //checks if any black pin can move to this field
            {

                if (Match.ContainsKey(i))
                {
                    if (((Pin)(Match[i])).Can_Move(Field) == true)
                    {
                        if (Black_Move_Possible(get_field(i),Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }

            }
            for (int i = 18; i < 21; i = i + 2) //checks if any knight pin can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Knight)(Match[i])).Can_Move(Field) == true)
                    {
                        if (Black_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
            }
            for (int i = 22; i < 25; i = i + 2) //checks if any black bishop can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Bishop)(Match[i])).Can_Move(Field) == true)
                    {
                        if (Black_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
            }
            for (int i = 26; i < 29; i = i + 2) //checks if any black rook can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Rook)(Match[i])).Can_Move(Field) == true)
                    {
                        if (Black_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
            }
            if (Match.ContainsKey(30))
            {
                if (((Queen)(Match[30])).Can_Move(Field) == true) //checks if  black queen can move to this field
                {
                    if (Black_Move_Possible(get_field(30), Field)) //can game piece leave this field without this opening a new check path against the king
                    {
                        return true;
                    }
                }
            }
            if (Match.ContainsKey(32))
            {
                if (((King)(Match[32])).Can_Move(Field) == true) //checks if black king can move to this field
                {
                    if (Black_Move_Possible(get_field(32), Field))
                    {
                        return true;
                    }
                }
            }
            for (int i = 34; i < 49; i = i + 2) //checks if any black Queen made from pin can move to this field
            {
                if (Match.ContainsKey(i))
                {
                    if (((Queen)(Match[i])).Can_Move(Field) == true)
                    {
                        if (Black_Move_Possible(get_field(i), Field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
            }
            return false;

        }

        static bool check_next_turn_black(string kingField) //would the king be under check on this field
        {




            for (int i = 1; i < 16; i = i + 2) //checks if any hostile pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Pin)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            for (int i = 17; i < 20; i = i + 2) //checks if any knight  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Knight)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            for (int i = 21; i < 24; i = i + 2) //checks if any hostile bishop  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Bishop)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }

            }
            for (int i = 25; i < 28; i = i + 2) //checks if any hostile rook  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Rook)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            if (Match.ContainsKey(29))
            {
                if (((Queen)(Match[29])).Can_Check(kingField) == true) //checks if hostile Queen causes check on king
                {
                    return true;
                }
            }
            if (Match.ContainsKey(31))
            {
                if (((King)(Match[31])).Can_Check(kingField) == true) //checks if hostile King causes check on king
                {
                    return true;
                }
            }
            for (int i = 33; i < 48; i = i + 2) //checks if any Queen made from pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Queen)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        static bool check_next_turn_white(string kingField) //would the king be under check on this field
        {




            for (int i = 2; i < 17; i = i + 2) //checks if any hostile pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Pin)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            for (int i = 18; i < 21; i = i + 2) //checks if any knight  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Knight)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            for (int i = 22; i < 25; i = i + 2) //checks if any hostile bishop  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Bishop)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }

            }
            for (int i = 26; i < 29; i = i + 2) //checks if any hostile rook  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Rook)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }
            }
            if (Match.ContainsKey(30))
            {
                if (((Queen)(Match[30])).Can_Check(kingField) == true) //checks if hostile Queen causes check on king
                {
                    return true;
                }
            }
            if (Match.ContainsKey(32))
            {
                if (((King)(Match[32])).Can_Check(kingField) == true) //checks if hostile King causes check on king
                {
                    return true;
                }
            }
            for (int i = 34; i < 49; i = i + 2) //checks if any Queen made from pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Queen)(Match[i])).Can_Check(kingField) == true)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
        static int check_black_id() //Stores the id of piece that causes check on white king, if more then one piece causes check return 0
        {


            string kingField = ((King)(Match[32])).field; // the king is on this field

             int id = 0;

            int Count = 0;


            for (int i = 1; i < 16; i = i + 2) //checks if any hostile pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Pin)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }
            }
            for (int i = 17; i < 20; i = i + 2) //checks if any knight  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Knight)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }
            }
            for (int i = 21; i < 24; i = i + 2) //checks if any hostile bishop  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Bishop)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }

            }
            for (int i = 25; i < 28; i = i + 2) //checks if any hostile rook  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Rook)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }
            }
            if (Match.ContainsKey(29))
            {
                if (((Queen)(Match[29])).Can_Move(kingField) == true) //checks if hostile Queen causes check on king
                {
                    id = 29;

                    Count++;
                }
            }
            if (Match.ContainsKey(31))
            {
                if (((King)(Match[31])).Can_Move(kingField) == true) //checks if hostile King causes check on king
                {
                    id = 31;

                    Count++;
                }
            }
            for (int i = 33; i < 48; i = i + 2) //checks if any hostile Queen made from pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Queen)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }
            }
            if (Count > 1) 
            {
                return 0; 
            }
            else
            {
                return id;
            }

        }

        static int check_white_id() //Stores the id of piece that causes check on white king, if more then one piece causes check return 0
        {


            string kingField = ((King)(Match[31])).field; // the king is on this field

            int id = 0;

            int Count = 0; //number of game pieces that cause check on white king

            


            for (int i = 2; i < 17; i = i + 2) //checks if any hostile pin causes check on king
            {

                if (Match.ContainsKey(i))
                {
                    if (((Pin)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i; //id of piece that causes check on the king

                        Count++; 
                    }
                }

            }
            for (int i = 18; i < 21; i = i + 2) //checks if any knight  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Knight)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }
            }
            for (int i = 22; i < 25; i = i + 2) //checks if any hostile bishop  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Bishop)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }
            }
            for (int i = 26; i < 29; i = i + 2) //checks if any hostile rook  causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Rook)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }
            }
            if (Match.ContainsKey(30))
            {
                if (((Queen)(Match[30])).Can_Move(kingField) == true) //checks if hostile Queen causes check on king
                {
                    id = 30;

                    Count++;
                }
            }
            if (Match.ContainsKey(32))
            {
                if (((King)(Match[32])).Can_Move(kingField) == true) //checks if hostile King causes check on king
                {
                    id = 32;

                    Count++;
                }
            }
            for (int i = 34; i < 49; i = i + 2) //checks if any hostile Queen made from pin causes check on king
            {
                if (Match.ContainsKey(i))
                {
                    if (((Queen)(Match[i])).Can_Move(kingField) == true)
                    {
                        id = i;

                        Count++;
                    }
                }
            }
            if (Count>1)
            {
                return 0;

            }
            else
            {

                return id;

            }

        }

        static bool white_escape() //see if white king escape check by the king moving to any different field
        {

            string[] AdjacentField = new string[9];

            AdjacentField = ((King)(Match[31])).Escape_Fields();

            for (int i = 0; i < 9; i++)
            {
                if (!AdjacentField[i].Equals("NA")) //if the field is on the gameboard 
                {
                    if (((King)(Match[31])).Can_Move(AdjacentField[i])) //if king can move to the adjacent field
                    {
                        if (!check_next_turn_white(AdjacentField[i])) //checks if the king would be under check on this field
                        {
                            return true; //king not under check, hence there is a field to which king can escape
                        }
                    }
 
                }
            }

            return false; //there is no field to which king can escape



        }
        static bool black_escape() //see if black king escape check by the king moving to any different field
        {

            string[] AdjacentField = new string[9];

            AdjacentField = ((King)(Match[32])).Escape_Fields();


            for (int i = 0; i < 9; i++)
            {
                if (!AdjacentField[i].Equals("NA")) //if the field is gameboard field
                {
                    if (((King)(Match[32])).Can_Move(AdjacentField[i])) //if king can move to the adjacent field
                    {
                        if (!check_next_turn_black(AdjacentField[i])) //checks if the king would be under check on this field
                        {
                            return true; //king not under check, hence there is a field to which king can escape
                        }
                    }

                }
            }

            return false; //there is no field to which king can escape

        }

        static void Reverse_Queue(Queue<string> toReverse) //reverses a queue and returns reversed queue
        {

            Queue<string> Reversed = new Queue<string>();

            Stack<string> Reversing = new Stack<string>();

            int length = toReverse.Count;

            for (int i = 0; i < length; i++)
            {
                Reversing.Push(toReverse.Dequeue()); //adding to stack

            }

            for (int i = 0; i <length; i++)
            {
                toReverse.Enqueue(Reversing.Pop()); //adding to reversed Queue
            }

        }

        static int IndexOfElement(string[] array,string element) //return index of array element in the array
        {

            for (int i=0;i<array.Length;i++)
            {

                if(array[i].Equals(element))
                {

                    return i;

                }

            }

            return 0; // if the element is not in the array

        }

        static List<string> separation_fields(string Origin, string Destination) //returns the gameboard fields between destination and origin not including destination and origin fields
        {

            string[] Letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };

            string[] Digits = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };

            List<string> Fields = new List<string>();

            Queue<string> Intial = new Queue<string>();

            Queue<string> Numbers = new Queue<string>();

            int Add1 = 0;

            int Add2 = 0;



            if (!Origin[0].Equals(Destination[0])) //if both game pieces are not on the same letter
            {


                for (int i = 0; i < 8; i++) //writes all the letters between the destination and origin in Intial Queue e.g for B and G origin destination C,D,E,F
                {
                    if ((Letters[i].Equals(Origin[0].ToString()) || Letters[i].Equals(Destination[0].ToString())))
                    {

                        Add1++;
                    }

                    if (Add1 == 2)
                    {
                        Intial.Enqueue(Letters[i]);

                    }

                    if ((Letters[i].Equals(Origin[0].ToString()) || Letters[i].Equals(Destination[0].ToString())))
                    {
                        Add1++;
                    }

                }
            }


            if (!Origin[1].Equals(Destination[1])) //if both game pieces are not on the same number
            {

                for (int i = 0; i < 8; i++) //writes all the numbers between the destination and origin in Intial Queue e.g for B and G origin destination C,D,E,F
                {
                    if ((Digits[i].Equals(Origin[1].ToString()) || Digits[i].Equals(Destination[1].ToString())))
                    {
                        Add2++;
                    }

                    if (Add2 == 2)
                    {
                        Numbers.Enqueue(Digits[i]);

                    }

                    if ((Digits[i].Equals(Origin[1].ToString()) || Digits[i].Equals(Destination[1].ToString())))
                    {
                        Add2++;
                    }

                }
            }
            if (Origin[0].Equals(Destination[0])) // if both game pieces are on the same letter
            {

                for (int i = 0; i < Numbers.Count; i++)
                {
                    Intial.Enqueue(Origin[0].ToString());

                }


            }
            else if (Origin[1].Equals(Destination[1])) // if both game pieces are on the same number
            {

                for (int i = 0; i < Intial.Count; i++)
                {
                    Numbers.Enqueue(Origin[1].ToString());
                }

            }

            // The following adjustments are needed as separation_fields returned only fields along one diagonal only and not the other

            if (Destination[1] > Origin[1])
            {
                

                if (IndexOfElement(Letters, Destination[0].ToString()) < IndexOfElement(Letters, Origin[0].ToString()))
                {
                    
                    Reverse_Queue(Numbers);
                }
            }
            else if (Destination[1] < Origin[1])
            {
               

                if (IndexOfElement(Letters, Destination[0].ToString()) > IndexOfElement(Letters, Origin[0].ToString()))
                {
                    
                    Reverse_Queue(Numbers);
                }
            }


            int len = Intial.Count;

            for (int k = 0; k < len; k++) //creates fields
            {

                Fields.Add(Intial.Dequeue() + Numbers.Dequeue());


            }

            return Fields;



        }

        static bool white_move_between(string checkingPiece,int checkingPieceId,string kingField) //can white player escape check by moving in between checking piece and king
        {
            if (checkingPieceId >= 17 & checkingPieceId <= 20)
            {
                return false; //moving in between a knight does not save king from being under check
            }

            List<string> moveFields = separation_fields(checkingPiece, kingField); //the fields to which white player can move, between the king and the enemy piece checking king

            if (moveFields.Count == 0)
            {
                return false;  //can not move between a game piece that is on adjacent field to king
            }

            foreach (string field in moveFields)
            {
                for (int i = 1; i < 16; i = i + 2) //checks if any white pin can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Pin)(Match[i])).Can_Move(field))
                        {
                            
                            if (White_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                            
                            
                        }
                    }
                }
                for (int i = 17; i < 20; i = i + 2) //checks if any white knight can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Knight)(Match[i])).Can_Move(field))
                        {
                            if (White_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                        }
                    }
                }
                for (int i = 21; i < 24; i = i + 2) //checks if any white bishop can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Bishop)(Match[i])).Can_Move(field))
                        {
                            if (White_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                        }
                    }

                }
                for (int i = 25; i < 28; i = i + 2) //checks if any white rook can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Rook)(Match[i])).Can_Move(field))
                        {
                            if (White_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Match.ContainsKey(29))
                {
                    if (((Queen)(Match[29])).Can_Move(field)) //checks if any Queen can move to this place
                    {
                        if (White_Move_Possible(get_field(29), field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
                for (int i = 33; i < 48; i = i + 2) //checks if any white Queen made from pin  can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Rook)(Match[i])).Can_Move(field))
                        {
                            if (White_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                        }
                    }
                }

            }

            return false;

        }

        static bool black_move_between(string checkingPiece,int checkingPieceId, string kingField) //can black player escape check by moving in between checking piece and king
        {
            if (checkingPieceId >= 17 & checkingPieceId <= 20)
            {
                return false; //moving in between a knight does not save king from being under check
            }

            List<string> moveFields = separation_fields(checkingPiece, kingField); //the fields to which white black can move

            if (moveFields.Count == 0)
            {
                return false;  //can not move between a game piece that is on adjacent field to king
            }

            foreach (string field in moveFields)
            {
                for (int i = 2; i < 17; i = i + 2) //checks if any white pin can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Pin)(Match[i])).Can_Move(field))
                        {
                            if (Black_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }

                        }
                    }
                }
                for (int i = 18; i < 21; i = i + 2) //checks if any black knight can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Knight)(Match[i])).Can_Move(field))
                        {
                            if (Black_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                        }
                    }
                }
                for (int i = 22; i < 25; i = i + 2) //checks if any black bishop can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Bishop)(Match[i])).Can_Move(field))
                        {
                            if (Black_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                        }
                    }

                }
                for (int i = 26; i < 29; i = i + 2) //checks if any black rook can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Rook)(Match[i])).Can_Move(field))
                        {
                            if (Black_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                        }
                    }
                }
                if (Match.ContainsKey(30))
                {
                    if (((Queen)(Match[30])).Can_Move(field)) //checks if any black Queen can move to this place
                    {
                        if (Black_Move_Possible(get_field(30), field)) //can game piece leave this field without this opening a new check path against the king
                        {
                            return true;
                        }
                    }
                }
                for (int i = 34; i < 49; i = i + 2) //checks if any white Queen made from pin  can move to this place
                {
                    if (Match.ContainsKey(i))
                    {
                        if (((Rook)(Match[i])).Can_Move(field))
                        {
                            if (Black_Move_Possible(get_field(i), field)) //can game piece leave this field without this opening a new check path against the king
                            {
                                return true;
                            }
                        }
                    }
                }

            }

            return false;

        }

        static bool White_Move_Possible(string selectField,string moveField) //check if this piece can move to this field without causing a check on the king
        {

            int id_select=Game_Board.Occupied_Fields[selectField];

            if (id_select == 31) //if king selected
            {
                ((King)Match[31]).field = moveField; //necessary to simulate kings postion on new field - check() function
            }

            int id_moveField = 0;

            Game_Board.Occupied_Fields.Remove(selectField); //removes the piece from occupied fields - leaving the field could put a king under check

            bool Move_Possible;
            

            if (Game_Board.Occupied_Fields.ContainsKey(moveField)) //if enemy on the field
            {
                id_moveField=Game_Board.Occupied_Fields[moveField];

                Game_Board.Occupied_Fields.Remove(moveField); //Removing the enemy from the occupied fields dictionary

                Match.Remove(id_moveField); //removing the enemy from match dictionary 

                Game_Board.Occupied_Fields.Add(moveField, id_select);  //adding white piece on the move field

                Move_Possible=!check_2(); //white king not under check?

                //restoring gameboard previously defined order

                Game_Board.Occupied_Fields.Remove(moveField); //removing the white piece from this field

               // Game_Board.Occupied_Fields.Add(moveField, id_moveField); //restoring the enemy piece on this field

                Add_Match(moveField, id_moveField); //restoring the destroyed piece to match dictionary

            }
            else
            {

               Game_Board.Occupied_Fields.Add(moveField,id_select); //adding white piece on the move field

                Move_Possible = !check_2(); //white king not under check?

               //restoring gameboard previously defined order

               Game_Board.Occupied_Fields.Remove(moveField); //removing the white piece from this field

            }

            Game_Board.Occupied_Fields.Add(selectField,id_select); //restoring white piece on it's original field

            if (id_select == 31) //if king selected
            {
                ((King)Match[31]).field = selectField; //restoring the postion king was orginally on
            }

            return Move_Possible; //returning if the move is possible
        }

        static bool Black_Move_Possible(string selectField, string moveField) //check if this piece can move to this field without causing a check on the king
        {

            int id_select = Game_Board.Occupied_Fields[selectField];

            if (id_select==32) //if king selected
            {
                ((King)Match[32]).field = moveField; //necessary to simulate kings postion on new field - check() function
            }

            int id_moveField = 0;

            Game_Board.Occupied_Fields.Remove(selectField); //removes the piece from occupied fields - leaving the field could put a king under check

            bool Move_Possible;


            if (Game_Board.Occupied_Fields.ContainsKey(moveField)) //if enemy on the field
            {
                id_moveField = Game_Board.Occupied_Fields[moveField];

                Game_Board.Occupied_Fields.Remove(moveField); //Removing the enemy

                Match.Remove(id_moveField); //removing the enemy from match dictionary 

                Game_Board.Occupied_Fields.Add(moveField, id_select);  //adding black piece on the move field

                Move_Possible = !check_1(); //black king not under check?

                //restoring gameboard previously defined order

                Game_Board.Occupied_Fields.Remove(moveField); //removing the black piece from this field

     //           Game_Board.Occupied_Fields.Add(moveField, id_moveField); //restoring the enemy piece on this field

                Add_Match(moveField, id_moveField); //restoring the destroyed piece to match dictionary

            }
            else
            {

                Game_Board.Occupied_Fields.Add(moveField, id_select); //adding black piece on the move field

                Move_Possible = !check_1(); //black king not under check?

                //restoring gameboard previously defined order

                Game_Board.Occupied_Fields.Remove(moveField); //removing the black piece from this field

            }

            Game_Board.Occupied_Fields.Add(selectField, id_select); //restoring black piece on it's original field

            if (id_select == 32) //if king selected
            {
                ((King)Match[32]).field = selectField; //restoring the postion king was orginally on
            }

            return Move_Possible; //returning if the move is possible
        }

        static bool Can_White_Leave(int i) //can this white game piece leave the field without putting king under check
        {

            if (i <= 16) //pin
            {
                Game_Board.Occupied_Fields.Remove(((Pin)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_white_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Pin)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Pin)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else if (i <= 20)
            {
                Game_Board.Occupied_Fields.Remove(((Knight)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_white_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Knight)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Knight)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else if(i <= 24)
            {
                Game_Board.Occupied_Fields.Remove(((Bishop)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_white_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Bishop)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Bishop)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else if(i <= 28)
            {
                Game_Board.Occupied_Fields.Remove(((Rook)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_white_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Rook)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Rook)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else if (i <= 30)
            {
                Game_Board.Occupied_Fields.Remove(((Queen)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_white_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Queen)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Queen)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else
            {
                return true; //can leave it is the king
            }

        }

        static bool Can_Black_Leave(int i) //can this black game piece leave the field without putting king under check
        {

            if (i <= 16) //pin
            {
                Game_Board.Occupied_Fields.Remove(((Pin)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_black_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Pin)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Pin)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else if (i <= 20)
            {
                Game_Board.Occupied_Fields.Remove(((Knight)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_black_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Knight)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Knight)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else if (i <= 24)
            {
                Game_Board.Occupied_Fields.Remove(((Bishop)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_black_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Bishop)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Bishop)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else if (i <= 28)
            {
                Game_Board.Occupied_Fields.Remove(((Rook)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_black_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Rook)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Rook)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else if (i <= 30)
            {
                Game_Board.Occupied_Fields.Remove(((Queen)(Match[i])).field); //removes the piece from occupied fields - leaving the field could put a king under check

                if (check_black_id() == 0) //if an extra check path was opened then more then one piece now causes check on the king and function has value 0
                {

                    Game_Board.Occupied_Fields.Add(((Queen)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return false; //can not move away from the field if that would put the king under check

                }
                else
                {

                    Game_Board.Occupied_Fields.Add(((Queen)(Match[i])).field, i); // returns piece to the gameboard - the piece was not destroyed

                    return true;

                }
            }
            else
            {
                return true; //can move if it is the king
            }

        }

        static bool black_wins() //does black win the game
        {

            if (white_escape()) //can king escape check by moving to a different field
            {

                return false;

            }
            else if (check_white_id() == 0)  // are two or more pieces causing check on the king
            {

                return true;

            }
            else if (white_defense(get_field(check_white_id()))) // can the game piece that causes check on the king be destroyed?
            {

                return false;

            }
            else if(white_move_between(get_field(check_white_id()), check_white_id(),((King)(Match[31])).field)) // can white game piece move between king and a piece causing check on the king ending the check
            {
                return false;
            }
            else
            {
                return true; 

            }
            

        }

        static bool white_wins() //does white win the game
        {

            if (black_escape()) //can king escape check by moving to a different field
            {

                return false;

            }
            else if (check_black_id() == 0)  // are two or more pieces causing check on the king
            {

                return true;

            }
            else if (black_defense(get_field(check_black_id()))) // can the game piece that causes check on the king be destroyed?
            {

                return false;

            }
            else if (black_move_between(get_field(check_black_id()), check_black_id(), ((King)(Match[32])).field)) // can black game piece move between king and a piece causing check on the king ending the check
            {
                return false;
            }
            else
            {
                return true;

            }


        }

        static void Add_Match(string field,int id) //adds game piece at a given field to the match dictionary
        {
            string color; //defining the color

            if (id%2==1)
            {
                color = "White";
            }
            else
            {
                color = "Black";
            }

            switch(id)
            { 
                case 1:
                    Pin A7 = new Pin(field, 1, "White"); Match.Add(1, A7);
                    break;
                case 2:
                    Pin A2 = new Pin(field, 2, "Black"); Match.Add(2, A2);
                    break;
                case 3:
                    Pin B7 = new Pin(field, 3, "White"); Match.Add(3, B7);
                    break;
                case 4:
                    Pin B2 = new Pin(field, 4, "Black"); Match.Add(4, B2);
                    break;
                case 5:
                    Pin C7 = new Pin(field, 5, "White"); Match.Add(5, C7);
                    break;
                case 6:
                    Pin C2 = new Pin(field, 6, "Black"); Match.Add(6, C2);
                    break;
                case 7:
                    Pin D7 = new Pin(field, 7, "White"); Match.Add(7, D7);
                    break;
                case 8:
                    Pin D2 = new Pin(field, 8, "Black"); Match.Add(8, D2);
                    break;
                case 9:
                    Pin E7 = new Pin(field, 9, "White"); Match.Add(9, E7);
                    break;
                case 10:
                    Pin E2 = new Pin(field, 10, "Black"); Match.Add(10, E2);
                    break;
                case 11:
                    Pin F7 = new Pin(field, 11, "White"); Match.Add(11, F7);
                    break;
                case 12:
                    Pin F2 = new Pin(field, 12, "Black"); Match.Add(12, F2);
                    break;
                case 13:
                    Pin G7 = new Pin(field, 13, "White"); Match.Add(13, G7);
                    break;
                case 14:
                    Pin G2 = new Pin(field, 14, "Black"); Match.Add(14, G2);
                    break;
                case 15:
                    Pin H7 = new Pin(field, 15, "White"); Match.Add(15, H7);
                    break;
                case 16:
                    Pin H2 = new Pin(field, 16, "Black"); Match.Add(16, H2);
                    break;
                case 17:
                    Knight B8 = new Knight(field, 17, "White"); Match.Add(17, B8);
                    break;
                case 18:
                    Knight B1 = new Knight(field, 18, "Black"); Match.Add(18, B1);
                    break;
                case 19:
                    Knight G8 = new Knight(field, 19, "White"); Match.Add(19, G8);
                    break;
                case 20:
                    Knight G1 = new Knight(field, 20, "Black"); Match.Add(20, G1);
                    break;
                case 21:
                    Bishop C8 = new Bishop(field, 21, "White"); Match.Add(21, C8);
                    break;
                case 22:
                    Bishop C1 = new Bishop(field, 22, "Black"); Match.Add(22, C1);
                    break;
                case 23:
                    Bishop F8 = new Bishop(field, 23, "White"); Match.Add(23, F8);
                    break;
                case 24:
                    Bishop F1 = new Bishop(field, 24, "Black"); Match.Add(24, F1);
                    break;
                case 25:
                    Rook A8 = new Rook(field, 25, "White"); Match.Add(25, A8);
                    break;
                case 26:
                    Rook A1 = new Rook(field, 26, "Black"); Match.Add(26, A1);
                    break;
                case 27:
                    Rook H8 = new Rook(field, 27, "White"); Match.Add(27, H8);
                    break;
                case 28:
                    Rook H1 = new Rook(field, 28, "Black"); Match.Add(28, H1);
                    break;
                case 29:
                    Queen D8 = new Queen(field, 29, "White"); Match.Add(29, D8);
                    break;
                case 30:
                    Queen D1 = new Queen(field, 30, "Black"); Match.Add(30, D1);
                    break;
                case 31:
                    King E8 = new King(field, 31, "White"); Match.Add(31, E8);
                    break;
                case 32:
                    King E1 = new King(field, 32, "Black"); Match.Add(32, E1);
                    break;
                default:
                    Game_Board.Pin_Queens[Game_Board.Queen_ID_Postion[id]] = new Queen(field, id, color); Match.Add(id, Game_Board.Pin_Queens[Game_Board.Queen_ID_Postion[id]]);
                    break;
            }

            

        }

        static bool Stalemate(string color) //checks if game ends with stalemate
        {

            List<int> Keys = new List<int>(); //dictionary with game piece ids - Match.Keys not suitable for stalemate function as foreach(int id in Match.Keys) resulted in Match.Keys being edited - System.InvalidOperationException: Collection was modified; enumeration operation may not execute

            foreach (int id in Match.Keys)
            {

                Keys.Add(id);

            }

            if (color.Equals("White")) //does white player cause a stalemate on black
            {

                foreach(int id in Keys)
                {

                    if (id%2==1)
                    {

                        foreach(string Field in Game_Board.gameBoardFields)
                        {

                            if (id <= 16)
                            {

                                if (((Pin)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                {
                                    if (White_Move_Possible(((Pin)(Match[id])).field, Field))
                                    {

                                        return false;

                                    }
                                }
                                

                            }
                            else if (id <= 20)
                            {
                                if (((Knight)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                {
                                    if (White_Move_Possible(((Knight)(Match[id])).field, Field))
                                    {

                                        return false;

                                    }
                                }
                                

                            }
                            else if (id <= 24)
                            {
                                if (((Bishop)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                {
                                    if (White_Move_Possible(((Bishop)(Match[id])).field, Field))
                                    {

                                        return false;

                                    }
                                }
                                

                            }
                            else if (id <= 28)
                            {
                                if (((Rook)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                {
                                    if (White_Move_Possible(((Rook)(Match[id])).field, Field))
                                    {

                                        return false;

                                    }
                                }
                                

                            }
                            else if (id <= 30 || id > 32)
                            {
                                if (((Queen)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                {
                                    if (White_Move_Possible(((Queen)(Match[id])).field, Field))
                                    {

                                        return false;

                                    }
                                }
                                

                            }
                            else if (id==31)
                            {
                                if (((King)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                {
                                    if (White_Move_Possible(((King)(Match[id])).field, Field))
                                    {
                                        try
                                        {

                                            if (!((King)(Match[id])).Castling) //if not a castling move
                                            {
                                                return false;
                                            }
                                            else if (!((Rook)(Match[((King)(Match[id])).Castling_Id])).hasMoved & Match.ContainsKey(((King)(Match[id])).Castling_Id) & !check_2()) //if the rook did not move and the rook was not destroyed and king is not under check
                                            {

                                                List<string> Danger_Fields = new List<string>(); //list containing the field king passes through and the destination field 

                                                Danger_Fields = (separation_fields(((King)(Match[id])).field, Field)); //adding the field through which king moves to the list

                                                Danger_Fields.Add(Field); //adding destination field

                                                bool Blocked_Move = false; //can not do a castling move

                                                foreach (string field in Danger_Fields) //if any of those fields would be attacked by enemy pieces
                                                {

                                                    if (check_next_turn_white(field))
                                                    {

                                                        Blocked_Move = true; //can not do castling move

                                                    }

                                                }

                                                //castling is allowed

                                                if (!Blocked_Move)
                                                {

                                                    return false;

                                                }




                                            }
                                        }
                                        catch (System.Collections.Generic.KeyNotFoundException)
                                        {

                                        }
                                    }
                                }
                               

                            }

                        }

                    }

                }

                return true; //black player is stalemated

             }
            else //Does black player cause stalemate on white
            {

                    foreach (int id in Keys)
                    {

                        if (id % 2 == 0)
                        {

                            foreach (string Field in Game_Board.gameBoardFields)
                            {

                                if (id <= 16)
                                {

                                    if (((Pin)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                    {
                                       if(Black_Move_Possible(((Pin)(Match[id])).field, Field))
                                       
                                        {

                                        return false;

                                        }
                                        
                                    }


                                }
                                else if (id <= 20)
                                {
                                    if (((Knight)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                    {
                                        if(Black_Move_Possible(((Knight)(Match[id])).field, Field))
                                       
                                        {

                                        return false;

                                        }

                                    }


                                }
                                else if (id <= 24)
                                {
                                    if (((Bishop)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                    {
                                        if(Black_Move_Possible(((Bishop)(Match[id])).field, Field))
                                       
                                        {

                                        return false;

                                        }
                                    }


                                }
                                else if (id <= 28)
                                {
                                    if (((Rook)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                    {
                                        if(Black_Move_Possible(((Rook)(Match[id])).field, Field))
                                       
                                        {

                                        return false;

                                        }
                                    }


                                }
                                else if (id <= 30 || id > 32)
                                {
                                    if (((Queen)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                    {
                                        if(Black_Move_Possible(((Queen)(Match[id])).field, Field))
                                       
                                        {

                                        return false;

                                        }
                                    }


                                }
                                else if (id == 32)
                                {
                                    if (((King)(Match[id])).Can_Move(Field) == true) //if can move to this field and would not put the king under check
                                    {

                                    if (Black_Move_Possible(((King)(Match[id])).field, Field))
                                    {
                                        try
                                        {

                                            if (!((King)(Match[id])).Castling) //if not a castling move
                                            {
                                                return false;
                                            }
                                            else if (!((Rook)(Match[((King)(Match[id])).Castling_Id])).hasMoved & Match.ContainsKey(((King)(Match[id])).Castling_Id) & !check_1()) //if the rook did not move and the rook was not destroyed and king is not under check
                                            {

                                                List<string> Danger_Fields = new List<string>(); //list containing the field king passes through and the destination field 

                                                Danger_Fields = (separation_fields(((King)(Match[id])).field, Field)); //adding the field through which king moves to the list

                                                Danger_Fields.Add(Field); //adding destination field

                                                bool Blocked_Move = false; //can not do a castling move

                                                foreach (string field in Danger_Fields) //if any of those fields would be attacked by enemy pieces
                                                {

                                                    if (check_next_turn_black(field))
                                                    {

                                                        Blocked_Move = true; //can not do castling move

                                                    }

                                                }

                                                //castling is allowed

                                                if (!Blocked_Move)
                                                {

                                                    return false;

                                                }




                                            }
                                        }
                                        catch (System.Collections.Generic.KeyNotFoundException)
                                        {

                                        }
                                    }
                                    }


                                }

                            }

                        }

                    }

                
                return true; //white player is stalemated

            }

           

        }

        static void Play(Game_Board item)
        {
            item.displayGameBoard();

            if (check_2())
            {
                if (black_wins())
                {
                    Console.WriteLine("Checkamate Player 2 Wins");

                    System.Environment.Exit(1); //stops excution of program

                }
                else
                {
                    Console.WriteLine("Player 1 is under Check!");
                }

            }

            if (Stalemate("White"))
            {
                Console.WriteLine("Stalement, white is stalemated");

                System.Environment.Exit(1); //stops excution of program
            }

            Play_1();

            item.displayGameBoard();

      

            if (check_1())
            {
                if (white_wins())
                {
                    Console.WriteLine("Checkamate Player 1 Wins");

                    System.Environment.Exit(1); //stops excution of program

                }
                else
                {
                    Console.WriteLine("Player 2 is under Check!");
                }
            }


            if (Stalemate("Black"))
            {
                Console.WriteLine("Stalement, black is stalemated");

                System.Environment.Exit(1); //stops excution of program
            }

            Play_2();

            Play(item); //unless game ends continues playing by calling itself

        }
    }
}
