/* При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды. 
  Т.е. вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды. */
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;                        
            Console.WriteLine("Вы стоите перед выбором:\n1.пойти налево \n2.пойти направо");    
            string way;
            way = Console.ReadLine();
            switch (way)
            {
                case "1":
                    Console.WriteLine("вы выбрали путь воина");
                    break;
                case "2":
                    Console.WriteLine("вы выбрали путь мага");
                    break;
            }
        }
    }
}
