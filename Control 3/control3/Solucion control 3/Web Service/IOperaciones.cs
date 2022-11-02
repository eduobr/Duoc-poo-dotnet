using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CapaLogicaNegocio;

namespace Web_Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOperaciones
    {

        [OperationContract]
        bool validar(string user, string pass);

        [OperationContract]
        bool agregarProfesor(int idprofe, string nombre, string asignatura, string curso);
        [OperationContract]
        bool eliminarProfesor(int idprofe);
        [OperationContract]
        bool buscarProfesor(int idProf);

        [OperationContract]
        bool agregarAlumno(int id,string nombre,DateTime fechanac, char sexo,string apoderado,int idprofe);
        [OperationContract]
        List<Cl_Alumno> listado(int idProfe);
    }
}
