if exists(select 1 from sys.procedures where name = 'spHuellasPersonasGrd')
drop proc spHuellasPersonasGrd
go

create proc spHuellasPersonasGrd
(
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor	varchar(100),
	@pIdRegistro	int,
	@pClaCampus		int,
	@pMatricula		varchar (10),
	@pClaEmpleado	int,
	@pTipoPersona	int,
	@pHuella		image
	
)
as
begin

		if @pIdRegistro is not null begin
		select @pIdRegistro = '%' + @pIdRegistro + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by IdRegistro asc), 
		 IdRegistro,
		 ClaCampus, 
		 Matricula,
		 ClaEmpleado, 
		 TipoPersona, 
		 Huella
		 
	
	into #tabla
	from HuellasPersonas 
	where Matricula like @pMatricula 
	
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

