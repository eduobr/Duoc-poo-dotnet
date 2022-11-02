using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_DE_CLASES
{
    public enum TipoCategoria
    {
        Infantil, Adulto, Belleza, Animales
    }
    public class Cl_Producto
    {
        private int _numero;
        private DateTime _fechaIngreso;
        private string _descripcion;
        private int _valor;
        private int _cantidad;
        private TipoCategoria _categoria;
        private int _impuesto;

        public int Impuesto
        {
            get {
                CalcularImpuesto();
                return _impuesto; 
            }            
        }
        private void CalcularImpuesto()
        {
            int V = 0;
            switch (Categoria)
            {
                case TipoCategoria.Infantil:
                    V+= (int)(Valor * 0.05);
                    break;
                case TipoCategoria.Adulto:
                    V += (int)(Valor * 0.06);
                    break;
                case TipoCategoria.Belleza:
                    V += (int)(Valor * 0.08);
                    break;
                case TipoCategoria.Animales:
                    V += (int)(Valor * 0.09);
                    break;
                default:
                    break;
            }
            _impuesto = V;
        }
        public TipoCategoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value >= 10 && value <= 45)
                {
                    _cantidad = value;
                }
                else
                {
                    throw new Exception("valor entre 10 y 45");
                }
            }
        }
        public int Valor
        {
            get { return _valor; }
            set
            {
                if (value >= 100 && value <= 23000)
                {
                    _valor = value;
                }
                else
                {
                    throw
                    new Exception("valor entre 100 y 23000");
                }
            }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                if (value.Length >= 5)
                {
                    _descripcion = value;
                }
                else
                {
                    throw
                    new Exception("largo desc minimo 5 caracteres");
                }
            }
        }
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set
            {
                if (value < DateTime.Now)
                {
                    _fechaIngreso = value;
                }
                else
                {
                    throw
                    new Exception("fecha ingreso debe ser menoy a hoy");
                }
            }
        }
        public int Numero
        {
            get { return _numero; }
            set
            {
                if (value >= 0)
                {
                    _numero = value;
                }
                else
                {
                    throw new Exception("numero debe ser mayor a cero");
                }
            }
        }

        public Cl_Producto()
        {
            Init();
        }
        public Cl_Producto(int num,DateTime fi,string desc,int val,int cant,
            TipoCategoria cat)
        {
            Numero = num; FechaIngreso = fi; Descripcion = desc; Valor = val;
            Cantidad = cant; Categoria = cat;
        }
        private void Init()
        {
            Numero = 0;
            FechaIngreso = new DateTime(2010, 01, 01);
            Descripcion = "sin descipcion";
            Valor = 100;
            Cantidad = 10;
            Categoria = TipoCategoria.Infantil;
        }

        public void Descontar(int cant)
        {
            _cantidad -= cant;
        }
    }

}
