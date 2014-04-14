if exists(select 1 from sys.procedures where name = 'spFwkUsuariosGrd')
drop proc spFwkUsuariosGrd
go

create proc spFwkUsuariosGrd
(
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor	varchar(100),
	@pIdUsuario		varchar (50),
	@pNomUsuario		varchar (50),
	@pPassword		varchar	(50),
	@pEmail			varchar	(100)
)
as
begin

		if @pIdUsuario is not null begin
		select @pIdUsuario = '%' + @pIdUsuario + '%'
end	
	
	select	RowNumber = ROW_NUMBER() over (order by IdUsuario asc),
			IdUsuario,
			NomUsuario,
			[Password],
			Email
			
	into #tabla
	from FwkUsuarios 
	
	where (IdUsuario = @pIdUsuario or @pNomUsuario = 0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor
end

