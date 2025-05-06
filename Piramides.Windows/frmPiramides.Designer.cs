namespace Piramides.Windows
{
    partial class frmPiramides
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
            components = new System.ComponentModel.Container();
            lblLado = new Label();
            txtLado = new TextBox();
            lblAltura = new Label();
            txtAltura = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            PiramidesCuadradas = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            lblCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblLado
            // 
            lblLado.AutoSize = true;
            lblLado.Location = new Point(96, 28);
            lblLado.Name = "lblLado";
            lblLado.Size = new Size(36, 15);
            lblLado.TabIndex = 0;
            lblLado.Text = "Lado:";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(138, 25);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(107, 23);
            txtLado.TabIndex = 1;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(90, 57);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(138, 54);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(107, 23);
            txtAltura.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(41, 116);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 50);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(221, 116);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // PiramidesCuadradas
            // 
            PiramidesCuadradas.FormattingEnabled = true;
            PiramidesCuadradas.ItemHeight = 15;
            PiramidesCuadradas.Location = new Point(41, 192);
            PiramidesCuadradas.Name = "PiramidesCuadradas";
            PiramidesCuadradas.Size = new Size(255, 124);
            PiramidesCuadradas.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(96, 335);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // frmPiramides
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 359);
            Controls.Add(lblCantidad);
            Controls.Add(PiramidesCuadradas);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtAltura);
            Controls.Add(lblAltura);
            Controls.Add(txtLado);
            Controls.Add(lblLado);
            Name = "frmPiramides";
            Text = "frmPiramides";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLado;
        private TextBox txtLado;
        private Label lblAltura;
        private TextBox txtAltura;
        private Button btnOK;
        private Button btnCancelar;
        private ListBox PiramidesCuadradas;
        private ErrorProvider errorProvider1;
        private Label lblCantidad;
    }
}