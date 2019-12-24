# Introduction à l’Interaction Homme-Machine
## Projet Jeu de la vie 
Déroulement du mini-projet. Le projet est réalisé en binôme et se déroule en deux phases:
1. La conception, où vous élaborerez les fonctionnalités (cas d’utilisation), les maquettes, prototypes  et  storyboards  de  votre  application  interactive.  Ce  travail  sera  fait  avec Balsamiq  Mockups  et  bien  entendu  vous  utiliserez  les  outils  à  votre  disposition  dans l’application pour commenter  et  justifier  vos choix de conception. Ce  travail sera évidemment  pris  en  compte  dans  la  note  finale  (originalité  de  la  proposition  et  de l’interface des  interactions,  qualité  des  maquettes  et  storyboards,  pertinence  des explications   et   justifications). Cette   phase   de   conception   sert   aussi   à   préparer l’implémentation en élaborant les tables fonctionnelles, machines à états/transition si besoin,  et les arbres  des  widgets  correspondants(éventuellement issu d’un prototype Visual Basic non fonctionnel).

2. L’implémentation, durant laquellevous développerez l'application avec Visual Basic. Vous devrez être particulièrement soigneux pour le codage: respectez les conventions de nommages vues en cours/TP, commentez votre code, indentez-le et organisez-le de manière  cohérente.  Vous  devrez   implémenter  l’interface,  les  interactions  et  les fonctionnalités nécessaires pour l’interaction de sorte à avoir un prototype «grandeur nature» de l’application interactive.

Thème et objectifs du projetLe but de ce projet est de développer le jeu de la vie(https://fr.wikipedia.org/wiki/Jeu_de_la_vie).       Le jeu de la vie une simulation composée d’une grille 2D de cellule. Chaque cellule peut être soit vivante(noire), soit morte(blanche). Une règle, qu’on peut changer, définit la naissance, la mort, ou la survie d’une cellule à l’itération suivante t+1, en fonction du nombre de cellules voisines à l’itération actuelle t.
Une cellule du bord compte ses voisines en incluant les cellules du bord opposé, de manière à donner l’impression que la grille est infinie. Ainsi par exemple, une cellule vivante meurt à t+1 si elle est entourée de moins de 3 cellules à l’instant t, et meurt à l’instant t+1 si elle est entourée de plus de 6 cellules à l’instant t, et une cellule nait si elle est entourée par 3 à 5 cellules. Dans les autres cas (ici s'il y a exactement 6 cellules) la cellule reste son état actuel.

A – Conception et implémentation de la plateforme Les fonctionnalités et éléments de base requis de l’application, pour lesquelles  vous  devrez réaliser une interface et des interactions, seront:
    -Configurer la taille de la grille du jeu de la vie, 
    -Configurerl’état initialou modifier l’état en cours, i.e. choisir les cellules qui seront vivantes à l’état initial ou en cours 
     de la simulation en cliquant dessus,
    -Configurer les règles de naissance et de mort en fonction du voisinage,
    -Lancer le jeu de la vie,
    -Mettre en pausele jeu de la vie.
    
L’interface doit être prévue pour être la plus efficace possible(réduction du nombre de clics, réduction du nombre de changements de fenêtre, forte affordance, compréhension facile de ce que peut faire ou doit faire l’utilisateur...).

B – Implémentationindépendante du moteur et de l’interface graphique. Vous devez développer de manière la plus cloisonnée possible le moteur du jeu et son interface graphique. Ainsi, dans un premier temps, vous devrez développer le moteur, avec une interface simple  en  mode  texte. Ceci  nécessite  que  vous  respectiez  tous  le  fait  que  la  classe Moteur dispose des fonctions et des procédures en pseudo code suivantes : Moteur :

    -setRegle (entier minMort, entier maxMort, entier minNaissance, entier maxNaissance)
    -setTailleGrille(entier n, entier m)
    -getTailleGrille(entier n, entier m)
    -setEtatCellule(entier i,entier j, booléen état)
    -booléen getEtatCellule(entier i,entier j)
    -etatSuivant()

Un  des  attributs  de  la  classe de  votre  interface  graphique MoteurUI(votre  Windows  Form principale)sera le moteur du jeu de la vie, c’est-à-dire une instance de la classe Moteur.

C –Intégration entre chaque binômeChaque moteur doit pouvoir se brancher avec l’interface graphique d’un autre binôme, et vice-versa. 
Cette contrainte sera un aspect important de l’évaluation.

D–Pour aller plus loinTester des configurations initiales et des règles qui permettent d’obtenir différentes structures (structure  stable,  oscillateur,  vaisseau,  puffeurs,  canons...),  comme  indiqué  dans https://fr.wikipedia.org/wiki/Jeu_de_la_vie.

## Démo
![Video](./gameoflife.mp4 "Démo")
