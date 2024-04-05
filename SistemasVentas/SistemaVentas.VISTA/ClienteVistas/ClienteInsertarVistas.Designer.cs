namespace SistemaVentas.VISTA.ClienteVistas
{
    partial class ClienteInsertarVistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteInsertarVistas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdPersona = new TextBox();
            label4 = new Label();
            txtTipoCliente = new TextBox();
            txtCodigoCliente = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnSelec = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 111);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "IDPERSONA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 147);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 1;
            label2.Text = "TIPOCLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(99, 183);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 2;
            label3.Text = "CODIGOCLIENTE";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(251, 108);
            txtIdPersona.Margin = new Padding(3, 2, 3, 2);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(273, 23);
            txtIdPersona.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(380, 238);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(251, 144);
            txtTipoCliente.Margin = new Padding(3, 2, 3, 2);
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.Size = new Size(273, 23);
            txtTipoCliente.TabIndex = 5;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(251, 180);
            txtCodigoCliente.Margin = new Padding(3, 2, 3, 2);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(273, 23);
            txtCodigoCliente.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(251, 231);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(103, 26);
            button1.TabIndex = 7;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(379, 231);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 26);
            button2.TabIndex = 8;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSelec
            // 
            btnSelec.BackColor = Color.FromArgb(0, 192, 192);
            btnSelec.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelec.Location = new Point(536, 103);
            btnSelec.Margin = new Padding(3, 2, 3, 2);
            btnSelec.Name = "btnSelec";
            btnSelec.Size = new Size(131, 27);
            btnSelec.TabIndex = 9;
            btnSelec.Text = "SELECCIONAR";
            btnSelec.UseVisualStyleBackColor = false;
            btnSelec.Click += btnSelec_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(288, 55);
            label5.Name = "label5";
            label5.Size = new Size(222, 29);
            label5.TabIndex = 15;
            label5.Text = "AGREGAR CLIENTE";
            // 
            // ClienteInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(781, 384);
            Controls.Add(label5);
            Controls.Add(btnSelec);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCodigoCliente);
            Controls.Add(txtTipoCliente);
            Controls.Add(label4);
            Controls.Add(txtIdPersona);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClienteInsertarVistas";
            Text = "ClienteInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdPersona;
        private Label label4;
        private TextBox txtTipoCliente;
        private TextBox txtCodigoCliente;
        private Button button1;
        private Button button2;
        private Button btnSelec;
        private Label label5;
    }
}