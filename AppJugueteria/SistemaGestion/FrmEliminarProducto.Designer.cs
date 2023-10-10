namespace SistemaGestion
{
    partial class FrmEliminarProducto
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
            btnEliminar = new Button();
            textDescripcion = new Label();
            txtCosto = new Label();
            txtPrecioVenta = new Label();
            label4 = new Label();
            txtDescripcion = new TextBox();
            txtUsuario = new TextBox();
            numCosto = new NumericUpDown();
            numPrecioVenta = new NumericUpDown();
            numStock = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(335, 397);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 41);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // textDescripcion
            // 
            textDescripcion.AutoSize = true;
            textDescripcion.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            textDescripcion.Location = new Point(265, 18);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 21);
            textDescripcion.TabIndex = 1;
            textDescripcion.Text = "Descripción";
            // 
            // txtCosto
            // 
            txtCosto.AutoSize = true;
            txtCosto.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            txtCosto.Location = new Point(265, 91);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(53, 21);
            txtCosto.TabIndex = 2;
            txtCosto.Text = "Costo";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.AutoSize = true;
            txtPrecioVenta.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioVenta.Location = new Point(265, 168);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(106, 21);
            txtPrecioVenta.TabIndex = 3;
            txtPrecioVenta.Text = "Precio Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(265, 245);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 4;
            label4.Text = "Stock";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(265, 46);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(302, 31);
            txtDescripcion.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(265, 341);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(302, 31);
            txtUsuario.TabIndex = 6;
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 2;
            numCosto.Location = new Point(265, 119);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(180, 31);
            numCosto.TabIndex = 7;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.DecimalPlaces = 2;
            numPrecioVenta.Location = new Point(265, 196);
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(180, 31);
            numPrecioVenta.TabIndex = 8;
            // 
            // numStock
            // 
            numStock.Location = new Point(265, 273);
            numStock.Name = "numStock";
            numStock.Size = new Size(180, 31);
            numStock.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(265, 313);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 10;
            label5.Text = "Id Usuario";
            // 
            // FrmEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(numStock);
            Controls.Add(numPrecioVenta);
            Controls.Add(numCosto);
            Controls.Add(txtUsuario);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(textDescripcion);
            Controls.Add(btnEliminar);
            Name = "FrmEliminarProducto";
            Text = "FrmEliminarProducto";
            Load += FrmEliminarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Label textDescripcion;
        private Label txtCosto;
        private Label txtPrecioVenta;
        private Label label4;
        private TextBox txtDescripcion;
        private TextBox txtUsuario;
        private NumericUpDown numCosto;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numStock;
        private Label label5;
    }
}