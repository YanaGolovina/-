using System;

namespace ConsoleApp1
{
        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Введите начальную позицию фигуры");
                string firstNum = Console.ReadLine();
                Console.WriteLine("Введите вторую позицию фигуры");
                string secondNum = Console.ReadLine();
                Console.WriteLine("Введите название фигуры(на русском) ");
                string figure =  Console.ReadLine();

            if (figure == "Конь" || figure == "конь")
            {
                IsQueenRight(firstNum, secondNum, out string answer);
                Console.WriteLine(answer);
            }
            else if (figure == "Король" || figure == "король")
            {
                IsQueenRight(firstNum, secondNum, out string answer);
                Console.WriteLine(answer);
            }
            else if (figure == "Ладья" || figure == "ладья")
            {
                IsQueenRight(firstNum, secondNum, out string answer);
                Console.WriteLine(answer);
            }
            else if (figure == "Пешка" || figure == "пешка")
            {
                IsQueenRight(firstNum, secondNum, out string answer);
                Console.WriteLine(answer);
            }
            else if (figure == "слон" || figure == "Слон" || figure == "офицер" || figure == "Офицер")
            {
                IsQueenRight(firstNum, secondNum, out string answer);
                Console.WriteLine(answer);
            }
            else if (figure == "Ферзь" || figure == "ферзь" || figure == "Королева" || figure == "королева")
            {
                IsQueenRight(firstNum, secondNum, out string answer);
                Console.WriteLine(answer);
            }
            else
                Console.WriteLine("Такой фигуры нет");
                Console.ReadKey();

            }
            static void IsHorseRight(string x, string y, out string answer)
            {
            
                char[] fPosition = x.ToCharArray();
                char[] sPosition = y.ToCharArray();
            if ((fPosition[0] > 'H') || (fPosition[1] > '8')|| (sPosition[0] > 'H') || (sPosition[1] > '8'))
                     answer = "Не верно введены значения, их нет на шахматной доске";
               else if (((Math.Abs(fPosition[0] - sPosition[0]) == 1) & (Math.Abs(fPosition[1] - sPosition[1]) == 2))
                            || (Math.Abs(fPosition[0] - sPosition[0]) == 2) & (Math.Abs(fPosition[1] - sPosition[1]) == 1))
                    {
                    answer = "Ход верный";
                    }

                else
                {
                    answer = "Ход неверный";
                }
            }
            static void IsRookRight(string x, string y, out string answer)
            {

                char[] fPosition = x.ToCharArray();
                char[] sPosition = y.ToCharArray();
                if ((fPosition[0] > 'H') || (fPosition[1] > '8') || (sPosition[0] > 'H') || (sPosition[1] > '8'))
                    answer = "Не верно введены значения, их нет на шахматной доске";
                else if (((Math.Abs(fPosition[0] - sPosition[0]) != 0) & (fPosition[1] == sPosition[1]))
                             || (fPosition[0] == sPosition[0]) & (Math.Abs(fPosition[1] - sPosition[1]) != 0))
                     {
                    answer = "Ход верный";
                     }

                else
                {
                    answer = "Ход неверный";
                }
            }
            static void IsPawnRight(string x, string y, out string answer)
            {

                char[] fPosition = x.ToCharArray();
                char[] sPosition = y.ToCharArray();
                if ((fPosition[0] > 'H') || (fPosition[1] > '8') || (sPosition[0] > 'H') || (sPosition[1] > '8'))
                    answer = "Не верно введены значения, их нет на шахматной доске";
                else if ((fPosition[0] == sPosition[0]) & ((sPosition[1] - fPosition[1]) < 3))
                {
                    answer = "Ход верный";
                }

                else
                {
                    answer = "Ход неверный";
                }
            }
        static void IsElephantRight(string x, string y, out string answer)
        {

            char[] fPosition = x.ToCharArray();
            char[] sPosition = y.ToCharArray();
            if ((fPosition[0] > 'H') || (fPosition[1] > '8') || (sPosition[0] > 'H') || (sPosition[1] > '8'))
                answer = "Не верно введены значения, их нет на шахматной доске";
            else if ((Math.Abs(fPosition[0] - sPosition[0]))==(Math.Abs(fPosition[1] - sPosition[1])))
            {
                answer = "Ход верный";
            }

            else
            {
                answer = "Ход неверный";
            }
        }
        static void IsQueenRight(string x, string y, out string answer)
        {

            char[] fPosition = x.ToCharArray();
            char[] sPosition = y.ToCharArray();
            if ((fPosition[0] > 'H') || (fPosition[1] > '8') || (sPosition[0] > 'H') || (sPosition[1] > '8'))
                answer = "Не верно введены значения, их нет на шахматной доске";
            else if ((Math.Abs(fPosition[0] - sPosition[0])) == (Math.Abs(fPosition[1] - sPosition[1]))
                        ||((Math.Abs(fPosition[0] - sPosition[0]) != 0) & (fPosition[1] == sPosition[1]))
                             || (fPosition[0] == sPosition[0]) & (Math.Abs(fPosition[1] - sPosition[1]) != 0))
            {
                answer = "Ход верный";
            }

            else
            {
                answer = "Ход неверный";
            }
        }
        static void IsKingRight(string x, string y, out string answer)
        {

            char[] fPosition = x.ToCharArray();
            char[] sPosition = y.ToCharArray();
            if ((fPosition[0] > 'H') || (fPosition[1] > '8') || (sPosition[0] > 'H') || (sPosition[1] > '8'))
                answer = "Не верно введены значения, их нет на шахматной доске";
            else if ((Math.Abs(fPosition[0] - sPosition[0]) ==1 & Math.Abs(fPosition[1] - sPosition[1]) == 1
                      & Math.Abs(fPosition[0] - sPosition[0])== Math.Abs(fPosition[1] - sPosition[1]))
                        || (Math.Abs(fPosition[0] - sPosition[0]) ==1 & fPosition[1] == sPosition[1])
                             || (fPosition[0] == sPosition[0] & Math.Abs(fPosition[1] - sPosition[1]) ==1))
            {
                answer = "Ход верный";
            }

            else
            {
                answer = "Ход неверный";
            }
        }
    }
    
}
