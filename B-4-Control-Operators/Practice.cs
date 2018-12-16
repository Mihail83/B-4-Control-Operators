using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            var current = DateTime.Now.Hour;
            if (current < 7)
            {
                Console.WriteLine("Мы спим");
            }
            else if (current < 12)
                {
                Console.WriteLine("Доброе утро!");
                }
                    else if (current < 18)
                        {
                            Console.WriteLine("Добрый день!");
                        }
                        else if (current < 24)
                             {
                                Console.WriteLine("Добрый вечер!");
                             }
        }
        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            Console.WriteLine("Введите значение Х");
            int valueX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            int valueY = Convert.ToInt32(Console.ReadLine());
            if (valueX == valueY)
                Console.WriteLine("Значения равны");
            else if (valueX < valueY)
                    Console.WriteLine($"X меньше Y на {valueY-valueX}");
                else
                    Console.WriteLine($"Y меньше X на {valueX - valueY}");
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            Console.WriteLine("Введите значение Х");
            int valueX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            int valueY = Convert.ToInt32(Console.ReadLine());
            if ((valueX >= 0) && (valueY >= 0))
            {
                if (valueX == valueY)
                    Console.WriteLine("Значения равны");
                else if (valueX < valueY)
                    Console.WriteLine($"X меньше Y на {valueY - valueX}");
                else
                    Console.WriteLine($"Y меньше X на {valueX - valueY}");
            }
            else Console.WriteLine("не работаю с отрицательными числами");

        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            Console.WriteLine("Загадывайте целое число от 1 до 10        легенда -   '+' да, '-' нет ");
            int min = 1;
            int max = 10;
            int middle = 5;
            while (true)
            {
                if (min == max)
                {
                    Console.WriteLine($"Вроде бы ответ {min}");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    

                }
                Console.WriteLine($"Загаданное число больше {middle} ?");
                char answer = Convert.ToChar(Console.ReadLine());                
                if (!answer.Equals('+') && !answer.Equals('-'))
                {
                    Console.WriteLine("Непонятный ответ...");
                    continue;
                }
                if (answer.Equals('+'))
                {
                    min = middle;
                    if ((min + max) / 2 != middle)
                    {
                        middle = ((min + max) / 2);
                    }
                    else min++;
                }
                else
                {                   
                    max = middle;
                    middle = ((min + max) / 2);
                }
            }

        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var today = DateTime.Now;
            var dayOfWeek = (Int32)today.DayOfWeek;
            switch (dayOfWeek){
                case 0:
                    Console.WriteLine("Доброго воскресенья");
                    break;
                case 1:
                    Console.WriteLine("Доброго понедельника");
                    break;
                case 2:
                    Console.WriteLine("Доброго вторника");
                    break;
                case 3:
                    Console.WriteLine("Доброй среды");
                    break;
                case 4:
                    Console.WriteLine("Доброго четверга");
                    break;
                case 5:
                    Console.WriteLine("Доброй пятницы ");
                    break;
                case 6:
                    Console.WriteLine("Доброй субботы");
                    break;
                
            }
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
           
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
        }
    }
}
