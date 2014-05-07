if exists (select 1 from sys.procedures where name = 'spAmpliacionesIns')
drop proc spAmpliacionesIns
go

create proc spAmpliacionesIns
(
@pIdAmpliacion int out,
@pMatricula varchar(10),
@pVigencia smalldatetime,
@pComentarios varchar (255),
@pEstatus int,
@pClaNivel int,
@pClaLeccion int
)
as 
begin

Insert into Ampliaciones (Matricula, Vigencia, Comentarios, Estatus, ClaNivel, ClaLeccion)  
values(@pMatricula, @pVigencia, @pComentarios, @pEstatus, @pClaNivel, @pClaLeccion)
 select @pIdAmpliacion = @@IDENTITY
end