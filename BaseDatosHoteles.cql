/*CREATE KEYSPACE baseHoteles
WITH replication ={
	'class':'SimpleStrategy',
	'replication_factor':1
};
USE baseHoteles;*/

 CREATE TABLE IF NOT EXISTS USUARIOS(
 	correo TEXT PRIMARY KEY,
 	nombre text,
 	password TEXT,
 	nomina TEXT,
 	nacimiento DATE,
 	-- telefonos casa/cel <data collection>
 	--telefonos LIST<numeros>, 
	-- tipo 	
	fechaRegistro DATE 
 );
 
 CREATE TABLE IF NOT EXISTS CLIENTES(

 	//id ?
 	nombre VARCHAR,
 	ciudad VARCHAR,
 	estado VARCHAR,
 	pais VARCHAR,
 	rfc VARCHAR PRIMARY KEY,
 	correo VARCHAR,
 	-- telefono casa/cel <data collection>
 	
 	password VARCHAR,
 	nomina INT,
 	nacimiento DATE,
 	-- telefonos <data collection> 
 	estadoCivil VARCHAR	 
 );

CREATE TYPE IF NOT EXISTS habitacion (
    cama TEXT,
    precio DECIMAL,
    cantidad_personas INT,
    nivel TEXT,
    amenidades MAP<TEXT, TEXT>
);

CREATE TABLE IF NOT EXISTS hoteles (
    nombre TEXT PRIMARY KEY,
    ciudad TEXT,
    estado TEXT,
    pais TEXT,
    domicilio TEXT,
    num_pisos INT,
    habitaciones LIST<FROZEN<habitacion>>,
    zona_turistica TEXT,
    servicios_adicionales LIST<TEXT>,
    frente_a_playa TEXT,
    inicio_operaciones DATE
);



CREATE TABLE IF NOT EXISTS reservaciones (
    id UUID PRIMARY KEY,
    fecha_reserva DATE,
    nombre_cliente TEXT,
    check_in DATE,
    check_out DATE,
    fecha_cancelacion DATE,
    habitaciones LIST<TEXT>,  -- IDs o nombres de habitaciones
    num_personas INT,
    anticipo DECIMAL,
    tipo TEXT,
    guid TEXT
);

 
/*
 
 create table IF not exists HOTELES(
 	numbre TEXT PRIMARY KEY
 	
 );*/
 