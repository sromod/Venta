
namespace Ventas.Views
{
    partial class ComisionView
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
            this.lblAnioComision = new System.Windows.Forms.Label();
            this.lblMesComision = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnConsultarComision = new System.Windows.Forms.Button();
            this.dgvComision = new System.Windows.Forms.DataGridView();
            this.btnRegresarComision = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComision)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnioComision
            // 
            this.lblAnioComision.AutoSize = true;
            this.lblAnioComision.Location = new System.Drawing.Point(12, 37);
            this.lblAnioComision.Name = "lblAnioComision";
            this.lblAnioComision.Size = new System.Drawing.Size(29, 13);
            this.lblAnioComision.TabIndex = 0;
            this.lblAnioComision.Text = "Año:";
            // 
            // lblMesComision
            // 
            this.lblMesComision.AutoSize = true;
            this.lblMesComision.Location = new System.Drawing.Point(218, 37);
            this.lblMesComision.Name = "lblMesComision";
            this.lblMesComision.Size = new System.Drawing.Size(30, 13);
            this.lblMesComision.TabIndex = 1;
            this.lblMesComision.Text = "Mes:";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cmbAnio.Location = new System.Drawing.Point(47, 37);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 21);
            this.cmbAnio.TabIndex = 3;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(255, 37);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 4;
            // 
            // btnConsultarComision
            // 
            this.btnConsultarComision.Location = new System.Drawing.Point(416, 37);
            this.btnConsultarComision.Name = "btnConsultarComision";
            this.btnConsultarComision.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarComision.TabIndex = 5;
            this.btnConsultarComision.Text = "Consultar";
            this.btnConsultarComision.UseVisualStyleBackColor = true;
            // 
            // dgvComision
            // 
            this.dgvComision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComision.Location = new System.Drawing.Point(15, 96);
            this.dgvComision.Name = "dgvComision";
            this.dgvComision.Size = new System.Drawing.Size(361, 342);
            this.dgvComision.TabIndex = 6;
            // 
            // btnRegresarComision
            // 
            this.btnRegresarComision.Location = new System.Drawing.Point(416, 105);
            this.btnRegresarComision.Name = "btnRegresarComision";
            this.btnRegresarComision.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarComision.TabIndex = 7;
            this.btnRegresarComision.Text = "<< Regresar";
            this.btnRegresarComision.UseVisualStyleBackColor = true;
            this.btnRegresarComision.Click += new System.EventHandler(this.btnRegresarComision_Click);
            // 
            // ComisionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarComision);
            this.Controls.Add(this.dgvComision);
            this.Controls.Add(this.btnConsultarComision);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.lblMesComision);
            this.Controls.Add(this.lblAnioComision);
            this.Name = "ComisionView";
            this.Text = "COMISIONES ";
            this.Load += new System.EventHandler(this.ComisionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnioComision;
        private System.Windows.Forms.Label lblMesComision;
        public System.Windows.Forms.ComboBox cmbAnio;
        public System.Windows.Forms.ComboBox cmbMes;
        public System.Windows.Forms.Button btnConsultarComision;
        public System.Windows.Forms.DataGridView dgvComision;
        private System.Windows.Forms.Button btnRegresarComision;
    }
}