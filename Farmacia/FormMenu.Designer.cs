namespace Farmacia
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.farmaciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeTransaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosYPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.farmaciaToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // farmaciaToolStripMenuItem
            // 
            this.farmaciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.farmaciaToolStripMenuItem.Name = "farmaciaToolStripMenuItem";
            this.farmaciaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.farmaciaToolStripMenuItem.Text = "Farmacia";
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            this.medicamentosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosDeMedicamentosToolStripMenuItem,
            this.salidasDeMedicamentosToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // ingresosDeMedicamentosToolStripMenuItem
            // 
            this.ingresosDeMedicamentosToolStripMenuItem.Name = "ingresosDeMedicamentosToolStripMenuItem";
            this.ingresosDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ingresosDeMedicamentosToolStripMenuItem.Text = "Ingresos de Medicamentos";
            // 
            // salidasDeMedicamentosToolStripMenuItem
            // 
            this.salidasDeMedicamentosToolStripMenuItem.Name = "salidasDeMedicamentosToolStripMenuItem";
            this.salidasDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.salidasDeMedicamentosToolStripMenuItem.Text = "Salidas de Medicamentos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeMedicamentosToolStripMenuItem,
            this.reporteDeClientesToolStripMenuItem,
            this.reportesDeFacturaToolStripMenuItem,
            this.reporteDeTransaccionesToolStripMenuItem,
            this.reporteDeProveedoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeMedicamentosToolStripMenuItem
            // 
            this.reportesDeMedicamentosToolStripMenuItem.Name = "reportesDeMedicamentosToolStripMenuItem";
            this.reportesDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.reportesDeMedicamentosToolStripMenuItem.Text = "Reportes de Medicamentos";
            // 
            // reportesDeFacturaToolStripMenuItem
            // 
            this.reportesDeFacturaToolStripMenuItem.Name = "reportesDeFacturaToolStripMenuItem";
            this.reportesDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.reportesDeFacturaToolStripMenuItem.Text = "Reportes de Factura";
            // 
            // reporteDeTransaccionesToolStripMenuItem
            // 
            this.reporteDeTransaccionesToolStripMenuItem.Name = "reporteDeTransaccionesToolStripMenuItem";
            this.reporteDeTransaccionesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.reporteDeTransaccionesToolStripMenuItem.Text = "Reporte de Transacciones";
            // 
            // reporteDeProveedoresToolStripMenuItem
            // 
            this.reporteDeProveedoresToolStripMenuItem.Name = "reporteDeProveedoresToolStripMenuItem";
            this.reporteDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.reporteDeProveedoresToolStripMenuItem.Text = "Reporte de Proveedores";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosYPermisosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // usuariosYPermisosToolStripMenuItem
            // 
            this.usuariosYPermisosToolStripMenuItem.Name = "usuariosYPermisosToolStripMenuItem";
            this.usuariosYPermisosToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.usuariosYPermisosToolStripMenuItem.Text = "Login";
            this.usuariosYPermisosToolStripMenuItem.Click += new System.EventHandler(this.usuariosYPermisosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 257);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem farmaciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeTransaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosYPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}