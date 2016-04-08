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
        public int PrecioUC { get; set; }
        public int PrecioUV { get; set; }
        public int Cantidad { get; set; }
        public int IVA { get; set; }
        public string IdDepartamento { get; set; }
        public int PrecioUM { get; set; }
        public int PrecioSM { get; set; }


        public Producto() { }

        public Producto(int pIdProducto, string pDesc, string pIdDepartamento, int pPrecioUC, int pPrecioUV, int PCantidad, int pIVA, int pPrecioUM, int pPrecioSM)
        {
            this.IdProducto = pIdProducto;
            this.Desc = pDesc;
            this.IdDepartamento = pIdDepartamento;
            this.PrecioUC = pPrecioUC;
            this.PrecioUV = pPrecioUV;
            this.Cantidad = PCantidad;
            this.IVA = pIVA;
            this.PrecioUM = pPrecioUM;
            this.PrecioSM = pPrecioSM;
        }

    }
}
