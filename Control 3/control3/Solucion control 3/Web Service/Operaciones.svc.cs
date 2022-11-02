using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CapaLogicaNegocio:

namespace Web_Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class Operaciones : IOperaciones
    {

        public bool validar(string user, string pass)
        {
            throw new NotImplementedException();
        }

        public bool agregarProfesor(int idpro, string nombre, string asignatura, string curso)
        {
            try
            {
                Cl_Profesor pro = new Cl_Profesor();
                pro.idProfe = idpro;
                pro.nombre = nombre;
                pro.Asignatura = asignatura;
                pro.curso = curso;

                return pro.agregar();

            }
            catch (Exception ex )
            {
                
                throw new Exception(ex.Message);
            }
        }

        public bool eliminarProfesor(int idprofe)
        {
            Cl_Profesor pro = new Cl_Profesor(idprofe);
            return pro.Eliminar();
        }

        public bool buscarProfesor(int idProf)
        {
            Cl_Profesor pro = new Cl_Profesor(idProf);
            return pro.Buscar();
            // pa la web txtnombre.text = pro.nombre;
        }

        public bool agregarAlumno(int id, string nombre, DateTime fechanac, char sexo, string apoderado, int idprofe)
        {
            Cl_Alumno al = new Cl_Alumno();

            al.idAlumno = id;
            al.nombre = nombre;
            al.FechaNacimiento = fechanac;
            al.Sexo = sexo;
            al.apoderado = apoderado;
            al.profe = new Cl_Profesor(idprofe);
            return al.agregar();
        }

        public List<Cl_Alumno> listado(int idProfe)
        {
            Cl_Alumno al = new Cl_Alumno();
            return al.listar(idProfe);
        }
    }
}
