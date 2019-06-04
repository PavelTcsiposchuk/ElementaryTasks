using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller application = new Controller();

            StartApplication(args, application);
            while (!application.IsSuccessful)
            {
                StartApplicationWithoutArgs(application);
            }

            Console.ReadLine();
        }

        private static void StartApplicationWithoutArgs(Controller application)
        {
            try
            {
                application.Run();
            }
            catch (ArgumentException ex)
            {
                UI.ShowError(ex.Message);
            }
        }

        private static void StartApplication(string[] args, Controller application)
        {
            try
            {
                application.Run(args);
            }
            catch (ArgumentException ex)
            {
                UI.ShowError(ex.Message);
            }
        }

    }
}
