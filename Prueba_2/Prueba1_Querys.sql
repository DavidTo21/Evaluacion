-------------PRUEBA 1-----------
--Crear base de datos--
CREATE DATABASE TestDevBackJr;
USE TestDevBackJr;

--Crear tabla usuarios--
CREATE TABLE usuarios(
	userId INT PRIMARY KEY IDENTITY(1,1),
	Login VARCHAR(100) NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	Paterno VARCHAR(100) NOT NULL,
	Materno VARCHAR(100) NOT NULL
);
--Create tabla empleados--
CREATE TABLE empleados(
	userId INT NOT NULL,
	Sueldo FLOAT NOT NULL,
	FechaIngreso DATE,
	FOREIGN KEY (userId) REFERENCES usuarios (userId)
);


--Consultas--
--1--
DELETE FROM usuarios WHERE (userId<>6 AND userId<>7 AND userId<>9 AND userId<>10);
--2--
UPDATE empleados SET Sueldo=Sueldo+(Sueldo*0.10) WHERE FechaIngreso BETWEEN '01-01-2000' AND '31-12-2001';
--3--
SELECT 
CONCAT(u.Nombre,' ',u.Paterno,' ',Materno) [Nombre Usuario],
e.FechaIngreso [Fecha Ingreso]
FROM usuarios u
INNER JOIN empleados e ON e.userId=u.userId
WHERE e.Sueldo>10000 AND u.Paterno LIKE 'T_%';
--4--
--Sueldo Menor a 1200
SELECT
Sueldo,
Count(*) Cantidad
FROM empleados
WHERE Sueldo>=1200
GROUP BY Sueldo
--Sueldo Mayor o igual a 1200
SELECT
Sueldo,
COUNT(*) userId
FROM empleados
WHERE Sueldo>=1200
GROUP BY Sueldo
