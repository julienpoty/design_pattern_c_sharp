# Design Pattern en C#

## Creational Patterns

### Abstract Factory

La classe Scooter est une classe abstraite

la classe scooterElectricité et la classe scooterEssence sont deux classes filles de la classe Scooter
une instance de la classe scooterElectricité est retourné par la méthode créeScooter de la classe FabriqueVéhiculeElectricité
une instance de la classe scooterEssence est retourné par la méthode créeScooter de la classe FabriqueVéhiculeEssence

### Builder

Construire des documents dans un format donné en fonction du client

Constructeur de liase de document

Quel que soit l'implémentation des méthodes le client ne va dialoguer qu'avec le builder de base.

On distingue la logique métier de l'implémentation des méthodes.

Un client a besoin de construire des objets complexes sans avoir besoin de connaître leur implémentation ou construire des objets avec différentes implémentations

### Factory Method

Introduire une méthode abstraite de création d'un objet en reportant l'implémentation dans une classe

### Singleton

Permet de s'assurer qu'on ne peut utiliser (créer) qu'une seule instance de la classe.
On utilise une méthode de classe pour instancier l'objet.

Le pattern Abstract Factory est susceptible d'utiliser ce type d'instance unique.

Notre application va utiliser la classe liasse vierge (LiasseVierge) qui ne posédera qu'une seule instance.

Chaque classe qui utilise la liasse vierge doit avoir accès à la même instance.
Il faut s'arranger pour ne pas en créer de nouvelles (avec l'opérateur new)

### Prototype

Permet la création d'objets à partir d'autres objets appelés "prototpes" disposant d'une méthode Clone() qui retourne un objet identique

## Composition VS Héritage

La Composition est le fait d'avoir une instance d'une classe dans une instance d'une autre classe, ainsi l'objet "englobant" peut interragir directement avec l'objet "englobé".

L'héritage permet a une classe d'hériter des comportements ou des propriétés d'une autre classe, appelée classe mère, sans avoir a redéfinir ces comportements. la classe qui hérite des comportements est appelée classe fille.

## Structural Patterns

Les patterns de structuration permettent de créer de faciliter l'indépendace de l'interface d'un objet et de son implémentation.

En fournissant les interfaces ce pattern permet d'encapsuler la composition des objets

cela augmente le niveau d'abstraction d'un système donné un peu à la manière des patterns de création qui encapsulent la création d'objets.

Ces patterns mettent en avant les interfaces.

### Adapter 

Permet de convertir l'interface d'une classe donnée en une interface attendue par des clients afin qu'il puissent travailler.

En résumé, il permet de donner à une classe existante une nouvelle interface pour répondre aux besoins d'un client.

### Bridge

Permet de séparer le comportement de l'implémentation de l'interface et de l'implémentation de l'objet

Exemple : on s'intéresse au demande d'immatriculation des véhicules.

Le formulaire de demande d'immatriculation possède deux implémentations différentes

FormulaireImmat

FormulaireImmatHTML
FormulaireImmatAPP

Au départ le système a été conçu pour la France uniquement
Ensuite on a du créé une sous-classe FormulaireImmatCH
Elle aussi est abstraite pour avoir également deux sous-classes concrètes (qui sont FormulaireImmatHTML et FormulaireImmatAPP dédiées à la Suisse)

### Composite

