
namespace Ventas.Views
{
    partial class VentaView
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
            this.dgvVentasAcumuladas = new System.Windows.Forms.DataGridView();
            this.lblFechaInicialVA = new System.Windows.Forms.Label();
            this.lblFechaFinalVA = new System.Windows.Forms.Label();
            this.btnConsultarVA = new System.Windows.Forms.Button();
            this.dtpFechaInicialVA = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinalVA = new System.Windows.Forms.DateTimePicker();
            this.btnRegresarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAcumuladas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasAcumuladas
            // 
            this.dgvVentasAcumuladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasAcumuladas.Location = new System.Drawing.Point(12, 140);
            this.dgvVentasAcumuladas.Name = "dgvVentasAcumuladas";
            this.dgvVentasAcumuladas.Size = new System.Drawing.Size(389, 286);
            this.dgvVentasAcumuladas.TabIndex = 0;
            // 
            // lblFechaInicialVA
            // 
            this.lblFechaInicialVA.AutoSize = true;
            this.lblFechaInicialVA.Location = new System.Drawing.Point(12, 32);
            this.lblFechaInicialVA.Name = "lblFechaInicialVA";
            this.lblFechaInicialVA.Size = new System.Drawing.Size(70, 13);
            this.lblFechaInicialVA.TabIndex = 1;
            this.lblFechaInicialVA.Text = "Fecha Inicial:";
            // 
            // lblFechaFinalVA
            // 
            this.lblFechaFinalVA.AutoSize = true;
            this.lblFechaFinalVA.Location = new System.Drawing.Point(12, 75);
            this.lblFechaFinalVA.Name = "lblFechaFinalVA";
            this.lblFechaFinalVA.Size = new System.Drawing.Size(65, 13);
            this.lblFechaFinalVA.TabIndex = 2;
            this.lblFechaFinalVA.Text = "Fecha Final:";
            // 
            // btnConsultarVA
            // 
            this.btnConsultarVA.Location = new System.Drawing.Point(315, 72);
            this.btnConsultarVA.Name = "btnConsultarVA";
            this.btnConsultarVA.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVA.TabIndex = 3;
            this.btnConsultarVA.Text = "Consultar";
            this.btnConsultarVA.UseVisualStyleBackColor = true;
            // 
            // dtpFechaInicialVA
            // 
            this.dtpFechaInicialVA.Location = new System.Drawing.Point(89, 32);
            this.dtpFechaInicialVA.Name = "dtpFechaInicialVA";
            this.dtpFechaInicialVA.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicialVA.TabIndex = 4;
            // 
            // dtpFechaFinalVA
            // 
            this.dtpFechaFinalVA.Location = new System.Drawing.Point(83, 75);
            this.dtpFechaFinalVA.Name = "dtpFechaFinalVA";
            this.dtpFechaFinalVA.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinalVA.TabIndex = 5;
            // 
            // btnRegresarVentas
            // 
            this.btnRegresarVentas.Location = new System.Drawing.Point(421, 152);
            this.btnRegresarVentas.Name = "btnRegresarVentas";
            this.btnRegresarVentas.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarVentas.TabIndex = 6;
            this.btnRegresarVentas.Text = "<< Regresar";
            this.btnRegresarVentas.UseVisualStyleBackColor = true;
            this.btnRegresarVentas.Click += new System.EventHandler(this.btnRegresarVentas_Click);
            // 
            // VentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarVentas);
            this.Controls.Add(this.dtpFechaFinalVA);
            this.Controls.Add(this.dtpFechaInicialVA);
            this.Controls.Add(this.btnConsultarVA);
            this.Controls.Add(this.lblFechaFinalVA);
            this.Controls.Add(this.lblFechaInicialVA);
            this.Controls.Add(this.dgvVentasAcumuladas);
            this.Name = "VentaView";
            this.Text = "VENTAS ACUMULADAS POR DEPARTAMENTO";
            this.Load += new System.EventHandler(this.VentaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAcumuladas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFechaInicialVA;
        private System.Windows.Forms.Label lblFechaFinalVA;
        public System.Windows.Forms.DataGridView dgvVentasAcumuladas;
        public System.Windows.Forms.DateTimePicker dtpFechaInicialVA;
        public System.Windows.Forms.DateTimePicker dtpFechaFinalVA;
        public System.Windows.Forms.Button btnConsultarVA;
        private System.Windows.Forms.Button btnRegresarVentas;
    }
}