namespace SistemaVentas.VISTA.ProveeVistas
{
    partial class ProveeEditarVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveeEditarVistas));
            btnSelecProvee = new Button();
            btnSelecProd = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            txtPrecio = new TextBox();
            txtProveedor = new TextBox();
            txtIdProducto = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnSelecProvee
            // 
            btnSelecProvee.BackColor = Color.White;
            btnSelecProvee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecProvee.Location = new Point(745, 169);
            btnSelecProvee.Margin = new Padding(3, 2, 3, 2);
            btnSelecProvee.Name = "btnSelecProvee";
            btnSelecProvee.Size = new Size(122, 25);
            btnSelecProvee.TabIndex = 30;
            btnSelecProvee.Text = "SELECCIONAR";
            btnSelecProvee.UseVisualStyleBackColor = false;
            btnSelecProvee.Click += btnSelecProvee_Click;
            // 
            // btnSelecProd
            // 
            btnSelecProd.BackColor = Color.White;
            btnSelecProd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecProd.Location = new Point(745, 143);
            btnSelecProd.Margin = new Padding(3, 2, 3, 2);
            btnSelecProd.Name = "btnSelecProd";
            btnSelecProd.Size = new Size(122, 25);
            btnSelecProd.TabIndex = 29;
            btnSelecProd.Text = "SELECCIONAR";
            btnSelecProd.UseVisualStyleBackColor = false;
            btnSelecProd.Click += btnSelecProd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(426, 208);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(277, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(592, 334);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(111, 25);
            button2.TabIndex = 27;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(342, 334);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 25);
            button1.TabIndex = 26;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(426, 248);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(277, 23);
            txtPrecio.TabIndex = 25;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(426, 172);
            txtProveedor.Margin = new Padding(3, 2, 3, 2);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(277, 23);
            txtProveedor.TabIndex = 24;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(426, 143);
            txtIdProducto.Margin = new Padding(3, 2, 3, 2);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(277, 23);
            txtIdProducto.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 248);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(336, 248);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 34;
            label5.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(342, 211);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 33;
            label4.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(278, 177);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 32;
            label2.Text = "IDPROVEEDOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 143);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 31;
            label1.Text = "IDPRODUCTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(410, 69);
            label6.Name = "label6";
            label6.Size = new Size(270, 37);
            label6.TabIndex = 35;
            label6.Text = "EDITAR PROVEE";
            // 
            // ProveeEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1181, 551);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSelecProvee);
            Controls.Add(btnSelecProd);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(txtProveedor);
            Controls.Add(txtIdProducto);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProveeEditarVistas";
            Text = "ProveeEditarVistas";
            Load += ProveeEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelecProvee;
        private Button btnSelecProd;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox txtPrecio;
        private TextBox txtProveedor;
        private TextBox txtIdProducto;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}