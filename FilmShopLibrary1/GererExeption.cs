using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FilmShopLibrary1
{
    

        public class FirstException : Exception
        {
            public FirstException()
            {
            }

            public FirstException(String message) : base(message)
            {
            }

        }

        public class TestException
        {
            private string testString;

            public TestException(string testString)
            {
                TestString = testString;
            }

            public string TestString
            {
                get => testString;
                set
                {
                    if (!value.Contains("@") || value.Length > 120 || !value.Contains(".") || value.Length < 6)
                    {
                        throw new FirstException("Emailadresse incorrecte !!!");
                    }
                    testString = value;
                }
            }

        }
        public class TestNomException
        {
            private string testString;


            public string TestString
            {
                get
                {
                    testString = testString.ToUpper();

                    return testString;
                }

                set
                {

                    if (value.Length > 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new FirstException("Le nom ne peut pas être plus long que 80 !! ");

                    }
                    if (value.Length < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        throw new FirstException("Renseigner un nom valide !!!");
                    }
                    testString = value;
                }
            }
            public TestNomException()
            {
            }

            public TestNomException(string testString)
            {
                TestString = testString;
            }

            // fonction pour mettre la premiere lettre en majuscule
            public static string premiereLettreMajuscule(string caractere)
            {
                caractere = caractere[0].ToString().ToUpper() + caractere.Substring(1).ToLower();

                return caractere;
            }
            // fonction qui controle tout les string d'une valeur maxi 80 et met tout en majuscule
            public static string SaisieNom(string variable)
            {
                bool isUserInputValid = false;
                string nom = null;

                while (!isUserInputValid)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        if (nom == null)
                        {
                            Console.Write(variable);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            nom = Console.ReadLine();
                        }
                        TestNomException TE = new TestNomException(nom);
                        isUserInputValid = true;
                    }
                    catch (FirstException firstException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\tErreur : " + firstException.Message);
                        nom = null;
                    }
                }
                return nom;
            }

            // fonction qui controle si la donnée est bien un décimal
            public static decimal SaisieNombreDecimal(string variable)
            {
                decimal qte = 0;
                string quantite = "";

                bool isUserInputValid = false;

                while (!isUserInputValid)
                {
                    try
                    {
                        if (quantite == null)
                        {
                            Console.Write(variable);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            quantite = Console.ReadLine();
                        }
                        qte = Convert.ToDecimal(quantite);
                        isUserInputValid = true;
                    }
                    catch (FormatException)
                    {
                        quantite = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    catch (ArgumentNullException)
                    {
                        quantite = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    catch (OverflowException)
                    {
                        quantite = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
                return qte;
            }

            // fonction qui verifie si la saisie s'est  un nombre entier
            public static int SaisieNombreInit(string variable)
            {
                int qte = 0;
                string quantite = "";
                bool isUserInputValid = false;

                while (!isUserInputValid)
                {
                    try
                    {
                        if (quantite == null)
                        {
                            Console.Write(variable);
                            Console.ForegroundColor = ConsoleColor.Red;
                            quantite = Console.ReadLine();
                        }
                        qte = Int32.Parse(quantite);
                        isUserInputValid = true;
                    }
                    catch (FormatException)
                    {
                        quantite = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    catch (ArgumentNullException)
                    {
                        quantite = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    catch (OverflowException)
                    {
                        quantite = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
                return qte;
            }
        }
}
