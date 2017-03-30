using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using System.Data;
using System.Data.SqlClient;
//using Data.Database;

namespace Data.Database
{
   public class Personas:Adapter
    {
       //Adapter c = new Adapter();
       public enum gestion 
       {
           Administrador=1,
           Profesor,
           Alumno
       }

       public List<_Personas> GetAll()
       {
           List<_Personas> personas = new List<_Personas>();

           try
           {

               //this.OpenConnection();
               this.OpenConnection();
               int opc;
               SqlCommand cmdPersonas = new SqlCommand("select * from personas", SqlConn);
               SqlDataReader drpersonas = cmdPersonas.ExecuteReader();
               while (drpersonas.Read())
               {
                   _Personas per = new _Personas();
                   per.Codigo = (int)drpersonas["id_persona"];
                   per.Nombre = (string)drpersonas["nombre"];
                   per.Apellido = (string)drpersonas["apellido"];
                   per.Direccion = (string)drpersonas["direccion"];
                   per.Email = (string)drpersonas["email"];
                   per.Telefono = (string)drpersonas["telefono"];
                   per.Fecha_Nac = (DateTime)drpersonas["fecha_nac"];
                   per.Legajo = (int)drpersonas["legajo"];
                   opc = (int)drpersonas["tipo_persona"];
                   if (opc == 1)
                   {
                       per.Tipo_Persona = Convert.ToString(gestion.Administrador);
                   }
                   else if (opc == 2)
                   {
                       per.Tipo_Persona = Convert.ToString(gestion.Profesor);
                   }
                   else
                   {
                       per.Tipo_Persona = Convert.ToString(gestion.Alumno);
                   }                    
                    per.Id_Plan = (int)drpersonas["id_plan"];
                    per.Sexo = (string)drpersonas["sexo"];

                    personas.Add(per);
                



               }
               drpersonas.Close();
           }
           catch (Exception ex)
           {
               Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
           }
           finally
           {
               this.CloseConnection();
           }
           return personas;

       }


       public _Personas TraerUno(int ID)
       {

           _Personas per = new _Personas();
           int op;
           try
           {
               this.OpenConnection();
               SqlCommand cmdPersonas = new SqlCommand( "select per.id_persona,per.nombre,per.apellido,per.direccion,per.email,per.telefono,per.fecha_nac,per.legajo, per.tipo_persona,per.id_plan,pla.desc_plan,per.sexo from personas per inner join planes pla on pla.id_plan = per.id_plan where per.id_persona = @ID", SqlConn);
               cmdPersonas.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
               SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
               if (drPersonas.Read())
               {
                   per.Codigo = (int)drPersonas["id_persona"];
                   per.Nombre = (string)drPersonas["nombre"];
                   per.Apellido = (string)drPersonas["apellido"];
                   per.Direccion = (string)drPersonas["direccion"];
                   per.Email = (string)drPersonas["email"];
                   per.Telefono = (string)drPersonas["telefono"];
                   per.Fecha_Nac = (DateTime)drPersonas["fecha_nac"];
                   per.Legajo = (int)drPersonas["legajo"];
                   
                   op = (int)drPersonas["tipo_persona"];
                   if (op == 1)
                   {
                       per.Tipo_Persona = Convert.ToString(Data.Database.Personas.gestion.Administrador);
                   }
                   else if (op == 2)
                   {
                       per.Tipo_Persona = Convert.ToString(Data.Database.Personas.gestion.Profesor);
                   }
                   else
                   {
                       per.Tipo_Persona = Convert.ToString(Data.Database.Personas.gestion.Alumno);
                   }
                   per.Id_Plan = (int)drPersonas["id_plan"];
                   per.Plan = (string)drPersonas["desc_plan"];
                   per.Sexo = (string)drPersonas["sexo"];

               }
               drPersonas.Close();
           }
           catch (Exception ex)
           {
               Exception ExcepcionManejada = new Exception("Error al buscar la persona", ex);
           }
           finally
           {
               this.CloseConnection();
           }
           return per;


       }


       public _Personas GetByAgregarRegularidadporAdministrador(string nombre)
       {
           _Personas lista = new _Personas();
           try
           {
               OpenConnection();
               SqlCommand cmdCurso = new SqlCommand("select id_persona,tipo_persona from personas where tipo_persona=2 and nombre=@nombre", SqlConn);
               cmdCurso.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
               SqlDataReader drCurso = cmdCurso.ExecuteReader();
               if (drCurso.Read())
               {
                   AlumnoInscripciones alumno = new AlumnoInscripciones();

                   lista.Codigo = drCurso.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drCurso["id_persona"]));
                  

               }
               drCurso.Close();
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

