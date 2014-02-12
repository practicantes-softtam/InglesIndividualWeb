if exists (select 1 from sys.procedures where name = 'spHorarioMaestrosUpd')
drop proc spHorarioMaestrosUpd 
go

create proc spHorarioMaestrosUpd
(
	@pClaEmpleado int out,
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
	@pOrdenDom tinyint
)
as
begin

	update HorarioMaestros
	set  (ClaEmpleado=@pClaEmpleado, ClaCampus=@pClaCampus, ClaHorario=@pClaHorario, Lun=@pLun, Mar=@pMar, 
	Mie=@pMie, Jue=@pJue, Vie=@pVie, Sab=@pSab, Dom=@pDom, OrdenLun=@pOrdenLun, OrdenMar=@pOrdenMar, OrdenMie=@pOrdenMie, 
	OrdenJue=@pOrdenJue, OrdenVie=@pOrdenVie, OrdenSab=@pOrdenSab, OrdenDom=@pOrdenDom) --duda
	
	
	where ClaCiudad = @pClaCiudad
end

exec spHorarioMaestrosUpd 10, 'Ciudad 10', 1,1 --duda
	select * from HorarioMaestros