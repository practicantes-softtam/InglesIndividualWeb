if exists(select 1 from sys.procedures where name = 'spFwkAplicacionesUpd')
drop proc spFwkAplicacionesUpd
go
create proc spFwkAplicacionesUpd
(
	@pClaAplicacion int out,
	@pNomAplicacion varchar(50)
	)
	
as
begin
	update FwkAplicaciones
	set NomAplicacion= @pNomAplicacion
	where ClaAplicacion= @pClaAplicacion
       
end

select * from FwkAplicaciones
