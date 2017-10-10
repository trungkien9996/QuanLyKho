using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Formhanghoa());
            //Application.Run(new FormKho());
            //Application.Run(new Formmain());
            //Application.Run(new FormNhap());
            //Application.Run(new FormPhieuNhap());
            //Application.Run(new FormPhieuXuat());
            //Application.Run(new Formtimkiem());
            //Application.Run(new FormXuat());
        }
    }
}
