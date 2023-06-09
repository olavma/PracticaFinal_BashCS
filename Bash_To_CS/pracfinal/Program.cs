﻿using System;
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
            StreamReader sr = File.OpenText(@"..\..\..\..\text\bd102.txt");
            string st = sr.ReadToEnd();
            sr.Close();

            string[] configLines = st.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            using (StreamWriter sw = File.AppendText(path + "\\ignorame.txt"))
            {
                sw.WriteLine(configLines[0]);

            }
            Joke();


            foreach (string line in configLines)
            {
                using (StreamWriter sw = File.AppendText(path + "\\ignorame.txt"))
                {
                    if (line != configLines[0])
                    {
                        sw.WriteLine(line);
                        System.Threading.Thread.Sleep(5000);
                    }
                }
            }

            // mv $ruta/ignorame.txt $ruta/Ejecutando/ > .archivo.sh    = archivo.bat
            // O solo crear la carpeta y mover ignorame.txt a esa carpeta sin crear un nuevo script
        }

        public static void Joke()
        {
            StreamReader sr = File.OpenText(@"..\..\..\..\text\bd103.txt");
            string st = sr.ReadToEnd();
            sr.Close();

            string[] configLines = st.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (string line in configLines)
            {
                Console.WriteLine(line);
                System.Threading.Thread.Sleep(3000);
            }
            Console.ResetColor();
        }
    }
}
