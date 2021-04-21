using System;

namespace PracticalWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Задание 1-------------------");
            Folder.ClassDocument.SaveInDocument();
            Console.WriteLine();
            Console.WriteLine("-------------------Задание 2-------------------");
            Folder.ClassDocument.SaveDateNow();
            Console.WriteLine();
            Console.WriteLine("-------------------Задание 3-------------------");
            Folder.ClassDocument.BinaryFile();
            Console.WriteLine();
            Console.WriteLine("-------------------Задание 4-------------------");
            Folder.ClassEmployee[] persArray = new Folder.ClassEmployee[5];
            persArray[0] = new Folder.ClassEmployee("Егоров Александр Михайлович", "Директор", "eaM@mail.ru", "+7-985-963-52-85", 250000, 65);
            persArray[1] = new Folder.ClassEmployee("Беспалый Георгий Валерьевич", "Менеджер", "bgV@mail.ru", "+7-852-963-41-52", 80000, 45);
            persArray[2] = new Folder.ClassEmployee("Абрамов Данил Александрович", "Заместитель директора по финансам", "adA@mail.ru", "+7-856-945-52-36", 200000, 36);
            persArray[3] = new Folder.ClassEmployee("Симановская Ирина Александровна", "Дизайнер", "siA@mail.ru", "+7-985-745-65-45", 135000, 25);
            persArray[4] = new Folder.ClassEmployee("Алинов Дмитрий Евгеньевич", "Главный бухгалтер", "adE@mail.ru", "+7-235-654-85-25", 220000, 42);

            
            for (int i = 0; i < persArray.Length; i++)
                if (persArray[i].age > 40)
                {
                    Console.WriteLine("!---------------------------!");
                    persArray[i].Print();
                }

        }
    }
}
