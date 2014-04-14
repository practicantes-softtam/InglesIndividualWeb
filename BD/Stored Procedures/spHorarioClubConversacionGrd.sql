if exists(select 1 from sys.procedures where name = 'spHorarioClubConversacionGrd')
drop proc spHorarioClubConversacionGrd
go

create proc spHorarioClubConversacionGrd
(
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor	varchar(100),
	@pClaCampus		int,
	@pClaEmpleado	int,
	@pClaHorario	int,
	@pClaDia		int,
	@pHoras			int
	
)
as
begin

		if @pClaCampus is not null begin
		select @pClaCampus = '%' + @pClaHorario + '%'
	end	
	
	select	RowNumber = ROW_NUMBER() over (order by ClaCampus asc), 
		 ClaCampus, 
		 ClaEmpleado, 
		 ClaHorario, 
		 ClaDia, 
		 Horas
		 
		 into #tabla
	from HorarioClubConversacion 
	where ClaCampus like @pClaCampus 
	and (ClaEmpleado=@pClaEmpleado or @pClaEmpleado=0)
	and (ClaHorario=@pClaHorario or @pClaHorario=0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

