USE TPFinalDisYAdmDB
CREATE TABLE Login_Usuarios(
	Usuario nchar (100) NOT NULL,
	Contase�a nchar (100) NOT NULL,
	CONSTRAINT PK_LoginUsuarios PRIMARY KEY (Usuario,Contase�a)
) 

INSERT INTO Login_Usuarios(Usuario,Contase�a) VALUES ('admin','admin123')
INSERT INTO Login_Usuarios(Usuario,Contase�a) VALUES ('root','1234')

select * from Login_Usuarios