       public List<_Personas> GetAllAdministrador()
       {
           List<_Personas> personas = new List<_Personas>();
          
           try
           {
               
               //this.OpenConnection();
               this.OpenConnection();
               int opc;
               SqlCommand cmdPersonas = new SqlCommand("select * from personas",SqlConn);
               SqlDataReader drpersonas = cmdPersonas.ExecuteReader();
               while (drpersonas.Read())
               {
                   _Personas per = new _Personas();
                   opc = (int)drpersonas["tipo_persona"];
                   if (opc==1)
                   {
                       per.Codigo = (int)drpersonas["id_persona"];
                       per.Nombre = (string)drpersonas["nombre"];
                       per.Apellido = (string)drpersonas["apellido"];
                       per.Direccion = (string)drpersonas["direccion"];
                       per.Email = (string)drpersonas["email"];
                       per.Telefono = (string)drpersonas["telefono"];
                       per.Fecha_Nac = (DateTime)drpersonas["fecha_nac"];
                       per.Legajo = (int)drpersonas["legajo"];
                       per.Tipo_Persona = Convert.ToString(gestion.Administrador);
                       per.Id_Plan = (int)drpersonas["id_plan"];
                       per.Sexo = (string)drpersonas["sexo"];
                       personas.Add(per);
                   }
                  
                   
                   
               }
               drpersonas.Close();
           }
           catch (Exception ex)
           {
               Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
           }
           finally
           {
               this.CloseConnection();
           }
           return personas;

       }

       public List<_Personas> GetAllProfesor()
       {
           List<_Personas> personas = new List<_Personas>();

           try
           {

               //this.OpenConnection();
               this.OpenConnection();
               int opc;
               SqlCommand cmdPersonas = new SqlCommand("select * from personas", SqlConn);
               SqlDataReader drpersonas = cmdPersonas.ExecuteReader();

               while (drpersonas.Read())
               {
                  _Personas per = new _Personas();
                  opc = (int)drpersonas["tipo_persona"];
                if (opc == 2)
                  {
                      per.Codigo = (int)drpersonas["id_persona"];
                      per.Nombre = (string)drpersonas["nombre"];
                      per.Apellido = (string)drpersonas["apellido"];
                      per.Direccion = (string)drpersonas["direccion"];
                      per.Email = (string)drpersonas["email"];
                      per.Telefono = (string)drpersonas["telefono"];
                      per.Fecha_Nac = (DateTime)drpersonas["fecha_nac"];
                      per.Legajo = (int)drpersonas["legajo"];
                      per.Id_Plan = (int)drpersonas["id_plan"];
                      per.Sexo = (string)drpersonas["sexo"];
                      per.Tipo_Persona = Convert.ToString(gestion.Profesor);
                      personas.Add(per);
                      
                  }
                  
                 

               }
               drpersonas.Close();
           }
           catch (Exception ex)
           {
               Exception ExcepcionManejada = new Exception("No se Econtrar la lista", ex);
           }
           finally
           {
               this.CloseConnection();
           }
           return personas;

       }

       public List<_Personas> GetAllAlumno()
       {
           List<_Personas> personas = new List<_Personas>();           
           try
           {

               //this.OpenConnection();
               this.OpenConnection();
               int opc;
               SqlCommand cmdPersonas = new SqlCommand("select per.id_Persona,per.nombre,per.apellido,per.legajo,pl.desc_plan, per.email, per.telefono, per.direccion, per.fecha_nac, per.tipo_persona, per.sexo,pl.id_plan from personas per inner join planes pl on per.id_plan=pl.id_plan", SqlConn);
               SqlDataReader drpersonas = cmdPersonas.ExecuteReader();
               while (drpersonas.Read())
               {
                   _Personas per = new _Personas();
                   opc = (int)drpersonas["tipo_persona"];
                   if (opc == 3)
                   {
                       per.Codigo = (int)drpersonas["id_persona"];
                       per.Nombre = (string)drpersonas["nombre"];
                       per.Apellido = (string)drpersonas["apellido"];
                       per.Legajo = (int)drpersonas["legajo"];
                       per.Plan = (string)drpersonas["desc_plan"];
                       per.Email = (string)drpersonas["email"];
                       per.Telefono = (string)drpersonas["telefono"];
                       per.Direccion = (string)drpersonas["direccion"];
                       per.Fecha_Nac = (DateTime)drpersonas["fecha_nac"];
                       per.Tipo_Persona = Convert.ToString(gestion.Alumno);
                       per.Sexo = (string)drpersonas["sexo"];
                       per.Id_Plan = (int)drpersonas["id_plan"];
                      
                       
                      
                       
                       personas.Add(per);
                   }



               }
               drpersonas.Close();
           }
           catch (Exception ex)
           {
               Exception ExcepcionManejada = new Exception("No se hallaron resultados", ex);
           }
           finally
           {
               this.CloseConnection();
           }
           return personas;

       }

