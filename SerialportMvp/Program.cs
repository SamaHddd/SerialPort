using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialportMvp.View;
using SerialportMvp.Presenter;

namespace SerialportMvp
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form= new Form1();
            var formPersenter=new SerialportPersenter(form);
            Application.Run(form);
        }
    }
}
