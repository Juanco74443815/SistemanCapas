namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    partial class UsuarioRolEditarVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioRolEditarVistas));
            btnSelecMarca = new Button();
            btnSelecTiProd = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            txtIdRol = new TextBox();
            txtIdUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSelecMarca
            // 
            btnSelecMarca.BackColor = Color.White;
            btnSelecMarca.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecMarca.Location = new Point(569, 180);
            btnSelecMarca.Margin = new Padding(3, 2, 3, 2);
            btnSelecMarca.Name = "btnSelecMarca";
            btnSelecMarca.Size = new Size(123, 27);
            btnSelecMarca.TabIndex = 27;
            btnSelecMarca.Text = "SELECCIONAR";
            btnSelecMarca.UseVisualStyleBackColor = false;
            btnSelecMarca.Click += btnSelecMarca_Click;
            // 
            // btnSelecTiProd
            // 
            btnSelecTiProd.BackColor = Color.White;
            btnSelecTiProd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecTiProd.Location = new Point(569, 119);
            btnSelecTiProd.Margin = new Padding(3, 2, 3, 2);
            btnSelecTiProd.Name = "btnSelecTiProd";
            btnSelecTiProd.Size = new Size(123, 30);
            btnSelecTiProd.TabIndex = 26;
            btnSelecTiProd.Text = "SELECCIONAR";
            btnSelecTiProd.UseVisualStyleBackColor = false;
            btnSelecTiProd.Click += btnSelecTiProd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(301, 249);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(481, 344);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(121, 28);
            button2.TabIndex = 24;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(260, 344);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 28);
            button1.TabIndex = 23;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtIdRol
            // 
            txtIdRol.Location = new Point(301, 184);
            txtIdRol.Margin = new Padding(3, 2, 3, 2);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(262, 23);
            txtIdRol.TabIndex = 22;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(301, 118);
            txtIdUsuario.Margin = new Padding(3, 2, 3, 2);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(262, 23);
            txtIdUsuario.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(161, 253);
            label3.Name = "label3";
            label3.Size = new Size(130, 19);
            label3.TabIndex = 20;
            label3.Text = "FECHA ASIGNADA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(230, 188);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 19;
            label2.Text = "IDROL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 119);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 18;
            label1.Text = "IDUSUARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(282, 53);
            label4.Name = "label4";
            label4.Size = new Size(349, 37);
            label4.TabIndex = 28;
            label4.Text = "EDITAR USUARIOROL";
            // 
            // UsuarioRolEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 500);
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
            Name = "UsuarioRolEditarVistas";
            Text = "UsuarioRolEditarVistas";
            Load += UsuarioRolEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelecMarca;
        private Button btnSelecTiProd;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox txtIdRol;
        private TextBox txtIdUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}