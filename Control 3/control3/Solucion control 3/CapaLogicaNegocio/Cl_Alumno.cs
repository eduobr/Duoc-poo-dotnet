using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDALC;

namespace CapaLogicaNegocio
{
    public class Cl_Alumno
    {
        public int idAlumno { get; set; }
        public string nombre { get; set; }
        public string apoderado { get; set; }
        public Cl_Profesor profe { get; set; }
        private DateTime fechaNacimiento;
        private char sexo;

        public char Sexo
        {
            get { return sexo; }
            set
            {
                if (value.Equals('F') || value.Equals('M'))
                {
                    sexo = value;
                }
                else {
                    throw new Exception("el sexo debe ser f o m");
                }
                 }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set {
                if (value < DateTime.Now)
                {
                    fechaNacimiento = value;
                }
                else {
                    throw new Exception("fecha deve ser menor a hoy");
                }
                 }
        }

        Cl_Contexto conn;

        public Cl_Alumno()
        {
            conn = new Cl_Contexto();
        }

        //metodos
        public bool agregar()
        {
            try
            {
                ALUMNO al = new ALUMNO();
                al.IDALUMNO = this.idAlumno;
                al.NOMBRE = this.nombre;
                al.FECHA_NACIMIENTO = this.FechaNacimiento;
                al.SEXO = this.Sexo.ToString();
                al.APODERADO = this.apoderado;
                al.PROFESOR_IDPROFESOR = this.profe.idProfe;

                conn.entidades.AddToALUMNO(al);
                conn.entidades.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public List<Cl_Alumno> listar(int idprofe)
        {
            try
            {
                List<ALUMNO> lista = conn.entidades.ALUMNO
                    .Where(a => a.PROFESOR_IDPROFESOR == idprofe)
                    .OrderBy(a=> a.APODERADO).ToList();

                List<Cl_Alumno> lista_clase = new List<Cl_Alumno>();
                foreach (ALUMNO item in lista)
                {
                    Cl_Alumno d = new Cl_Alumno();
                    d.idAlumno = item.IDALUMNO;
                    d.nombre = item.NOMBRE;
                    d.fechaNacimiento = item.FECHA_NACIMIENTO;
                    d.sexo = char.Parse(item.SEXO);
                    d.apoderado = item.APODERADO;
                    d.profe = new Cl_Profesor(item.PROFESOR_IDPROFESOR);
                    lista_clase.Add(d);
                }
                return lista_clase;
            }
            catch (Exception )
            {
                return null;
            }
        }
    }
}
