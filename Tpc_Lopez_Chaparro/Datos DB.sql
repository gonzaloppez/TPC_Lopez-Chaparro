use TPC_LopezChaparroProga
go
--select * from Empleados
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1000, 'Gonzalo', 'Lopez', '36887980', '1134500808','gonza@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1001, 'Agustin', 'Chaparro', '33225466', '1134997808','Agustin@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1002, 'Alejandro', 'Bedgud', '90556989', '1135400408','ale.b@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1003, 'Daniela', 'Perez', '115356589', '1132621000','DaniPerez@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1004, 'Mariano', 'Soriano', '25689898', '1108002333','Soriano_Marian@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1005, 'Roberto', 'Lambert', '357896213', '1123330000','LabertRomer@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1006, 'Juliano', 'Romano', '21021011', '1136548989','RomeroJulian@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1007, 'Florencia', 'Cabrera', '268712369', '1110112598','CabreFlor@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1008, 'Daiana', 'Cabrera', '359898756', '45685988','Cabrera.d@gmail',1)
insert into Empleados (Legajo, Nombre, Apellido, DNI, Telefono, mail, Estado) values (1009, 'Melina', 'Doyenart', '32662599', '47094132','MDoyen@gmail',1)
Go
--Ingreso Usuarios-- select * from Usuario
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,Perfil) values (1,'gonzalopez',ENCRYPTBYPASSPHRASE('pass','Gonza'),'Administrador')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (2,'agusChaparro',ENCRYPTBYPASSPHRASE('pass','Agus'),'Administrador')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (3,'abegud',ENCRYPTBYPASSPHRASE('pass','Abegud2020'),'Mozo')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (4,'dperez',ENCRYPTBYPASSPHRASE('pass','DperezPiola'),'Cocina')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (5,'msoriano',ENCRYPTBYPASSPHRASE('pass','Msoriano_atlanta'),'Mozo')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (6,'rlambert',ENCRYPTBYPASSPHRASE('pass','Vikingo290'),'Mozo')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (7,'jromano',ENCRYPTBYPASSPHRASE('pass','jRoMaN10_boca'),'Cocina')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (8,'fcabrera',ENCRYPTBYPASSPHRASE('pass','LaFlor_20'),'Caja')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (9,'dcabrera',ENCRYPTBYPASSPHRASE('pass','DaiaNa1999'),'Caja')
Insert Into Usuario (IDEmpleado,NombreUsuario,contraseña,perfil) values (10,'mdoyenart',ENCRYPTBYPASSPHRASE('pass','doyenMel1929'),'Cocina')
go
--IngresoTipo_Platos select * from Tipo_Platos
Insert into Tipo_Platos (Nombre) Values ('Entrada')
Insert into Tipo_Platos (Nombre) Values ('Plato Principal')
Insert into Tipo_Platos (Nombre) Values ('Guarnicion')
Insert into Tipo_Platos (Nombre) Values ('Postre')
Insert into Tipo_Platos (Nombre) Values ('Bebida')
go
--Ingreso Carta-- select * from carta
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Picada para 2',560,1,'Queso Fontina, Salame picado fino, Aceitunas, Jamon cocido y Jamon Crudo')
Insert into Carta (Nombre,Precio,IDTipo_Platos) values ('Chicken Fingers',260,1)
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Rabas',620,1,'Rabas de pescado rebozadas')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Papas Bravas',320,1,'Papas al roquefort con salsa especial')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Milanesa',390,2,'Carne de Ternera')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Milanesa a la napolitana',420,2,'Milanesa con queso y salsa roja')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Suprema a la suiza',330,2,'Suprema con salsa blanca')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Vacio de novillo',560,2,'Vacio a la parrilla')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Asado',500,2,'Tira de asado a la parrilla')
Insert into Carta (Nombre,Precio,IDTipo_Platos) values ('Mollejas',490,2)
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Flan',120,4,'Con crema o dulce de leche')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Queso y Dulce',90,4,'Queso fresco y dulce de batata o membrillo')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Panqueque',70,4,'Con dulce de leche')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Frutillas',180,4,'Con crema')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Peras',60,4,'Peras al vino')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Coca Cola',100,5,'500CC')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Sprite CERO',95,5,'500CC')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Fanta',98,5,'500CC')
Insert into Carta (Nombre,Precio,IDTipo_Platos,Descripcion) values ('Cerveza',220,5,'500CC')
Insert into Carta (Nombre,Precio,IDTipo_Platos) values ('Pure de papas',180,3)
Insert into Carta (Nombre,Precio,IDTipo_Platos) values ('Papas fritas',220,3)
Insert into Carta (Nombre,Precio,IDTipo_Platos) values ('Pure de batata',150,3)
Insert into Carta (Nombre,Precio,IDTipo_Platos) values ('Arroz',90,3)
Insert into Carta (Nombre,Precio,IDTipo_Platos) values ('Batata frita',150,3)
go
--Ingreso Pedido select * from Pedido select * from carta
--
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (1,1,3,1,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (1,6,3,1,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (1,8,3,1,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (1,11,3,1,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (1,18,3,1,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (1,17,3,1,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (2,5,5,10,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (2,6,5,10,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (2,16,5,10,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (3,1,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (3,1,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (3,2,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (3,6,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,7,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,8,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,9,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,10,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,13,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,13,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,16,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,16,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (4,16,6,8,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (5,5,5,3,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (5,6,5,3,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (5,17,5,3,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (6,3,4,2,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (6,9,4,2,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (6,19,4,2,0)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (7,7,6,4,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (7,6,6,4,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (7,11,6,4,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (7,12,6,4,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (7,18,6,4,1)
Insert into Pedido (numPedido,IDCarta,IDEmpleado,NumeroMesa,Estado) values (7,18,6,4,1)
go
--Ingreso Comanda-- select * from detallePedido
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (1,1,1,560)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (1,6,1,420)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (1,8,1,560)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (1,11,1,120)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (1,18,1,98)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (1,17,1,95)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (2,5,1,250)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (2,6,1,420)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (2,16,1,100)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (3,1,2,1120)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (3,2,1,260)
Insert Into DetallePedido (NumPedido,IDCarta,cantidad,precio) values (3,6,1,420)
















