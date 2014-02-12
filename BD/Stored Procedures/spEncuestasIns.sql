if exists (select 1 from sys.procedures where name = 'spEncuestasIns')
drop proc spEncuestasIns
go

create proc spEncuestasIns
(
	@pClaEncuesta int,
	@pNomEncuesta varchar (50)
	

)
as 
begin

 insert into Encuestas(ClaEncuesta, NomEncuesta) 
 values(@pClaEncuesta, @pNomEncuesta)
 
end