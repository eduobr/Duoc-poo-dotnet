using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDALC;

namespace CapaLogicaNegocio
{
    public class Cl_Profesor
    {
        public int idProfe { get; set; }
        public string nombre { get; set; }
        private string asignatura;
        public string curso { get; set; }
        public string Asignatura
        {
            get { return asignatura; }
            set {
                if (value.Length >= 2)
                {
                    asignatura = value;
                }
                else
                {
                    throw new Exception("asignatura minimo 2 caracteres");
                }
                }
        }

        private Cl_Contexto conn;

        public Cl_Profesor()
        {
            conn = new Cl_Contexto();
        }

        public Cl_Profesor(int id)
        {
            this.idProfe = id;
        }

        //metodos
        public bool agregar()
        {
            try
            {
                PROFESOR pro = new PROFESOR();
                pro.IDPROFESOR = this.idProfe;
                pro.NOMBRE = this.nombre;
                pro.ASIGNATURA = this.Asignatura;
                pro.CURSO = this.curso;

                conn.entidades.AddToPROFESOR(pro);
                conn.entidades.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                PROFESOR pro = conn.entidades.PROFESOR
                   .First(d => d.IDPROFESOR == this.idProfe);

                pro.NOMBRE = this.nombre;
                pro.ASIGNATURA = this.asignatura;
                pro.CURSO = this.curso;

                conn.entidades.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public bool Buscar()
        {
            try
            {
                PROFESOR pro = conn.entidades.PROFESOR
                    .First(a => a.IDPROFESOR == this.idProfe);
                this.nombre = pro.NOMBRE;
                this.Asignatura = pro.ASIGNATURA;
                this.curso = pro.CURSO;

                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public bool Eliminar()
        {
            try
            {
                PROFESOR pro = conn.entidades.PROFESOR
                    .First(d => d.IDPROFESOR == this.idProfe);
                conn.entidades.DeleteObject(pro);
                conn.entidades.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        
    }
}
