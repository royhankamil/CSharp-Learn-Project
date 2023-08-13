using System;

namespace Program
{

    class SyntaxGame
    {
        public static string? name;
        static int index = 0;

        public SyntaxGame()
        {
            index++;
        }

        public string SelectingThree(string question, string selector1, string selector2, string selector3, bool sleep = true, int time = 2000)
        {
            short onSelector = 0;

            if (sleep)
                Thread.Sleep(time);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(question);
                if (onSelector == 0)
                {
                    Console.WriteLine("==> " + selector1);
                    Console.WriteLine("    " + selector2);
                    Console.WriteLine("    " + selector3);
                }
                else if (onSelector == 1){
                    Console.WriteLine("    " + selector1);
                    Console.WriteLine("==> " + selector2);
                    Console.WriteLine("    " + selector3);
                }
                else if (onSelector == 2){
                    Console.WriteLine("    " + selector1);
                    Console.WriteLine("    " + selector2);
                    Console.WriteLine("==> " + selector3);
                }
                
                char theInput = (char)Console.ReadKey(false).Key;
                if (theInput == (char)ConsoleKey.UpArrow)
                {
                    if (onSelector != 0)
                        onSelector--;
                    else
                        onSelector = 2;
                }
                else if (theInput == (char)ConsoleKey.DownArrow)
                {
                    if (onSelector != 2)
                        onSelector++;
                    else
                        onSelector = 0;
                }
                else if (theInput == (char)ConsoleKey.Enter)
                {
                    string[] resultOf = {selector1, selector2, selector3};
                    Console.WriteLine();
                    return resultOf[onSelector];     
                }
            }

        }

        public string SelectingTwo(string question, string selector1, string selector2, bool sleep = true, int time = 2000)
        {
            bool isSelectOne = true;
            string resultOf;

            if (sleep)
                Thread.Sleep(time);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(question);
                if (isSelectOne == true)
                {
                    Console.WriteLine("==> " + selector1);
                    Console.WriteLine("    " + selector2);
                }
                else{
                    Console.WriteLine("    " + selector1);
                    Console.WriteLine("==> " + selector2);
                }
                
                char theInput = (char)Console.ReadKey(false).Key;
                if (theInput == (char)ConsoleKey.UpArrow || theInput == (char)ConsoleKey.DownArrow)
                {
                    isSelectOne = isSelectOne? false : true; 
                }
                else if (theInput == (char)ConsoleKey.Enter)
                {
                    resultOf = isSelectOne? selector1 : selector2;
                    Console.WriteLine();
                    return resultOf;     
                }
            }
        }

        public void PeopleSay(string talk, int time = 100, bool newline = true, string name ="Dudung")
        {
            if (name == "")
                name = SyntaxGame.name;
            
            talk = name + ": \"" + talk + "\"";

            foreach(char letter in talk)
            {
                Thread.Sleep(time);
                Console.Write(letter);
            }
            if (newline == true)
                Console.WriteLine();

        }



        public void GoTalk(string talk, int time = 100, bool newline = true)
        {
            foreach(char letter in talk)
            {
                Thread.Sleep(time);
                Console.Write(letter);
            }
            if (newline == true)
                Console.WriteLine();
        }

    }
}
