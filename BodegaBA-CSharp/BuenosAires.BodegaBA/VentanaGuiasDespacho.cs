using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuenosAires.BodegaBA.WsGuiaDespacho;
using Newtonsoft.Json;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaGuiasDespacho : Form
    {
        public VentanaGuiasDespacho()
        {
            InitializeComponent();
            this.Load += VentanaGuiasDespacho_Load;
        }

        public class GuiaItem
        {
            public int nrogd { get; set; }
            public int nrofac { get; set; }
            public int idprod { get; set; }
            public string estadogd { get; set; }
            public string nomprod { get; set; }
            public string rutcli { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarGuias();
        }

        private void VentanaGuiasDespacho_Load(object sender, EventArgs e)
        {
            CargarGuias();
        }

        private void CargarGuias()
        {
            try
            {
                var ws = new WsGuiaDespachoClient();
                var respuesta = ws.ConsultarGuiasDespacho();
                if (!respuesta.HayErrores)
                {
                    var guias = JsonConvert.DeserializeObject<List<GuiaItem>>(respuesta.JsonStockProducto);
                    dataGridViewGuias.DataSource = guias;

                    
                    dataGridViewGuias.Columns["nrogd"].HeaderText = "N° Guía";
                    dataGridViewGuias.Columns["nrofac"].HeaderText = "N° Factura";
                    dataGridViewGuias.Columns["idprod"].HeaderText = "ID Producto";
                    dataGridViewGuias.Columns["estadogd"].HeaderText = "Estado";
                    dataGridViewGuias.Columns["nomprod"].HeaderText = "Producto";
                    dataGridViewGuias.Columns["rutcli"].HeaderText = "RUT Cliente";
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
