using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FilmShopLibrary1
{
    public class Personne
    {

        private int idPersonne;
        private string nomPersonne;
        private string prenomPersonne;
        private DateTime dateNaissance;
        private string adressePersonne;
        private string villePersonne;
        private string cPPersonne;
        private int taillePersonne;
        private int poidsPersonne;

        public Personne()
        {
        }

        public int Age
        {
            get
            {

                int age = DateTime.Now.Year - DateNaissance.Year;
                DateTime dateAnniversaire =
                    new DateTime(
                        DateTime.Now.Year,
                        DateNaissance.Month,
                        DateNaissance.Day);

                if (dateAnniversaire >= DateTime.Now)
                {
                    age--;
                }

                return age;
            }
        }

        public string NomEntier

        {
            get
            {
                string nomEntier = "";                
                nomEntier = PrenomPersonne + " " + NomPersonne;
                return nomEntier;
            }
        }

        

        public int IdPersonne { get => idPersonne; set => idPersonne = value; }
        public string NomPersonne {
            get
            {
                nomPersonne = nomPersonne.ToUpper();

                return nomPersonne;
            }
            set => nomPersonne = value; }
        public string PrenomPersonne {
                get
            {
                prenomPersonne = prenomPersonne.ToUpper();

                return prenomPersonne;
            }
            set => prenomPersonne = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string AdressePersonne { get => adressePersonne; set => adressePersonne = value; }
        public string VillePersonne { get => villePersonne; set => villePersonne = value; }
        public string CPPersonne { get => cPPersonne; set => cPPersonne = value; }
        public int TaillePersonne { get => taillePersonne; set => taillePersonne = value; }
        public int PoidsPersonne { get => poidsPersonne; set => poidsPersonne = value; }
    }

  /*  public string Presenter(Personne NouvPerson)
    
    {
        String presentation = "Bonjour je m'appelle " + NouvPerson.NomEntier;

        return presentation;
    }*/
}