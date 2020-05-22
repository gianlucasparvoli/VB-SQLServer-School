USE TPFinalDisYAdmDB

--Para Alumnos
INSERT INTO TipoDocumento (CodDoc,Descripcion_TipDoc) VALUES('001','DNI')
INSERT INTO TipoDocumento (CodDoc,Descripcion_TipDoc) VALUES('002','Pasaporte')
INSERT INTO TipoDocumento (CodDoc,Descripcion_TipDoc) VALUES('003','Carnet extranjero')
INSERT INTO TipoDocumento (CodDoc,Descripcion_TipDoc) VALUES('004','Reg unico de contrib')
INSERT INTO TipoDocumento (CodDoc,Descripcion_TipDoc) VALUES('005','Partida nacimiento')

--Para Profesores
INSERT INTO Titulos (IDTitulo,Decripcion_Titulos) VALUES ('AA001','Universitario')
INSERT INTO Titulos (IDTitulo,Decripcion_Titulos) VALUES ('AA002','Terciario')
INSERT INTO Titulos (IDTitulo,Decripcion_Titulos) VALUES ('AA003','Secundario')
INSERT INTO Titulos (IDTitulo,Decripcion_Titulos) VALUES ('AA004','Primario')
------------------------------------------------------------------------------------
INSERT INTO Profesores(NroLegajo_P,NombreApellido_P,DNI_P,FechaNac_P,mail_P,
EstadoCivil_P,Domicilio_P,Telefono_P,Titulo_P) 
VALUES ('1','Julian Castaña','003','01/02/70','jcastaña@hotmail.com',
'C','Savio 39','3364899807','AA001')

INSERT INTO Profesores(NroLegajo_P,NombreApellido_P,DNI_P,FechaNac_P,mail_P,
EstadoCivil_P,Domicilio_P,Telefono_P,Titulo_P) 
VALUES ('2','Pedro Gonzalez','001','01/06/77','pgon@hotmail.com',
'D','Savio 798','3364212132','AA002')

INSERT INTO Profesores(NroLegajo_P,NombreApellido_P,DNI_P,FechaNac_P,mail_P,
EstadoCivil_P,Domicilio_P,Telefono_P,Titulo_P) 
VALUES ('3','Jose Kekio','001','01/06/74','ffff@hotmail.com',
'D','Savio 21','33345544','AA004')

INSERT INTO Profesores(NroLegajo_P,NombreApellido_P,DNI_P,FechaNac_P,mail_P,
EstadoCivil_P,Domicilio_P,Telefono_P,Titulo_P) 
VALUES ('4','Juan Perez','005','01/06/74','jperez@hotmail.com',
'D','Roca 451','556666777','AA003')

INSERT INTO Profesores(NroLegajo_P,NombreApellido_P,DNI_P,FechaNac_P,mail_P,
EstadoCivil_P,Domicilio_P,Telefono_P,Titulo_P) 
VALUES ('5','Juan Sebastian Kekio','001','01/06/74','ffff@hotmail.com',
'S','Savio 41','9990087','AA002')

-------------------------------------------------------------------------------------

INSERT INTO Alumnos(NroLegajo_A,NombreApellido_A,DNI_A,FechaNac_A,mail_A,
EstadoCivil_A,Domicilio_A,Telefono_A) 
VALUES ('1','Cosme Fulanito','001','08/08/99','cf@hotmail.com',
'S','Brown 12','123456789')

INSERT INTO Alumnos(NroLegajo_A,NombreApellido_A,DNI_A,FechaNac_A,mail_A,
EstadoCivil_A,Domicilio_A,Telefono_A) 
VALUES ('2','Juan Rodriguez','003','08/08/78','jr@hotmail.com',
'C','Savio 12','987654321')

INSERT INTO Alumnos(NroLegajo_A,NombreApellido_A,DNI_A,FechaNac_A,mail_A,
EstadoCivil_A,Domicilio_A,Telefono_A) 
VALUES ('3','Pedro Perez','001','08/08/66','cf@hotmail.com',
'S','Pellegrini 123','444455566')

INSERT INTO Alumnos(NroLegajo_A,NombreApellido_A,DNI_A,FechaNac_A,mail_A,
EstadoCivil_A,Domicilio_A,Telefono_A) 
VALUES ('4','Nicolas Funes','001','08/06/56','nfunes@hotmail.com',
'C','Pellegrini 98','111133344')

INSERT INTO Alumnos(NroLegajo_A,NombreApellido_A,DNI_A,FechaNac_A,mail_A,
EstadoCivil_A,Domicilio_A,Telefono_A) 
VALUES ('5','Sebastian Palacios','004','08/01/34','spal@hotmail.com',
'V','Brown 34','99807633')

----------------------------------------------------------------------------------------

INSERT INTO Materias(IDMateria,DescripcionMateria,Carrera,NroLegajo_P) 
VALUES ('1','Fisica','Ing Industrial','1')

INSERT INTO Materias(IDMateria,DescripcionMateria,Carrera,NroLegajo_P) 
VALUES ('2','Estadistica','Tec Sup Progr','3')

INSERT INTO Materias(IDMateria,DescripcionMateria,Carrera,NroLegajo_P) 
VALUES ('3','Quimica','Ing Industrial','5')

INSERT INTO Materias(IDMateria,DescripcionMateria,Carrera,NroLegajo_P) 
VALUES ('4','Analisis Matematico','Ing Industrial','4')

INSERT INTO Materias(IDMateria,DescripcionMateria,Carrera,NroLegajo_P) 
VALUES ('5','Ingles','Ing Mecanica','2')
