// See https://aka.ms/new-console-template for more information


using Linkpartie5;

List<List<Personne>> personnes = new List<List<Personne>>
 {
 new List<Personne>() {new Personne("Drucker", "Michel"),
 new Personne("Bedia", "Ramzy"),
 new Personne("Judor", "Eric")},
 new List<Personne>() {new Personne("Diaz", "Cameron"),
 new Personne("Depardieu", "Gerard"),
 new Personne("Stallone", "Sylvester"),
 new Personne("Macron", "Emmanuel")},
 new List<Personne>() {new Personne("Benzema", "Karim"),
 new Personne("Antoine", "Eric"),
 new Personne("Ruiz", "Olivia"),
 new Personne("Clavier", "Christian"),
 new Personne("Einstein", "Albert")}
 };


var noms = from List<Personne> personne2 in personnes
           from personne in personne2
           where personne.Nom.Length > 5
           select new { Nom = personne.Nom };


foreach (var item in noms)
{

    Console.WriteLine(item);
}

var noms2 = from List<Personne> personne2 in personnes
           from personne in personne2
           where personne.Nom.Contains("e")
            select new { Nom = personne.Nom };

Console.WriteLine("Exo 2:");
foreach (var item in noms2)
{

    Console.WriteLine(item);
}



var noms3 = from List<Personne> personne2 in personnes
            from personne in personne2
            where personne.Prenom.Contains("a")
            select new { Nom = personne.Nom };

Console.WriteLine("Exo 3:");
foreach (var item in noms3)
{

    Console.WriteLine(item);
}



var tri = from List<Personne> personne2 in personnes
                           from personne in personne2
                           orderby personne.Nom descending
                           select new Personne(personne.Nom, personne.Prenom);


                 Console.WriteLine("Exo 4:");
foreach (var item in tri)
{

        Console.WriteLine(item.Nom);
}


var anonyme = from List<Personne> personne2 in personnes
          from personne in personne2
          orderby personne.Nom descending
          select new { Nom_concat= personne.Nom + personne.Prenom };


Console.WriteLine("Exo 5:");
foreach (var item in anonyme)
{

    Console.WriteLine(item.Nom_concat);
}





/*
Ecrire les requêtes LINQ permettant de :
1.Récupérer tous les noms dont la longueur est supérieure à 5
2. Récupérer tous les noms contenant un "e"
• Récupérer tous les prénoms contenant un "a"
• Trier par nom (tri décroissant)
• Créer un objet anonyme avec un attribut identite = prénom+" "+nom*/
