package buenosaires.ventaba;

import buenosaires.model.Producto;
import buenosaires.model.ListaProducto;
import buenosaires.utils.XmlLoader;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.util.List;

public class VentanaConsultarBodega extends javax.swing.JFrame {

    private JTable tabla;
    private DefaultTableModel modelo;
    
    public VentanaConsultarBodega() {
        setTitle("Consulta de Bodega");
        setSize(600, 400);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        
        String[] columnas = {"ID", "Nombre", "Descripción", "Precio", "Imagen"};
        modelo = new DefaultTableModel(columnas, 0);
        tabla = new JTable(modelo);

        add(new JScrollPane(tabla), BorderLayout.CENTER);

        cargarDatosDesdeXml();
    }
    
     private void cargarDatosDesdeXml() {
        ListaProducto lista = XmlLoader.cargarProductosDesdeXml("productos.xml");
        if (lista != null) {
            List<Producto> productos = lista.getProductos();
            for (Producto p : productos) {
                modelo.addRow(new Object[]{
                        p.getIdprod(),
                        p.getNomprod(),
                        p.getDescprod(),
                        p.getPrecio(),
                        p.getImagen()
                });
            }
        } else {
            JOptionPane.showMessageDialog(this, "No se pudieron cargar los productos.", "Error", JOptionPane.ERROR_MESSAGE);
        }
    }


    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 400, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 300, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents


    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new VentanaConsultarBodega().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables
}
