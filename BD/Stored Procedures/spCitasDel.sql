if exists (select 1 from sys.procedures where name = 'spCitasDel')
drop proc spCitasDel
go

create proc spCitasDel
(
	@pIdCita int
)
as
begin

	delete Citas
	where IdCita = @pIdCita

end