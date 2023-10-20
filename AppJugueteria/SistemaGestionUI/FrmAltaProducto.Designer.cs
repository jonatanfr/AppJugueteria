namespace SistemaGestion
{
    partial class FrmAltaProducto
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
            btnguardar = new Button();
            textDescripcion = new TextBox();
            txtUsuario = new TextBox();
            labelDescripcion = new Label();
            labelPrecioVenta = new Label();
            labelCosto = new Label();
            numCosto = new NumericUpDown();
            numVenta = new NumericUpDown();
            numStock = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // btnguardar
            // 
            btnguardar.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardar.Location = new Point(347, 391);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(112, 34);
            btnguardar.TabIndex = 0;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(279, 48);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(299, 31);
            textDescripcion.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(279, 328);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(299, 31);
            txtUsuario.TabIndex = 2;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(279, 21);
            labelDescripcion.Margin = new Padding(3);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(100, 21);
            labelDescripcion.TabIndex = 6;
            labelDescripcion.Text = "Descripción";
            labelDescripcion.Click += label1_Click;
            // 
            // labelPrecioVenta
            // 
            labelPrecioVenta.AutoSize = true;
            labelPrecioVenta.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecioVenta.Location = new Point(279, 163);
            labelPrecioVenta.Name = "labelPrecioVenta";
            labelPrecioVenta.Size = new Size(129, 21);
            labelPrecioVenta.TabIndex = 7;
            labelPrecioVenta.Text = "Precio de Venta";
            // 
            // labelCosto
            // 
            labelCosto.AutoSize = true;
            labelCosto.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            labelCosto.Location = new Point(279, 92);
            labelCosto.Name = "labelCosto";
            labelCosto.Size = new Size(53, 21);
            labelCosto.TabIndex = 8;
            labelCosto.Text = "Costo";
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 2;
            numCosto.Location = new Point(279, 116);
            numCosto.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(180, 31);
            numCosto.TabIndex = 9;
            // 
            // numVenta
            // 
            numVenta.DecimalPlaces = 2;
            numVenta.Location = new Point(279, 187);
            numVenta.Name = "numVenta";
            numVenta.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            numVenta.Size = new Size(180, 31);
            numVenta.TabIndex = 10;
            // 
            // numStock
            // 
            numStock.Location = new Point(279, 256);
            numStock.Name = "numStock";
            numStock.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            numStock.Size = new Size(180, 31);
            numStock.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 232);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 12;
            label1.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(279, 304);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 13;
            label2.Text = "Id Usuario";
            // 
            // FrmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numStock);
            Controls.Add(numVenta);
            Controls.Add(numCosto);
            Controls.Add(labelCosto);
            Controls.Add(labelPrecioVenta);
            Controls.Add(labelDescripcion);
            Controls.Add(txtUsuario);
            Controls.Add(textDescripcion);
            Controls.Add(btnguardar);
            Name = "FrmAltaProducto";
            Text = "AltaProducto";
            Load += FrmAltaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnguardar;
        private TextBox textDescripcion;
        private TextBox txtUsuario;
        private Label labelDescripcion;
        private Label labelPrecioVenta;
        private Label labelCosto;
        private NumericUpDown numCosto;
        private NumericUpDown numVenta;
        private NumericUpDown numStock;
        private Label label1;
        private Label label2;
    }
}