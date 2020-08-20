namespace Capa_Presentacion
{
    partial class Agregar_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Producto));
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtStockPro = new System.Windows.Forms.TextBox();
            this.txtPrecioPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarPro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar_Producto = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ID2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrePro.Location = new System.Drawing.Point(199, 172);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(199, 20);
            this.txtNombrePro.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(199, 229);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 64);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtStockPro
            // 
            this.txtStockPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockPro.Location = new System.Drawing.Point(199, 321);
            this.txtStockPro.Name = "txtStockPro";
            this.txtStockPro.Size = new System.Drawing.Size(199, 20);
            this.txtStockPro.TabIndex = 2;
            // 
            // txtPrecioPro
            // 
            this.txtPrecioPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioPro.Location = new System.Drawing.Point(199, 371);
            this.txtPrecioPro.Name = "txtPrecioPro";
            this.txtPrecioPro.Size = new System.Drawing.Size(199, 20);
            this.txtPrecioPro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(199, 428);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(199, 21);
            this.cbCategoria.TabIndex = 11;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // btnAgregarPro
            // 
            this.btnAgregarPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAgregarPro.FlatAppearance.BorderSize = 0;
            this.btnAgregarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPro.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPro.Image")));
            this.btnAgregarPro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPro.Location = new System.Drawing.Point(46, 472);
            this.btnAgregarPro.Name = "btnAgregarPro";
            this.btnAgregarPro.Size = new System.Drawing.Size(103, 34);
            this.btnAgregarPro.TabIndex = 13;
            this.btnAgregarPro.Text = "Guardar";
            this.btnAgregarPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPro.UseVisualStyleBackColor = false;
            this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(376, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 34);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar_Producto
            // 
            this.btnEliminar_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnEliminar_Producto.FlatAppearance.BorderSize = 0;
            this.btnEliminar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar_Producto.Image")));
            this.btnEliminar_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar_Producto.Location = new System.Drawing.Point(261, 472);
            this.btnEliminar_Producto.Name = "btnEliminar_Producto";
            this.btnEliminar_Producto.Size = new System.Drawing.Size(102, 34);
            this.btnEliminar_Producto.TabIndex = 15;
            this.btnEliminar_Producto.Text = "Eliminar";
            this.btnEliminar_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar_Producto.UseVisualStyleBackColor = false;
            this.btnEliminar_Producto.Click += new System.EventHandler(this.btnEliminar_Producto_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(174, 269);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 24);
            this.ID.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 100);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(123, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Producto";
            // 
            // ID2
            // 
            this.ID2.AutoSize = true;
            this.ID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID2.Location = new System.Drawing.Point(30, 122);
            this.ID2.Name = "ID2";
            this.ID2.Size = new System.Drawing.Size(20, 29);
            this.ID2.TabIndex = 18;
            this.ID2.Text = ".";
            // 
            // Agregar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 518);
            this.Controls.Add(this.ID2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btnEliminar_Producto);
            this.Controls.Add(this.btnAgregarPro);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioPro);
            this.Controls.Add(this.txtStockPro);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombrePro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_Producto";
            this.Load += new System.EventHandler(this.Agregar_Producto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNombrePro;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtStockPro;
        public System.Windows.Forms.TextBox txtPrecioPro;
        public System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnEliminar_Producto;
        public System.Windows.Forms.Button btnAgregarPro;
        public System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label ID2;
    }
}