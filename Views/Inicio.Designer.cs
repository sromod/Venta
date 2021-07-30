
namespace Ventas.Views
{
    partial class Inicio
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
            this.btnVentasAcumuladas = new System.Windows.Forms.Button();
            this.btnComisionesVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVentasAcumuladas
            // 
            this.btnVentasAcumuladas.Location = new System.Drawing.Point(59, 51);
            this.btnVentasAcumuladas.Name = "btnVentasAcumuladas";
            this.btnVentasAcumuladas.Size = new System.Drawing.Size(127, 46);
            this.btnVentasAcumuladas.TabIndex = 0;
            this.btnVentasAcumuladas.Text = "Ventas Acumuladas";
            this.btnVentasAcumuladas.UseVisualStyleBackColor = true;
            this.btnVentasAcumuladas.Click += new System.EventHandler(this.btnVentasAcumuladas_Click);
            // 
            // btnComisionesVendedor
            // 
            this.btnComisionesVendedor.Location = new System.Drawing.Point(59, 114);
            this.btnComisionesVendedor.Name = "btnComisionesVendedor";
            this.btnComisionesVendedor.Size = new System.Drawing.Size(127, 46);
            this.btnComisionesVendedor.TabIndex = 1;
            this.btnComisionesVendedor.Text = "Comisiones Vendedor";
            this.btnComisionesVendedor.UseVisualStyleBackColor = true;
            this.btnComisionesVendedor.Click += new System.EventHandler(this.btnComisionesVendedor_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComisionesVendedor);
            this.Controls.Add(this.btnVentasAcumuladas);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVentasAcumuladas;
        private System.Windows.Forms.Button btnComisionesVendedor;
    }
}