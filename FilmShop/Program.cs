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
            ShowListFilm();
            ShowListPersonne();
           
                            return;
       
            
           
           


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