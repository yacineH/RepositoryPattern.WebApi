# RepositoryPattern.WebApi
Projets backend avec API

API(Core 5) --->couche metier ----->DAL(EfCore) ------>Bdd(SqlServer)

l'utilisation du Pattern UOF (qui permet de rassembler tous les repository de la couche DAL evite les inyections des repositories dans le controller +
execution de plusieurs requettes en une unité).

l'utilisation du Pattern Repository couplage faible entre controller et la DAL (realisation des tests) et aussi permet de basculer d'un ORM a un autre plus facilement.
