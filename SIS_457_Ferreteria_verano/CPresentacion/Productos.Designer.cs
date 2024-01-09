﻿namespace CPresentacion
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.nudPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.gbxLista.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(749, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 42);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(24, 55);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(190, 19);
            this.lblBusqueda.TabIndex = 27;
            this.lblBusqueda.Text = "Buscar por nombre del cliente";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(28, 77);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(702, 20);
            this.txtParametro.TabIndex = 26;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(29, 28);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(847, 34);
            this.lblPrincipal.TabIndex = 25;
            this.lblPrincipal.Text = "PRODUCTOS";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.AllowUserToAddRows = false;
            this.dgvListaClientes.AllowUserToDeleteRows = false;
            this.dgvListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(7, 22);
            this.dgvListaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaClientes.MultiSelect = false;
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowHeadersVisible = false;
            this.dgvListaClientes.RowHeadersWidth = 62;
            this.dgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaClientes.Size = new System.Drawing.Size(825, 118);
            this.dgvListaClientes.TabIndex = 0;
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvListaClientes);
            this.gbxLista.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(28, 113);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(839, 157);
            this.gbxLista.TabIndex = 29;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de clientes";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(50, 276);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(789, 48);
            this.pnlAcciones.TabIndex = 30;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(501, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 42);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(402, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 42);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(309, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 42);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(212, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 42);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Accesorios",
            "Periféricos",
            "Laptops",
            "Repuestos",
            "Componentes"});
            this.cbxCategoria.Location = new System.Drawing.Point(656, 67);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(134, 27);
            this.cbxCategoria.TabIndex = 31;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(527, 70);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(71, 19);
            this.lblCategoria.TabIndex = 30;
            this.lblCategoria.Text = "Categoría:";
            // 
            // nudPrecioVenta
            // 
            this.nudPrecioVenta.Location = new System.Drawing.Point(656, 105);
            this.nudPrecioVenta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecioVenta.Name = "nudPrecioVenta";
            this.nudPrecioVenta.Size = new System.Drawing.Size(134, 26);
            this.nudPrecioVenta.TabIndex = 29;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(527, 107);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(108, 19);
            this.lblPrecioVenta.TabIndex = 28;
            this.lblPrecioVenta.Text = "Precio de Venta:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(656, 29);
            this.txtMarca.MaxLength = 250;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(134, 26);
            this.txtMarca.TabIndex = 27;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(527, 32);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 19);
            this.lblMarca.TabIndex = 26;
            this.lblMarca.Text = "Marca:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(141, 63);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(296, 100);
            this.txtDescripcion.TabIndex = 25;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(141, 25);
            this.txtCodigo.MaxLength = 250;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(296, 26);
            this.txtCodigo.TabIndex = 24;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 66);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(84, 19);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 19);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Código:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(683, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 42);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(582, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 42);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbxCategoria);
            this.gbxDatos.Controls.Add(this.lblCategoria);
            this.gbxDatos.Controls.Add(this.nudPrecioVenta);
            this.gbxDatos.Controls.Add(this.lblPrecioVenta);
            this.gbxDatos.Controls.Add(this.txtMarca);
            this.gbxDatos.Controls.Add(this.lblMarca);
            this.gbxDatos.Controls.Add(this.txtDescripcion);
            this.gbxDatos.Controls.Add(this.txtCodigo);
            this.gbxDatos.Controls.Add(this.lblDescripcion);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(35, 339);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(832, 188);
            this.gbxDatos.TabIndex = 41;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Detalles del producto";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.gbxLista.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.NumericUpDown nudPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbxDatos;
    }
}