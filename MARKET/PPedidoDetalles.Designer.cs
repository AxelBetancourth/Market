﻿namespace MARKET
{
    partial class PPedidoDetalles
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
            this.components = new System.ComponentModel.Container();
            this.txtproductoid = new System.Windows.Forms.TextBox();
            this.txtpedidoid = new System.Windows.Forms.TextBox();
            this.bbuscarproducto = new System.Windows.Forms.Button();
            this.buscarpdido = new System.Windows.Forms.Button();
            this.DgDetallesPedido = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtsubt = new System.Windows.Forms.TextBox();
            this.txtotal = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtDetallePedidoId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgDetallesPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtproductoid
            // 
            this.txtproductoid.Enabled = false;
            this.txtproductoid.Location = new System.Drawing.Point(611, 14);
            this.txtproductoid.Name = "txtproductoid";
            this.txtproductoid.ReadOnly = true;
            this.txtproductoid.Size = new System.Drawing.Size(38, 20);
            this.txtproductoid.TabIndex = 61;
            this.txtproductoid.Visible = false;
            // 
            // txtpedidoid
            // 
            this.txtpedidoid.Enabled = false;
            this.txtpedidoid.Location = new System.Drawing.Point(671, 14);
            this.txtpedidoid.Name = "txtpedidoid";
            this.txtpedidoid.ReadOnly = true;
            this.txtpedidoid.Size = new System.Drawing.Size(41, 20);
            this.txtpedidoid.TabIndex = 60;
            this.txtpedidoid.Visible = false;
            // 
            // bbuscarproducto
            // 
            this.bbuscarproducto.Location = new System.Drawing.Point(138, 87);
            this.bbuscarproducto.Name = "bbuscarproducto";
            this.bbuscarproducto.Size = new System.Drawing.Size(117, 23);
            this.bbuscarproducto.TabIndex = 59;
            this.bbuscarproducto.Text = "Buscar";
            this.bbuscarproducto.UseVisualStyleBackColor = true;
            this.bbuscarproducto.Click += new System.EventHandler(this.bbuscarproducto_Click);
            // 
            // buscarpdido
            // 
            this.buscarpdido.Location = new System.Drawing.Point(138, 114);
            this.buscarpdido.Name = "buscarpdido";
            this.buscarpdido.Size = new System.Drawing.Size(117, 23);
            this.buscarpdido.TabIndex = 58;
            this.buscarpdido.Text = "Buscar";
            this.buscarpdido.UseVisualStyleBackColor = true;
            this.buscarpdido.Click += new System.EventHandler(this.buscarpdido_Click);
            // 
            // DgDetallesPedido
            // 
            this.DgDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetallesPedido.Location = new System.Drawing.Point(12, 203);
            this.DgDetallesPedido.Name = "DgDetallesPedido";
            this.DgDetallesPedido.Size = new System.Drawing.Size(700, 235);
            this.DgDetallesPedido.TabIndex = 57;
            this.DgDetallesPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDetallesPedido_CellDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(391, 159);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(94, 23);
            this.btneliminar.TabIndex = 56;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(271, 159);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(94, 23);
            this.btnguardar.TabIndex = 55;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(611, 107);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(101, 20);
            this.txtDescuento.TabIndex = 54;
            // 
            // txtsubt
            // 
            this.txtsubt.Enabled = false;
            this.txtsubt.Location = new System.Drawing.Point(611, 81);
            this.txtsubt.Name = "txtsubt";
            this.txtsubt.ReadOnly = true;
            this.txtsubt.Size = new System.Drawing.Size(101, 20);
            this.txtsubt.TabIndex = 53;
            // 
            // txtotal
            // 
            this.txtotal.Enabled = false;
            this.txtotal.Location = new System.Drawing.Point(611, 133);
            this.txtotal.Name = "txtotal";
            this.txtotal.ReadOnly = true;
            this.txtotal.Size = new System.Drawing.Size(101, 20);
            this.txtotal.TabIndex = 52;
            // 
            // txtprecio
            // 
            this.txtprecio.Enabled = false;
            this.txtprecio.Location = new System.Drawing.Point(611, 55);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(101, 20);
            this.txtprecio.TabIndex = 51;
            // 
            // txtDetallePedidoId
            // 
            this.txtDetallePedidoId.Enabled = false;
            this.txtDetallePedidoId.Location = new System.Drawing.Point(138, 59);
            this.txtDetallePedidoId.Name = "txtDetallePedidoId";
            this.txtDetallePedidoId.ReadOnly = true;
            this.txtDetallePedidoId.Size = new System.Drawing.Size(117, 20);
            this.txtDetallePedidoId.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Descuento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "SubTotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Busque el Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Busque el Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Detalle Pedido Id\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Gestion de Detalles de Pedido";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PPedidoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.txtproductoid);
            this.Controls.Add(this.txtpedidoid);
            this.Controls.Add(this.bbuscarproducto);
            this.Controls.Add(this.buscarpdido);
            this.Controls.Add(this.DgDetallesPedido);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtsubt);
            this.Controls.Add(this.txtotal);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtDetallePedidoId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PPedidoDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPedidoDetalles";
            this.Load += new System.EventHandler(this.PPedidoDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDetallesPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtproductoid;
        private System.Windows.Forms.TextBox txtpedidoid;
        private System.Windows.Forms.Button bbuscarproducto;
        private System.Windows.Forms.Button buscarpdido;
        private System.Windows.Forms.DataGridView DgDetallesPedido;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtsubt;
        private System.Windows.Forms.TextBox txtotal;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtDetallePedidoId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}