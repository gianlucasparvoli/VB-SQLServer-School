--USE TPFinalDisYAdmDB
--Vista de Consulta de Alumnos
--DROP VIEW VISTA_ConsultaAlumnos
CREATE VIEW VISTA_ConsultaAlumnos AS 
SELECT	NroLegajo_A AS 'Numero Legajo',
		CASE	WHEN NombreApellido_A IS NULL THEN '-' 
				ELSE NombreApellido_A
				END AS 'Nombre y Apellido',
		Descripcion_TipDoc AS 'Tipo Documento',
		FechaNac_A AS 'Fecha Nacimiento',
		CASE	WHEN mail_A IS NULL THEN '-' 
				ELSE mail_A
				END AS 'Mail',
		CASE	WHEN Domicilio_A IS NULL THEN '-' 
				ELSE Domicilio_A
				END AS 'Domicilio',
		CASE	WHEN Telefono_A IS NULL THEN '-' 
				ELSE Telefono_A
				END AS 'Telefono',
		CASE	WHEN EstadoCivil_A = 'V' THEN 'Viudo'
				WHEN EstadoCivil_A = 'C' THEN 'Casado'
				WHEN EstadoCivil_A = 'S' THEN 'Soltero'	
				WHEN EstadoCivil_A = 'D' THEN 'Divorciado'
		ELSE	''
		END AS 'Estado Civil'
FROM Alumnos,TipoDocumento
WHERE TipoDocumento.CodDoc = Alumnos.DNI_A
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--Vista de Consulta de Profesores
--DROP VIEW VISTA_ConsultaProfesores
CREATE VIEW VISTA_ConsultaProfesores AS 
SELECT	NroLegajo_P AS 'Numero Legajo',
		CASE	WHEN NombreApellido_P IS NULL THEN '-' 
				ELSE NombreApellido_P
				END AS 'Nombre y Apellido',
		Descripcion_TipDoc AS 'Tipo Documento',
		FechaNac_P AS 'Fecha Nacimiento',
		CASE	WHEN mail_P IS NULL THEN '-' 
				ELSE mail_P
				END AS 'Mail',
		CASE	WHEN Domicilio_P IS NULL THEN '-' 
				ELSE Domicilio_P
				END AS 'Domicilio',
		CASE	WHEN Telefono_P IS NULL THEN '-' 
				ELSE Telefono_p
				END AS 'Telefono',
		CASE	WHEN EstadoCivil_P = 'V' THEN 'Viudo'
				WHEN EstadoCivil_P = 'C' THEN 'Casado'
				WHEN EstadoCivil_P = 'S' THEN 'Soltero'	
				WHEN EstadoCivil_P = 'D' THEN 'Divorciado'
		ELSE	''
		END AS 'Estado Civil',
		Decripcion_Titulos AS 'Titulo'
FROM Profesores,TipoDocumento,Titulos
WHERE (TipoDocumento.CodDoc = Profesores.DNI_P) AND (Titulos.IDTitulo = Profesores.Titulo_P)
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--Vista de Consulta de Examenes
--DROP VIEW VISTA_ConsultaExamenes
CREATE VIEW VISTA_ConsultaExamenes AS 
SELECT	año AS 'Año',
		cod_materia AS 'Codigo Materia',
		cod_turno AS 'Codigo Turno',
		NombreApellido_A AS 'Alumno',
		nota AS 'Nota',
		fecha_inscripcion AS 'Fecha Inscripcion'
FROM Examenes,Alumnos
WHERE Examenes.nro_legajo_a = Alumnos.NroLegajo_A
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--Vista de Consulta de Planificacion
--DROP VIEW VISTA_ConsultaPlanificacion
CREATE VIEW VISTA_ConsultaPlanificacion AS 
SELECT	año AS 'Año',
		cod_turno AS 'Codigo Turno',
		cod_materia AS 'Coddigo Materia',
		fecha_examen AS 'Fecha Examen'
FROM Planificacion
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--Vista de Consulta de TipoDocumento
--DROP VIEW VISTA_ConsultaTipoDocumento
CREATE VIEW VISTA_ConsultaTipoDocumento AS 
SELECT	CodDoc AS 'Codigo Documento',
		Descripcion_TipDoc AS 'Decripcion'
FROM TipoDocumento
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--Vista de Consulta de Titulos
--DROP VIEW VISTA_ConsultaTitulos
CREATE VIEW VISTA_ConsultaTitulos AS 
SELECT	IDTitulo AS 'ID Titulo',
		Decripcion_Titulos AS 'Descripcion'
FROM Titulos
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--Vista de Consulta de Turnos
--DROP VIEW VISTA_ConsultaTurnos
CREATE VIEW VISTA_ConsultaTurnos AS 
SELECT	IDTurno AS 'ID Turno',
		Descripcion_Turnos AS 'Descripcion'
FROM Turnos
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--Vista de Consulta de Materias
--DROP VIEW VISTA_ConsultaMaterias
CREATE VIEW VISTA_ConsultaMaterias AS 
SELECT	IDMateria AS 'ID Materia',
		DescripcionMateria AS 'Descripcion Materia',
		Carrera,
		NombreApellido_P AS 'Profesor'
FROM Materias,Profesores
WHERE Materias.NroLegajo_P = Profesores.NroLegajo_P
-----------------------------------------------------------------------
-----------------------------------------------------------------------
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--Stores Procedures para Update (modificacion)
--SP Para modificacion de alumno
--drop procedure SP_ModifAlumno
CREATE PROCEDURE SP_ModifAlumno 
	@legajo int,
	@nomap nchar(20), 
	@dni int,
	@fecnac datetime,
	@mail nchar(40),
	@ec nchar(1),
	@domic nchar(20),
	@tel nchar(40)
	AS
		UPDATE	Alumnos SET
				NombreApellido_A = @nomap,
				DNI_A = @dni,
				FechaNac_A = @fecnac,
				mail_A = @mail,
				EstadoCivil_A = @ec,
				Domicilio_A = @domic,
				Telefono_A = @tel
		WHERE NroLegajo_A = @legajo
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--SP Para modificacion de profesores
--drop procedure SP_ModifProf
CREATE PROCEDURE SP_ModifProf
	@legajo int,
	@nomap nchar(20), 
	@dni int,
	@fecnac datetime,
	@mail nchar(40),
	@ec nchar(1),
	@domic nchar(20),
	@tel nchar(40),
	@titulo nchar (5)
	AS
		UPDATE	Profesores SET
				NombreApellido_P = @nomap,
				DNI_P = @dni,
				FechaNac_P = @fecnac,
				mail_P = @mail,
				EstadoCivil_P = @ec,
				Domicilio_P = @domic,
				Telefono_P = @tel,
				Titulo_P = @titulo
		WHERE NroLegajo_P = @legajo
-----------------------------------------------------------------------
-----------------------------------------------------------------------
--SP Para modificacion de materias
--drop procedure SP_ModifMaterias
CREATE PROCEDURE SP_ModifMaterias
	@id nchar(5),
	@descrip nchar(20),
	@carrera nchar (20),
	@legajoProf int
	AS
		UPDATE	Materias SET
				DescripcionMateria = @descrip,
				Carrera = @carrera,
				NroLegajo_P = @legajoProf
		WHERE IDMateria = @id