using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIB
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       // public static Menux f = new Menux();
       // public static Add_Revenue add = new Add_Revenue();
       // public static Show_Revenue show = new Show_Revenue();
        //public Menux f = new Menux();
        public static GlobalForm GF;
        [STAThread]
        
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GF = new GlobalForm();
            Application.Run(GF.MenuForm);

        }
    }    
}