       public List<_Personas> GetByAlumno(string Txtbuscado)
       {
           List<_Personas> Lista = new List<_Personas>();
           try
           {
               int opc;
               this.OpenConnection();
               SqlCommand cmdpersonas = new SqlCommand("select per.id_Persona,per.nombre,per.apellido,per.legajo,pl.desc_plan, per.email, per.telefono, per.direccion, per.fecha_nac, per.tipo_persona, per.sexo from personas per inner join planes pl on per.id_plan=pl.id_plan where per.apellido like @textobuscar + '%'", SqlConn);
               cmdpersonas.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;

               SqlDataReader drPersonas = cmdpersonas.ExecuteReader();
               while (drPersonas.Read())
               {
                   _Personas per = new _Personas();
                   opc = (int)drPersonas["tipo_persona"];
                   if (opc == 3)
                   {
                       per.Codigo = drPersonas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drPersonas["id_persona"]));
                       per.Nombre = drPersonas.IsDBNull(1) ? string.Empty : drPersonas["nombre"].ToString();
                       per.Apellido = drPersonas.IsDBNull(2) ? string.Empty : ((string)drPersonas["apellido"]);
                       per.Legajo = drPersonas.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (int)drPersonas["legajo"];
                       per.Plan = drPersonas.IsDBNull(4) ? string.Empty : ((string)drPersonas["desc_plan"]);
                       per.Direccion = drPersonas.IsDBNull(5) ? string.Empty : ((string)drPersonas["direccion"]);
                       per.Email = drPersonas.IsDBNull(6) ? string.Empty : ((string)drPersonas["email"]);
                       per.Telefono = drPersonas.IsDBNull(7) ? string.Empty : ((string)drPersonas["telefono"]);
                       per.Fecha_Nac = drPersonas.IsDBNull(8) ? Convert.ToDateTime(string.Empty) : Convert.ToDateTime(drPersonas["fecha_nac"]);
                       per.Tipo_Persona = drPersonas.IsDBNull(9) ? string.Empty : drPersonas["tipo_persona"].ToString();
                       per.Sexo = drPersonas.IsDBNull(10) ? string.Empty : drPersonas["sexo"].ToString();
                       Lista.Add(per);
                   }


                   Lista.Add(per);
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
           return Lista;
       }


       public List<_Personas> GetByPersona(string Txtbuscado)
       {
           List<_Personas> Lista = new List<_Personas>();
           try
           {
               this.OpenConnection();
               SqlCommand cmdpersonas = new SqlCommand("select per.id_Persona,per.nombre,per.apellido,per.legajo,pl.desc_plan, per.email, per.telefono, per.direccion, per.fecha_nac, per.tipo_persona, per.sexo, per.id_plan from personas per inner join planes pl on per.id_plan=pl.id_plan where per.apellido like @textobuscar + '%'", SqlConn);
               cmdpersonas.Parameters.Add("@textobuscar", SqlDbType.VarChar, 50).Value = Txtbuscado;

               SqlDataReader drPersonas = cmdpersonas.ExecuteReader();
               while (drPersonas.Read())
               {
                   _Personas per = new _Personas();

                   per.Codigo = drPersonas.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drPersonas["id_persona"]));
                   per.Nombre = drPersonas.IsDBNull(1) ? string.Empty : drPersonas["nombre"].ToString();
                   per.Apellido = drPersonas.IsDBNull(2) ? string.Empty : ((string)drPersonas["apellido"]);
                   per.Legajo = drPersonas.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (int)drPersonas["legajo"];
                   per.Plan = drPersonas.IsDBNull(4) ? string.Empty : ((string)drPersonas["desc_plan"]);
                   per.Direccion = drPersonas.IsDBNull(5) ? string.Empty : ((string)drPersonas["direccion"]);
                   per.Email = drPersonas.IsDBNull(6) ? string.Empty : ((string)drPersonas["email"]);
                   per.Telefono = drPersonas.IsDBNull(7) ? string.Empty : ((string)drPersonas["telefono"]);
                   per.Fecha_Nac = drPersonas.IsDBNull(8) ? Convert.ToDateTime(string.Empty) : Convert.ToDateTime(drPersonas["fecha_nac"]);
                   per.Tipo_Persona = drPersonas.IsDBNull(9) ? string.Empty : drPersonas["tipo_persona"].ToString();
                   per.Sexo = drPersonas.IsDBNull(10) ? string.Empty : drPersonas["sexo"].ToString();
                   per.Id_Plan = drPersonas.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (int)drPersonas["id_plan"];


                   Lista.Add(per);
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
           return Lista;
       }
       
