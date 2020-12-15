/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO Contact VALUES ('Pendragon', 'Arthur', 'arthur@cuillere.com')
INSERT INTO Contact VALUES ('Ator', 'Termin', 'terminator@skynet.com')
INSERT INTO Contact VALUES ('Norris', 'Chuck', 'god@beatall.com')