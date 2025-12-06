using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BabetaMaster
{
    public class Engine 
    {
       private Music music;
       public void Welcome()
        {
            
            music = new Music("WelcomeSong.wav");
            music.Play();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            System.Threading.Thread.Sleep(1000);

            Console.SetCursorPosition(55, 2);
            Console.WriteLine("Ahoj, vítaj v hre BabetaMaster");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(55, 4);
            Console.WriteLine("Táto hra je simuláciou života v obci s názvom Skalité.");
            Console.SetCursorPosition(55, 5);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Budeš hrať za postavu menom David, ktorý sa snaží opraviť svoju babetu.");
            Console.SetCursorPosition(55, 6);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Čaká na teba zoznam oprav, ktoré budeš musieť urobiť.");
            Console.SetCursorPosition(55, 7);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Taktiež budeš prechádzať rôznymi výzvami a veľa ďalším.");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(55, 9);
            Console.WriteLine("Odporúčam ti pozrieť si Nastavenia");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(55, 11);
            Console.WriteLine("Ak si pripravený stlač ENTER.");
            Console.ReadLine();
        }
        public void Settings()
        {
            while (true)
            {
                Console.Clear();
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 18);
                Console.WriteLine("Základné ovládanie hry:");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 20);
                Console.WriteLine("Pokračovať: ENTER");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 21);
                Console.WriteLine("Voziť sa na babete: W");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 22);
                Console.WriteLine("Opravovať babetu: O");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 23);
                Console.WriteLine("Brať veci: R");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 24);
                Console.WriteLine("Otvárať tašku: E");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(65, 25);
                Console.WriteLine("Vrátiť do menu z Nastavení: ESC");
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                {
                    return ;
                }
            }
        }
        public void Menu()
        {
            while (true)
            {
            music = new Music("MenuSong.wav");
            music.Play();
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(70, 20);
            Console.WriteLine("1. HRAŤ");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(70, 23);
            Console.WriteLine("2. NASTAVENIA");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(70, 26);
            Console.WriteLine("3. KONIEC");
            char input = char.ToLower(Console.ReadKey(true).KeyChar);
                switch (input)
                {
                    case '1':
                        
                        break;
                    case '2':
                        Settings();
                        break;
                    case '3':
                        music.Stop();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
