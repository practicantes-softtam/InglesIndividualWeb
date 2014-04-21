if exists (select 1 from sys.procedures where name = 'spAmpliacionesGrd')
drop proc spAmpliacionesGrd
go

CREATE proc spAmpliacionesGrd
(
	@pMatricula varchar (10),
	@pClaNivel	int,
	@pClaLeccion int,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pMatricula is not null begin
		select @pMatricula = '%' + @pMatricula + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by Matricula asc), 
		 IdAmpliacion, Matricula,Vigencia,Comentarios,Estatus,a.ClaNivel,a.ClaLeccion
	into #tabla
	from Ampliaciones a
	inner join Niveles n on a.ClaNivel = n.ClaNivel
	inner join Lecciones l on l.ClaLeccion = a.ClaLeccion
	where Matricula like @pMatricula
	and (a.ClaNivel=@pClaNivel or @pClaNivel=0)
	and (a.ClaLeccion=@pClaLeccion or @pClaLeccion=0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end
