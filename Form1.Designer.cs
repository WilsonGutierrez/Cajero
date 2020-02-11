namespace Cajero
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadd = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.gbxPrimo = new System.Windows.Forms.GroupBox();
            this.lblComprobar = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNúmero = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxPrimo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEfectivo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnPagar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCantidadd);
            this.groupBox2.Controls.Add(this.lblCambio);
            this.groupBox2.Location = new System.Drawing.Point(817, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 189);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PAGAR";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(111, 71);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtEfectivo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Efectivo: ";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(29, 122);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(111, 49);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a pagar:";
            // 
            // txtCantidadd
            // 
            this.txtCantidadd.Location = new System.Drawing.Point(111, 33);
            this.txtCantidadd.Name = "txtCantidadd";
            this.txtCantidadd.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadd.TabIndex = 2;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(227, 78);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(54, 13);
            this.lblCambio.TabIndex = 1;
            this.lblCambio.Text = "Cambio: ?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRetirar);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblRespuesta);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 198);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RETIRAR";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(29, 96);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(111, 49);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(17, 36);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(75, 36);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(181, 39);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(70, 13);
            this.lblRespuesta.TabIndex = 1;
            this.lblRespuesta.Text = "Respuesta: ?";
            // 
            // gbxPrimo
            // 
            this.gbxPrimo.Controls.Add(this.lblComprobar);
            this.gbxPrimo.Controls.Add(this.btnComprobar);
            this.gbxPrimo.Controls.Add(this.label2);
            this.gbxPrimo.Controls.Add(this.txtNúmero);
            this.gbxPrimo.Location = new System.Drawing.Point(639, 17);
            this.gbxPrimo.Name = "gbxPrimo";
            this.gbxPrimo.Size = new System.Drawing.Size(321, 205);
            this.gbxPrimo.TabIndex = 12;
            this.gbxPrimo.TabStop = false;
            this.gbxPrimo.Text = "Comprobar si un número es Primo:";
            // 
            // lblComprobar
            // 
            this.lblComprobar.AutoSize = true;
            this.lblComprobar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobar.ForeColor = System.Drawing.Color.Red;
            this.lblComprobar.Location = new System.Drawing.Point(66, 135);
            this.lblComprobar.Name = "lblComprobar";
            this.lblComprobar.Size = new System.Drawing.Size(0, 29);
            this.lblComprobar.TabIndex = 3;
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(80, 85);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(75, 23);
            this.btnComprobar.TabIndex = 2;
            this.btnComprobar.Text = "Comprobar ";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingresar número: ";
            // 
            // txtNúmero
            // 
            this.txtNúmero.Location = new System.Drawing.Point(119, 42);
            this.txtNúmero.Name = "txtNúmero";
            this.txtNúmero.Size = new System.Drawing.Size(87, 20);
            this.txtNúmero.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblList);
            this.groupBox3.Controls.Add(this.btnGenerar);
            this.groupBox3.Controls.Add(this.txtNum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(215, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 248);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fibonacci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese el número de inicio:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(148, 27);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(87, 20);
            this.txtNum.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(85, 53);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(6, 94);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(0, 13);
            this.lblList.TabIndex = 5;
            this.lblList.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxPrimo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxPrimo.ResumeLayout(false);
            this.gbxPrimo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadd;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.GroupBox gbxPrimo;
        private System.Windows.Forms.Label lblComprobar;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNúmero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
    }
}

