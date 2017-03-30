using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Alumnos_InscripcionesD:Adapter
    {
//select  DISTINCT com.anio_especialidad,mat.id_materia,mat.desc_materia,pl.desc_plan from cursos cur inner join materias mat on cur.id_materia= mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision inner join planes pl on com.id_plan=pl.id_plan inner join personas per on pl.id_plan=per.id_plan where per.id_persona=@id_persona 
        public List<AlumnoInscripciones> GetAll()
        {

            List<AlumnoInscripciones> pl = new List<AlumnoInscripciones>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdplan = new SqlCommand("select  DISTINCT com.anio_especialidad,mat.id_materia,mat.desc_materia,pl.desc_plan from cursos cur inner join materias mat on cur.id_materia= mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision inner join planes pl on com.id_plan=pl.id_plan ", SqlConn);
                SqlDataReader drmateria = cmdplan.ExecuteReader();
                while (drmateria.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();

                    //_Especialidades esp = new _Especialidades();
                    alumno.Anio_especialidad = (int)drmateria["anio_especialidad"];
                    alumno.ID = (int)drmateria["id_materia"];
                    alumno.Desc_Materia = (string)drmateria["desc_materia"];
                    alumno.Plan = (string)drmateria["desc_plan"];
                    //alumno.IdAlumnos = (int)drmateria["id_inscripcion"];                   

                    pl.Add(alumno);

                }
            }

            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Econtrar la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return pl;
        }

        public List<AlumnoInscripciones> TraerTodosLosInscriptos()
        {

            List<AlumnoInscripciones> pl = new List<AlumnoInscripciones>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAluIns = new SqlCommand("select com.anio_especialidad,mat.desc_materia,pl.desc_plan,per.nombre,per.apellido,alu.condicion,alu.id_curso,alu.id_inscripcion,com.desc_comision from cursos cur inner join alumnos_inscripciones alu on cur.id_curso = alu.id_curso inner join materias mat on cur.id_materia = mat.id_materia inner join comisiones com on cur.id_comision = com.id_comision inner join planes pl on com.id_plan=pl.id_plan inner join personas per on per.id_persona = alu.id_alumno", SqlConn);
                SqlDataReader dr = cmdAluIns.ExecuteReader();
                while (dr.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();

                    alumno.Anio_especialidad = (int)dr["anio_especialidad"];
                    alumno.Desc_Materia = (string)dr["desc_materia"];
                    alumno.Plan = (string)dr["desc_plan"];
                    alumno.Nombre = (string)dr["nombre"];
                    alumno.Apellido = (string)dr["apellido"];
                    alumno.Condicion = (string)dr["condicion"];
                    alumno.IdCurso = (int)dr["id_curso"];
                    alumno.IdInscripcion = (int)dr["id_inscripcion"];
                    alumno.Desc_Comision = (string)dr["desc_comision"];

                    pl.Add(alumno);

                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return pl;
        }
        public List<AlumnoInscripciones> GetAllCursando()
        {
            List<AlumnoInscripciones> pl = new List<AlumnoInscripciones>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdplan = new SqlCommand("select alu.id_inscripcion,per.nombre,per.apellido,mat.desc_materia,alu.condicion from"+
                                                     "alumnos_inscripciones alu inner join personas per on alu.id_alumno=per.id_persona "+
                                                     "inner join cursos curs on curs.id_curso=alu.id_curso inner join materias mat on"+
                                                     " curs.id_materia=mat.id_materia  where condicion='Cursando'", SqlConn);
                SqlDataReader drmateria = cmdplan.ExecuteReader();
                while (drmateria.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();

                    //_Especialidades esp = new _Especialidades();
                    alumno.IdInscripcion = (int)drmateria["id_inscripcion"];
                    alumno.Nombre = (string)drmateria["nombre"];
                    alumno.Apellido = (string)drmateria["apellido"];
                    alumno.Desc_Materia = (string)drmateria["desc_materia"];
                    alumno.Condicion = (string)drmateria["condicion"];
                    //alumno.IdAlumnos = (int)drmateria["id_inscripcion"];                   

                    pl.Add(alumno);

                }
            }

            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return pl;
        }

        public List<AlumnoInscripciones> GetAllInscriptonCursado()
        {
            List<AlumnoInscripciones> pl = new List<AlumnoInscripciones>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdplan = new SqlCommand("select alu.id_inscripcion,cur.id_curso,mat.desc_materia from alumnos_inscripciones alu inner join cursos cur on alu.id_curso=cur.id_curso inner join materias mat on mat.id_materia=cur.id_materia", SqlConn);
                SqlDataReader drmateria = cmdplan.ExecuteReader();
                while (drmateria.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();

                    //_Especialidades esp = new _Especialidades();
                    alumno.IdInscripcion = (int)drmateria["id_inscripcion"];
                    alumno.IdCurso = (int)drmateria["id_curso"];
                    alumno.Desc_Materia = (string)drmateria["desc_materia"];
                    //alumno.IdAlumnos = (int)drmateria["id_inscripcion"];                   

                    pl.Add(alumno);

                }
            }

            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return pl;
        }

        public List<AlumnoInscripciones> GetByInscripto(int id_mat)
        {
            List<AlumnoInscripciones> lista = new List<AlumnoInscripciones>();           
            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select cur.id_curso,com.desc_comision,count(mat.id_materia) as cantidad,mat.desc_materia from cursos cur inner join materias mat on cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision where mat.id_materia=@tipo_persona group by cur.id_curso,com.desc_comision,mat.id_materia,mat.desc_materia", SqlConn);
                cmdCurso.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = id_mat;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();
                    int contrala = drCurso.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["cantidad"]));
                    if (contrala < 31)
                    {
                        alumno.IdCurso = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_curso"]));                        
                        alumno.Desc_Comision = drCurso.IsDBNull(1) ? string.Empty : ((string)drCurso["desc_comision"]);
                        alumno.Desc_Materia = drCurso.IsDBNull(1) ? string.Empty : ((string)drCurso["desc_materia"]);
                        lista.Add(alumno);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Econtrar la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }

        public AlumnoInscripciones TraerUnaInscripcion(int id)
        {
            AlumnoInscripciones inscripcion = new AlumnoInscripciones();
            try
            {
                OpenConnection();
                SqlCommand cmdali = new SqlCommand("select per.nombre,per.apellido,per.legajo,mat.desc_materia,com.desc_comision,ali.condicion,ali.nota,ali.id_persona, ali.id_curso from alumnos_inscripciones ali inner join cursos cur on ali.id_curso = cur.id_curso inner join personas per on per.id_persona = ali.id_alumno inner join materias mat on mat.id_materia = cur.id_materia inner join comisiones com on com.id_comision = cur.id_materia where ali.id_inscripcion = @id", SqlConn);
                cmdali.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drali = cmdali.ExecuteReader();
                if (drali.Read())
                {
                    inscripcion.IdInscripcion = (int)drali["id"];
                    inscripcion.Nombre = (string)drali["nombre"];
                    inscripcion.Apellido = (string)drali["apellido"];
                    inscripcion.Legajo = (int)drali["legajo"];
                    inscripcion.Desc_Materia = (string)drali["desc_materia"];
                    inscripcion.Desc_Comision = (string)drali["desc_comision"];
                    inscripcion.Condicion = (string)drali["condicion"];
                    inscripcion.Nota = (int)drali["nota"];
                    inscripcion.IdAlumnos = (int)drali["id_persona"];
                    inscripcion.IdCurso = (int)drali["id_curso"];
                    

                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al buscar la inscripcion", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return inscripcion;
        }

        public List<AlumnoInscripciones> GetByAlumnoInscripto(string apellido)
        {
            List<AlumnoInscripciones> lista = new List<AlumnoInscripciones>();
            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select DISTINCT ai.id_inscripcion, per.apellido,per.nombre, mat.desc_materia,pl.desc_plan, com.desc_comision, cur.anio_calendario, cur.id_curso, per.id_persona from cursos cur inner join materias mat on cur.id_materia = mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision inner join planes pl on com.id_plan=pl.id_plan inner join alumnos_inscripciones ai on ai.id_curso=cur.id_curso inner join personas per on per.id_persona = ai.id_alumno where per.apellido like @apellido +  + '%'", SqlConn);
                cmdCurso.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = apellido ;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();
                    int contrala = drCurso.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["cantidad"]));
                    if (contrala < 31)
                    {
                        alumno.IdCurso = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_curso"]));
                        alumno.Desc_Comision = drCurso.IsDBNull(1) ? string.Empty : ((string)drCurso["desc_comision"]);
                        alumno.Desc_Materia = drCurso.IsDBNull(1) ? string.Empty : ((string)drCurso["desc_materia"]);
                        lista.Add(alumno);
                    }

                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }


         public List<AlumnoInscripciones> MatInscriptasDeAlumno(int idalumno)
        {
            List<AlumnoInscripciones> lista = new List<AlumnoInscripciones>();
            try
            {
                OpenConnection();
                SqlCommand cmdAlinsc = new SqlCommand("select mat.desc_materia,com.desc_comision,ali.condicion,ali.nota,pla.desc_plan,com.anio_especialidad,ali.id_curso from alumnos_inscripciones ali inner join personas per on per.id_persona = ali.id_alumno inner join cursos cur on cur.id_curso = ali.id_curso inner join materias mat on mat.id_materia = cur.id_materia inner join comisiones com on com.id_comision = cur.id_comision inner join planes pla on pla.id_plan = mat.id_plan where ali.id_alumno = @idalumno", SqlConn);
                cmdAlinsc.Parameters.Add("@idalumno", SqlDbType.Int).Value = idalumno;
                SqlDataReader drAlinsc = cmdAlinsc.ExecuteReader();
                while (drAlinsc.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();
                       
                    alumno.Desc_Materia = drAlinsc.IsDBNull(0) ? string.Empty : ((string)drAlinsc["desc_materia"]);
                        alumno.Desc_Comision = drAlinsc.IsDBNull(1) ? string.Empty : ((string)drAlinsc["desc_comision"]);
                        alumno.Condicion = drAlinsc.IsDBNull(2) ? string.Empty : ((string)drAlinsc["condicion"]);
                        alumno.Nota = drAlinsc.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAlinsc["nota"]));
                        alumno.Anio_especialidad = drAlinsc.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAlinsc["anio_especialidad"]));
                        alumno.Plan = drAlinsc.IsDBNull(4) ? string.Empty : ((string)drAlinsc["desc_plan"]);
                        alumno.Nota = drAlinsc.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAlinsc["id_curso"]));
                        
                        lista.Add(alumno);
                    }

                }
            
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
             }




         public List<AlumnoInscripciones> MatRegularesDeAlumno(int idalumno)
         {
             List<AlumnoInscripciones> lista = new List<AlumnoInscripciones>();
             try
             {
                 OpenConnection();
                 SqlCommand cmdAlinsc = new SqlCommand("select mat.desc_materia,com.desc_comision,ali.condicion,ali.nota,pla.desc_plan,com.anio_especialidad,cur.anio_calendario from alumnos_inscripciones ali inner join personas per on per.id_persona = ali.id_alumno inner join cursos cur on cur.id_curso = ali.id_curso inner join materias mat on mat.id_materia = cur.id_materia inner join comisiones com on com.id_comision = cur.id_comision inner join planes pla on pla.id_plan = mat.id_plan where ali.id_alumno = @idalumno and ali.condicion = 'Regular'", SqlConn);
                 cmdAlinsc.Parameters.Add("@idalumno", SqlDbType.Int).Value = idalumno;
                 SqlDataReader drAlinsc = cmdAlinsc.ExecuteReader();
                 while (drAlinsc.Read())
                 {
                     AlumnoInscripciones alumno = new AlumnoInscripciones();

                     alumno.Desc_Materia = drAlinsc.IsDBNull(0) ? string.Empty : ((string)drAlinsc["desc_materia"]);
                     alumno.Desc_Comision = drAlinsc.IsDBNull(1) ? string.Empty : ((string)drAlinsc["desc_comision"]);
                     alumno.Condicion = drAlinsc.IsDBNull(2) ? string.Empty : ((string)drAlinsc["condicion"]);
                     alumno.Nota = drAlinsc.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAlinsc["nota"]));
                     alumno.Plan = drAlinsc.IsDBNull(4) ? string.Empty : ((string)drAlinsc["desc_plan"]);
                     alumno.Anio_especialidad = drAlinsc.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAlinsc["anio_especialidad"]));
                     alumno.Anio_especialidad = drAlinsc.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAlinsc["anio_calendario"]));
                     
                    

                     lista.Add(alumno);
                 }

             }

             catch (Exception ex)
             {
                 Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
             }
             finally
             {
                 this.CloseConnection();
             }
             return lista;
         }   







       
        private static AlumnoInscripciones LoadContacto(IDataReader reader)
        {
            AlumnoInscripciones contacto = new AlumnoInscripciones();

            contacto.IdAlumnos = Convert.ToInt32(reader["id_persona"]);
            return contacto;
        }
        public AlumnoInscripciones GetByInscribirporAdministrador(string nombre)
        {
            AlumnoInscripciones lista = new AlumnoInscripciones();
            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select id_persona,tipo_persona from personas where nombre=@nombre", SqlConn);
                cmdCurso.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                if (drCurso.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();

                     lista.IdAlumnos = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_persona"]));
                     lista.Tipo = drCurso.IsDBNull(0) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["tipo_persona"]));
                   
                }
                drCurso.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Ecuentra en la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }

        public List<AlumnoInscripciones> GetByDevolverEstadoMateria(int id_mat)
        {
            List<AlumnoInscripciones> lista = new List<AlumnoInscripciones>();
            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand(" select aluins.id_alumno,mat.desc_materia,aluins.condicion from alumnos_inscripciones aluins inner join cursos curs on curs.id_curso=aluins.id_curso inner join materias mat on mat.id_materia=curs.id_materia where aluins.id_alumno=@id_alumno", SqlConn);
                cmdCurso.Parameters.Add("@id_alumno", SqlDbType.Int).Value = id_mat;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();
                  
                        alumno.IdAlumnos = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_alumno"]));
                        alumno.Desc_Materia = drCurso.IsDBNull(1) ? string.Empty : ((string)drCurso["desc_materia"]);
                        alumno.Condicion = drCurso.IsDBNull(1) ? string.Empty : ((string)drCurso["condicion"]);
                      
                        lista.Add(alumno);
                   

                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Econtrar la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }

        public List<AlumnoInscripciones> GetByPasarRegularidad(int id_mata)
        {
            List<AlumnoInscripciones> lista = new List<AlumnoInscripciones>();
            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select alu_insc.id_inscripcion,per.apellido,per.nombre,com.desc_comision,alu_insc.id_curso,alu_insc.id_alumno from alumnos_inscripciones alu_insc inner join cursos cur on alu_insc.id_curso=cur.id_curso inner join personas per on per.id_persona=alu_insc.id_alumno inner join materias mat on cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision where per.tipo_persona=3 and alu_insc.condicion='Cursando' and mat.id_materia=@id_materia", SqlConn);
                cmdCurso.Parameters.Add("@id_materia", SqlDbType.Int).Value = id_mata;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();
                    alumno.IdInscripcion = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_inscripcion"]));
                    alumno.Apellido = drCurso.IsDBNull(1) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["apellido"])); 
                    alumno.Nombre = drCurso.IsDBNull(2) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["nombre"]));
                    alumno.Desc_Comision = drCurso.IsDBNull(3) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["desc_comision"]));
                    //alumno.Condicion = drCurso.IsDBNull(3) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["condicion"]));
                    alumno.IdCurso = drCurso.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_curso"]));
                    alumno.IdAlumnos = drCurso.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_alumno"]));

                    lista.Add(alumno);


                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Encuentra la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }


        public List<AlumnoInscripciones> GetByPasarNotaFinal(int id_mata)
        {
            List<AlumnoInscripciones> lista = new List<AlumnoInscripciones>();
            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand(" select alu_ins.id_inscripcion,per.nombre,per.apellido,dcur.id_curso,per.id_alumno,alu_ins.nota from alumnos_inscripciones alu_ins inner join personas per on per.id_persona=alu_ins.id_alumno inner join planes pla on per.id_plan=pla.id_plan inner join materias mat on mat.id_plan=pla.id_plan inner join docentes_cursos dcur on alu_ins.id_curso=dcur.id_curso where per.tipo_persona=1 and alu_ins.condicion='Examen' and dcur.id_docente=@id_docente", SqlConn);
                cmdCurso.Parameters.Add("@id_docente", SqlDbType.Int).Value = id_mata;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();
                    alumno.IdInscripcion = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_inscripcion"]));
                    alumno.Apellido = drCurso.IsDBNull(1) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["apellido"]));
                    alumno.Nombre = drCurso.IsDBNull(2) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["nombre"]));
                    //alumno.Desc_Comision = drCurso.IsDBNull(3) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["desc_comision"]));
                    //alumno.Condicion = drCurso.IsDBNull(3) ? Convert.ToString(string.Empty) : (Convert.ToString(drCurso["condicion"]));
                    alumno.IdCurso = drCurso.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_curso"]));
                    alumno.IdAlumnos = drCurso.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_alumno"]));
                    alumno.Nota = drCurso.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["nota"]));

                    lista.Add(alumno);


                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Encuentra la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }

        public List<AlumnoInscripciones> GetByMateriasAprobada()
        {
            List<AlumnoInscripciones> lista = new List<AlumnoInscripciones>();
            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand(" select aluins.id_inscripcion,mat.desc_materia,aluins.nota from alumnos_inscripciones aluins" +
                                                     " inner join personas per on aluins.id_alumno=per.id_persona inner join cursos cur on cur.id_curso=aluins.id_curso"+
                                                     " inner join materias mat on cur.id_materia=mat.id_materia where aluins.nota>=4", SqlConn);
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    AlumnoInscripciones alumno = new AlumnoInscripciones();                    
                    
                        alumno.IdInscripcion = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_inscripcion"]));
                        alumno.Desc_Materia = drCurso.IsDBNull(1) ? string.Empty : ((string)(drCurso["desc_materia"]));
                        //alumno.Apellido = drCurso.IsDBNull(2) ? string.Empty : ((string)drCurso["Apellido"]);
                        alumno.Nota = drCurso.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["nota"]));
                        lista.Add(alumno);                 

                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Econtrar la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }

        public List<Cursos> GetoneCupo(string desc_mat)
        {
            List<Cursos> lista = new List<Cursos>();
            
            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand(" select count(mat.id_materia)as Cantidad from alumnos_inscripciones alins inner join cursos cur on alins.id_curso= cur.id_curso inner join materias mat on cur.id_materia=mat.id_materia where mat.desc_materia=@desc_materia", SqlConn);
                cmdCurso.Parameters.Add("@desc_materia", SqlDbType.VarChar,50).Value = desc_mat;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    Cursos alumno = new Cursos();
                    alumno.IdMateria = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["Cantidad"]));
                    lista.Add(alumno);                  
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("No se Econtrar la lista", ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return lista;
        }

        protected void Insertar(AlumnoInscripciones alum)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripcion = new SqlCommand("insert into alumnos_inscripciones(id_alumno,id_curso,condicion,nota) values(@id_alumno,@id_curso,@condicion,@nota)", SqlConn);

                cmdInscripcion.Parameters.Add("id_alumno", SqlDbType.Int).Value = alum.IdAlumnos;
                cmdInscripcion.Parameters.Add("id_curso", SqlDbType.Int).Value = alum.IdCurso;
                cmdInscripcion.Parameters.Add("condicion", SqlDbType.VarChar,50).Value = alum.Condicion;
                cmdInscripcion.Parameters.Add("nota", SqlDbType.Int).Value = alum.Nota;

                cmdInscripcion.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la Incripcion", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {

                this.CloseConnection();
            }
        }

        protected void Delete(AlumnoInscripciones alum)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdelete = new SqlCommand("delete alumnos_inscripciones where id_alumno=@id_alumno", SqlConn);
                cmdelete.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alum.IdAlumnos;
                Convert.ToInt32(cmdelete.ExecuteNonQuery());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al elimanar la Inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open)
                    this.CloseConnection();
            }
        }
        protected void Update(AlumnoInscripciones alum)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update alumnos_inscripciones set id_alumno = @id_alumno,id_curso=@id_curso,condicion=@condicion,nota=@nota where id_inscripcion=@id ", SqlConn);
               
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = alum.IdInscripcion;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alum.IdAlumnos;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alum.IdCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar,50).Value = alum.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alum.Nota;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar el registro", Ex);
                throw ExcepcionManejada;
                throw;
            }
            finally
            {
                if (SqlConn.State == ConnectionState.Open)
                    this.CloseConnection();
            }
        }
        public void Save(AlumnoInscripciones alum)
        {
            if (alum.Estado == BusinessEntity.Estados.Eliminar)
            {
                this.Delete(alum);
            }
            else if (alum.Estado == BusinessEntity.Estados.Nuevo)
            {
                this.Insertar(alum);
            }

            else if (alum.Estado == BusinessEntity.Estados.Modificar)
            {
                this.Update(alum);
            }
            alum.Estado = BusinessEntity.Estados.No_Modificar;
        }
    }
}
