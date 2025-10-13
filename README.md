# AP2_Prep-Order
<<<<<<< HEAD
PREP'ORDER - Une application pour intermarché qui gère les palettes et les commandes pour des magasins. Table des matières

Introduction
Fonctionnalités
Prérequis
Installation
Utilisation
Introduction

PREP'ORDER est une application C# permettant de gérer des commandes et des palettes pour le stockage d'Intermarché. L'application inclut des fonctionnalités pour les utilisateurs et les administrateurs.

Fonctionnalités

Importation de commandes à l'aide de ficher CSV
Vue des commandes importées
Gestion des utilisateurs de leurs rôles
Ajout d'une nouvelle commande
Tableau de bord des commandes
Notification aux caristes si un stock est vide
Liste des demandes de palettes
Gestion du stockage en hauteur
Prérequis

Avant d'installer ce projet, assurez-vous d'avoir les éléments suivants :

Microsoft Visual Studio
Microsoft SQL Server Management Studio
Installation

Utilisation

Lancez l'application et connectez vous avec vos identifiants.

Pour les résponsables : Vous pouvez ajouter ou modifier un utilisateur. Vous pouvez visualiser les commandes et leurs états (en cours/terminé) Vous pouvez importer un fichier CSV pour ajouter une nouvelle commande.

Pour les préparateurs : Vous pouvez choisir la zone de préparation avec la combo box et quand toute la commande est finie vous pouvez la valider et son statut passe à validé. Si pour un certain produit la zone est vide, vous pouvez cliquer sur le bouton zone vide et ça affiche au cariste dans la colonne Problem le message erreur pour dire que la zone est vide.

Pour les caristes : Vous avez accès au tableau de bord des racks, vous pouvez voir le stockage de tous et voir lesquels sont vides. Vous avez également accès au demandes de remplissage de palettes fait par les préparateurs, vous pouvez choisir la palette et la remplir.

Contribution

Les contributions sont les bienvenues ! Pour contribuer :

Forkez le projet.
Créez une branche pour votre fonctionnalité (git checkout -b features/nomDeVotreFeature).
Commitez vos modifications (git commit -m "Ajout d'une nouvelle fonctionnalité").
Poussez vos modifications (git push origin features/nomDeVotreFeature).
Ouvrez une Pull Request.
Licence

Le contenu et le code source de ce site sont la propriété exclusive d'Intermarché. Tous droits réservés.

Aucune partie de ce site, y compris le texte, les images, les fichiers, ou le code source, ne peut être reproduite, distribuée, ou utilisée à des fins commerciales sans l'autorisation écrite préalable d'Intermarché.

L'utilisation de cette application est soumise aux conditions générales définies par Intermarché. Toute tentative d'infraction aux droits de propriété intellectuelle entraînera des poursuites conformément à la législation en vigueur.

Pour toute demande concernant l'utilisation de cette application, veuillez contacter Intermarché.
=======
-[Description_de_l'Application](#Description_de_l'Application)
-[Fonctionnalités](#Fonctionnalités)
-[Accès_Utilisateurs](#Accès_Utilisateurs)
-[Prérequis](#Prérequis)
-[Langage_et_Framework](#Langage_et_Framework)
-[Documentation](#documentation)
-[Auteurs](#Auteurs)

## Description_de_l'Application
-L'Application à pour but d'améliorer l'efficacité des préparateurs de commandes et moderniser les outils de suivi des expéditions de l'Intermarché de Heudebouville.
 en centralisant la gestion des commandes, optimisant la préparation des palettes et de permettant une mise à jour en temps réel des stocks.

## Fonctionnalités
# Accueil
- **Connexion Cariste**
- Accès aux pages des caristes
- **Connexion Responsable**
- Accès aux pages des responsables
- **Connexion Préparateur**
- Accès aux pages des préparateurs
# Cariste
- **Demandes des Préparateurs**
- Listes des palettes vides à remplir
- **Confirmation de Stockage**
- interface qui permet de modifier le statut des palettes lorsqu'elles ont été remplies
- Liste qui affiche les stocks en Hauteur
# Responsable
- **Gestion des Commandes**
- Importer un fichier CSV
- Visualiser les commandes
- Assigner des préparateurs
- **Gestion des Utilisateurs**
- Utilisateurs
- **Suivie des commandes**
- Suivie des commandes
# Préparateur
- Pas disponible

## Accès_Utilisateurs
# Identifiant | mot de passe 
# Cariste
- Kelvin | Admin123
- Sans | Admin123
# Responsable
- Quentin | Admin123
- Starpiou | Admin123
# Préparateurs
- Evan | Admin123
- Vavane | Admin234
- Terrine | Admin123

## Prérequis
- SQL Server Managment Studio 20
- Visual Studio
- Télécharger la base de donnée avec ses procédures et triggers et l'appeler "ap2prep'order"
- Changer la ligne de connexion sur le projet dans Bdd

## Langages_et_frameworks
- SQL Server Managment Studio 20
- Visual Studio (Community)
- C-Sharp
- SQL

## Documentation
- Maquettes
- Base de données
- Description des procédures et triggers

## Auteurs
- Kelvin Chauvel (Chef de projet)
- Quentin Heyblom
- Evan Ghislain
>>>>>>> develop
