using MiTienda.Dominio.Entidades.Entidades;

namespace Pav.Tp7.Vistas
{
    partial class VistaProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaProducto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.lblMG = new System.Windows.Forms.Label();
            this.lblCCI = new System.Windows.Forms.Label();
            this.lblPI = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCSI = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardarModificar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtMG = new System.Windows.Forms.TextBox();
            this.txtCCI = new System.Windows.Forms.TextBox();
            this.txtPI = new System.Windows.Forms.TextBox();
            this.txtCSI = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lblEstado);
            this.panel2.Controls.Add(this.lblExistencias);
            this.panel2.Controls.Add(this.lblPF);
            this.panel2.Controls.Add(this.lblMG);
            this.panel2.Controls.Add(this.lblCCI);
            this.panel2.Controls.Add(this.lblPI);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblCSI);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 381);
            this.panel2.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(144, 309);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencias.Location = new System.Drawing.Point(25, 280);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(183, 20);
            this.lblExistencias.TabIndex = 7;
            this.lblExistencias.Text = "Cantidad de Existencias:";
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPF.Location = new System.Drawing.Point(112, 250);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(95, 20);
            this.lblPF.TabIndex = 6;
            this.lblPF.Text = "Precio Final:";
            // 
            // lblMG
            // 
            this.lblMG.AutoSize = true;
            this.lblMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMG.Location = new System.Drawing.Point(46, 217);
            this.lblMG.Name = "lblMG";
            this.lblMG.Size = new System.Drawing.Size(162, 20);
            this.lblMG.TabIndex = 5;
            this.lblMG.Text = "Margen de Ganancia:";
            // 
            // lblCCI
            // 
            this.lblCCI.AutoSize = true;
            this.lblCCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCI.Location = new System.Drawing.Point(89, 182);
            this.lblCCI.Name = "lblCCI";
            this.lblCCI.Size = new System.Drawing.Size(119, 20);
            this.lblCCI.TabIndex = 4;
            this.lblCCI.Text = "Costo Con IVA:";
            // 
            // lblPI
            // 
            this.lblPI.AutoSize = true;
            this.lblPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPI.Location = new System.Drawing.Point(88, 151);
            this.lblPI.Name = "lblPI";
            this.lblPI.Size = new System.Drawing.Size(120, 20);
            this.lblPI.TabIndex = 3;
            this.lblPI.Text = "Porcentaje IVA:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(112, 88);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCSI
            // 
            this.lblCSI.AutoSize = true;
            this.lblCSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSI.Location = new System.Drawing.Point(95, 118);
            this.lblCSI.Name = "lblCSI";
            this.lblCSI.Size = new System.Drawing.Size(113, 20);
            this.lblCSI.TabIndex = 1;
            this.lblCSI.Text = "Costo Sin IVA:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(145, 58);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.btnGuardarModificar);
            this.panel3.Controls.Add(this.cbxEstado);
            this.panel3.Controls.Add(this.txtExistencias);
            this.panel3.Controls.Add(this.txtPF);
            this.panel3.Controls.Add(this.txtMG);
            this.panel3.Controls.Add(this.txtCCI);
            this.panel3.Controls.Add(this.txtPI);
            this.panel3.Controls.Add(this.txtCSI);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Location = new System.Drawing.Point(234, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 381);
            this.panel3.TabIndex = 0;
            // 
            // btnGuardarModificar
            // 
            this.btnGuardarModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarModificar.Location = new System.Drawing.Point(64, 346);
            this.btnGuardarModificar.Name = "btnGuardarModificar";
            this.btnGuardarModificar.Size = new System.Drawing.Size(123, 23);
            this.btnGuardarModificar.TabIndex = 10;
            this.btnGuardarModificar.Text = "Guardar/Modificar";
            this.btnGuardarModificar.UseVisualStyleBackColor = true;
            this.btnGuardarModificar.Click += new System.EventHandler(this.btnGuardarModificar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsProducto, "Estado", true));
            this.cbxEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Estado", true));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO",
            "ELIMINADO"});
            this.cbxEstado.Location = new System.Drawing.Point(31, 307);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(199, 21);
            this.cbxEstado.TabIndex = 8;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExistencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Existencias", true));
            this.txtExistencias.Location = new System.Drawing.Point(31, 280);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(199, 20);
            this.txtExistencias.TabIndex = 7;
            this.txtExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPF
            // 
            this.txtPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PrecioFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.txtPF.Location = new System.Drawing.Point(31, 250);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(199, 20);
            this.txtPF.TabIndex = 6;
            this.txtPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMG
            // 
            this.txtMG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "MargenGanancia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "p"));
            this.txtMG.Location = new System.Drawing.Point(31, 217);
            this.txtMG.Name = "txtMG";
            this.txtMG.Size = new System.Drawing.Size(199, 20);
            this.txtMG.TabIndex = 5;
            this.txtMG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCCI
            // 
            this.txtCCI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCCI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoConIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.txtCCI.Enabled = false;
            this.txtCCI.Location = new System.Drawing.Point(31, 184);
            this.txtCCI.Name = "txtCCI";
            this.txtCCI.ReadOnly = true;
            this.txtCCI.Size = new System.Drawing.Size(199, 20);
            this.txtCCI.TabIndex = 4;
            this.txtCCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPI
            // 
            this.txtPI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PorcentageIva", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p"));
            this.txtPI.Location = new System.Drawing.Point(31, 151);
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(199, 20);
            this.txtPI.TabIndex = 3;
            this.txtPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCSI
            // 
            this.txtCSI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCSI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoSinIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.txtCSI.Location = new System.Drawing.Point(31, 120);
            this.txtCSI.Name = "txtCSI";
            this.txtCSI.Size = new System.Drawing.Size(199, 20);
            this.txtCSI.TabIndex = 2;
            this.txtCSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(31, 90);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Codigo", true));
            this.txtCodigo.Location = new System.Drawing.Point(31, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(199, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bsProducto
            // 
            this.bsProducto.DataSource = typeof(Producto);
            // 
            // VistaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 382);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta y Modificacion de productos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblMG;
        private System.Windows.Forms.Label lblCCI;
        private System.Windows.Forms.Label lblPI;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCSI;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.Button btnGuardarModificar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtMG;
        private System.Windows.Forms.TextBox txtCCI;
        private System.Windows.Forms.TextBox txtPI;
        private System.Windows.Forms.TextBox txtCSI;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.BindingSource bsProducto;
    }
}

