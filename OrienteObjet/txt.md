## Les namespaces :

En .NET, la structure des espaces de noms est logique, c’est-à-dire qu’elle organise le code conceptuellement 
sans imposer de correspondance avec la structure physique des fichiers sur le disque. 

Contrairement à Java, où la structure des packages doit refléter les dossiers, en .NET, 
un fichier peut être placé n’importe où tout en appartenant à un espace de noms défini dans le code. 

Cela offre flexibilité et simplicité de maintenance.

## La notion de dll en C# :

En C#, vous pourriez créer un projet avec des fonctions mathématiques
que vous pourriez par exemple avoir envie de réutiliser ailleurs.
Vous pourriez donc compiler le projet, ce qui génèrerait un fichier.dll
Celui-ci pourrait -etre réutiliser dans un autre projet à des fins utilitaires.

## Assembly 

Projet | .dll