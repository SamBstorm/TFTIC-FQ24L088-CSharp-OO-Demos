//using s = Super.Hyper;
using OrienteObjet.entities;
using OrienteObjet.indexeurs;
using OrienteObjet.partialClass;
using h = Super.Hyper;
//using s2 = Supra.Hyper;


// Base orienté objet (classe, instance, constructeur, encapsulation)
var telephone = new h.Telephone(0476567465, "nokia");

telephone.Téléphoner(1231231231);
telephone._marque = "samsung";


// Les classes internes (voir partialClass folder)
var partialClass = new ClassePartielle();
partialClass.sayHello();
partialClass.sayCoucou();

// Getteur et Setter || Accesseurs & Mutateurs :

Personne person1 = new Personne(
        "Aze",
        "Nazesd",
        56,
        123
    );

//person1.prenom = "azezae";
person1.age = 12;

// Indexeur
NomCollection collecDeNom = new NomCollection();

collecDeNom[0] = "Aaz";
Console.WriteLine(collecDeNom[0]);