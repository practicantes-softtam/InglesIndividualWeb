if exists (select 1 from sys.procedures where name = 'spAmpliacionesIns')
drop proc spAmpliacionesIns
go

create proc spAmpliacionesIns
(
@pIdAmpliacion int,
@pMatricula varchar(10),
@pVigencia smalldatetime,
@pComentarios varchar (255),
@pEstatus int,
@pClaNivel int,
@pClaLeccion int
)
as 
begin

Insert into Ampliaciones (IdAmpliacion, Matricula, Vigencia, Comentarios, Estatus, ClaNivel, ClaLeccion)  
values(@pIdAmpliacion, @pMatricula, @pVigencia, @pComentarios, @pEstatus, @pClaNivel, @pClaLeccion)

end