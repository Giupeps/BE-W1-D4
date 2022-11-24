using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BE_W1_D4
{
    internal static class Utente
    {
        private static string User { get; set; } = "Giuseppe";
        private static string Password { get; set; }
        private static string ConfermaPassword { get; set; }

        private static bool Logged { get; set; } = false;

        private static List<DateTime> ListaAccessi { get; set; } = new List<DateTime>();

        
        public static void Menu()
        {
            Console.WriteLine("=============Operazioni==============");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Logout");
            Console.WriteLine("3: Verifica ora e data di login");
            Console.WriteLine("4: Lista degli accessi");
            Console.WriteLine("5: Esci");

            string scelta = Console.ReadLine();

            if (scelta == "1")
            {
                Login();
            }
            else if(scelta == "2")
            {
                Logout();
            }
            else if (scelta == "3")
            {
                VerifyTime();
            }
            else if(scelta == "4")
            {
                AccessList();
            }
            else {
                Environment.Exit(0);
            }
        }

        public static void Login()
        {
            if (Logged == false)
            {
                Console.WriteLine("Digita l'username:");
                string nomeutente = Console.ReadLine();
                if (nomeutente != User)
                {
                    Console.WriteLine("Username non trovata");
                    Login();
                }

                Console.WriteLine("Digita la password:");
                Password = Console.ReadLine();
                Console.WriteLine("Conferma la password:");
                ConfermaPassword = Console.ReadLine();
                if (Password != ConfermaPassword)
                {
                    Console.WriteLine("La password non cambacia");
                    Login();
                }
                Logged = true;
                Menu();

            }
            else
            {
                Console.WriteLine("Sei già loggato");
                Menu();
            }
        }

        public static void Logout()
        {
            if (Logged == true)
            {
                Logged = false;
            }

    
            
        }
        public static void VerifyTime()
        {

        }
        public static void AccessList()
        {

        }
    }
}
