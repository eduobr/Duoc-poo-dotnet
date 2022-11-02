using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIBLIOTECA;
using CONTROLADOR;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DaoPaciente dao = new DaoPaciente();
            CL_ADULTO adulto = new CL_ADULTO(1,"Coke",21,TipoSalud.Fonasa,DateTime.Now,15,"Farmacia");
            CL_ADULTO adulto1 = new CL_ADULTO(2,"Ana",56,TipoSalud.Isapre,new DateTime(2016,01,25),19,"Aseo");
            CL_NINO nino = new CL_NINO(3,"Musolini",10,TipoSalud.Fonasa,DateTime.Now,16,"Semillita");

            dao.Agregar(adulto);
            dao.Agregar(adulto1);
            dao.Agregar(nino);
            foreach (CL_PACIENTE item in dao.Listar())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("\n Numero Ficha:"+item.NumeroFicha);
                sb.Append("\n Nombre:"+ item.Nombre);
                sb.Append("\n Edad:"+ item.Edad);
                sb.Append("\n Tipo Salud:"+ item.Salud);
                sb.Append("\n Doctor:"+ item.NombreDoctor());
                sb.Append("\n Valor Atencion:"+ item.ValorAtencion());
                sb.Append("\n " + new string('-', 25));
                Console.WriteLine(sb.ToString());
            }

            dao = new DaoPaciente();
            Console.WriteLine("Mayor fecha atencion:"+dao.MayorFechaAtencion());
            Console.WriteLine("Menor fecha atencion:" + dao.MenorFechaAtencion());
            Console.WriteLine("Numero Adultos Isapre:" + dao.MayoresIsapre());
            Console.WriteLine("Mayor fecha atencion:" + dao.AdultosMenores13());
            Console.ReadKey();
        }
    }
}
