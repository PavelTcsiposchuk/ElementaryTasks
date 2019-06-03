﻿using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7Sequence
{
    class UI : BaseUI
    {
        public static int GetNaturalNumberFromConsole()
        {
            bool isReaded = false;
            int result = 0;

            while (!isReaded)
            {
                UI.ShowMessage("Введите целое натуральное число");
                isReaded = Int32.TryParse(Console.ReadLine(), out result);
                if (isReaded)
                {
                    isReaded = result > 0;
                }
                else
                {
                    UI.ShowError("Вы ввели не целое число");
                }
                if (!isReaded)
                {
                    UI.ShowError("Вы ввели не натуральное число");
                }
            }

            return result;

        }

        internal static void PrintResult(string[] args, IEnumerable<int> enumerable)
        {
            
        }

        public static void ShowInstruction()
        {
            Console.WriteLine("Программа выводит ряд натуральных чисел через запятую, квадрат которых меньше заданного n.");
        }
    }
}
