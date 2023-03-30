using System;
using System.IO;

namespace pracfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Directory.Exists(path)) Start(path);
            else { Console.WriteLine("Como es posible que no tengas Escritorio?"); }
        }

        public static void Start(string path)
        {
            using (StreamWriter sw = File.AppendText(path + "\\ignorame.txt"))
            {
                sw.WriteLine("Buenos dias querido usuario. Este archivo es un texto que usted no deberia de estar mirando bajo ningun concepto");
            }
            //Console.WriteLine(file[8]);
        }
    }
}
