USE TPFinalDisYAdmDB

GO
CREATE TABLE TipoDocumento(
	CodDoc int NOT NULL,
	Descripcion_TipDoc nchar(20) NOT NULL,
	CONSTRAINT PK_TipoDocumento_CodDoc PRIMARY KEY (CodDoc)
)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE TPFinalDisYAdmDB
GO
CREATE TABLE Alumnos (
	NroLegajo_A int NOT NULL,
	NombreApellido_A nchar(20) NOT NULL,
	DNI_A int NOT NULL,
	FechaNac_A datetime NOT NULL,
	mail_A nchar(40) NULL,
	EstadoCivil_A nchar(1) NULL,
	Domicilio_A nchar(20) NOT NULL,
	Telefono_A nchar(40) NOT NULL,
	CONSTRAINT PK_Alumnos_NroLegajo_A PRIMARY KEY (NroLegajo_A)
)


ALTER TABLE Alumnos  WITH CHECK ADD  CONSTRAINT FK_ALumnos_DNI FOREIGN KEY(DNI_A)REFERENCES TipoDocumento (CodDoc)
ALTER TABLE Alumnos  WITH CHECK ADD  CONSTRAINT CK_EstadoCivil_A CHECK  ((EstadoCivil_A='S' OR EstadoCivil_A='C' OR EstadoCivil_A = 'D' OR EstadoCivil_A  = 'V'))
ALTER TABLE Alumnos ADD  CONSTRAINT DF_mail_A  DEFAULT (N'No tiene') FOR mail_A
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE Titulos (
	IDTitulo nchar(5) NOT NULL,
	Decripcion_Titulos nchar(40) NOT NULL,
	CONSTRAINT PK_IDTitulo PRIMARY KEY (IDTitulo)
)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE Profesores(
	NroLegajo_P int NOT NULL,
	NombreApellido_P nchar(20) NOT NULL,
	DNI_P int NOT NULL,
	FechaNac_P datetime NOT NULL,
	mail_P nchar(40) NULL,
	EstadoCivil_P nchar(1) NULL,
	Domicilio_P nchar(20) NOT NULL,
	Telefono_P nchar(40) NOT NULL,
	Titulo_P nchar(5) NOT NULL,
	CONSTRAINT PK_Profesores_NroLegajo_P PRIMARY KEY (NroLegajo_P)
)

ALTER TABLE Profesores  WITH CHECK ADD  CONSTRAINT FK_Profesores_DNI FOREIGN KEY(DNI_P)REFERENCES TipoDocumento (CodDoc)
ALTER TABLE Profesores  WITH CHECK ADD  CONSTRAINT FK_Profesores_Titulo FOREIGN KEY(Titulo_P)REFERENCES Titulos (IDTitulo)
ALTER TABLE Profesores  WITH CHECK ADD  CONSTRAINT CK_EstadoCivil_P CHECK  ((EstadoCivil_P='S' OR EstadoCivil_P='C' OR EstadoCivil_P = 'D' OR EstadoCivil_P  = 'V'))
ALTER TABLE Profesores ADD  CONSTRAINT DF_mail_P  DEFAULT (N'No tiene') FOR mail_P
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE Turnos(
	IDTurno nchar(5) NOT NULL,
	Descripcion_Turnos nchar(40) NOT NULL
	CONSTRAINT PK_Turnos_IDTurno PRIMARY KEY (IDTurno)
)
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE Planificacion(
	año nchar(8) NOT NULL,
	cod_turno nchar(5) NOT NULL,
	cod_materia nchar(5) NOT NULL,
	fecha_examen date NOT NULL,
	CONSTRAINT PK_Planificacion PRIMARY KEY (año, cod_materia, cod_turno)
	)

--ALTER TABLE Planificacion ADD CONSTRAINT FK_cod_turno_p FOREIGN KEY (cod_turno) REFERENCES Turnos (cod_turno);
--ALTER TABLE Planificacion ADD CONSTRAINT FK_cod_materia_p FOREIGN KEY (cod_materia) REFERENCES Materias (cod_materia);
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
GO
CREATE TABLE Materias(
	IDMateria nchar(5) NOT NULL,
	DescripcionMateria nchar(20) NOT NULL,
	Carrera nchar (20),
	NroLegajo_P int NOT NULL,
	CONSTRAINT PK_Mateiras_IDMateria PRIMARY KEY (IDMateria)
)

ALTER TABLE Materias ADD CONSTRAINT FK_Materias_NroLegP FOREIGN KEY (NroLegajo_P) REFERENCES Profesores (NroLegajo_P)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
GO 
CREATE TABLE Examenes(
	año nchar(8) NOT NULL,
	cod_materia nchar(5) NOT NULL,
	cod_turno nchar(5) NOT NULL,
	nro_legajo_a int NOT NULL,
	nota numeric(2,0),
	fecha_inscripcion date NOT NULL,
	CONSTRAINT PK_Examenes PRIMARY KEY (año, cod_materia, cod_turno, nro_legajo_a)
)

ALTER TABLE Examenes ADD CONSTRAINT FK_Planificacion_e FOREIGN KEY (año, cod_materia, cod_turno) REFERENCES Planificacion(año, cod_materia, cod_turno)
ALTER TABLE Examenes ADD CONSTRAINT FK_Alumno_e FOREIGN KEY (nro_legajo_a) REFERENCES Alumnos (NroLegajo_A)
ALTER TABLE Examenes ADD CONSTRAINT FK_materias FOREIGN KEY (cod_materia) REFERENCES Materias (IDMateria)
ALTER TABLE Examenes ADD CONSTRAINT FK_turnos FOREIGN KEY (cod_turno) REFERENCES Turnos (IDTurno)
