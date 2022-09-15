CREATE DATABASE Tiendas;

CREATE TABLE Producto
(
 idProducto INT PRIMARY KEY,
 nombre VARCHAR(250),
 descripcion VARCHAR(250),
 precio VARCHAR(50)
);

delimiter $$
DROP PROCEDURE if EXISTS p_lanzarerror;
CREATE PROCEDURE p_lanzarerror(
IN p_mensaje VARCHAR(100)
) BEGIN DECLARE EXIT HANDLER FOR SQLSTATE "42000"
SELECT p_mensaje AS "Tienda Ramon el dragon"; CALL raise_error;
 END;

delimiter ;;
create procedure insertProducto( 

     in _idproducto int, in _nombre VARCHAR(250), in _descripcion VARCHAR(250), IN _precio VARCHAR(50)) 

    begin 

    declare x int; 

    select count(*) from producto where nombre=_nombre into x; 

    if x=0 and _idProducto<0 then 

    insert into producto values(_idproducto, _nombre, _descripcion, _precio); 

    else if x=0 and _idproducto>0 then 

    update producto set nombre = _nombre, descripcion = _descripcion, precio = _precio
	 where idproducto=_idproducto; 

    else 

    update producto set nombre = _nombre, descripcion = _descripcion, precio= _precio where idproducto=_idproducto; 

    end if; 

    end if; 

end;; 
	
