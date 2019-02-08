using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FilmShopLibrary1;


namespace FilmShop
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowAddFilm();
            ShowAddPersonne();
            List<Film> filmTrouve =DataAccess.GetAllFilms();
            List<Personne> personneTrouve = DataAccess.GetAllPersonne();
            ShowListFilm();
            ShowListPersonne();
           
                            return;
       
            
           
           


        }

        private static void ShowListFilm()
        {
            Console.Clear();
            List<Film> filmTrouve = DataAccess.GetAllFilms();
            
            Console.WriteLine("\tNous avons trouvé {0} film :", filmTrouve.Count);
           
            foreach (var filmcourant in filmTrouve)
            {

                Console.Write(" titre   ");
               
                Console.Write(filmcourant.Titre);
                Console.Write(" realisateur   ");
                Console.Write(filmcourant.Realisateur;
                Console.Write(" datesortie   ");
                Console.Write(filmcourant.DateSortie);
                Console.Write(" resume   ");
                Console.Write(filmcourant.Resume);
                Console.Write(" genre   ");
                Console.Write(filmcourant.Genre);
                Console.Write(" duree   ");
                Console.Write(filmcourant.Duree);
              

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey(true);

        }

        private static void ShowListPersonne()
        {
            Console.Clear();
            List<Personne> personneTrouve = DataAccess.GetAllPersonne();
            loginCourant.NomPersonne = (string)dataReader["NomPersonne"];
            loginCourant.PrenomPersonne = (string)dataReader["PrenomPersonne"];
            loginCourant.NomPersonne = (string)dataReader["NomPersonne"];
            loginCourant.DateNaissance = (DateTime)dataReader["DateNaissance"];
            loginCourant.VillePersonne = (string)dataReader["VillePersonne"];
            loginCourant.CPPersonne = (string)dataReader["CPPersonne"];
            loginCourant.TaillePersonne = (int)dataReader["TaillePersonne"];


            Console.WriteLine("\tNous avons trouvé {0} film :", filmTrouve.Count);

            foreach (var filmcourant in filmtrouve)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n\n\tNom trouvé : ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(filmcourant.NomEntier);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("  avec son numéro téléphone : ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(filmcourant.TelephoneIdentification);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" \n\tet son adresse émail   ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(filmcourant.MailIdentification);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("  et il a le type   ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(filmcourant.NomType);
                Console.ForegroundColor = ConsoleColor.Blue;

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey(true);

        }
        public static void ShowAddFilm()
        {
            Film FCree = new Film();

            FCree.Titre = "the dark";
            FCree.Realisateur = "johnny";
            FCree.DateSortie = Convert.ToDateTime("2018" + "," + "08" + "," + "12");
            FCree.Resume = "c'est un test";
            FCree.Genre = "comdey";
            FCree.Duree = 122;

            DataAccess.AddFilm(FCree);

        }
        public static void ShowAddPersonne()
        {
           Personne PCree = new Personne();

            PCree.NomPersonne = "Mazellier";
            PCree.PrenomPersonne = "Petra";
            PCree.DateNaissance = Convert.ToDateTime("1968" + "," + "08" + "," + "11");
            PCree.AdressePersonne = "5, rue du dauphiné";
            PCree.VillePersonne = "Lampertheim";
            PCree.CPPersonne = "67450";
            PCree.TaillePersonne = 160;
            PCree.PoidsPersonne = 60;
            

            DataAccess.AddPersonnes(PCree);

        }
    }
}