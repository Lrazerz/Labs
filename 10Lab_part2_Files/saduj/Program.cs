using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/* Заносити інформацію у початкові текстові файли можна у звичайному текстовому редакторі 
 * (зверніть увагу на те, що кодування повинне бути UTF-8). Вважати, що початкові файли містять рядки. 
 * Рядок складається зі слів, розділених пробілами (і пробіл може бути не один). 
 * У параметрах методів повинно передаватися ім’я файлу, а не об’єкт відповідного потоку.
 * Передбачити обробку стандартних виключних ситуацій для роботи з файлами.
При роботі з рядками потрібно звертати увагу на те, що рядок є типом-посиланням, який містить масив символів, 
і що рядки є незмінюваними. Також при порівнянні рядків доцільно використовувати методи ToUpperCase() або ToLowerCase().
При розбитті рядків на масив слів варто використовувати метод Split(), який приймає роздільник у якості параметрів. 
У деяких задачах може бути доцільне використання регулярних виразів.*/

namespace sadui
{
    class Program
    {
        static string ValidCheck(string Fname, string FilePath)
        {
            bool TruthCheck = false;
            if (File.Exists(Fname))
            {
            }
            else
            {
                Console.WriteLine("файла по даному пути не существует, создаем файл по стандартному пути: " + FilePath);
                do
                {
                    TruthCheck = false;
                    Console.WriteLine("Введите имя файла без расширения");
                    Fname = Console.ReadLine();
                    for (int i = 0; i < Fname.Length; i++)
                    {
                        if (Path.GetInvalidFileNameChars().Contains(Fname[i]))
                        {
                            Console.WriteLine("Плохой символ: " + Fname[i]);
                            TruthCheck = true;
                        }
                    }
                    Fname = FilePath + Fname + ".txt";
                }
                while (TruthCheck | Fname == null);
            }
            return Fname;
        }

        static void Logic(string Filename1, string Filename2)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Filename1))
                {
                    using (StreamWriter sr2 = new StreamWriter(File.Create(Filename2)))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] liness = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int j = 0; j < liness.Length; j++)
                            {
                                sr2.WriteLine(liness[j]);
                            }
                            sr2.WriteLine();
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        static void Main(string[] args)
        {
            string Fname1, Fname2;
            const string FilePath = @"D:\Labs\FilesLab10part2\";
            Console.WriteLine("Введіть имя файла откуда читаем");
            Fname1 = Console.ReadLine();
            Console.WriteLine("Введіть имя файла куда записываем");
            Fname2 = Console.ReadLine();

            Fname1 = ValidCheck(Fname1, FilePath);
            Fname2 = ValidCheck(Fname2, FilePath);
            Logic(Fname1, Fname2); // запись, убирая все пробелы
        }
    }
}
