using System.Resources;

namespace FrmCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblPrimerOperando = new Label();
            lblOperador = new Label();
            lblSegundoOperando = new Label();
            txtPrimerOperando = new TextBox();
            cboOperador = new ComboBox();
            txtSegundoOperando = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            listBox1 = new ListBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(53, 26);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(98, 28);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(100, 79);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(200, 48);
            grpSistema.TabIndex = 1;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(105, 24);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(11, 24);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Location = new Point(26, 185);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(98, 15);
            lblPrimerOperando.TabIndex = 2;
            lblPrimerOperando.Text = "Primer Operando";
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Location = new Point(151, 185);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(57, 15);
            lblOperador.TabIndex = 3;
            lblOperador.Text = "Operador";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Location = new Point(245, 182);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(110, 15);
            lblSegundoOperando.TabIndex = 4;
            lblSegundoOperando.Text = "Segundo Operando";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(24, 217);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(100, 23);
            txtPrimerOperando.TabIndex = 5;
            // 
            // cboOperador
            // 
            cboOperador.FormattingEnabled = true;
            cboOperador.Location = new Point(157, 217);
            cboOperador.Name = "cboOperador";
            cboOperador.Size = new Size(51, 23);
            cboOperador.TabIndex = 6;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Location = new Point(245, 217);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(100, 23);
            txtSegundoOperando.TabIndex = 7;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(8, 262);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(98, 40);
            btnOperar.TabIndex = 8;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(139, 262);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 40);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(257, 262);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(98, 40);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(400, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 229);
            listBox1.TabIndex = 11;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 342);
            Controls.Add(listBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(txtSegundoOperando);
            Controls.Add(cboOperador);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblOperador);
            Controls.Add(lblPrimerOperando);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimerParcial";
            FormClosing += FrmCalculadora_FormClosing;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblPrimerOperando;
        private Label lblOperador;
        private Label lblSegundoOperando;
        private TextBox txtPrimerOperando;
        private ComboBox cboOperador;
        private TextBox txtSegundoOperando;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ListBox listBox1;
    }
}