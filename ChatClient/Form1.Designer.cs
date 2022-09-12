namespace ChatClient
{
    partial class Form1
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEnviarMensagem = new ChatClient.Controls.ButtonControl();
            this.txtEnviarMensagem = new ChatClient.Controls.TextBoxControl();
            this.btnConectar = new ChatClient.Controls.ButtonControl();
            this.txtNomeUsuario = new ChatClient.Controls.TextBoxControl();
            this.txtIp = new ChatClient.Controls.TextBoxControl();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelBackground.Controls.Add(this.lblStatus);
            this.panelBackground.Controls.Add(this.btnEnviarMensagem);
            this.panelBackground.Controls.Add(this.txtEnviarMensagem);
            this.panelBackground.Controls.Add(this.txtChat);
            this.panelBackground.Controls.Add(this.btnConectar);
            this.panelBackground.Controls.Add(this.lblPorta);
            this.panelBackground.Controls.Add(this.lblIP);
            this.panelBackground.Controls.Add(this.lblUsuario);
            this.panelBackground.Controls.Add(this.txtNomeUsuario);
            this.panelBackground.Controls.Add(this.txtPorta);
            this.panelBackground.Controls.Add(this.txtIp);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(368, 672);
            this.panelBackground.TabIndex = 7;
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.ForeColor = System.Drawing.Color.White;
            this.txtChat.Location = new System.Drawing.Point(12, 218);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.Size = new System.Drawing.Size(341, 329);
            this.txtChat.TabIndex = 7;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorta.ForeColor = System.Drawing.Color.White;
            this.lblPorta.Location = new System.Drawing.Point(229, 25);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(52, 20);
            this.lblPorta.TabIndex = 5;
            this.lblPorta.Text = "Porta";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.White;
            this.lblIP.Location = new System.Drawing.Point(3, 25);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(26, 20);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "IP";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, 88);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(144, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Nome de usuário";
            // 
            // txtPorta
            // 
            this.txtPorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.txtPorta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.ForeColor = System.Drawing.Color.White;
            this.txtPorta.Location = new System.Drawing.Point(233, 55);
            this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(120, 25);
            this.txtPorta.TabIndex = 1;
            this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(12, 589);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(341, 74);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Não conectado";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEnviarMensagem.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEnviarMensagem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnviarMensagem.BorderRadius = 40;
            this.btnEnviarMensagem.BorderSize = 0;
            this.btnEnviarMensagem.Enabled = false;
            this.btnEnviarMensagem.FlatAppearance.BorderSize = 0;
            this.btnEnviarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMensagem.ForeColor = System.Drawing.Color.White;
            this.btnEnviarMensagem.Location = new System.Drawing.Point(288, 553);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(64, 31);
            this.btnEnviarMensagem.TabIndex = 9;
            this.btnEnviarMensagem.Text = "Enviar";
            this.btnEnviarMensagem.TextColor = System.Drawing.Color.White;
            this.btnEnviarMensagem.UseVisualStyleBackColor = false;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // txtEnviarMensagem
            // 
            this.txtEnviarMensagem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEnviarMensagem.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtEnviarMensagem.BorderSize = 2;
            this.txtEnviarMensagem.Enabled = false;
            this.txtEnviarMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtEnviarMensagem.ForeColor = System.Drawing.Color.White;
            this.txtEnviarMensagem.Location = new System.Drawing.Point(14, 554);
            this.txtEnviarMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnviarMensagem.Name = "txtEnviarMensagem";
            this.txtEnviarMensagem.Padding = new System.Windows.Forms.Padding(7);
            this.txtEnviarMensagem.Size = new System.Drawing.Size(267, 31);
            this.txtEnviarMensagem.TabIndex = 8;
            this.txtEnviarMensagem.Texts = "";
            this.txtEnviarMensagem.UnderLinedStyle = false;
            this.txtEnviarMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnviarMensagem_KeyPress);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConectar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConectar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConectar.BorderRadius = 40;
            this.btnConectar.BorderSize = 0;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(14, 163);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(339, 40);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextColor = System.Drawing.Color.White;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.txtNomeUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNomeUsuario.BorderSize = 2;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.txtNomeUsuario.Location = new System.Drawing.Point(7, 112);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtNomeUsuario.Size = new System.Drawing.Size(340, 39);
            this.txtNomeUsuario.TabIndex = 2;
            this.txtNomeUsuario.Texts = "";
            this.txtNomeUsuario.UnderLinedStyle = true;
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.txtIp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIp.BorderSize = 2;
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.ForeColor = System.Drawing.Color.White;
            this.txtIp.Location = new System.Drawing.Point(4, 45);
            this.txtIp.Margin = new System.Windows.Forms.Padding(4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Padding = new System.Windows.Forms.Padding(7);
            this.txtIp.Size = new System.Drawing.Size(213, 39);
            this.txtIp.TabIndex = 0;
            this.txtIp.Texts = "127.0.0.1";
            this.txtIp.UnderLinedStyle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 672);
            this.Controls.Add(this.panelBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private Controls.TextBoxControl txtIp;
        private System.Windows.Forms.TextBox txtChat;
        private Controls.ButtonControl btnConectar;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblUsuario;
        private Controls.TextBoxControl txtNomeUsuario;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private Controls.ButtonControl btnEnviarMensagem;
        private Controls.TextBoxControl txtEnviarMensagem;
        private System.Windows.Forms.Label lblStatus;
    }
}

