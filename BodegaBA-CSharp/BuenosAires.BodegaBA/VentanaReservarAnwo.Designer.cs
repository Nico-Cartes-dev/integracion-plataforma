namespace BuenosAires.BodegaBA
{
    partial class VentanaReservarAnwo
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
            this.button1 = new System.Windows.Forms.Button();
            this.gridEquiposAnwo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquiposAnwo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gridEquiposAnwo
            // 
            this.gridEquiposAnwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquiposAnwo.Location = new System.Drawing.Point(55, 177);
            this.gridEquiposAnwo.Name = "gridEquiposAnwo";
            this.gridEquiposAnwo.RowHeadersWidth = 51;
            this.gridEquiposAnwo.RowTemplate.Height = 24;
            this.gridEquiposAnwo.Size = new System.Drawing.Size(685, 265);
            this.gridEquiposAnwo.TabIndex = 1;
            // 
            // VentanaReservarAnwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 485);
            this.Controls.Add(this.gridEquiposAnwo);
            this.Controls.Add(this.button1);
            this.Name = "VentanaReservarAnwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaReservarAnwo";
            ((System.ComponentModel.ISupportInitialize)(this.gridEquiposAnwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridEquiposAnwo;
    }
}