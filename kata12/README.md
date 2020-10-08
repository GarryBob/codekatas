# Kata12: Best Sellers

**Travail de réflexion sur ceci: http://codekata.com/kata/kata12-best-sellers/**

## Quoi?
Premièrement il faut clarifier les rôles et les requis...
- Qui sera notre client? C’est pas mal clair dans la description du kata mais il faut quand meme s’en assurer. 
    - Pour l'instant on présume que c’est un site web et possiblement des applis mobiles. 
- Quel est le use case exactement? À quel genre de requête peut-on s'attendre de la part du client?
    - Un extrême étant querystring jouflu avec ID du produit courant, catégorie, locale de l'usager, etc.
    - L'autre extrême étant un identifiant unique de liste de best sellers déjà tout cuit :-)
- Comment acquérir les données de best sellers? 
    - Est-ce qu’il est de notre responsabilité d’identifier les best-sellers ou cela sera synthétisé par un autre système tel un BI?
    - Si autre système, peut-il être accédé 24/7? Est-il performant et robuste? Peut-on en faire l’essai facilement dans un environnement de test?
    - Si nous devons le faire nous-même, il faudrait considérer mettre sur pied un projet et une équipe dédié à ceci et s'assurer d'une bonne collaboration entre les 2 équipes.
- Quelle est la nature et le volume de données?
    - Probablement qu’il ne s’agit pas d’une simple liste unique mais plutôt une liste par catégorie d’articles en vente? Par pays? Par langue? Etc.
    - Quelles infos devons nous gérer nous-même? Uniquement des identifiants? De la meta infomation pour aider la recherche? Tout le nécessaire pour l’affichage sur le site Web?

## Comment?

À ce stade ci il y a beaucoup de questions en suspens mais on peut tout-de-même se prêter au jeu et postuler quelques pistes de solutions...
- On devine qu’on s’oriente vers un API exposé sur le domaine publique mais dont l’accès est contrôlé avec un gestionnaire d’API. D'ailleurs la compagnie possède probablement déjà un portefeuille d'API bien garni...
- En sortie on produit des identifiants uniques de produits qui seront utilisés pour interroger un autre API (que la compagnie possède sans doute déjà) afin d'obtenir du détail sur les produits. 
- Pour alimenter cet API je vois 2 possibilitées :
    - Soit on utilise un moteur de recherche tel Solr ou ElasticSearch et on y stock de la meta information utile aux recherches. 
    - Ou alors, si on parvient à attribuer des identifiants uniques aux listes de best-sellers en amont, on utilise un key-value store comme Redis.
- Dans tous les cas il sera important d'utiliser une cache...