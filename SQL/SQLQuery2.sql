--creation de base de donne
create database gestion_de_stock
--creation des tables
--table client
create table Client
(ID_Client int NOT NULL IDENTITY(1,1),--ajouter outomatique
Nom_Client nvarchar(250) NOT NULL,
Prenom_Client nvarchar(250) NOT NULL,
Adresse_Client nvarchar(250) NOT NULL,
Telephone_Client nvarchar(250) NOT NULL,
Ville_Client nvarchar(250) NOT NULL,
--clé primaire
constraint PK_Client PRIMARY KEY(ID_Client)
)
--create table de produit
create table Produit
(ID_Produit int NOT NULL IDENTITY(1,1),
Nom_Produit nvarchar(250) NOT NULL,
Quantite_Produit int NOT NULL,
Prix_Produit nvarchar(250) NOT NULL,
Image_Produit IMAGE NOT NULL,
ID_CATEGORIE int NOT NULL,--clé étrangire de categorie
--clé primaire
constraint PK_Produit PRIMARY KEY(ID_Produit),
)
--table categorie
create table Categorie
(ID_CATEGORIE int NOT NULL IDENTITY(1,1),
Nom_Categorie nvarchar(250) not null,
--clé primaire
constraint PK_Categorie PRIMARY KEY (ID_CATEGORIE)
)
--table commend
create table Commande
(ID_Commande int not null identity(1,1),
Date_Commande datetime not null,
--------------
ID_Client int not null,--clé etrangire de table client
--clé primaire
constraint PK_Commande primary key (ID_Commande)
)
--table details de commande
create table Details_Commande
(ID_Commande int not null,
 ID_Produit int NOT NULL,
 Quantite int not null,
)
--table utulisateur
create table Utulisateur
(NomUtulisateur nvarchar(250) not null,
Mot_De_Pass nvarchar(250) not null,
--cle primiaire
constraint PK_Utulisateur primary key (NomUtulisateur)
)