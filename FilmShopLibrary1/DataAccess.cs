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

        public static void InsererUtilisateurEnBDD(Film InsertFilm)
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
                throw new FirstException("Problème base de donnée table Livraison !!!");
            }
        }
        #endregion
    }
}