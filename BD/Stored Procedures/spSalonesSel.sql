if exists (select * from sys.procedures where name = 'spSalonesSel')
begin
	drop proc spSalonesSel
end

go

CREATE proc spSalonesSel
(
	@pIdSalon		int
)

as
begin

	select	IdSalon,
			ClaCampus,
			NomSalon,
			Capacidad
	
	from	 Salones
	where	IdSalon	=	@pIdSalon

end


