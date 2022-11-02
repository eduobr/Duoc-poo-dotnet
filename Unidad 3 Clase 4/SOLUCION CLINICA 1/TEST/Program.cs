using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BIBLIOTECA;
using CONTROLADOR;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            DaoPaciente DAO = new DaoPaciente();
            CL_ADULTO adulto =
                new CL_ADULTO(1, "Juan", 58, TipoSalud.Fonasa, DateTime.Now, 15, "Farmacia");
            CL_ADULTO adulto1 =
                new CL_ADULTO(2, "Ana", 35, TipoSalud.Isapre, new DateTime(2016, 1, 25), 19, "Aseo");
            CL_NINO nino1 =
                new CL_NINO(3, "Adolfo Hit.", 10, TipoSalud.Fonasa, DateTime.Now, 10, "Semillita");
            DAO.Agregar(adulto);
            DAO.Agregar(adulto1);
            DAO.Agregar(nino1);
            foreach (CL_PACIENTE item in DAO.Listar())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("\n Numero Ficha:" + item.NumeroFicha);
                sb.Append("\n Nombre      :" + item.Nombre);
                sb.Append("\n Edad        :" + item.Edad);
                sb.Append("\n Tipo Salud  :" + item.Salud);
                sb.Append("\n Doctor      :" + item.NombreDoctor());
                sb.Append("\n Valor Aten. :" + item.ValorAtencion());
                sb.Append("\n "+ new string('-',25));
                Console.WriteLine(sb.ToString());
            }
            DAO = new DaoPaciente();
            Console.WriteLine("mayor fecha atencion:"+DAO.MayorFechaAtencion());
            Console.WriteLine("menor fecha atencion:"+DAO.MenorFechaAtencion());
            Console.WriteLine("Numero Adultos Isapre:"+DAO.MayoresIsapre());
            Console.WriteLine("Adultos con hora antes de las 13:"+DAO.AdultosMenores13());
            Console.ReadKey();

        }
    }
}
