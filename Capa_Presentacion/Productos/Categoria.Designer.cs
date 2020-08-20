namespace Capa_Presentacion
{
    partial class Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            this.txtDescripcionCa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCategoria = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBuscar_Categoria = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar_Categoria = new System.Windows.Forms.Button();
            this.btnBuscar_Categoria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategoria)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcionCa
            // 
            this.txtDescripcionCa.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionCa.Location = new System.Drawing.Point(147, 245);
            this.txtDescripcionCa.Multiline = true;
            this.txtDescripcionCa.Name = "txtDescripcionCa";
            this.txtDescripcionCa.Size = new System.Drawing.Size(214, 87);
            this.txtDescripcionCa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(251, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria";
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.BackColor = System.Drawing.Color.White;
            this.txtNombreCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCat.Location = new System.Drawing.Point(147, 131);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(214, 20);
            this.txtNombreCat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // dtCategoria
            // 
            this.dtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtCategoria.ColumnHeadersHeight = 30;
            this.dtCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtCategoria.Location = new System.Drawing.Point(367, 157);
            this.dtCategoria.Name = "dtCategoria";
            this.dtCategoria.RowHeadersWidth = 40;
            this.dtCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCategoria.Size = new System.Drawing.Size(329, 262);
            this.dtCategoria.TabIndex = 6;
            this.dtCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCategoria_CellDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(28, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 45);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtBuscar_Categoria
            // 
            this.txtBuscar_Categoria.BackColor = System.Drawing.Color.White;
            this.txtBuscar_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar_Categoria.Location = new System.Drawing.Point(377, 128);
            this.txtBuscar_Categoria.Name = "txtBuscar_Categoria";
            this.txtBuscar_Categoria.Size = new System.Drawing.Size(238, 20);
            this.txtBuscar_Categoria.TabIndex = 8;
            this.txtBuscar_Categoria.TextChanged += new System.EventHandler(this.txtBuscar_Categoria_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(241, 374);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 45);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar_Categoria
            // 
            this.btnModificar_Categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnModificar_Categoria.FlatAppearance.BorderSize = 0;
            this.btnModificar_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar_Categoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar_Categoria.Location = new System.Drawing.Point(631, 425);
            this.btnModificar_Categoria.Name = "btnModificar_Categoria";
            this.btnModificar_Categoria.Size = new System.Drawing.Size(65, 23);
            this.btnModificar_Categoria.TabIndex = 10;
            this.btnModificar_Categoria.Text = "Editar";
            this.btnModificar_Categoria.UseVisualStyleBackColor = false;
            this.btnModificar_Categoria.Click += new System.EventHandler(this.btnModificar_Categoria_Click);
            // 
            // btnBuscar_Categoria
            // 
            this.btnBuscar_Categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnBuscar_Categoria.FlatAppearance.BorderSize = 0;
            this.btnBuscar_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar_Categoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar_Categoria.Location = new System.Drawing.Point(621, 128);
            this.btnBuscar_Categoria.Name = "btnBuscar_Categoria";
            this.btnBuscar_Categoria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar_Categoria.TabIndex = 9;
            this.btnBuscar_Categoria.Text = "Buscar";
            this.btnBuscar_Categoria.UseVisualStyleBackColor = false;
            this.btnBuscar_Categoria.Click += new System.EventHandler(this.btnBuscar_Categoria_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(664, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 35);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 100);
            this.panel1.TabIndex = 15;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(708, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar_Categoria);
            this.Controls.Add(this.btnBuscar_Categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionCa);
            this.Controls.Add(this.txtNombreCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar_Categoria);
            this.Controls.Add(this.dtCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCategoria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcionCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtCategoria;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBuscar_Categoria;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar_Categoria;
        private System.Windows.Forms.Button btnBuscar_Categoria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
    }
}