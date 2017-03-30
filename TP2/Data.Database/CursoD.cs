using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
   public class CursoD:Adapter
    {
       public List<Cursos> GetAll()
       {
           List<Cursos> lista = new List<Cursos>();
           try
           {
               OpenConnection();
               SqlCommand cmdCurso = new SqlCommand("select  cur.id_curso,mat.id_materia,mat.desc_materia,com.id_comision,com.desc_comision,cur.anio_calendario,cur.cupo from cursos cur inner join materias mat on cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision",SqlConn);
               SqlDataReader drCurso = cmdCurso.ExecuteReader();
               while (drCurso.Read())
               {
                   Cursos curso = new Cursos();

                   curso.IdCurso = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_curso"]));
                   curso.IdMateria = drCurso.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_materia"]));
                   curso.Desc_materia = drCurso.IsDBNull(2) ? string.Empty : drCurso["desc_materia"].ToString();
                   curso.IdComision = drCurso.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_comision"]));
                   curso.Desc_comision = drCurso.IsDBNull(4) ? string.Empty : ((string)drCurso["desc_comision"]);
                   curso.AnioCalendario = drCurso.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (int)drCurso["anio_calendario"];
                   curso.Cupo = drCurso.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (int)drCurso["cupo"];

                   lista.Add(curso);
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

       public List<Cursos> GetByCurso(string Tbuscado)
       {
           List<Cursos> lista = new List<Cursos>();
           try
           {
               OpenConnection();
               SqlCommand cmdCurso = new SqlCommand("select cur.id_curso,mat.desc_materia,com.desc_comision,cur.cupo,cur.id_comision,cur.anio_calendario,cur.id_materia  from cursos cur inner join materias mat on cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision where mat.desc_materia like @Tbuscado + '%'", SqlConn);
               cmdCurso.Parameters.Add("@Tbuscado", SqlDbType.VarChar, 50).Value = Tbuscado;
               SqlDataReader drCurso = cmdCurso.ExecuteReader();
               while (drCurso.Read())
               {
                   Cursos curso = new Cursos();

                   curso.IdCurso = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (int)drCurso["id_curso"];                   
                   curso.Desc_materia = drCurso.IsDBNull(1) ? string.Empty : drCurso["desc_materia"].ToString();
                   curso.Desc_comision = drCurso.IsDBNull(2) ? string.Empty : ((string)drCurso["desc_comision"]);
                   curso.Cupo = drCurso.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (int)drCurso["cupo"];
                   curso.IdComision = drCurso.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_comision"]));
                   curso.AnioCalendario = drCurso.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (int)drCurso["anio_calendario"];
                   curso.IdMateria = drCurso.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (int)drCurso["id_materia"];
                   lista.Add(curso);
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

       public Cursos TraerUno(int id)
       {

           Cursos curso = new Cursos();
           //int op;
           try
           {
               this.OpenConnection();
               SqlCommand cmdcursos = new SqlCommand("select cur.id_curso,cur.anio_calendario,cur.cupo,cur.id_materia,cur.id_comision from cursos cur where cur.id_curso = @id", SqlConn);
               cmdcursos.Parameters.Add("@id", SqlDbType.Int).Value = id;
               SqlDataReader drCursos = cmdcursos.ExecuteReader();
               if (drCursos.Read())
               {

                   curso.IdCurso = (int)(drCursos["id_curso"]);
                   curso.AnioCalendario = (int)drCursos["anio_calendario"];
                   curso.Cupo = (int)drCursos["cupo"];
                   curso.IdMateria = (int)(drCursos["id_materia"]);
                   curso.IdComision = (int)(drCursos["id_comision"]);
                   
                   


               }
               drCursos.Close();
           }
           catch (Exception ex)
           {
               Exception ExcepcionManejada = new Exception("Error al buscar el curso", ex);
           }
           finally
           {
               this.CloseConnection();
           }
           return curso;


       }




       public Cursos TraerCurso(string desc_mat,string desc_comision)
       {
           Cursos curso = new Cursos();
           try
           {
               this.OpenConnection();
               SqlCommand cmdcursos = new SqlCommand("select cur.id_curso,mat.desc_materia,com.desc_comision,cur.cupo,cur.id_comision,cur.anio_calendario,cur.id_materia  from cursos cur inner join materias mat on cur.id_materia=mat.id_materia inner join comisiones com on cur.id_comision=com.id_comision where mat.desc_materia = @desc_mat and com.desc_comision= desc_comision ", SqlConn);
               cmdcursos.Parameters.Add("@desc_mat", SqlDbType.VarChar, 50).Value = desc_mat;
               cmdcursos.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = desc_comision;
               SqlDataReader drCursos = cmdcursos.ExecuteReader();
               if (drCursos.Read())
               {

                   curso.IdCurso = (int)(drCursos["id_curso"]);
                   curso.AnioCalendario = (int)drCursos["anio_calendario"];
                   curso.Cupo = (int)drCursos["cupo"];
                   curso.IdMateria = (int)(drCursos["id_materia"]);
                   curso.IdComision = (int)(drCursos["id_comision"]);
                   
                   


               }
               drCursos.Close();
           }
           catch (Exception ex)
           {
               Exception ExcepcionManejada = new Exception("Error al buscar el curso", ex);
           }
           finally
           {
               this.CloseConnection();
           }
           return curso;


       }

       

       protected void Insertar(Cursos curso)
       {
           try
           {
               this.OpenConnection();
               SqlCommand cmdMateria = new SqlCommand("insert into cursos(id_materia,id_comision,anio_calendario,cupo)" +
               " values(@id_materia,@id_comision,@anio_calendario,@cupo)", SqlConn);

               cmdMateria.Parameters.Add("id_materia", SqlDbType.Int).Value = curso.IdMateria;
               cmdMateria.Parameters.Add("id_comision", SqlDbType.Int).Value = curso.IdComision;
               cmdMateria.Parameters.Add("anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
               cmdMateria.Parameters.Add("cupo", SqlDbType.Int).Value = curso.Cupo;

               cmdMateria.ExecuteNonQuery();

           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al crear el curso", Ex);
               throw ExcepcionManejada;
               throw;
           }
           finally
           {

               this.CloseConnection();
           }
       }

       protected void Delete(Cursos curso)
       {
           try
           {
               this.OpenConnection();
               SqlCommand cmdelete = new SqlCommand("delete cursos where id_curso=@id_curso", SqlConn);
               cmdelete.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.IdCurso;
               Convert.ToInt32(cmdelete.ExecuteNonQuery());
           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al elimanar el curso", Ex);
               throw ExcepcionManejada;
           }
           finally
           {
               if (SqlConn.State == ConnectionState.Open)
                   this.CloseConnection();
           }
       }
       protected void Update(Cursos curso)
       {
           try
           {
               this.OpenConnection();
               SqlCommand cmdSave = new SqlCommand("update cursos set id_materia = @id_materia,id_comision=@id_comision,anio_calendario=@anio_calendario,cupo=@cupo where id_curso=@id_curso ", SqlConn);

               cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.IdCurso;
               cmdSave.Parameters.Add("@id_materia", SqlDbType.Int, 50).Value = curso.IdMateria;
               cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IdComision;
               cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
               cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;

              cmdSave.ExecuteNonQuery();
           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al modificar datos el curso", Ex);
               throw ExcepcionManejada;
               throw;
           }
           finally
           {
               if (SqlConn.State == ConnectionState.Open)
                   this.CloseConnection();
           }
       }

       public void Save(Cursos curso)
       {
           if (curso.Estado == BusinessEntity.Estados.Eliminar)
           {
               this.Delete(curso);
           }
           else if (curso.Estado == BusinessEntity.Estados.Nuevo)
           {
               this.Insertar(curso);
           }

           else if (curso.Estado == BusinessEntity.Estados.Modificar)
           {
               this.Update(curso);
           }
           curso.Estado = BusinessEntity.Estados.No_Modificar;
       }
    }
}
