CREATE DATABASE workTeam;

USE workTeam;
-- Tareas
-- TareasPorActividad
-- ActividadesPorProyecto
-- TODO
--Recursos

create table To_do(
	Tod_id int not null	identity(1,1) primary key
);

create table Actividades_Proyecto(
	ActPro_id int not null
);

create table Recurso(
	Rec_id int not null identity(1, 1) primary key,
	Rec_Description varchar(100) not null,
	Proyecto_id int not null
);
