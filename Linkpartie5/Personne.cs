using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkpartie5
{
    internal class Personne
    {
 public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Age { get; set; }
    public string Sexe { get; set; }
    public bool Est_ingenieur { get; set; }
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
         
        }
        public Personne(string nom, string prenom, bool ingenieur)
    {
        Nom = nom;
        Prenom = prenom;
        Est_ingenieur = ingenieur;
    }
    public Personne(string nom, string prenom, int age, string sexe)
    {
        Nom = nom;
        Prenom = prenom;
        Age = age;
        Sexe = sexe;
    }
    public Personne(string nom, string prenom, int age, string sexe, bool ingenieur)
    {
        Nom = nom;
        Prenom = prenom;
        Age = age;
        Sexe = sexe;
        Est_ingenieur = ingenieur;
    }
}
}
