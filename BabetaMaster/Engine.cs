using System;
using System.Collections.Generic;
using System.Text;

namespace BabetaMaster
{
    public class Engine
    {
       public void Welcome()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            System.Threading.Thread.Sleep(1000);

            Console.SetCursorPosition(50, 2);
            Console.WriteLine("Ahoj, vítaj v hre BabetaMaster");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("Táto hra je simuláciou života v obci s názvom Skalité.");
            Console.SetCursorPosition(50, 4);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Budeš hrať za postavu menom David, ktorý sa snáži opraviť svoju babetu.");
            Console.SetCursorPosition(50, 5);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Čakajú ťa rôzne výzvy, ktoré budeš musieť splniť.");
            Console.SetCursorPosition(50, 6);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Ak si pripravený môžeme začať");
            Console.ReadLine();
        }
    }
}
