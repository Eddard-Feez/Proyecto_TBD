using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTBD
{
    public class Producto
    {

        public int IdProducto { get; set; }
        public string Desc { get; set; }
        public int IdUnidadMed { get; set; }
        public decimal PrecioUC { get; set; }
        public decimal PrecioUV { get; set; }
        public decimal Cantidad { get; set; }
        public int IVA { get; set; }
        public int IdDepartamento { get; set; }
        public decimal PrecioUM { get; set; }
        public decimal PrecioSM { get; set; }
        public decimal CantidadMin { get; set; }


        public Producto() { }
      

        public Producto(int pIdProducto, string pDesc,int pIdUnidadMed, int pIdDepartamento, decimal pPrecioUC, decimal pPrecioUV, decimal PCantidad,decimal pCantidadMin, int pIVA, decimal pPrecioUM, decimal pPrecioSM)
        {
            this.IdProducto = pIdProducto;
            this.Desc = pDesc;
            this.IdDepartamento = pIdDepartamento;
            this.IdUnidadMed = pIdUnidadMed;
            this.PrecioUC = pPrecioUC;
            this.PrecioUV = pPrecioUV;
            this.Cantidad = PCantidad;
            this.IVA = pIVA;
            this.PrecioUM = pPrecioUM;
            this.PrecioSM = pPrecioSM;
            this.CantidadMin = pCantidadMin;
        }

    }
}
