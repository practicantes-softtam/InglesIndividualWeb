if exists (select 1 from sys.procedures where name = 'spHorarioMaestrosGrd')
drop proc spHorarioMaestrosGrd
go

CREATE proc spHorarioMaestrosGrd
(
	@pNomCiudad varchar (50),
	@pClaEmpleado int,
	@pClaCampus int,
	@pClaHorario int,
	@pLun tinyint,
	@pMar tinyint,
	@pMie tinyint,
	@pJue tinyint,
	@pVie tinyint,
	@pSab tinyint,
	@pDom tinyint,
	@pOrdenLun tinyint,
	@pOrdenMar tinyint,
	@pOrdenMie tinyint,
	@pOrdenJue tinyint,
	@pOrdenVie tinyint,
	@pOrdenSab tinyint,
	@pOrdenDom tinyint,
	@pTamanioPagina	int,
	@pNumPagina		int,
	@pOrdenarPor		varchar(100)
)
as
begin

	if @pClaEmpleado is not null begin
		select @pClaEmpleado = '%' + @pClaEmpleado + '%'
	end	

	select	RowNumber = ROW_NUMBER() over (order by ClaEmpleado asc), 
		 ClaEmpleado, 
		 ClaCampus,
		 ClaHorario, 
		 Lun, 
		 Mar,
		 Mie,
		 Jue,
		 Vie,
		 Sab,
		 Dom,
		 OrdenLun,
		 OrdenMar,
		 OrdenMie,
		 OrdenJue,
		 OrdenVie,
		 OrdenSab,
		 OrdenDom
	
	into #tabla
	from HorarioMaestros 
	where ClaEmpleado like @pClaEmpleado
	and (ClaCampus = @pClaCampus or @pClaCampus = 0)
	and (ClaHorario = @pClaHorario or @pClaHorario = 0)
	and (Mar = @pMar or @pMar = 0)
	and (Mie = @pMie or @pMie = 0)
	and (Jue = @pJue or @pJue = 0)
	and (Vie = @pVie or @pVie = 0)
	and (Sab = @pSab or @pSab = 0)
	and (Dom = @pDom or @pDom = 0)
	and (OrdenLun = @pOrdenLun or @pOrdenLun = 0)
	and (OrdenMar = @pOrdenMar or @pOrdenMar = 0)
	and (OrdenMie = @pOrdenMie or @pOrdenMie = 0)
	and (OrdenJue = @pOrdenJue or @pOrdenJue = 0)
	and (OrdenVie = @pOrdenVie or @pOrdenVie = 0)
	and (OrdenSab = @pOrdenSab or @pOrdenSab = 0)
	and (OrdenDom = @pOrdenDom or @pOrdenDom = 0)
	
	exec spGridPaginado @pTamanioPagina, @pNumPagina, @pOrdenarPor

end

