namespace SistemaGestion
{
    partial class FrmModificarProducto
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
            btnModificar = new Button();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtUsuario = new TextBox();
            numCosto = new NumericUpDown();
            numPrecioVenta = new NumericUpDown();
            numStock = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(328, 383);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 46);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "GUARDAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 21);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 1;
            label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(244, 45);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(314, 31);
            txtDescripcion.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(244, 332);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(314, 31);
            txtUsuario.TabIndex = 3;
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 2;
            numCosto.Location = new Point(244, 120);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(180, 31);
            numCosto.TabIndex = 4;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.DecimalPlaces = 2;
            numPrecioVenta.Location = new Point(244, 188);
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(180, 31);
            numPrecioVenta.TabIndex = 5;
            // 
            // numStock
            // 
            numStock.Location = new Point(244, 259);
            numStock.Name = "numStock";
            numStock.Size = new Size(180, 31);
            numStock.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(244, 96);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 7;
            label2.Text = "Precio de Costo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(244, 164);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 8;
            label3.Text = "Precio de Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(244, 231);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 9;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(244, 304);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 10;
            label5.Text = "Id usuario";
            // 
            // FrmModificarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numStock);
            Controls.Add(numPrecioVenta);
            Controls.Add(numCosto);
            Controls.Add(txtUsuario);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Name = "FrmModificarProducto";
            Text = "FrmModificarProducto";
            Load += FrmModificarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtUsuario;
        private NumericUpDown numCosto;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numStock;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}