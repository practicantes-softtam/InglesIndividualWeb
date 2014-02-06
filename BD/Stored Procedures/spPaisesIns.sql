if exists(select 1 from sys.procedures where name = 'spPaisesIns')
drop proc spPaisesIns
go
create proc spPaisesIns
(
@pClaPais int out,
@pNomPais varchar(50)
)
as 
begin
 select @pClaPais = ISNULL (Max (ClaPais),0) +1
 from Paises
 insert into Paises (ClaPais,NomPais)
 values(@pClaPais,@pNomPais)
 end
 
 

 
 
