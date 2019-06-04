using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class BaseUI
    {
        /// <summary>
        /// Выводит любую последовательность через запятую в консоль
        /// </summary>
        /// <typeparam name="T">любой тип реализующий ToString()</typeparam>
        /// <param name="enumerable"></param>
        public static void PrintIEnumerable<T>(IEnumerable<T> enumerable)
        {
            string print = String.Join(",", enumerable);
            ShowMessage(print);

        }
        public static void ShowError(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// Выводит сообщения консоль о неверности пути к файлу и приводит пример корректного пути
        /// </summary>
        protected static void ShowInstructionWrongPath()
        {
            ShowMessage("Ошибка, по указанному пути файла не существует");
            ShowMessage("Введите еще раз, пример - D:\\\\Папка\\\\Filename.txt ");
        }
        /// <summary>
        /// Показывает сообщение пользователю
        /// </summary>
        /// <param name="message"></param>
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// Спрашивает пользователя хочет ли он продолжить. Ожидает ввод пользователем строки
        /// </summary>
        /// <returns>Возвращает true, если пользователем была введено y/Yes (без учета регистра) и false в ином случае</returns>
        public static bool AskUserAboutEndProgram()
        {
            ShowMessage("Вы хотите продолжить?");
            ShowMessage("Введите \"yes\" или \"y\", если да");
            
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
