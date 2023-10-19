using System;
using System.Collections.Generic;

namespace TumakovHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 7.1");
            List<Build> builds = new List<Build>();
            Build build1 = new Build(189.34, 10, 120, 10);
            Build build2 = new Build(180, 10, 80, 5);
            builds.Add(build1);
            builds.Add(build2);
            Build userbuild = new Build();

            bool pickup = true;
            while (pickup)
            {
                Console.WriteLine("\tМеню");
                Console.WriteLine("a. Посмотреть данные о зданиях");
                Console.WriteLine("b. Добавить новое здание");
                Console.WriteLine("c. Выбрать конкретное здание");
                Console.WriteLine("q. Выйти");
                Console.WriteLine("Выберите опцию: ");
                char option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case 'a':
                        Console.WriteLine();
                        foreach (var el in builds)
                        {
                            el.GetInfoOfBuild();
                            Console.WriteLine();
                        }
                        break;
                    case 'b':
                        Console.WriteLine("\nВведите высоту здания, количество этажей, количество квартир и количество подъездов(с новой строки): ");
                        if (double.TryParse(Console.ReadLine(), out double height) && (uint.TryParse(Console.ReadLine(), out uint floors)) && uint.TryParse(Console.ReadLine(), out uint apartments) && uint.TryParse(Console.ReadLine(), out uint entrances))
                        {
                            if (apartments % floors == 0 && apartments % entrances == 0)
                            {
                                userbuild.SetDataOfBuild(height, floors, apartments, entrances);
                                builds.Add(userbuild);
                                Console.WriteLine("Здание успешно добавлено!");
                            }
                            else
                            {
                                Console.WriteLine("Введите значения так, чтобы количество квартир было кратно количеству подъездов и количеству этажей!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введите корректные значения!");
                        }
                        break;
                    case 'c':
                        Console.WriteLine($"\nВыберите здание (0 - {builds.Count - 1})");
                        if (uint.TryParse(Console.ReadLine(), out uint buildChoice) && (buildChoice <= builds.Count - 1))
                        {
                            bool flag = true;
                            while (flag)
                            {
                                Console.WriteLine("\tМеню");
                                Console.WriteLine("a. Посмотреть данные о здании");
                                Console.WriteLine("b. Узнать высоту этажа");
                                Console.WriteLine("c. Узнать количество квартир на этаже");
                                Console.WriteLine("d. Узнать количество квартир в подъезде");
                                Console.WriteLine("q. Выйти");
                                Console.WriteLine("Выберите опцию: ");
                                char choice = Console.ReadKey().KeyChar;
                                switch (choice)
                                {
                                    case 'a':
                                        Console.WriteLine();
                                        builds[(int)buildChoice].GetInfoOfBuild();
                                        break;
                                    case 'b':
                                        Console.WriteLine($"Высота этажа здания {buildChoice} равна {builds[(int)buildChoice].CalculateHeighPerFloor()}");
                                        break;
                                    case 'c':
                                        Console.WriteLine($"Количество квартир в подъезде здания {buildChoice} равна {builds[(int)buildChoice].CalculateApartmentsPerEntrances()}");
                                        break;
                                    case 'd':
                                        Console.WriteLine($"Количество квартир на этаже здания {buildChoice} равна {builds[(int)buildChoice].CalculateApartmentsPerFloors()}");
                                        break;
                                    case 'q':
                                        flag = false;
                                        break;
                                    default: Console.WriteLine("\nВыберите опцию из меню!"); break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Введите корректный номер здания!!!");
                        }
                        break;
                    case 'q':
                        pickup = false;
                        break;
                    default: Console.WriteLine("\nВыберите корректную опцию!"); break;
                }
            }
        }
    }
}
