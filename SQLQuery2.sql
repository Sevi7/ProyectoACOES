USE [ACOES]
GO

insert into Beneficiario(nif, nombre, apellidos, observaciones, numcuenta, eliminado, responsable) values ('12345H', 'Ramona', 'Ramirez', 'Cocinera', 'ES123456789', 0,'12345R');

insert into Beneficiario(nif, nombre, apellidos, observaciones, numcuenta, eliminado,responsable) values ('23456Q', 'Jesus', 'Llorente', 'Limpiador', 'ES234567890', 0,'12345R');

insert into Beneficiario(nif, nombre, apellidos, observaciones, numcuenta, eliminado,responsable) values ('45678J', 'Andrea', 'García', 'Profesora', 'ES456789012', 0,'12345R');

insert into Beneficiario(nif, nombre, apellidos, observaciones, numcuenta, eliminado,responsable) values ('56789X', 'Álvaro', 'Vallejo', 'Profesor', 'ES567890123', 0,'12345R');

insert into Beneficiario(nif, nombre, apellidos, observaciones, numcuenta, eliminado,responsable) values ('67890D', 'GreenPace', '', 'Proveedor', 'ES678901234', 0,'12345R');

insert into Socio(nombre, apellidos, estado, nif, direccion, codigoPostal, email, relacion, certificado, numCuenta, eliminado,tlf,agente,fechaAlta,fechaBaja,provincia) values ('Beatriz', 'Carrion', 'Casada', '51234J', 'Castellón de la plona, n24', 21002, 'bea@gmail.com', 'Cuñada', 1, 'ES6732012234', 0,952408765,'12345A','2012-10-23','2018-07-11','Málaga');

insert into Socio(nombre, apellidos, estado, nif, direccion, codigoPostal, email, relacion, certificado, numCuenta, eliminado,tlf,agente,fechaAlta,fechaBaja,provincia) values ('Pablo', 'Bautista', 'Soltero', '71367K', 'Castellón de la plona, n20', 21002, 'pablo@gmail.com', 'Vecino', 1, 'ES3714022834', 0,951874632,'12345A','2014-10-28','2017-02-05','Málaga');

insert into Socio(nombre, apellidos, estado, nif, direccion, codigoPostal, email, relacion, certificado, numCuenta, eliminado,tlf,agente,fechaAlta,fechaBaja,provincia) values ('Francisco', 'Diaz', 'Casado', '92820L', 'Castellón de la plona, n24', 21002, 'diaz@gmail.com', 'Hermano', 1, 'ES6732012234', 0,952896534,'12345A','2011-01-13','2016-06-11','Málaga');

INSERT INTO Calificacion VALUES (1,5,'Lengua','2018-12-19');
INSERT INTO Calificacion VALUES (1,2,'Matematicas','2018-11-02');
INSERT INTO Calificacion VALUES (2,10,'Matematicas','2018-09-27');

INSERT INTO Comunidad VALUES ('El Espino','Poblado del Departamento de Valle, en Honduras. El poblado se encuentra a una altitud de 23 metros sobre el nivel del mar.');
INSERT INTO Comunidad VALUES ('Madrigales','');
INSERT INTO Comunidad VALUES ('Duyure','El casco urbano del municipio está situado 32 kilómetros al norte de San Marcos de Colón por una carretera de tierra connectada con la Carretera Pan-Americana.');

insert into TipoProyecto(nombre,descripcion,coordinador,responsable) values ('Casa Populorum', 'Sitio agradable', '12345C','12345R');
insert into Proyecto(nombre, tipo_proyecto, coordinador, responsable, localidad) values ('PUS','Casa Populorum','12345C', '12345R', 'Madrigales');
insert into Proyecto(nombre, tipo_proyecto, coordinador, responsable, localidad) values ('FUSTA','Casa Populorum','12345C', '12345R', 'Madrigales');
insert into Proyecto(nombre, tipo_proyecto, coordinador, responsable, localidad) values ('ALLOP','Casa Populorum','12345C', '12345R','Madrigales');
insert into Cuenta(tipo,nombre,categoria,cantidad,fecha,descripcion,validado) values ('Ingreso','Romana Ramirez', 'Nutrición','1000','12/07/2015', 'Lentejas', '1');
insert into Cuenta(tipo,nombre,categoria,cantidad,fecha,descripcion,validado) values ('Ingreso','Romana Ramirez', 'Nutrición','1000','12/07/2015', 'Paella', '1');
insert into Cuenta(tipo,nombre,categoria,cantidad,fecha,descripcion,validado) values ('Ingreso','Romana Ramirez', 'Nutrición','500','12/07/2015', 'Potaje de garbanzos', '1');
insert into CuentaTipoProyecto(cuenta,tipoProyecto) values('1','Casa Populorum');
insert into CuentaTipoProyecto(cuenta,tipoProyecto) values('2','Casa Populorum');
insert into CuentaTipoProyecto(cuenta,tipoProyecto) values('3','Casa Populorum');
