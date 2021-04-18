using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticalWork5.Folder
{
    class ClassDocument
    {
        public static void SaveInDocument()
        {           
            var path = "textFile.txt";
            
            using var fs = new FileStream(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate);
            using var sw = new StreamWriter(fs);


            Console.WriteLine("Введите данные для сохранения в текстовом файле и нажмите клавишу Esc для остановки");
            sw.AutoFlush = true;
            while (true)
            {
                var inputKey = Console.ReadKey();

                if (inputKey.Key == ConsoleKey.Escape)
                    break;
                if (inputKey.Key == ConsoleKey.Enter)
                {
                    sw.Write("\n");
                    Console.WriteLine();
                }
                else sw.Write(inputKey.KeyChar);
            }
                      
            Console.WriteLine("\n Запись осуществлена успешно");
        }

        
        public static void SaveDateNow()
        {
            using var sw = File.AppendText("startup.txt");
            var time = DateTime.Now.ToString("HH:mm:ss tt");
            sw.WriteLine(time);
            Console.WriteLine($"Добавляю новое время: {time}");
        }

        
    }
}
