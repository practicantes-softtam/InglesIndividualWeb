if exists(select 1 from sys.procedures where name = 'spFwkUsuariosSistemaSeguridadGrd')
drop proc spFwkUsuariosSistemaSeguridadGrd
go

create proc spFwkUsuariosSistemaSeguridadGrd
(
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor	varchar(100),
	@pIdRegistro	int,
	@pIdUsuario		varchar (50)
	
)
as
begin

	select	RowNumber = ROW_NUMBER() over (order by IdRegistro asc),
			IdRegistro, 
			IdUsuario
			
	into #tabla
	from FwkUsuariosSistemaSeguridad 
	
	where (IdRegistro = @pIdRegistro or @pIdUsuario = 0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor
end

