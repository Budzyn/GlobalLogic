using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GL
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            FolderBrowserDialog db = new FolderBrowserDialog();
            if(db.ShowDialog()==DialogResult.OK)
            {
                foreach(var path in Directory.GetFiles(db.SelectedPath))
                {
                    Console.WriteLine(path);
                    Console.WriteLine(System.IO.Path.GetFileName(path));
                }
            }
            Console.ReadKey();
        }
    }
}
