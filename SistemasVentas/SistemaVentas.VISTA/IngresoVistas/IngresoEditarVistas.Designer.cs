namespace SistemaVentas.VISTA.IngresoVistas
{
    partial class IngresoEditarVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoEditarVistas));
            btnSelec = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            txtTotal = new TextBox();
            txtIdProveedor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSelec
            // 
            btnSelec.BackColor = Color.FromArgb(0, 192, 192);
            btnSelec.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelec.Location = new Point(695, 247);
            btnSelec.Margin = new Padding(3, 2, 3, 2);
            btnSelec.Name = "btnSelec";
            btnSelec.Size = new Size(122, 28);
            btnSelec.TabIndex = 18;
            btnSelec.Text = "SELECCIONAR";
            btnSelec.UseVisualStyleBackColor = false;
            btnSelec.Click += btnSelec_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(416, 291);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(566, 432);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(231, 39);
            button2.TabIndex = 16;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(213, 432);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(232, 39);
            button1.TabIndex = 15;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(416, 329);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(258, 23);
            txtTotal.TabIndex = 14;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(416, 252);
            txtIdProveedor.Margin = new Padding(3, 2, 3, 2);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(258, 23);
            txtIdProveedor.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(301, 326);
            label3.Name = "label3";
            label3.Size = new Size(91, 29);
            label3.TabIndex = 12;
            label3.Text = "TOTAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(181, 289);
            label2.Name = "label2";
            label2.Size = new Size(211, 29);
            label2.TabIndex = 11;
            label2.Text = "FECHA INGRESO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(204, 252);
            label1.Name = "label1";
            label1.Size = new Size(188, 29);
            label1.TabIndex = 10;
            label1.Text = "IDPROVEEDOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(416, 110);
            label4.Name = "label4";
            label4.Size = new Size(243, 34);
            label4.TabIndex = 19;
            label4.Text = "EDITAR INGRESO";
            // 
            // IngresoEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1045, 547);
            Controls.Add(label4);
            Controls.Add(btnSelec);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(txtIdProveedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IngresoEditarVistas";
            Text = "IngresoEditarVistas";
            Load += IngresoEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelec;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox txtTotal;
        private TextBox txtIdProveedor;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}