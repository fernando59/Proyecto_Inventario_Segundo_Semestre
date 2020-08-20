namespace Capa_Presentacion { 
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnProductos1 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUsuario_Opciones = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.MenuHorizontal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureImagen = new Capa_Presentacion.Imagen_Circular();
            this.MenuVertical.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MenuHorizontal.SuspendLayout();
            this.Panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.MenuVertical.Controls.Add(this.btnCliente);
            this.MenuVertical.Controls.Add(this.btnProveedor);
            this.MenuVertical.Controls.Add(this.btnPedido);
            this.MenuVertical.Controls.Add(this.btnVenta);
            this.MenuVertical.Controls.Add(this.btnProductos1);
            this.MenuVertical.Controls.Add(this.btnInicio);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 750);
            this.MenuVertical.TabIndex = 0;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(3, 562);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(244, 58);
            this.btnCliente.TabIndex = 8;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Location = new System.Drawing.Point(6, 487);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(244, 58);
            this.btnProveedor.TabIndex = 7;
            this.btnProveedor.Text = "PROVEEDOR";
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPedido.Image")));
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(6, 626);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(244, 58);
            this.btnPedido.TabIndex = 3;
            this.btnPedido.Text = "PEDIDO";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnVenta.Image")));
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(3, 423);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(244, 58);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "VENTA";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnProductos1
            // 
            this.btnProductos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnProductos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductos1.FlatAppearance.BorderSize = 0;
            this.btnProductos1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProductos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProductos1.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos1.Image")));
            this.btnProductos1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos1.Location = new System.Drawing.Point(3, 359);
            this.btnProductos1.Name = "btnProductos1";
            this.btnProductos1.Size = new System.Drawing.Size(244, 58);
            this.btnProductos1.TabIndex = 1;
            this.btnProductos1.Text = "PRODUCTOS";
            this.btnProductos1.UseVisualStyleBackColor = false;
            this.btnProductos1.Click += new System.EventHandler(this.btnProductos1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 295);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(244, 58);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureImagen);
            this.panel3.Controls.Add(this.btnUsuario_Opciones);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.btnExaminar);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 207);
            this.panel3.TabIndex = 6;
            // 
            // btnUsuario_Opciones
            // 
            this.btnUsuario_Opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnUsuario_Opciones.FlatAppearance.BorderSize = 0;
            this.btnUsuario_Opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario_Opciones.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario_Opciones.Image")));
            this.btnUsuario_Opciones.Location = new System.Drawing.Point(159, 172);
            this.btnUsuario_Opciones.Name = "btnUsuario_Opciones";
            this.btnUsuario_Opciones.Size = new System.Drawing.Size(41, 19);
            this.btnUsuario_Opciones.TabIndex = 7;
            this.btnUsuario_Opciones.UseVisualStyleBackColor = false;
            this.btnUsuario_Opciones.Click += new System.EventHandler(this.btnUsuario_Opciones_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUsuario.Location = new System.Drawing.Point(3, 172);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(150, 18);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Fernando Mercado";
            this.lblUsuario.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Image = ((System.Drawing.Image)(resources.GetObject("btnExaminar.Image")));
            this.btnExaminar.Location = new System.Drawing.Point(206, 172);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(23, 19);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // MenuHorizontal
            // 
            this.MenuHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(181)))), ((int)(((byte)(161)))));
            this.MenuHorizontal.Controls.Add(this.label1);
            this.MenuHorizontal.Controls.Add(this.button2);
            this.MenuHorizontal.Controls.Add(this.btnMaximizar);
            this.MenuHorizontal.Controls.Add(this.btnSalir);
            this.MenuHorizontal.Controls.Add(this.btnMinimizar);
            this.MenuHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuHorizontal.Location = new System.Drawing.Point(250, 0);
            this.MenuHorizontal.Name = "MenuHorizontal";
            this.MenuHorizontal.Size = new System.Drawing.Size(1030, 72);
            this.MenuHorizontal.TabIndex = 1;
            this.MenuHorizontal.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuHorizontal_Paint);
            this.MenuHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuHorizontal_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(429, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "TIENDA VIEJITA";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(181)))), ((int)(((byte)(161)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(964, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 69);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(181)))), ((int)(((byte)(161)))));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(964, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 62);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleDescription = "";
            this.btnSalir.AccessibleName = "";
            this.btnSalir.AllowDrop = true;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(181)))), ((int)(((byte)(161)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(995, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSalir.Size = new System.Drawing.Size(35, 72);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(181)))), ((int)(((byte)(161)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(933, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 69);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Contenedor.AutoSize = true;
            this.Panel_Contenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_Contenedor.Controls.Add(this.splitter1);
            this.Panel_Contenedor.Location = new System.Drawing.Point(250, 68);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(1030, 682);
            this.Panel_Contenedor.TabIndex = 2;
            this.Panel_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 682);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureImagen
            // 
            this.pictureImagen.Image = ((System.Drawing.Image)(resources.GetObject("pictureImagen.Image")));
            this.pictureImagen.Location = new System.Drawing.Point(30, 17);
            this.pictureImagen.Name = "pictureImagen";
            this.pictureImagen.Size = new System.Drawing.Size(159, 140);
            this.pictureImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImagen.TabIndex = 8;
            this.pictureImagen.TabStop = false;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 750);
            this.Controls.Add(this.Panel_Contenedor);
            this.Controls.Add(this.MenuHorizontal);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda Viejita";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.MenuVertical.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.MenuHorizontal.ResumeLayout(false);
            this.MenuHorizontal.PerformLayout();
            this.Panel_Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel MenuHorizontal;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnUsuario_Opciones;
        public System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProductos1;
        private Imagen_Circular pictureImagen;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

