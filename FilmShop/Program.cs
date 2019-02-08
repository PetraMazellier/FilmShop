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
            ShowListFilm1();
            ShowListPersonne1();

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
                Console.Write(filmcourant.Realisateur);
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
           

            Console.WriteLine("\tNous avons trouvé {0} personne:", personneTrouve.Count);

            foreach (var personnecourant in personneTrouve)
            {
                Console.Write(" nom entier   ");
                Console.Write(personnecourant.NomEntier);
                Console.Write(" date naissance   ");
                Console.Write(personnecourant.DateNaissance);
                Console.Write(" code postale   ");
                Console.Write(personnecourant.CPPersonne);
                Console.Write(" ville   ");
                Console.Write(personnecourant.VillePersonne);
                Console.Write(" taille   ");
                Console.Write(personnecourant.TaillePersonne);


            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey(true);

        }

        private static void ShowListFilm1()
        {
            Console.Clear();
            Film FCree = new Film();

            FCree.Titre = "the dark";
            List<Film> filmTrouve = DataAccess.GetFilmByld(FCree);

            Console.WriteLine("\tNous avons trouvé {0} film :", filmTrouve.Count);

            foreach (var filmcourant in filmTrouve)
            {

                Console.Write(" titre   ");

                Console.Write(filmcourant.Titre);
                Console.Write(" realisateur   ");
                Console.Write(filmcourant.Realisateur);
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

        private static void ShowListPersonne1()
        {
            Console.Clear();
            Personne PCree = new Personne();

            PCree.NomPersonne = "Mazellier";
            PCree.PrenomPersonne = "Petra";
            List<Personne> filmTrouve = DataAccess.GetPersonneByld(PCree);
            List<Personne> personneTrouve = DataAccess.GetAllPersonne();


            Console.WriteLine("\tNous avons trouvé {0} personne:", personneTrouve.Count);

            foreach (var personnecourant in personneTrouve)
            {
                Console.Write(" nom entier   ");
                Console.Write(personnecourant.NomEntier);
                Console.Write(" date naissance   ");
                Console.Write(personnecourant.DateNaissance);
                Console.Write(" code postale   ");
                Console.Write(personnecourant.CPPersonne);
                Console.Write(" ville   ");
                Console.Write(personnecourant.VillePersonne);
                Console.Write(" taille   ");
                Console.Write(personnecourant.TaillePersonne);


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