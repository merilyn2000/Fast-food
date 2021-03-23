using System;
using System.Collections.Generic;

namespace FastFood
{
    class UI
    {
        Service service;

        public UI(Service serv)
        {
            this.service = serv;
        }

        public void ShowMeniuri()
        {
            List<Menu> meniuri = service.getAll();

            foreach (Menu meniu in meniuri)
            {
                Console.WriteLine($"{meniu.Nume}--->{meniu.Pret} (RON) ");
            }
        }

        public void ShowAdminMenu()
        {
            Console.WriteLine("\n0.Exit");
            Console.WriteLine("1.Adaugati produs");
            Console.WriteLine("2.Eliminati produs");
            Console.WriteLine("3.Vezi toate meniurile");
        }

        public void ShowClientMenu(List<Menu> meniuri)
        {
            Console.WriteLine("\n0.Exit");
            Console.WriteLine("\n");
            Console.WriteLine("Doriti meniu mare pentru inca doar 2.5 RON ?");
            Console.WriteLine("1. DA !");
            Console.WriteLine("2. NU !");
            Console.WriteLine("\n");
            Console.WriteLine("Doriti si sos pentru inca doar 2 RON?");
            Console.WriteLine("3. DA !");
            Console.WriteLine("4. NU !");
            Console.WriteLine("\n");
            for (int i = 0; i < meniuri.Count; i++)
            {
                int IMenu = i + 1;
                string nume = meniuri[i].Nume;
                double pret = meniuri[i].Pret;
                int val = meniuri[i].ValoareaEnergetica;
                int stoc = meniuri[i].Stoc;
                Console.WriteLine($"Meniul : {IMenu}.{nume}.(kl : {val}) cu pretul de : {pret} RON " +
                                  $" .  Au ramas doar : {stoc} meniuri de acest tip !");
                Console.WriteLine("\n");
            }
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("\n0.Exit");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.Client");
        }

        public Menu AdaugatiProdus()
        {
            Console.WriteLine("Nume :");
            string name = Console.ReadLine();

            Console.WriteLine("\nPret :");
            double pret = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("RON");

            Console.WriteLine("\nBautura inclusa ?");
            bool bautura = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(":)");

            Console.WriteLine("\nSos :");
            bool sos = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(":)");

            Console.WriteLine("\nValoarea energetica :");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kilocalorii");

            Console.WriteLine("\nStoc :");
            int stoc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Buc");

            Menu menu = new Menu()
            {
                Nume = name,
                Pret = pret,
                BauturaInclusa = bautura,
                SosInclus = sos,
                ValoareaEnergetica = val,
                Stoc = stoc
            };

            return menu;
        }

        public void EliminatiProdus()
        {
            Console.WriteLine("Ce produs doriti sa elimianti ?");
            int i = Convert.ToInt32(Console.ReadLine());
            service.remove(i);
        }

        public void MainMenu()
        {
            Console.WriteLine("Welcome to the Los Pollos Hermanos ! :) ");
            bool x = true;
            while (x)
            {
                ShowMainMenu();
                string acces = Console.ReadLine();

                switch (acces)
                {
                    case "0":
                        {
                            x = false;
                            break;
                        }
                    case "1":
                        {
                            AdminMenu();
                            break;
                        }
                    case "2":
                        {
                            ClientMenu();
                            break;
                        }
                }

            }
        }

        public void ClientMenu()
        {
            Console.Clear();
            Console.WriteLine("CHOOSE WISELY !");
            bool x = true;
            while (x)
            {

                var meniuri = service.getAll();
                ShowClientMenu(meniuri);

                string acces = Console.ReadLine();
                Console.Clear();

                switch (acces)
                {
                    case "0":
                        {
                            Console.Clear();
                            Console.WriteLine("You're welcome !");
                            x = false;
                            break;
                        }
                    case "1":
                        {
                            Console.WriteLine("A wise choice !");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Not a very wise choice !");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("I see u are a man of culture aswell !");
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Shame !");
                            break;
                        }
                }
            }
        }

        public void AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("--->ADMIN<---");
            bool x = true;
            while (x)
            {
                ShowAdminMenu();
                string acces = Console.ReadLine();

                switch (acces)
                {
                    case "0":
                        {
                            Console.Clear();
                            x = false;
                            break;
                        }
                    case "1":
                        {

                            Menu menu = AdaugatiProdus();
                            service.add(menu);
                            break;
                        }
                    case "2":
                        {
                            EliminatiProdus();
                            break;
                        }
                    case "3":
                        {
                            ShowMeniuri();
                            break;
                        }
                }
            }
        }
    }
}
