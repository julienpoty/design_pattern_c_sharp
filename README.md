# Envoi de message client à l'aide de Design Pattern

Voici un petit projet en C# permettant d'illustrer l'envoi de message (Sms, Mail, Notification) à un client d'une boutique en ligne, en utilisant des design Pattern.

Un utilisateur client d'une boutique en ligne, peut choisir de recevoir des messages par sms, mail ou notification ou bien les 3 en même temps s'il le souhaite.

## Builder

J'ai mis en place un builder pour les types de message Sms et Notification. Le builder permet de construire des messages plus ou moins complets.

Par exemple, Le builder de Mail permet de créer des messages avec un body de texte, un body html, un titre, avec une pièce jointe, ou des destinataires en copies.

Le builder permet d'ajouter un ou plusieurs de ces éléments. Le code client est ainsi libre de choisir les éléments qu'il souhaite ajouter au mail.

## Abstract Factory

L'abstract factory permet de définir une même interface pour récupérer différentes type de message (confirmation de commande, annulation de commande, envoi de code promo).

Les différentes implémentations de factory permettent de renvoyer le message correspondant, que ce soit un sms, un mail ou une notification.

## Bridge

L'utilisation du Bridge offre la possibilité d'utiliser différentes implémentations de factory, ou de serveur d'envoi, s'en altérer le fonctionnement global.

Par exemple, si l'on souhaite ajouter un nouveau serveur d'envoi de mail (qui utiliserait une autre assembly), le bridge permet de conserver le comportement initial (envoi de mail). 

On évite ainsi de coupler les classes factory (qui créé l'objet message), formatter (qui complète le message) et serveur d'envoi (qui envoi le message).

## Command

Une interface a été ajouté pour implémenter Le design pattern Command (ICommand). Cette interface permet de créer une classe concrête pour chaque type de message (sms, mail, notification), chacune de ces classes doit ensuite implémenter la méthode Execute().

Il devient alors possible de stocker toutes les commandes de message dans une même pile.

En interne la commande message utilise un bridge pour créer un mail, le compléter avec les informations du client, et l'envoyer au serveur.

## Facage

Le design pattern Facade est utilisé pour simplifier la création de commande de message.