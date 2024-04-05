namespace SistemaVentas.VISTA.DetalleIngVistas
{
    partial class DetalleIngEditarVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleIngEditarVistas));
            btnIng = new Button();
            txtPrecioVenta = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtProducto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnProd = new Button();
            button2 = new Button();
            button1 = new Button();
            txtCantidad = new TextBox();
            txtIngreso = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPrecioCosto = new TextBox();
            txtSubTotal = new TextBox();
            SuspendLayout();
            // 
            // btnIng
            // 
            btnIng.BackColor = Color.FromArgb(0, 192, 192);
            btnIng.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIng.Location = new Point(547, 124);
            btnIng.Margin = new Padding(3, 2, 3, 2);
            btnIng.Name = "btnIng";
            btnIng.Size = new Size(122, 26);
            btnIng.TabIndex = 50;
            btnIng.Text = "SELECCIONAR";
            btnIng.UseVisualStyleBackColor = false;
            btnIng.Click += btnIng_Click;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(262, 289);
            txtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(262, 23);
            txtPrecioVenta.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLight;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(150, 326);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 47;
            label7.Text = "SUBTOTAL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLight;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(115, 292);
            label8.Name = "label8";
            label8.Size = new Size(122, 21);
            label8.TabIndex = 46;
            label8.Text = "PRECIO VENTA";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(262, 157);
            txtProducto.Margin = new Padding(3, 2, 3, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(262, 23);
            txtProducto.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(124, 157);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 44;
            label6.Text = "IDPRODUCTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(290, 44);
            label5.Name = "label5";
            label5.Size = new Size(237, 30);
            label5.TabIndex = 43;
            label5.Text = "EDITAR UN INGRESO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(262, 190);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 42;
            // 
            // btnProd
            // 
            btnProd.BackColor = Color.FromArgb(0, 192, 192);
            btnProd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnProd.Location = new Point(547, 153);
            btnProd.Margin = new Padding(3, 2, 3, 2);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(122, 26);
            btnProd.TabIndex = 41;
            btnProd.Text = "SELECCIONAR";
            btnProd.UseVisualStyleBackColor = false;
            btnProd.Click += btnProd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(463, 425);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 28);
            button2.TabIndex = 40;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(163, 425);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(106, 28);
            button1.TabIndex = 39;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(262, 223);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(262, 23);
            txtCantidad.TabIndex = 37;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(262, 124);
            txtIngreso.Margin = new Padding(3, 2, 3, 2);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(262, 23);
            txtIngreso.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 191);
            label4.Name = "label4";
            label4.Size = new Size(199, 21);
            label4.TabIndex = 35;
            label4.Text = "FECHA DE VENCIMIENTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(116, 258);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 34;
            label3.Text = "PRECIO COSTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(144, 225);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 33;
            label2.Text = "CANTIDAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 124);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 32;
            label1.Text = "IDINGRESO";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(262, 259);
            txtPrecioCosto.Margin = new Padding(3, 2, 3, 2);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(262, 23);
            txtPrecioCosto.TabIndex = 51;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(262, 327);
            txtSubTotal.Margin = new Padding(3, 2, 3, 2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(262, 23);
            txtSubTotal.TabIndex = 52;
            // 
            // DetalleIngEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(794, 483);
            Controls.Add(txtSubTotal);
            Controls.Add(txtPrecioCosto);
            Controls.Add(btnIng);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtProducto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnProd);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCantidad);
            Controls.Add(txtIngreso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DetalleIngEditarVistas";
            Text = "DetalleIngEditarVistas";
            Load += DetalleIngEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIng;
        private TextBox txtPrecioVenta;
        private Label label7;
        private Label label8;
        private TextBox txtProducto;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button btnProd;
        private Button button2;
        private Button button1;
        private TextBox txtCantidad;
        private TextBox txtIngreso;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPrecioCosto;
        private TextBox txtSubTotal;
    }
}