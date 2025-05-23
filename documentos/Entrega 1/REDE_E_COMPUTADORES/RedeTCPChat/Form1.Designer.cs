namespace RedeTCPChat
{
    partial class frmChat
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
            this.gbxChat = new System.Windows.Forms.GroupBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.gbxMensagem = new System.Windows.Forms.GroupBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtIPDestino = new System.Windows.Forms.TextBox();
            this.lblIPDestino = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.cmbIPAddress = new System.Windows.Forms.ComboBox();
            this.gbxChat.SuspendLayout();
            this.gbxMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxChat
            // 
            this.gbxChat.Controls.Add(this.txtChat);
            this.gbxChat.Location = new System.Drawing.Point(16, 15);
            this.gbxChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxChat.Name = "gbxChat";
            this.gbxChat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxChat.Size = new System.Drawing.Size(800, 303);
            this.gbxChat.TabIndex = 0;
            this.gbxChat.TabStop = false;
            this.gbxChat.Text = "FTT-CHAT";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(8, 23);
            this.txtChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(784, 271);
            this.txtChat.TabIndex = 0;
            // 
            // gbxMensagem
            // 
            this.gbxMensagem.Controls.Add(this.txtMensagem);
            this.gbxMensagem.Location = new System.Drawing.Point(24, 436);
            this.gbxMensagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxMensagem.Name = "gbxMensagem";
            this.gbxMensagem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxMensagem.Size = new System.Drawing.Size(792, 79);
            this.gbxMensagem.TabIndex = 1;
            this.gbxMensagem.TabStop = false;
            this.gbxMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(8, 23);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(776, 47);
            this.txtMensagem.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(708, 400);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 28);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(16, 318);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 28);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Chat";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtIPDestino
            // 
            this.txtIPDestino.Location = new System.Drawing.Point(567, 404);
            this.txtIPDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIPDestino.Name = "txtIPDestino";
            this.txtIPDestino.Size = new System.Drawing.Size(120, 22);
            this.txtIPDestino.TabIndex = 4;
            this.txtIPDestino.Text = "127.0.0.1";
            // 
            // lblIPDestino
            // 
            this.lblIPDestino.AutoSize = true;
            this.lblIPDestino.Location = new System.Drawing.Point(484, 407);
            this.lblIPDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPDestino.Name = "lblIPDestino";
            this.lblIPDestino.Size = new System.Drawing.Size(72, 17);
            this.lblIPDestino.TabIndex = 5;
            this.lblIPDestino.Text = "IP Destino";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.Red;
            this.lblIP.Location = new System.Drawing.Point(25, 362);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(119, 32);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "SEU IP:";
            // 
            // cmbIPAddress
            // 
            this.cmbIPAddress.FormattingEnabled = true;
            this.cmbIPAddress.Location = new System.Drawing.Point(169, 325);
            this.cmbIPAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbIPAddress.Name = "cmbIPAddress";
            this.cmbIPAddress.Size = new System.Drawing.Size(592, 24);
            this.cmbIPAddress.TabIndex = 7;
            this.cmbIPAddress.SelectedIndexChanged += new System.EventHandler(this.cmbIPAddress_SelectedIndexChanged);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 529);
            this.Controls.Add(this.cmbIPAddress);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblIPDestino);
            this.Controls.Add(this.txtIPDestino);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.gbxMensagem);
            this.Controls.Add(this.gbxChat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChat";
            this.Text = "FTT - EC";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChat_FormClosing);
            this.gbxChat.ResumeLayout(false);
            this.gbxChat.PerformLayout();
            this.gbxMensagem.ResumeLayout(false);
            this.gbxMensagem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxChat;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.GroupBox gbxMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtIPDestino;
        private System.Windows.Forms.Label lblIPDestino;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.ComboBox cmbIPAddress;
    }
}

