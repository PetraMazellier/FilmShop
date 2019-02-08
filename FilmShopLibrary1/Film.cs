using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FilmShopLibrary1
{
    public class Film
    {
        private int idFilm;
        private string titre;
        private string realisateur;
        private DateTime dateSortie;
        private string resume;
        private string genre;        
        private int duree;

        public Film()
        {
        }

        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Realisateur { get => realisateur; set => realisateur = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Duree { get => duree; set => duree = value; }

       

    }
}


