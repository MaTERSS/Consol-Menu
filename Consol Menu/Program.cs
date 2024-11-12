/* При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды. 
  Т.е. вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды. 

Меню должно содержать следующие команды:
- пара команд на вывод разного текста
- команда показать случайное число
- команда очистить консоль
- команда выхода

Если решение строится на switch, то принято работать с константами (в остальных случаях объявляются переменные).*/
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            const string CommandShowFirstText = "1";
            const string CommandShowSecondText = "2";
            const string CommandShowRandomNumber = "3";
            const string CommandClearConsole = "4";
            const string CommandExit = "5";

            Random random = new Random();
            int maxNumber = 34;
            int number = random.Next(0, maxNumber);
            bool isWork = true;

            Console.ForegroundColor = ConsoleColor.Red;                 
            
            while (isWork) 
            { 
                Console.WriteLine("Перед вами небольшое консольное меню, выберите действие:\n1.Вывод первого варианта текста.\n2.Вывод второго варианта текста.\n3.Показ случайного числа.\n4.Очистить консоль.\n5.Выход.");    
                
                string userInput = Console.ReadLine();
            
                switch (userInput)
                {
                    case CommandShowFirstText:
                        Console.WriteLine("1.Компьютерная программа, набор (обычно последовательность) инструкций, реализующий алгоритм решения некоторой задачи, которая может быть выполнена на компьютере; компонент программного обеспечения. Процесс составления компьютерной программы называется программированием.");
                        break;

                    case CommandShowSecondText:
                        Console.WriteLine("2.Информационная безопасность – это сохранение и защита информации, а также ее важнейших элементов, в том числе системы и оборудование, предназначенные для использования, сбережения и передачи этой информации. Другими словами, это набор технологий, стандартов и методов управления, которые необходимы для защиты информационной безопасности.");
                        break;

                    case CommandShowRandomNumber:
                        Console.WriteLine($"3.Сгенерированное число: {number}");
                        break;

                    case CommandClearConsole:
                        Console.Clear();
                        break; 

                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Завершение работы...");
                        break;

                    default:
                        Console.WriteLine("Извините такая команда отсутствует...");
                        break;  
                }
            }
        }
    }
}
