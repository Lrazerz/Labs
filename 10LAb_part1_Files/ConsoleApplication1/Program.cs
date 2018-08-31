using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Оскільки вручну бінарний файл створити не можна, заносити інформацію у бінарний файл потрібно окремим методом. 
 * Після його виконання решта програми повинна бути написана так, щоб вона могла працювати з довільним файлом,
 * а не лише із щойно створеним (тобто не можна використовувати ту інформацію, яка у вас є за рахунок того, 
 * що ви створюєте файл програмно). Нехай заданий файл цілих чисел f1. Визначити, чи впорядковані числа у файлі 
 * (у порядку зростання або спадання).*/

namespace ConsoleApplication1
{
    class Program
    {
        static string ValidCheck(string BinPath, string DefoltPath)
        {
            string Filename = null;
            bool BoolCheck = false;
            try
            {
                if (File.Exists(BinPath))
                {
                    Console.WriteLine("Путь к файлу введен верно");
                    Filename = BinPath;
                }
                else
                {
                    Console.WriteLine("Создаем файл по стандартному пути: {0}", DefoltPath);
                    do
                    {
                        BoolCheck = false;
                        Console.WriteLine("Введите имя файла");
                        BinPath = Console.ReadLine();
                        for (int i = 0; i < BinPath.Length; i++)
                        {
                            if (Path.GetInvalidFileNameChars().Contains(BinPath[i]))
                            {
                                Console.WriteLine("Плохой символ: " + BinPath[i]);
                                BoolCheck = true;
                                continue;
                            }
                        }
                    } while (BoolCheck || BinPath == null);
                    Filename = (DefoltPath + BinPath);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Filename;
        }
        static void Writer(string FilePath)
        {
            int x = 0, n;
            string temp;

            Console.WriteLine("Сколько чисел запишем");
            try {

                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите {0} чисел", n);
                using (BinaryWriter binwriter = new BinaryWriter(File.Open(FilePath, FileMode.Create, FileAccess.Write)))
                {
                    int i = 0;
                    while (i < n)
                    {
                        temp = Console.ReadLine();
                        if (Int32.TryParse(temp, out x))
                        {
                            binwriter.Write(x);
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Enter the number");
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        static int Logic(string FilePath)
        {
            int number;
            int check = -2; // '1' - по возрастанию, '-1' - по убыванию, '0' - не упорядочены
            int Reading;
            using (BinaryReader reader = new BinaryReader(File.Open((FilePath), FileMode.Open, FileAccess.ReadWrite)))
            {
                number = reader.ReadInt32();// 1 елемент
                Reading = reader.ReadInt32();// ост елемент
                if (Reading == number)
                {
                    number = Reading;
                    for (int i = (int)reader.BaseStream.Position; i <= (int)reader.BaseStream.Length; i+=8)
                    {
                        Reading = reader.ReadInt32();
                        if (number != Reading)
                        {
                            break;
                        }
                        number = Reading;
                    }
                }
                if (Reading > number)
                {
                    number = Reading;
                    for (int i = (int)reader.BaseStream.Position; i <= (int)reader.BaseStream.Length; i+=8)
                    {
                        Reading = reader.ReadInt32();
                        if (Reading < number)
                        {
                            check = 0;
                            break;
                        }
                        number = Reading;
                    }
                    if (check != 0)
                        return check = 1;
                }
                else if (Reading < number)
                {
                    number = Reading;
                    for (int i = (int)reader.BaseStream.Position; i <= (int)reader.BaseStream.Length; i+=8)
                    {
                        Reading = reader.ReadInt32();
                        if (Reading > number)
                        {
                            check = 0;
                            break;
                        }
                        number = Reading;
                    }
                    if (check != 0)
                        return check = -1;
                }
                return check;
            }
        }
            
        static void Check(int g)
        {
                if (g == 1)
                {
                    Console.WriteLine("Числа у файлі впорядковані у порядку зростання");
                }
                else if (g == -1)
                {
                    Console.WriteLine("Числа у файлі впорядковані у порядку спадання");
                }
                else
                {
                    Console.WriteLine("Числа у файлі не впорядковані  *(в порядку зростання/спадання)");
                Console.WriteLine(g);
                }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string DefoltPath = @"D:\Labs\FilesLab10part1\";
            String FilePath;
            int g;
            Console.WriteLine("Введите путь к файлу");
            FilePath = Console.ReadLine();
           FilePath = ValidCheck(FilePath,DefoltPath);
                    Writer(FilePath);
                    g = Logic(FilePath);
                        Check(g);
         }

     }

}
