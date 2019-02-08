using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FilmShopLibrary1
{
    public static class DataAccess
    {

        public static string SqlConnectionString = @"Server=.\SQLExpress;Database=LaFerme;Trusted_Connection=Yes";



        #region Création d'un enregistrement Film

        public static void AddFilm(Film InsertFilm)
        {
            try
            {
                SqlConnection connection = new SqlConnection(SqlConnectionString);
                connection.Open();
                SqlCommand firstInsert =
                        new SqlCommand("INSERT INTO Film (Titre, Realisateur, DateSortie, Resume, Genre, Duree) " +
                        " VALUES (@titre, @realisateur, @dateSortie, @resume, @duree)", connection);

                firstInsert.Parameters.AddWithValue("@titre", InsertFilm.Titre);
                firstInsert.Parameters.AddWithValue("@realisateur", InsertFilm.Realisateur);
                firstInsert.Parameters.AddWithValue("@dateSortie", InsertFilm.DateSortie);
                firstInsert.Parameters.AddWithValue("@resume", InsertFilm.Resume);
                firstInsert.Parameters.AddWithValue("@duree", InsertFilm.Duree);
                

                firstInsert.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                throw new FirstException("Problème base de donnée table Film !!!");
            }
        }
        #endregion

        #region Création d'un enregistrement Film

        public static void AddPersonnes(Personne InsertPerson)
        {
            try
            {
                SqlConnection connection = new SqlConnection(SqlConnectionString);
                connection.Open();
                SqlCommand firstInsert =
                        new SqlCommand("INSERT INTO Personne (NomPersonne, PrenomPersonne, DateNaissance, AdressePersonne, VillePersonne, CPPersonne, TaillePersonne, PoidsPersonne) " +
                        " VALUES (@nomPersonne, @prenomPersonne, @dateNaissance, @adressePersonne, @villePersonne, @cPPersonne, @taillePersonne, @poidsPersonne)", connection);

                firstInsert.Parameters.AddWithValue("@nomPersonne", InsertPerson.NomPersonne);
                firstInsert.Parameters.AddWithValue("@prenomPersonne", InsertPerson.PrenomPersonne);
                firstInsert.Parameters.AddWithValue("@dateNaissance", InsertPerson.DateNaissance);
                firstInsert.Parameters.AddWithValue("@adressePersonne", InsertPerson.AdressePersonne);
                firstInsert.Parameters.AddWithValue("@villePersonne", InsertPerson.CPPersonne);
                firstInsert.Parameters.AddWithValue("@cPPersonne", InsertPerson.CPPersonne);
                firstInsert.Parameters.AddWithValue("@taillePersonne", InsertPerson.TaillePersonne);
                firstInsert.Parameters.AddWithValue("@poidsPersonne", InsertPerson.PoidsPersonne);               


                firstInsert.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                throw new FirstException("Problème base de donnée table Person !!!");
            }
        }
        #endregion
        // select pour voir si l'adresse émail existe dans la base de donnéé
        public static List<Film> GetAllFilms()

        {
           

                List<Film> resultat = new List<Film>();

                SqlConnection connection = new SqlConnection(SqlConnectionString);
                connection.Open();
                SqlCommand selectCommand =
                    new SqlCommand
                      ("SELECT Titre, Realisateur, DateSortie, Resume, Genre, Duree " +
                    "FROM Film " , connection);
                
                SqlDataReader dataReader = selectCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    #region .Liste tous les film..             
                    Film loginCourant = new Film();
                loginCourant.Titre = (string)dataReader["Titre"];
                loginCourant.Realisateur = (string)dataReader["Realisateur"];
                loginCourant.DateSortie = (DateTime)dataReader["DateSortie"];
                loginCourant.Resume = (string)dataReader["Resume"];
                loginCourant.Genre = (string)dataReader["Genre"];
                loginCourant.Duree= (int)dataReader["Duree"];

                               
                #endregion
                resultat.Add(loginCourant);


                }
                connection.Close();

                return resultat;
            
        }
        // select pour voir si l'adresse émail existe dans la base de donnéé
        public static List<Personne> GetAllPersonne()

        {


            List<Personne> resultat = new List<Personne>();

            SqlConnection connection = new SqlConnection(SqlConnectionString);
            connection.Open();
            SqlCommand selectCommand =
                new SqlCommand
                  ("SELECT NomPersonne, PrenomPersonne, DateNaissance, AdressePersonne, VillePersonne, CPPersonne, TaillePersonne," +
                  " PoidsPersonne " +
                "FROM Personne ", connection);

            SqlDataReader dataReader = selectCommand.ExecuteReader();
            while (dataReader.Read())
            {
                #region .Liste tous les personne.             
                Personne loginCourant = new Personne();
               
                loginCourant.NomPersonne = (string)dataReader["NomPersonne"];
                loginCourant.PrenomPersonne = (string)dataReader["PrenomPersonne"];
                loginCourant.NomPersonne = (string)dataReader["NomPersonne"];
                loginCourant.DateNaissance = (DateTime)dataReader["DateNaissance"];
                loginCourant.VillePersonne = (string)dataReader["VillePersonne"];
                loginCourant.CPPersonne = (string)dataReader["CPPersonne"];
                loginCourant.TaillePersonne = (int)dataReader["TaillePersonne"];
                

                #endregion
                resultat.Add(loginCourant);


            }
            connection.Close();

            return resultat;

        }

        public static List<Film> GetFilmByld(Film ListF)
            {

            List<Film> resultat = new List<Film>();

            SqlConnection connection = new SqlConnection(SqlConnectionString);
            connection.Open();
            SqlCommand selectCommand =
                new SqlCommand
                  ("SELECT Titre, Realisateur, DateSortie, Resume, Genre, Duree " +
                "FROM Film  WHERE Titre =  @titre ORDER BY Titre ", connection);
            selectCommand.Parameters.AddWithValue("@titre", ListF.Titre);
            SqlDataReader dataReader = selectCommand.ExecuteReader();
          
            while (dataReader.Read())
            {
                #region .Liste tous les film..             
                Film loginCourant = new Film();
                loginCourant.Titre = (string)dataReader["Titre"];
                loginCourant.Realisateur = (string)dataReader["Realisateur"];
                loginCourant.DateSortie = (DateTime)dataReader["DateSortie"];
                loginCourant.Resume = (string)dataReader["Resume"];
                loginCourant.Genre = (string)dataReader["Genre"];
                loginCourant.Duree = (int)dataReader["Duree"];


                #endregion
                resultat.Add(loginCourant);


            }
            connection.Close();

            return resultat;
        }

        // select pour voir si l'adresse émail existe dans la base de donnéé
        public static List<Personne> GetPersonneByld(Personne ListP)

        {


            List<Personne> resultat = new List<Personne>();

            SqlConnection connection = new SqlConnection(SqlConnectionString);
            connection.Open();
            SqlCommand selectCommand =
                new SqlCommand
                  ("SELECT NomPersonne, PrenomPersonne, DateNaissance, AdressePersonne, VillePersonne, CPPersonne, TaillePersonne," +
                  " PoidsPersonne " +
                "FROM Personne WHERE NomPersonne=  @nomPersonne ORDER BY NomPersonne ", connection);
            selectCommand.Parameters.AddWithValue("@nomPersonne", ListP.NomPersonne);

            SqlDataReader dataReader = selectCommand.ExecuteReader();
            while (dataReader.Read())
            {
                #region .Liste tous les personne.             
                Personne loginCourant = new Personne();

                loginCourant.NomPersonne = (string)dataReader["NomPersonne"];
                loginCourant.PrenomPersonne = (string)dataReader["PrenomPersonne"];
                loginCourant.NomPersonne = (string)dataReader["NomPersonne"];
                loginCourant.DateNaissance = (DateTime)dataReader["DateNaissance"];
                loginCourant.VillePersonne = (string)dataReader["VillePersonne"];
                loginCourant.CPPersonne = (string)dataReader["CPPersonne"];
                loginCourant.TaillePersonne = (int)dataReader["TaillePersonne"];


                #endregion
                resultat.Add(loginCourant);


            }
            connection.Close();

            return resultat;

        }

    }

   

            }

