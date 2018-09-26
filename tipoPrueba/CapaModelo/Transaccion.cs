using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Transaccion
    {
        private String  cod_producto,
                        nom_producto;
        private int peso_producto,
                    piezas_producidas,
                    piezas_malas,
                    piezas_totales,
                    kilos_totales;

        public string Cod_producto { get => cod_producto; set => cod_producto = value; }
        public string Nom_producto { get => nom_producto; set => nom_producto = value; }
        public int Peso_producto { get => peso_producto; set => peso_producto = value; }
        public int Piezas_producidas { get => piezas_producidas; set => piezas_producidas = value; }
        public int Piezas_malas { get => piezas_malas; set => piezas_malas = value; }
        public int Piezas_totales { get => piezas_totales; set => piezas_totales = value; }
        public int Kilos_totales { get => kilos_totales; set => kilos_totales = value; }

    }
}
