namespace FormsCliente
{
    partial class Form1
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
            lblComando = new Label();
            txtResposta = new TextBox();
            lblResposta = new Label();
            btnEnviar = new Button();
            btnLimpar = new Button();
            cbx_1 = new ComboBox();
            SuspendLayout();
            // 
            // lblComando
            // 
            lblComando.AutoSize = true;
            lblComando.Cursor = Cursors.IBeam;
            lblComando.Font = new Font("Segoe UI", 12F);
            lblComando.ForeColor = SystemColors.MenuHighlight;
            lblComando.Location = new Point(12, 12);
            lblComando.Name = "lblComando";
            lblComando.Size = new Size(167, 21);
            lblComando.TabIndex = 1;
            lblComando.Text = "Selecione um Comodo";
            // 
            // txtResposta
            // 
            txtResposta.ForeColor = SystemColors.Window;
            txtResposta.Location = new Point(29, 78);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.ReadOnly = true;
            txtResposta.ScrollBars = ScrollBars.Vertical;
            txtResposta.Size = new Size(591, 222);
            txtResposta.TabIndex = 2;
            txtResposta.TextChanged += txtResposta_TextChanged;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Font = new Font("Segoe UI", 12F);
            lblResposta.ForeColor = SystemColors.MenuHighlight;
            lblResposta.Location = new Point(266, 54);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(135, 21);
            lblResposta.TabIndex = 3;
            lblResposta.Text = "Status do comodo";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(528, 319);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DimGray;
            btnLimpar.Font = new Font("Segoe UI", 9F);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(12, 306);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(158, 36);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar Respota";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // cbx_1
            // 
            cbx_1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_1.FormattingEnabled = true;
            cbx_1.Items.AddRange(new object[] { "Sala ", "Quarto 1 ", "Quarto 2" });
            cbx_1.Location = new Point(185, 14);
            cbx_1.Name = "cbx_1";
            cbx_1.Size = new Size(121, 23);
            cbx_1.TabIndex = 6;
            cbx_1.SelectedIndexChanged += cbx_1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 354);
            Controls.Add(cbx_1);
            Controls.Add(btnLimpar);
            Controls.Add(btnEnviar);
            Controls.Add(lblResposta);
            Controls.Add(txtResposta);
            Controls.Add(lblComando);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblComando;
        private TextBox txtResposta;
        private Label lblResposta;
        private Button btnEnviar;
        private Button btnLimpar;
        private ComboBox cbx_1;
    }
}
