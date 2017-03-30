delete from cursos where id_curso='1'
select * from alumnos_inscripciones
delete from alumnos_inscripciones where id_inscripcion='3'
select * from cursos
select * from materias
select * from comisiones

select * from usuarios

select distinct con.anio_especialidad,mat.desc_materia,pla.desc_plan,pla.id_plan from
materias mat inner join planes pla on mat.id_plan=pla.id_plan inner join comisiones con 
on pla.id_plan=con.id_plan 

select distinct mat.id_materia,mat.desc_materia,cur.anio_calendario,cur.cupo from
 cursos cur inner join materias mat on cur.id_materia=mat.id_materia inner join 
 comisiones com on cur.id_comision=com.id_comision

insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(58,72,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(58,73,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(58,74,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(58,75,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(58,76,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(58,77,2016,30)

insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(59,72,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(59,73,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(59,74,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(59,75,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(59,76,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(59,77,2016,30)

insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(60,72,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(60,73,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(60,74,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(60,75,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(60,76,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(60,77,2016,30)

insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(61,72,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(61,73,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(61,74,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(61,75,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(61,76,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(61,77,2016,30)

insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(62,72,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(62,73,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(62,74,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(62,75,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(62,76,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(62,77,2016,30)

insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(63,72,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(63,73,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(63,74,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(63,75,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(63,76,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(63,77,2016,30)

insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(64,72,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(64,73,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(64,74,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(64,75,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(64,76,2016,30)
insert into cursos(id_materia,id_comision,anio_calendario,cupo)
values(64,77,2016,30)

select  DISTINCT com.anio_especialidad,mat.desc_materia,pl.desc_plan from
 cursos cur inner join materias mat on cur.id_materia= mat.id_materia 
inner join comisiones com on cur.id_comision=com.id_comision inner join planes pl on com.id_plan=pl.id_plan 

update cursos set id_materia='43' where id_curso='17'
update cursos set id_materia='43' where id_curso='18'
update cursos set id_materia='43' where id_curso='19'
update cursos set id_materia='43' where id_curso='20'
update cursos set id_materia='43' where id_curso='21'

select distinct cur.id_curso,mat.id_materia,mat.desc_materia,com.id_comision,com.desc_comision,cur.anio_calendario,cur.cupo from 
cursos cur inner join materias mat on cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision

select distinct per.id_persona,cur.id_curso,cur.id_comision,mat.desc_materia,com.desc_comision from personas per 
inner join planes pla on per.id_plan= pla.id_plan inner join materias mat on mat.id_plan=pla.id_plan 
inner join cursos cur  on cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision
  where mat.desc_materia = 'Algebra y Geometria Analitica'and per.tipo_persona 
  like '3' and com.anio_especialidad like '1' + '%'

  select distinct per.id_persona,per.apellido,per.nombre,com.desc_comision from personas per 
inner join planes pla on per.id_plan= pla.id_plan inner join materias mat on mat.id_plan=pla.id_plan 
inner join cursos cur  on cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision
where per.id_persona=1

select * from personas where id_persona =1

select distinct per.apellido,per.nombre,alu.condicion,mat.desc_materia from alumnos_inscripciones alu inner join personas per on 
per.id_persona=alu.id_alumno inner join planes pla on pla.id_plan=per.id_plan inner join 
materias mat on pla.id_plan=mat.id_plan inner join comisiones com on pla.id_plan=com.id_plan where mat.desc_materia='Fisica I'

select distinct usr.id_persona,per.nombre,per.apellido,alu.condicion from 
usuarios usr inner join personas per on usr.id_persona=per.id_persona inner join alumnos_inscripciones alu 
on per.id_persona=alu.id_alumno inner join planes pla on pla.id_plan=per.id_plan inner join comisiones com
on pla.id_plan=com.id_plan inner join materias mat on mat.id_plan=pla.id_plan 

select alu.id_inscripcion,mat.desc_materia,alu.condicion,cur.cupo from 
alumnos_inscripciones alu inner join personas per on alu.id_alumno=per.id_persona 
inner join cursos cur on cur.id_curso=alu.id_curso inner join materias mat on
cur.id_materia=mat.id_materia 

select * from alumnos_inscripciones
select * from personas

delete  personas where id_persona=4
select pla.id_plan ,CONCAT(pla.desc_plan , esp.desc_especialidad) as Plans from  planes pla inner join especialidades esp  on esp.id_especialidad=pla.id_especialidad
select pla.id_plan,(pla.desc_plan +'---'+esp.desc_especialidad) as plans from  planes pla inner join especialidades esp  on esp.id_especialidad=pla.id_especialidad

select u.id_usuario,p.id_persona,u.nombre_usuario,u.clave,u.habilitado,u.cambia_clave,p.tipo_persona,p.email from
 usuarios u inner join personas p on p.id_persona=u.id_persona

 select usr.id_usuario,usr.nombre_usuario,usr.clave,usr.habilitado,usr.cambia_clave,per.nombre,per.apellido,per.tipo_persona 
 from usuarios usr inner join personas per on usr.id_persona=per.id_persona where usr.nombre_usuario='prade'

 select * from usuarios
 select * from cursos
 select aluins.id_inscripcion,mat.desc_materia,aluins.nota from alumnos_inscripciones aluins 
 inner join personas per on aluins.id_alumno=per.id_persona inner join cursos cur on cur.id_curso=aluins.id_curso 
 inner join materias mat on cur.id_materia=mat.id_materia where aluins.nota>=4


 update alumnos_inscripciones set nota='8' where id_inscripcion='13'

 select distinct per.id_persona,cur.id_curso,com.desc_comision,cur.cupo from personas per inner join planes pla 
 on per.id_plan= pla.id_plan inner join materias mat on mat.id_plan=pla.id_plan inner join cursos cur  on
  cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision
   where mat.desc_materia = 'Fisica I' and per.tipo_persona = 1 and com.anio_especialidad = 1

   select distinct cur.id_curso,com.desc_comision from cursos cur inner join materias mat on cur.id_materia=mat.id_materia inner join planes pl
   on mat.id_plan=pl.id_plan inner join personas per on pl.id_plan=per.id_plan inner join comisiones com
   on cur.id_comision=com.id_comision where per.tipo_persona=3

   select * from alumnos_inscripciones alins inner join cursos cur on
   alins.id_curso= cur.id_curso inner join materias mat on
   cur.id_materia=mat.id_materia where mat.desc_materia='Fisica I'

   select distinct cur.id_curso,com.desc_comision,mat.id_materia,mat.desc_materia from cursos cur inner join materias mat 
   on cur.id_materia=mat.id_materia inner join planes pl on mat.id_plan=pl.id_plan inner join personas per 
   on pl.id_plan=per.id_plan inner join comisiones com on cur.id_comision=com.id_comision
    where per.tipo_persona=1 and mat.desc_materia='Ingenieria y Sociedad'

	select cur.id_curso,com.desc_comision,count(mat.id_materia) as cantidad,mat.desc_materia from cursos cur inner join materias mat on cur.id_materia=mat.id_materia 
	inner join comisiones com on cur.id_comision=com.id_comision where mat.id_materia='41' 
	group by cur.id_curso,com.desc_comision,mat.id_materia,mat.desc_materia

	delete from alumnos_inscripciones where id_inscripcion='17'

	select count(mat.id_materia) as Cantidad from alumnos_inscripciones alins inner join cursos cur 
	on alins.id_curso= cur.id_curso inner join materias mat on cur.id_materia=mat.id_materia where mat.desc_materia='Sistemas y Organizaciones'