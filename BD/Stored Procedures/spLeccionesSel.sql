if exists (select * from sys.procedures where name = 'spLeccionesSel')
begin
	drop proc spLeccionesSel
end

go

CREATE proc spLeccionesSel
(
	@pClaLeccion		int
)
as
begin

	select	ClaLeccion,
			ClaNivel,
			NomLeccion,
			EsReview
	
	from	Lecciones
	where	ClaLeccion	=	@pClaLeccion
end


