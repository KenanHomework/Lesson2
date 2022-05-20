using WinFormsApp1.Task_2;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //UserLoader userLoader = new UserLoader();
            //userLoader.ShowDialog();
            while (true)
            {

                Start start = new Start();
                start.ShowDialog();
                if (start.ChangeTask1)
                {
                    start.Close();
                    UserLoader userLoader = new UserLoader();
                    userLoader.ShowDialog();
                    if (!userLoader.GoBack)
                        break;

                }
                else if (start.ChangeTask2)
                {
                    start.Close();
                    Calculator calculator = new Calculator();
                    calculator.ShowDialog();
                }
                else
                    break;
            }
        }
    }
}