namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    partial class UsuarioRolInsertarVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioRolInsertarVistas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdUsuario = new TextBox();
            txtIdRol = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnSelecMarca = new Button();
            btnSelecTiProd = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(268, 141);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 0;
            label1.Text = "IDUSUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(305, 183);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 1;
            label2.Text = "IDROL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(242, 227);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 2;
            label3.Text = "FECHA ASIGNA";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(363, 141);
            txtIdUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(262, 23);
            txtIdUsuario.TabIndex = 3;
            // 
            // txtIdRol
            // 
            txtIdRol.Location = new Point(363, 183);
            txtIdRol.Margin = new Padding(3, 2, 3, 2);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(262, 23);
            txtIdRol.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(321, 362);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 30);
            button1.TabIndex = 6;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(516, 362);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(109, 30);
            button2.TabIndex = 7;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(363, 227);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // btnSelecMarca
            // 
            btnSelecMarca.BackColor = Color.White;
            btnSelecMarca.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecMarca.Location = new Point(630, 177);
            btnSelecMarca.Margin = new Padding(3, 2, 3, 2);
            btnSelecMarca.Name = "btnSelecMarca";
            btnSelecMarca.Size = new Size(124, 27);
            btnSelecMarca.TabIndex = 17;
            btnSelecMarca.Text = "SELECCIONAR";
            btnSelecMarca.UseVisualStyleBackColor = false;
            btnSelecMarca.Click += btnSelecMarca_Click;
            // 
            // btnSelecTiProd
            // 
            btnSelecTiProd.BackColor = Color.White;
            btnSelecTiProd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecTiProd.Location = new Point(630, 141);
            btnSelecTiProd.Margin = new Padding(3, 2, 3, 2);
            btnSelecTiProd.Name = "btnSelecTiProd";
            btnSelecTiProd.Size = new Size(124, 28);
            btnSelecTiProd.TabIndex = 16;
            btnSelecTiProd.Text = "SELECCIONAR";
            btnSelecTiProd.UseVisualStyleBackColor = false;
            btnSelecTiProd.Click += btnSelecTiProd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(219, 63);
            label4.Name = "label4";
            label4.Size = new Size(544, 37);
            label4.TabIndex = 18;
            label4.Text = "AGREGA UN NUEVO USUARIOROL";
            // 
            // UsuarioRolInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 550);
            Controls.Add(label4);
            Controls.Add(btnSelecMarca);
            Controls.Add(btnSelecTiProd);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtIdRol);
            Controls.Add(txtIdUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuarioRolInsertarVistas";
            Text = "UsuarioRolInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdUsuario;
        private TextBox txtIdRol;
        private TextBox txtFechaAsigna;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button btnSelecMarca;
        private Button btnSelecTiProd;
        private Label label4;
    }
}