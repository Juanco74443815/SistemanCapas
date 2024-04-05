namespace SistemaVentas.VISTA.UsuarioVistas
{
    partial class UsuarioEditarVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioEditarVistas));
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtContraseña = new TextBox();
            txtNombreUser = new TextBox();
            txtIdPersona = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(406, 76);
            label5.Name = "label5";
            label5.Size = new Size(283, 37);
            label5.TabIndex = 24;
            label5.Text = "EDITAR USUARIO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(353, 278);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(627, 135);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(126, 26);
            button3.TabIndex = 22;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(578, 389);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 26);
            button2.TabIndex = 21;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(287, 389);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 26);
            button1.TabIndex = 20;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(349, 233);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(262, 23);
            txtContraseña.TabIndex = 19;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(349, 186);
            txtNombreUser.Margin = new Padding(3, 2, 3, 2);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(262, 23);
            txtNombreUser.TabIndex = 18;
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(349, 140);
            txtIdPersona.Margin = new Padding(3, 2, 3, 2);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(262, 23);
            txtIdPersona.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(182, 282);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 16;
            label4.Text = "FECHA REGISTRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(204, 234);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 15;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(167, 187);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 14;
            label2.Text = "NOMBRE USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(220, 140);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 13;
            label1.Text = "IDPERSONA";
            // 
            // UsuarioEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1012, 535);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUser);
            Controls.Add(txtIdPersona);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuarioEditarVistas";
            Text = "UsuarioEditarVistas";
            Load += UsuarioEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtContraseña;
        private TextBox txtNombreUser;
        private TextBox txtIdPersona;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}