       protected void Insert(_Personas persona)
       {
           try
           {
               this.OpenConnection();
               string opc;
               SqlCommand cmdSave = new SqlCommand("insert into personas(nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan,sexo)" +
               "values(@nombre,@apellido,@direccion,@email,@telefono,@fecha_nac,@legajo,@tipo_persona,@id_plan,@sexo)", SqlConn);

               cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
               cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
               cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
               cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
               cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
               cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.Fecha_Nac;
               cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;

               opc = persona.Tipo_Persona;

               if (opc == Convert.ToString(gestion.Administrador))
               {
                   cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 1;
               }
               else if (opc == Convert.ToString(gestion.Profesor))
               {
                   cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 2;
               }
               else
               {
                   cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 3;
               }
               cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.Id_Plan;
               cmdSave.Parameters.Add("@sexo", SqlDbType.VarChar, 50).Value = persona.Sexo;


               cmdSave.ExecuteNonQuery();

           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al crear la Persona", Ex);
               throw ExcepcionManejada;
               throw;
           }
           finally
           {
               if (SqlConn.State == ConnectionState.Open)
                   this.CloseConnection();
           }

       }

      protected void Update(_Personas persona)
       {           
           try
           {
               this.OpenConnection();
               string opc;
               SqlCommand cmdSave = new SqlCommand("update personas set nombre=@nombre,apellido=@apellido,direccion=@direccion,email=@email,telefono=@telefono,fecha_nac=@fecha_nac,legajo=@legajo,tipo_persona=@tipo_persona,id_plan=@id_plan,sexo=@sexo where id_persona=@id_persona", SqlConn);

               cmdSave.Parameters.Add("@id_persona", SqlDbType.Int).Value = persona.Codigo;
               cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
               cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
               cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar,50).Value = persona.Direccion;
               cmdSave.Parameters.Add("@email", SqlDbType.VarChar,50).Value = persona.Email;
               cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
               cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.Fecha_Nac;
               cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
               opc = persona.Tipo_Persona;
               if (opc == Convert.ToString(gestion.Administrador))
               {
                   cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 1;
               }
               else if (opc == Convert.ToString(gestion.Profesor))
               {
                   cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 2;
               }
               else
               {
                   cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 3;
               }
               cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.Id_Plan;
               cmdSave.Parameters.Add("@sexo", SqlDbType.VarChar,1).Value = persona.Sexo;
              
               Convert.ToInt32(cmdSave.ExecuteNonQuery());
   
           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al modificar la persona", Ex);
               throw ExcepcionManejada;
               throw;
           }
           finally
           {
               if (SqlConn.State == ConnectionState.Open)
                   this.CloseConnection();
           }          
       }

       protected void Delete(_Personas ID)
       {
           try
           {
               this.OpenConnection();
               SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona=@id_persona", SqlConn);
               cmdDelete.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID.Codigo;
               cmdDelete.ExecuteNonQuery();

               Convert.ToInt32(cmdDelete.ExecuteNonQuery());

           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al eliminar la Persona", Ex);
               throw ExcepcionManejada;
           }
           finally
           {
               if (SqlConn.State == ConnectionState.Open)
                   this.CloseConnection();
           }
       }

       public void Save(_Personas persona)
       {
           if (persona.Estado == BusinessEntity.Estados.Eliminar)
           {
               this.Delete(persona);
           }
           else if (persona.Estado == BusinessEntity.Estados.Nuevo)
           {
               this.Insert(persona);
           }

           else if (persona.Estado == BusinessEntity.Estados.Modificar)
           {
               this.Update(persona);
           }
           persona.Estado = BusinessEntity.Estados.No_Modificar;
       }

    }
}
