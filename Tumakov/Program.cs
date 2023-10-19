using System;

namespace Tumakov
{
    internal class Program
    {
        static void Lesson1()
        {
            Bank bank = new Bank(12313, 213, (BankTypes)1);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\tМеню");
                Console.WriteLine("a. Посмотреть данные");
                Console.WriteLine("b. Проверить номер счета");
                Console.WriteLine("c. Проверить баланс счета");
                Console.WriteLine("d. Проверить тип счета");
                Console.WriteLine("e. Изменить номер счета");
                Console.WriteLine("f. Изменить баланс счета");
                Console.WriteLine("g. Изменить тип счета");
                Console.WriteLine("q. Выйти");
                Console.WriteLine("Выберите опцию: ");
                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case 'a':
                        Console.WriteLine($"\nТекущий номер счета: {bank.GetAccountNumber()}\nТекущий баланс счета: {bank.GetAccountBalance()}\nТекущий тип счета: {bank.GetAccountBankType()}");
                        break;
                    case 'b':
                        Console.WriteLine($"\nТекущий номер счета: {bank.GetAccountNumber()}");
                        break;
                    case 'c':
                        Console.WriteLine($"\nТекущий баланс счета: {bank.GetAccountBalance()}");
                        break;
                    case 'd':
                        Console.WriteLine($"\nТекущий тип счета: {bank.GetAccountBankType()}");
                        break;
                    case 'e':
                        Console.WriteLine($"\nВведите новый номер счета:");
                        if (uint.TryParse(Console.ReadLine(), out uint newAccountNumber) && newAccountNumber > 0)
                        {
                            bank.UpdateAccountNumber(newAccountNumber);
                        }
                        else
                        {
                            Console.WriteLine("\nВведите корректный номер счета!");
                        }
                        break;
                    case 'f':
                        Console.WriteLine($"\nВведите новый баланс счета:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newAccountBalance) && newAccountBalance > 0)
                        {
                            bank.UpdateAccountBalance(newAccountBalance);
                        }
                        else
                        {
                            Console.WriteLine("\nВведите корректный баланс счета!");
                        }
                        break;
                    case 'g':
                        Console.WriteLine($"\nВведите новый тип счета:");
                        if (Enum.TryParse(Console.ReadLine(), out BankTypes newAccountType))
                        {
                            bank.UpdateAccountBankType(newAccountType);
                        }
                        else
                        {
                            Console.WriteLine("\nВведите корректный тип банковского счета(Сберегательный или Текущий)!");
                        }
                        break; ;
                    case 'q':
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nВыберите корректный пункт!");
                        break;

                }
            }
        }
        static void Lesson2()
        {
            SecondBank bank = new SecondBank(213, (BankTypes)1);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\tМеню");
                Console.WriteLine("a. Посмотреть данные");
                Console.WriteLine("b. Проверить номер счета");
                Console.WriteLine("c. Проверить баланс счета");
                Console.WriteLine("d. Проверить тип счета");
                Console.WriteLine("e. Изменить баланс счета");
                Console.WriteLine("f. Изменить тип счета");
                Console.WriteLine("q. Выйти");
                Console.WriteLine("Выберите опцию: ");
                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case 'a':
                        Console.WriteLine($"\nТекущий номер счета: {bank.GetAccountNumber()}\nТекущий баланс счета: {bank.GetAccountBalance()}\nТекущий тип счета: {bank.GetAccountBankType()}");
                        break;
                    case 'b':
                        Console.WriteLine($"\nТекущий номер счета: {bank.GetAccountNumber()}");
                        break;
                    case 'c':
                        Console.WriteLine($"\nТекущий баланс счета: {bank.GetAccountBalance()}");
                        break;
                    case 'd':
                        Console.WriteLine($"\nТекущий тип счета: {bank.GetAccountBankType()}");
                        break;
                    case 'e':
                        Console.WriteLine($"\nВведите новый баланс счета:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newAccountBalance) && newAccountBalance > 0)
                        {
                            bank.UpdateAccountBalance(newAccountBalance);
                        }
                        else
                        {
                            Console.WriteLine("\nВведите корректный баланс счета!");
                        }
                        break;
                    case 'f':
                        Console.WriteLine($"\nВведите новый тип счета:");
                        if (Enum.TryParse(Console.ReadLine(), out BankTypes newAccountType))
                        {
                            bank.UpdateAccountBankType(newAccountType);
                        }
                        else
                        {
                            Console.WriteLine("\nВведите корректный тип банковского счета(Сберегательный или Текущий)!");
                        }
                        break; ;
                    case 'q':
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nВыберите корректный пункт!");
                        break;

                }
            }
        }
        static void Lesson3()
        {
            SecondBank bank = new SecondBank(213, (BankTypes)1);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\tМеню");
                Console.WriteLine("a. Посмотреть данные");
                Console.WriteLine("b. Проверить номер счета");
                Console.WriteLine("c. Проверить баланс счета");
                Console.WriteLine("d. Проверить тип счета");
                Console.WriteLine("e. Изменить баланс счета");
                Console.WriteLine("f. Пополнить баланс счета");
                Console.WriteLine("g. Снять баланс со счета");
                Console.WriteLine("h. Изменить тип счета");
                Console.WriteLine("q. Выйти");
                Console.WriteLine("Выберите опцию: ");
                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case 'a':
                        Console.WriteLine($"\nТекущий номер счета: {bank.GetAccountNumber()}\nТекущий баланс счета: {bank.GetAccountBalance()}\nТекущий тип счета: {bank.GetAccountBankType()}");
                        break;
                    case 'b':
                        Console.WriteLine($"\nТекущий номер счета: {bank.GetAccountNumber()}");
                        break;
                    case 'c':
                        Console.WriteLine($"\nТекущий баланс счета: {bank.GetAccountBalance()}");
                        break;
                    case 'd':
                        Console.WriteLine($"\nТекущий тип счета: {bank.GetAccountBankType()}");
                        break;
                    case 'e':
                        Console.WriteLine($"\nВведите новый баланс счета:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newAccountBalance) && newAccountBalance > 0)
                        {
                            bank.UpdateAccountBalance(newAccountBalance);
                        }
                        else
                        {
                            Console.WriteLine("Введите корректный баланс счета!");
                        }
                        break;
                    case 'f':
                        Console.WriteLine($"\nНа сколько вы хотите пополнить баланс?:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newReplenishAccountBalance) && newReplenishAccountBalance > 0)
                        {
                            bank.ReplenishAccountBalance(newReplenishAccountBalance);
                        }
                        else
                        {
                            Console.WriteLine("Введите корректное значение!");
                        }
                        break;
                    case 'g':
                        Console.WriteLine($"\nСколько денег вы хотите снять со счета?:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newWithdrawAccountBalance) && newWithdrawAccountBalance > 0)
                        {
                            bank.WithdrawAccountBalance(newWithdrawAccountBalance);
                        }
                        else
                        {
                            Console.WriteLine("Введите корректное значение!!");
                        }
                        break;
                    case 'h':
                        Console.WriteLine($"\nВведите новый тип счета:");
                        if (Enum.TryParse(Console.ReadLine(), out BankTypes newAccountType))
                        {
                            bank.UpdateAccountBankType(newAccountType);
                        }
                        else
                        {
                            Console.WriteLine("Введите корректный тип банковского счета(Сберегательный или Текущий)!");
                        }
                        break; ;
                    case 'q':
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nВыберите корректный пункт!");
                        break;

                }
            }
        }
        static void Main(string[] args)
        {
            Lesson1();
            Lesson2();
            Lesson3();
        }
    }
}
