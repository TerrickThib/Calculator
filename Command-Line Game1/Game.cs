using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Line_Game1
{
    class Game
    {
        //varibles
        float inputValue1;
        float inputValue2;
        string input = "";
        bool validInputReceived = false;
        bool stopGame = false;

        //Function
                         
        public void Run()
        {
                                    
            while (stopGame == false)
            {
                Console.WriteLine("To Exit type Quit otherwise press Enter to Continue");
                input = Console.ReadLine();
                if (input == "Quit")
                {
                    stopGame = true;
                }
                Console.WriteLine("Enter Number");
                input = Console.ReadLine();
                if (!float.TryParse(input, out inputValue1))
                {
                    Console.WriteLine("Invalid Response");
                    continue;
                }
                Console.WriteLine("Enter another number: ");
                input = Console.ReadLine();
                if (!float.TryParse(input, out inputValue2))
                {
                    Console.WriteLine("Invalid Response");
                    continue;
                }
                validInputReceived = false;               
                while (validInputReceived == false)
                {
                    Console.WriteLine("What would you like to use these in.");
                    Console.WriteLine("Add");
                    Console.WriteLine("Multiply");
                    Console.WriteLine("Subtract");
                    Console.WriteLine("Divide");
                    input = Console.ReadLine();
                    if (input == "Add")
                    {
                        Console.WriteLine(inputValue1 += inputValue2);
                        validInputReceived = true;
                        stopGame = false;

                    }
                    else if (input == "Multiply")
                    {
                        Console.WriteLine(inputValue1 *= inputValue2);
                        validInputReceived = true;
                        stopGame = false;
                    }
                    else if (input == "Subtract")
                    {
                        Console.WriteLine(inputValue1 -= inputValue2);
                        validInputReceived = true;
                        stopGame = false;
                    }
                    else if (input == "Divide")
                    {
                        Console.WriteLine(inputValue1 /= inputValue2);
                        validInputReceived = true;
                        stopGame = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Answer");
                        validInputReceived = false;
                    }

                    
                    Console.ReadKey();
                }
            }
        }
    }
}
