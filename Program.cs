using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);//запрос системной граф пикселей
            Application.EnableVisualStyles();//строчка которая использует окна как принято в своей опер.системе
            Application.SetCompatibleTextRenderingDefault(false);//тексты в приложении
            Application.Run(new Form1());
        }
    }
}
