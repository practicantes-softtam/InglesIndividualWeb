if exists (select 1 from sys.procedures where name = 'spHorarioMaestrosIns')
drop proc spHorarioMaestrosIns
go

create proc spHorarioMaestrosIns
(

	@pClaEmpleado int out,
	@pClaCampus int,
	@pClaHorario int,
	@pLun tinyint,
	@pMar tinyint,
	@pMie tinyint,
	@Jue tinyint,
	@pVie tinyint,
	@pSab tinyint,
	@pDom tinyint,
	@pOrdenLun tinyint,
	@pOrdenMar tinyint,
	@pOrdenMie tinyint,
	@pOrdenJue tinyint,
	@pOrdenVie tinyint,
	@pOrdenSab tinyint,
	@pOrdenDom tinyint
)

as
begin
	select @pClaEmpleado = isnull  (MAX (ClaEmpleado), 0)+ 1 --duda--
	from HorarioMaestros

	insert into HorarioMaestros	(ClaEmpleado, ClaCampus, ClaHorario, Lun, Mar, Mie, Jue, Vie, Sab, Dom, OrdenLun,
	OrdenMar, OrdenMie, OrdenJue, OrdenVie, OrdenSab, OrdenDom) 
	values(@pClaEmpleado, @pClaCampus, @pClaHorario, @pLun, @pMar, @pMie, @Jue, @pVie, @pSab, @pDom, @pOrdenLun,
	@pOrdenMar, @pOrdenMie, @pOrdenJue, @pOrdenVie, @pOrdenSab, @pOrdenDom)

end

declare @clave int
	exec spHorarioMaestrosIns @clave out, 'HorarioMaestros de Prueba', 1,1 --duda
	select @clave

	select * from HorarioMaestros