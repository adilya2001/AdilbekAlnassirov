using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Stick.txt";
            string sourcePath = @"C:\Users\Куралай\source\repos\lab2\task4";
            string targetPath = @"C:\Users\Куралай\source\repos\lab2\task4\Magic";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }


            System.IO.File.Copy(sourceFile, destFile, true);


            if (System.IO.Directory.Exists(sourcePath))

            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);



                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);

                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
            if (System.IO.File.Exists(@"C:\Users\Куралай\source\repos\lab2\task4\stick")) ;

            try
            {
                System.IO.File.Delete(@"C:\Users\Куралай\source\repos\lab2\task4\stick.txt");

            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;

            }




        }











    }
}
