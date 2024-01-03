using System;

namespace programme_poo 
{ 

    class Personne
    {
        static int nombrePersonne = 0;

        public string nom;
        int age;
        string emploi;
        int numeroPersonne;

        public Personne(string nom, int age, string emploi) { 

            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nombrePersonne++;

            this.numeroPersonne = nombrePersonne;
            
        }

        public void Afficher()
        {
            Console.WriteLine("Personne N° : " + numeroPersonne);
            Console.WriteLine("  Nom : " + nom);
            Console.WriteLine("     Age : " + age);
            Console.WriteLine("     Emploi : " + emploi);
        }

        public static void AfficherNombrePersonne()
        {
            Console.WriteLine("Nombre total de personnes : " +nombrePersonne);
        }
    }

    class Program
    {

        /*static void AfficherInfosPersonne(string nom, int age, string emploi)
        {
            
        }
*/
        static void Main(string[] args) 
        {
            /*var noms = new List<string> {"paul", "jacque", "David", "val" };
            var ages = new List<int> { 30, 35, 20 , 9};
            var emplois = new List<string> { "Developpeur", "Professeur", "Etudiant", "Licence" };

            for (int i = 0; i < noms.Count; i++)
            {
                AfficherInfosPersonne(noms[i], ages[i], emplois[i]);
            }*/

            /*Personne personne1 = new Personne("val",20,"Dev");
            personne1.Afficher();

            Personne personne2 = new Personne("leila", 21, "FrontEnd");
            personne2.Afficher();*/

            var personnes = new List<Personne>
            {
                new Personne("val", 22 , "Dev"),
                new Personne("leila", 21 , "Dev"),
                new Personne("billie", 23 , "Dev"),
                new Personne("kim", 22 , "Dev")
            };

            //permet de faire le tris par le nom
            personnes.OrderBy(p => p.nom).ToList();

            foreach (var person in personnes)
            {
                person.Afficher();
            }
        }


    }
}