using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIBLIOTECA_DE_CLASES
{
    public class Cl_Venta
    {
        private int _numero;
        private DateTime _fechaVenta;
        private Cl_Producto _producto;
        private Cl_Cliente _cliente;
        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }       
        public Cl_Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }       
        public Cl_Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }        
        public DateTime FechaVenta
        {
            get { return _fechaVenta; }            
        }      
        public int Numero
        {
            get { return _numero; }
            set {
                if (value >= 0)
                {
                    _numero = value;
                }
                else {
                    throw new
                    Exception("numero mayor o igual a 0");
                }
            }
        }

        public bool RealizarCompra() {
            if (Producto.Cantidad >= Cantidad) {
                try
                {
                  int saldo = Cliente.Compra(Cantidad * Producto.Valor);
                  if (saldo >= 0) {
                      Producto.Descontar(Cantidad);
                      return true; 
                  }
                }
                catch (Exception ex)
                {                    
                    throw ex;
                }
            }
            throw new Exception("stock insuficiente");
        }

        public Cl_Venta()
        {
            Init();
        }

        public Cl_Venta(int num, Cl_Producto pro, Cl_Cliente cli, int cant)
        {
            Numero = num; Producto = pro; Cliente = cli; Cantidad = cant; _fechaVenta = DateTime.Now;
        }

        private void Init()
        {
            Numero = 0; _fechaVenta = DateTime.Now; Producto = new Cl_Producto(); Cliente = new Cl_Cliente(); Cantidad = 0;
        }

        
    }
}
