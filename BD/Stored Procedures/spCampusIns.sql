if exists(select 1 from sys.procedures where name = 'spCampusIns')
drop proc spCampusIns
go

create proc spCampusIns
(
	@pClaCampus int  out,
	@pNomCampus varchar(50),
	@pCalle varchar (200),
	@pColonia varchar (200),
	@pTelefono varchar (15)

)

as
begin
	
	insert into Campus (NomCampus, Calle, Colonia, Telefono)
	values (@pNomCampus, @pCalle, @pColonia, @pTelefono)
	select @pClaCampus = @@IDENTITY
end