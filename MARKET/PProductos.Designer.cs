﻿namespace MARKET
{
    partial class PProductos
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
            this.label4 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.checkBfiltroactivos = new System.Windows.Forms.CheckBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.checkbEstado = new System.Windows.Forms.CheckBox();
            this.cbxunidadmedida = new System.Windows.Forms.ComboBox();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.txtProductoid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Formulario y Vista de Productos";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(448, 268);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 28);
            this.btneliminar.TabIndex = 29;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(291, 268);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // checkBfiltroactivos
            // 
            this.checkBfiltroactivos.AutoSize = true;
            this.checkBfiltroactivos.Location = new System.Drawing.Point(75, 276);
            this.checkBfiltroactivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBfiltroactivos.Name = "checkBfiltroactivos";
            this.checkBfiltroactivos.Size = new System.Drawing.Size(130, 20);
            this.checkBfiltroactivos.TabIndex = 27;
            this.checkBfiltroactivos.Text = "Filtrar solo activo";
            this.checkBfiltroactivos.UseVisualStyleBackColor = true;
            this.checkBfiltroactivos.CheckedChanged += new System.EventHandler(this.checkBfiltroactivos_CheckedChanged_1);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(13, 304);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.Size = new System.Drawing.Size(893, 261);
            this.dgProductos.TabIndex = 26;
            this.dgProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellDoubleClick);
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(673, 91);
            this.txtpreciocompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(132, 22);
            this.txtpreciocompra.TabIndex = 25;
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
            // 
            // checkbEstado
            // 
            this.checkbEstado.AutoSize = true;
            this.checkbEstado.Location = new System.Drawing.Point(200, 223);
            this.checkbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkbEstado.Name = "checkbEstado";
            this.checkbEstado.Size = new System.Drawing.Size(66, 20);
            this.checkbEstado.TabIndex = 24;
            this.checkbEstado.Text = "Activo";
            this.checkbEstado.UseVisualStyleBackColor = true;
            // 
            // cbxunidadmedida
            // 
            this.cbxunidadmedida.FormattingEnabled = true;
            this.cbxunidadmedida.Location = new System.Drawing.Point(200, 174);
            this.cbxunidadmedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxunidadmedida.Name = "cbxunidadmedida";
            this.cbxunidadmedida.Size = new System.Drawing.Size(160, 24);
            this.cbxunidadmedida.TabIndex = 23;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(200, 129);
            this.cbxcategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(160, 24);
            this.cbxcategoria.TabIndex = 22;
            // 
            // txtProductoid
            // 
            this.txtProductoid.Enabled = false;
            this.txtProductoid.Location = new System.Drawing.Point(200, 91);
            this.txtProductoid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductoid.Name = "txtProductoid";
            this.txtProductoid.ReadOnly = true;
            this.txtProductoid.Size = new System.Drawing.Size(160, 22);
            this.txtProductoid.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Unidad de Medida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Producto Id";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Lps.";
            // 
            // PProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 577);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.checkBfiltroactivos);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.checkbEstado);
            this.Controls.Add(this.cbxunidadmedida);
            this.Controls.Add(this.cbxcategoria);
            this.Controls.Add(this.txtProductoid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PProductos";
            this.Load += new System.EventHandler(this.PProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.CheckBox checkBfiltroactivos;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.CheckBox checkbEstado;
        private System.Windows.Forms.ComboBox cbxunidadmedida;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.TextBox txtProductoid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
    }
}