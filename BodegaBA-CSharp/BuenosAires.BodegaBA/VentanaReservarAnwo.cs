using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BuenosAires.Model;
using BuenosAires.Model.Utiles;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaReservarAnwo : Form
    {
        public VentanaReservarAnwo()
        {
            InitializeComponent();
            gridEquiposAnwo.ConfigurarDataGridView(
                "nroserie:Nro Serie,"
                + "nomprod:Nombre,"
                + "precio:Precio,"
                + "reservado:Reservado,"
                + "opciones:Opciones");
            /*grid.ConfigurarDataGridView(
                  "idprod:ID,"
                + "nomprod:Nombre,"
                + "descprod:Descripcion,"
                + "precio:Precio,"
                + "imagen:Imagen"
                );*/
        }
    }
}
