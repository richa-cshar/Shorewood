
using Animalerie.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Animalerie.Utils.Tools;

namespace Shorewood.Core
{
    class Welcome
    {
        private List<Personnage> list { get; set; }
        private static int x = 5;
        private static int y = 5;

        public Welcome()
        {
            list = new List<Personnage>();
            Start();
        }
        public void Init()
        {
            Animated(5, y++, 5, $"╔════════════════════════════╗");
            Animated(5, y++, 5, $"║  Bienvenue à Shorewood     ║");
            Animated(5, y++, 5, $"╚════════════════════════════╝");
            Continue(5, y, 5);
        }
        public ConsoleKey Menu(bool byPass=false)
        {
            Console.Clear();
            x = 5;
            y = 5;

            Animated(x, y++, 5, $"╔════════════════════════════╗");
            Animated(x, y++, 5, $"║         PERSONNAGE         ║");
            Animated(x, y++, 5, $"╠════════════════════════════╣");
            Animated(x, y++, 5, $"║ 1. HEROS                   ║");
            Animated(x, y++, 5, $"║ 2. MONSTRES                ║");
            Animated(x, y++, 5, $"║ 5. Quitter                 ║");
            Animated(x, y++, 5, $"╚════════════════════════════╝");

            if (!byPass)
            {
                Animated(x, y++, 5, "Faites un choix : ");
                ConsoleKey response = Console.ReadKey().Key;
                return response;
            }

            return ConsoleKey.A;
        }
        public ConsoleKey SubMenuHeros()
        {
            x = 35;
            y = 8;

            Animated(x, y++, 5, $"╔════════════════════════════╗");
            Animated(x, y++, 5, $"║      Encoder les héros     ║");
            Animated(x, y++, 5, $"╠════════════════════════════╣");
            Animated(x, y++, 5, $"║ 1. Humain                  ║");
            Animated(x, y++, 5, $"║ 2. Nain                    ║");
            Animated(x, y++, 5, $"║ 3. Retour                  ║");
            Animated(x, y++, 5, $"╚════════════════════════════╝");
            Animated(x, y++, 5, "Faites un choix : ");

            ConsoleKey response = Console.ReadKey().Key;
            return response;
        }
        public ConsoleKey SubMenuMonstres()
        {
            x = 35;
            y = 8;

            Animated(x, y++, 5, $"╔════════════════════════════╗");
            Animated(x, y++, 5, $"║    Encoder les Monstres    ║");
            Animated(x, y++, 5, $"╠════════════════════════════╣");
            Animated(x, y++, 5, $"║ 1. Loop                    ║");
            Animated(x, y++, 5, $"║ 2. Dragonnet               ║");
            Animated(x, y++, 5, $"║ 3. Orque                   ║");
            Animated(x, y++, 5, $"║ 4. Retour                  ║");
            Animated(x, y++, 5, $"╚════════════════════════════╝");
            Animated(x, y++, 5, "Faites un choix : ");

            ConsoleKey response = Console.ReadKey().Key;
            return response;
        }
        private void Start()
        {
            ConsoleKey choice = ConsoleKey.A;
            Init();
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case ConsoleKey.NumPad1:
                        do
                        {
                            choice = SubMenuHeros();
                            switch (choice)
                            {
                                case ConsoleKey.NumPad1:
                                    //list.Add(EncoderChien());
                                    Menu(true);
                                    break;
                                case ConsoleKey.NumPad2:
                                    //list.Add(EncoderChat());
                                    Menu(true);
                                    break;
                                case ConsoleKey.NumPad3:
                                    //list.Add(EncoderOiseau());
                                    Menu(true);
                                    break;
                                case ConsoleKey.NumPad4:
                                    RemoveSquare(x, Console.BufferWidth, 0, ++y, "Press a Key to Continue");
                                    break;
                                default:
                                    Animated(x, y++, 5, "Choix Incorrect!");
                                    RemoveSquare(x, Console.BufferWidth, 0, ++y, "Press a Key to Continue");
                                    break;

                            }
                        } while (choice != ConsoleKey.NumPad4);
                        break;
                    //case ConsoleKey.NumPad2: AfficherLesAnimaux(); break;
                    //case ConsoleKey.NumPad3: FairePasserLeTemps(); break;
                    //case ConsoleKey.NumPad4: FaireLesComptes(); break;
                    case ConsoleKey.NumPad5:
                        Animated(x, y++, 5, "A la prochaine...");
                        Continue(x, y, 5);
                        break;
                    default:
                        Animated(x, y++, 5, "Choix Incorrect!");
                        Continue(x, y, 5);
                        break;
                }
            } while (choice != ConsoleKey.NumPad5);
        }




    }
}
