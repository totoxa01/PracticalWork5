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

        private const string file = "binaryFile.bin";
      
        public static void BinaryFile()
        {          

            Console.WriteLine("Введите числа в диапазоне [0..255] через пробел");
            var input = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (input is null)
            {
                Console.WriteLine("Не корректный ввод чисел");
                return;
            }

            var array = new byte[input.Length];
            for (var i = 0; i < array.Length; i++)
            {
                if (!byte.TryParse(input[i], out var number))
                {
                    Console.WriteLine($"Не правильное число {input[i]}");
                    return;
                }

                array[i] = number;
            }

            SaveFileBinary(array);

            Console.WriteLine("Посмотрите, что сейчас в файле binaryFile.bin");
            Console.WriteLine("Прочитанный файл:");
            ReadFileBinary(array);
        }              

        private static void SaveFileBinary(byte[] array)
        {
            using (var bw = new BinaryWriter(File.OpenWrite(file)))
            {
                bw.Write(array);
                bw.Flush();
            }
        }

        private static void ReadFileBinary(byte[] array)
        {
            byte[] newData;
            using (var br = new BinaryReader(File.OpenRead(file)))
            {
                newData = br.ReadBytes(array.Length);
            }

            for (var i = 0; i < newData.Length; i++)
            {
                Console.Write(newData[i] + " ");
            }
        }

       
    }
}
