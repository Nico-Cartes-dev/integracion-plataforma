﻿namespace BuenosAires.BodegaBA
{
    partial class VentanaGuiasDespacho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewGuias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGuias
            // 
            this.dataGridViewGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuias.Location = new System.Drawing.Point(41, 269);
            this.dataGridViewGuias.Name = "dataGridViewGuias";
            this.dataGridViewGuias.Size = new System.Drawing.Size(969, 306);
            this.dataGridViewGuias.TabIndex = 0;
            this.dataGridViewGuias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VentanaGuiasDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 606);
            this.Controls.Add(this.dataGridViewGuias);
            this.Name = "VentanaGuiasDespacho";
            this.Text = "VentanaGuiasDespacho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGuias;
    }
}