﻿namespace CapaDesconectada
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarNt = new System.Windows.Forms.Button();
            this.tbBusquedaNt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerNotipado = new System.Windows.Forms.Button();
            this.gridNotipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxBuscarTipado = new System.Windows.Forms.TextBox();
            this.btnBuscarTipado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarNt);
            this.groupBox1.Controls.Add(this.tbBusquedaNt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnObtenerNotipado);
            this.groupBox1.Controls.Add(this.gridNotipado);
            this.groupBox1.Location = new System.Drawing.Point(23, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet No Tipado";
            // 
            // btnBuscarNt
            // 
            this.btnBuscarNt.Location = new System.Drawing.Point(114, 324);
            this.btnBuscarNt.Name = "btnBuscarNt";
            this.btnBuscarNt.Size = new System.Drawing.Size(122, 37);
            this.btnBuscarNt.TabIndex = 4;
            this.btnBuscarNt.Text = "Enviar";
            this.btnBuscarNt.UseVisualStyleBackColor = true;
            this.btnBuscarNt.Click += new System.EventHandler(this.btnBuscarNt_Click);
            // 
            // tbBusquedaNt
            // 
            this.tbBusquedaNt.Location = new System.Drawing.Point(78, 281);
            this.tbBusquedaNt.Name = "tbBusquedaNt";
            this.tbBusquedaNt.Size = new System.Drawing.Size(196, 20);
            this.tbBusquedaNt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CustomerID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnObtenerNotipado
            // 
            this.btnObtenerNotipado.Location = new System.Drawing.Point(22, 226);
            this.btnObtenerNotipado.Name = "btnObtenerNotipado";
            this.btnObtenerNotipado.Size = new System.Drawing.Size(319, 37);
            this.btnObtenerNotipado.TabIndex = 1;
            this.btnObtenerNotipado.Text = "Obtener datos no tipado";
            this.btnObtenerNotipado.UseVisualStyleBackColor = true;
            this.btnObtenerNotipado.Click += new System.EventHandler(this.btnObtenerNotipado_Click);
            // 
            // gridNotipado
            // 
            this.gridNotipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotipado.Location = new System.Drawing.Point(9, 37);
            this.gridNotipado.Name = "gridNotipado";
            this.gridNotipado.Size = new System.Drawing.Size(356, 183);
            this.gridNotipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarTipado);
            this.groupBox2.Controls.Add(this.tboxBuscarTipado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnObtenerTipado);
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(412, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(39, 226);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnObtenerTipado.Size = new System.Drawing.Size(319, 37);
            this.btnObtenerTipado.TabIndex = 2;
            this.btnObtenerTipado.Text = "Obtener datos tipados";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(6, 37);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(352, 183);
            this.gridTipado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CustomerID";
            // 
            // tboxBuscarTipado
            // 
            this.tboxBuscarTipado.Location = new System.Drawing.Point(92, 281);
            this.tboxBuscarTipado.Name = "tboxBuscarTipado";
            this.tboxBuscarTipado.Size = new System.Drawing.Size(196, 20);
            this.tboxBuscarTipado.TabIndex = 4;
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(141, 324);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(122, 37);
            this.btnBuscarTipado.TabIndex = 5;
            this.btnBuscarTipado.Text = "Enviar";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            this.btnBuscarTipado.Click += new System.EventHandler(this.btnBuscarTipado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridNotipado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnObtenerNotipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.TextBox tbBusquedaNt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarNt;
        private System.Windows.Forms.TextBox tboxBuscarTipado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarTipado;
    }
}

