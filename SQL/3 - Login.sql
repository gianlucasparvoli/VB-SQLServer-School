USE TPFinalDisYAdmDB
CREATE TABLE Login_Usuarios(
	Usuario nchar (100) NOT NULL,
	Contaseña nchar (100) NOT NULL,
	CONSTRAINT PK_LoginUsuarios PRIMARY KEY (Usuario,Contaseña)
) 

INSERT INTO Login_Usuarios(Usuario,Contaseña) VALUES ('admin','admin123')
INSERT INTO Login_Usuarios(Usuario,Contaseña) VALUES ('root','1234')

select * from Login_Usuarios