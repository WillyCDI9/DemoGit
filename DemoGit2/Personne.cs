using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit2
{
    public class Personne
    {
        #region "Propriétés d'instances"

        private string Nom;
        private string Prenom;
        private short Age;

        public string _Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public string _Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

        public short _Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        #endregion

        #region "Constructeurs"
        public Personne (string nom, string prenom, short age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }

        //Autre constructeur
        public Personne( string nom, string prenom, short age) : this( nom, prenom, age) { }
        #endregion
    }
}
