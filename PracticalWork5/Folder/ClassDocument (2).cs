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
            Console.WriteLine("Введите тест:");
            var text = Console.ReadLine();

            File.WriteAllText("text.txt", text);

        }
    }
}
