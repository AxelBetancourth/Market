﻿namespace MARKET
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoDeDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condiciónDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condiciónDePagosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadDeMedidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupoDeDescuentosToolStripMenuItem,
            this.condiciónDePagosToolStripMenuItem,
            this.condiciónDePagosToolStripMenuItem1});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // grupoDeDescuentosToolStripMenuItem
            // 
            this.grupoDeDescuentosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDeDescuentosToolStripMenuItem.Image = global::MARKET.Properties.Resources.agregar_cliente;
            this.grupoDeDescuentosToolStripMenuItem.Name = "grupoDeDescuentosToolStripMenuItem";
            this.grupoDeDescuentosToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.grupoDeDescuentosToolStripMenuItem.Text = "Agregar";
            this.grupoDeDescuentosToolStripMenuItem.Click += new System.EventHandler(this.grupoDeDescuentosToolStripMenuItem_Click_1);
            // 
            // condiciónDePagosToolStripMenuItem
            // 
            this.condiciónDePagosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condiciónDePagosToolStripMenuItem.Image = global::MARKET.Properties.Resources.grupos_descuento;
            this.condiciónDePagosToolStripMenuItem.Name = "condiciónDePagosToolStripMenuItem";
            this.condiciónDePagosToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.condiciónDePagosToolStripMenuItem.Text = "Grupo de descuentos";
            this.condiciónDePagosToolStripMenuItem.Click += new System.EventHandler(this.condiciónDePagosToolStripMenuItem_Click);
            // 
            // condiciónDePagosToolStripMenuItem1
            // 
            this.condiciónDePagosToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condiciónDePagosToolStripMenuItem1.Image = global::MARKET.Properties.Resources.condicion_pago;
            this.condiciónDePagosToolStripMenuItem1.Name = "condiciónDePagosToolStripMenuItem1";
            this.condiciónDePagosToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.condiciónDePagosToolStripMenuItem1.Text = "Condición de pagos";
            this.condiciónDePagosToolStripMenuItem1.Click += new System.EventHandler(this.condiciónDePagosToolStripMenuItem1_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.unidadDeMedidaToolStripMenuItem,
            this.unidadDeMedidaToolStripMenuItem1});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categoriaToolStripMenuItem.Text = "Agregar";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem
            // 
            this.unidadDeMedidaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadDeMedidaToolStripMenuItem.Name = "unidadDeMedidaToolStripMenuItem";
            this.unidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unidadDeMedidaToolStripMenuItem.Text = "Categoria";
            this.unidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem1
            // 
            this.unidadDeMedidaToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadDeMedidaToolStripMenuItem1.Name = "unidadDeMedidaToolStripMenuItem1";
            this.unidadDeMedidaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.unidadDeMedidaToolStripMenuItem1.Text = "Unidad de medida";
            this.unidadDeMedidaToolStripMenuItem1.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem1_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPedidosToolStripMenuItem,
            this.detalleDePedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.verPedidosToolStripMenuItem.Text = "Agregar";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // detalleDePedidosToolStripMenuItem
            // 
            this.detalleDePedidosToolStripMenuItem.Name = "detalleDePedidosToolStripMenuItem";
            this.detalleDePedidosToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.detalleDePedidosToolStripMenuItem.Text = "Detalles";
            this.detalleDePedidosToolStripMenuItem.Click += new System.EventHandler(this.detalleDePedidosToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFacturasToolStripMenuItem,
            this.detalleDeFacturasToolStripMenuItem});
            this.facturasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.verFacturasToolStripMenuItem.Text = "Agregar";
            this.verFacturasToolStripMenuItem.Click += new System.EventHandler(this.verFacturasToolStripMenuItem_Click);
            // 
            // detalleDeFacturasToolStripMenuItem
            // 
            this.detalleDeFacturasToolStripMenuItem.Name = "detalleDeFacturasToolStripMenuItem";
            this.detalleDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.detalleDeFacturasToolStripMenuItem.Text = "Detalles";
            this.detalleDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.detalleDeFacturasToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MARKET.Properties.Resources.menu_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipal";
            this.Text = "MARKET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoDeDescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condiciónDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condiciónDePagosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unidadDeMedidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeFacturasToolStripMenuItem;
    }
}

