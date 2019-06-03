using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class BaseUI
    {
        public static void PrintIEnumerable<T>(IEnumerable<T> enumerable)
        {
            string print = String.Join(",", enumerable);
            ShowResult(print);

        }
        public static void ShowError(string message)
        {
            Console.Write(message);
        }
        
        protected static void ShowInstructionWrongPath()
        {
            Console.WriteLine("Ошибка, по указанному пути файла не существует");
            Console.WriteLine("Введите еще раз, пример - D:\\\\Папка\\\\Filename.txt ");
        }

        public static void ShowResult(string message)
        {
            Console.WriteLine(message);
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static bool AskUserAboutEndProgram()
        {
            bool isEndSession = true;
            string response = Console.ReadLine();
            response = response.ToUpperInvariant();
            if (response == "YES" || response == "Y")
            {
                isEndSession = false;
            }
            

            return isEndSession;
        }
    }
}
