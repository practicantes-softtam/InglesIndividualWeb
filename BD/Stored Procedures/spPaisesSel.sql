if exists (select * from sys.procedures where name = 'spPaisesSel')
begin
	drop proc spPaisesSel
end

go

CREATE proc spPaisesSel
as
begin

	select	ClaPais,
			NomPais
	from	Paises 
end