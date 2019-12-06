USE ALMACEN_FACTURAS
GO
alter proc spActualizanNumFactInventario
	@pID_INVENTARIO INT,
	@pFOLIO_FACTURA VARCHAR (36)
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and FOLIO_FACTURA =@pFOLIO_FACTURA)
begin
 update TBL_INVENTARIO
	set 
	FOLIO_FACTURA = @pFOLIO_FACTURA
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO
---------------------------------
create proc spActualizanFuenteFinanInventario
	@pID_INVENTARIO INT,
	@pFUENTE_ID INT
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and FUENTE_ID =@pFUENTE_ID)
begin
 update TBL_INVENTARIO
	set 
	FUENTE_ID = @pFUENTE_ID
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO
----------------------------------------------------------
create proc spActualizaResguardatarioInventario
	@pID_INVENTARIO INT,
	@pRESGUARDATARIO_ID INT
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and RESGUARDATORIO_ID =@pRESGUARDATARIO_ID)
begin
 update TBL_INVENTARIO
	set 
	RESGUARDATORIO_ID = @pRESGUARDATARIO_ID
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO
-----------------------------------------
create proc spActualizaPolizaInventario
	@pID_INVENTARIO INT,
	@pPOLIZA VARCHAR (10)
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and POLIZA =@pPOLIZA)
begin
 update TBL_INVENTARIO
	set 
	POLIZA = @pPOLIZA
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO
---------------------------------
create proc spActualizaNumInventario
	@pID_INVENTARIO INT,
	@pNUM_INVENTARIO VARCHAR (36)
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and NUM_INVENTARIO = @pNUM_INVENTARIO)
begin
 update TBL_INVENTARIO
	set 
	NUM_INVENTARIO = @pNUM_INVENTARIO
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO
--------------------------------------------------------
create proc spActualizaEjercicioInventario
	@pID_INVENTARIO INT,
	@pEJERICICIO INT
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and EJERCICIO_ID = @pEJERICICIO)
begin
 update TBL_INVENTARIO
	set 
	EJERCICIO_ID = @pEJERICICIO
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO
--------------------------------------------------------------------------
create proc spActualizaProveedorInventario
	@pID_INVENTARIO INT,
	@pPROVEEDOR_ID INT
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and PROVEEDOR_ID = @pPROVEEDOR_ID)
begin
 update TBL_INVENTARIO
	set 
	PROVEEDOR_ID = @pPROVEEDOR_ID
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO
----------------------------------------------------------------------

create proc spActualizaUbicacionInventario
	@pID_INVENTARIO INT,
	@pUBICACION_ID INT
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and UBICACION_ID = @pUBICACION_ID)
begin
 update TBL_INVENTARIO
	set 
	UBICACION_ID = @pUBICACION_ID
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO
----------------------------------------------------

create proc spActualizaValorInventario
	@pID_INVENTARIO INT,
	@pVALOR decimal(18,2)
	


as 
if not exists (select 1 from TBL_INVENTARIO where ID_INVENTARIO <> @pID_INVENTARIO and VALOR = @pVALOR)
begin
 update TBL_INVENTARIO
	set 
	VALOR = @pVALOR
	where ID_INVENTARIO = @pID_INVENTARIO
end  
GO