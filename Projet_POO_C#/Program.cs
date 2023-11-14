using System.Linq.Expressions;
using System.Xml;
using Projet_POO;

// Message de bienvenue
Console.WriteLine("Bonjour, bienvenue dans le programme de consultation de produit de votre magasin.");
// Message "renseignez type"
Console.WriteLine("Veuillez renseigner le type d'article que vous voulez consulter : \n- Ordinateur \n- Vetement \n- Alimentaire");
// Permet d'ecrire
string output = Console.ReadLine();

// Initialisation des articles
Ordinateur pc1 = new Ordinateur("ASUS", "ROG", 1250, "Processeur, Carte graphique", "Souris", "Gaming");
Vetement vet1 = new Vetement("NIKE", "AIR", 300, "43", "Blanc", "Cuir");
Alimentaire Aliment1 = new Alimentaire("BARILLA", "Pates", 2, "farine, eau, oeuf, sel", "A", "1Kg");

// Traitement de la selection utilisateur
switch (output)
{
    case "Ordinateur":
        Console.WriteLine($"Ordinateur : \n- Marque :{pc1.Marque} \n- Nom : {pc1.Nom} \n- Prix : {pc1.Prix} \n- Composants : {pc1.Composants} \n- Accessoires : {pc1.Accessoires} \n- TypeUtilisation : {pc1.TypeUtilisation}");
        break;
    case "Vetement":
        Console.WriteLine($"Vetement : \n- Marque :{vet1.Marque} \n- Nom :{vet1.Nom} \n- Prix :{vet1.Prix} \n- Taille : {vet1.Taille} \n- Couleur : {vet1.Couleur} \n- Matiere : {vet1.Matiere}");
        break;
    case "Alimentaire":
        Console.WriteLine($"Alimentaire : \n- Marque : {Aliment1.Marque} \n- Nom : {Aliment1.Nom} \n- Prix : {Aliment1.Prix} \n- Ingredients : {Aliment1.Ingredients} \n- NutriScore : {Aliment1.NutriScore} \n- Poids : {Aliment1.Poids}");
        break;
    default:
        Console.WriteLine("Aucun type d'article trouvé");
        break;
}
















