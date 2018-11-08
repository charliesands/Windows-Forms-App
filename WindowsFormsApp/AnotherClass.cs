using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class AnotherClass
    {
        public static void Main()
        {
            MessageBox.Show("Pow!");
            Application.EnableVisualStyles();
            Application.Run(new Form1());

        }
    }
}
