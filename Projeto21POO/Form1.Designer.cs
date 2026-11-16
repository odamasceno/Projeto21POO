namespace Projeto21POO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.escolhaBarText = new System.Windows.Forms.Label();
            this.BarComumButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelJogador = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBanca = new System.Windows.Forms.FlowLayoutPanel();
            this.panelJogo = new System.Windows.Forms.Panel();
            this.ButtonReiniciar = new System.Windows.Forms.Button();
            this.ButtonParar = new System.Windows.Forms.Button();
            this.ButtonComprar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblPontosJogador = new System.Windows.Forms.Label();
            this.lblPontosBanca = new System.Windows.Forms.Label();
            this.panelJogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // escolhaBarText
            // 
            this.escolhaBarText.AutoSize = true;
            this.escolhaBarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolhaBarText.Location = new System.Drawing.Point(192, 46);
            this.escolhaBarText.Name = "escolhaBarText";
            this.escolhaBarText.Size = new System.Drawing.Size(463, 39);
            this.escolhaBarText.TabIndex = 0;
            this.escolhaBarText.Text = "ESCOLHA SEU BARALHO!";
            this.escolhaBarText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BarComumButton
            // 
            this.BarComumButton.Location = new System.Drawing.Point(365, 267);
            this.BarComumButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarComumButton.Name = "BarComumButton";
            this.BarComumButton.Size = new System.Drawing.Size(143, 31);
            this.BarComumButton.TabIndex = 1;
            this.BarComumButton.Text = "Baralho Comum";
            this.BarComumButton.UseVisualStyleBackColor = true;
            this.BarComumButton.Click += new System.EventHandler(this.ButtonNormal_Click);
            // 
            // flowLayoutPanelJogador
            // 
            this.flowLayoutPanelJogador.AutoScroll = true;
            this.flowLayoutPanelJogador.BackColor = System.Drawing.Color.SeaGreen;
            this.flowLayoutPanelJogador.Location = new System.Drawing.Point(19, 18);
            this.flowLayoutPanelJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelJogador.Name = "flowLayoutPanelJogador";
            this.flowLayoutPanelJogador.Size = new System.Drawing.Size(665, 189);
            this.flowLayoutPanelJogador.TabIndex = 3;
            this.flowLayoutPanelJogador.WrapContents = false;
            // 
            // flowLayoutPanelBanca
            // 
            this.flowLayoutPanelBanca.AutoScroll = true;
            this.flowLayoutPanelBanca.BackColor = System.Drawing.Color.SeaGreen;
            this.flowLayoutPanelBanca.Location = new System.Drawing.Point(19, 275);
            this.flowLayoutPanelBanca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelBanca.Name = "flowLayoutPanelBanca";
            this.flowLayoutPanelBanca.Size = new System.Drawing.Size(665, 195);
            this.flowLayoutPanelBanca.TabIndex = 4;
            this.flowLayoutPanelBanca.WrapContents = false;
            // 
            // panelJogo
            // 
            this.panelJogo.Controls.Add(this.lblPontosBanca);
            this.panelJogo.Controls.Add(this.lblPontosJogador);
            this.panelJogo.Controls.Add(this.ButtonReiniciar);
            this.panelJogo.Controls.Add(this.ButtonParar);
            this.panelJogo.Controls.Add(this.ButtonComprar);
            this.panelJogo.Controls.Add(this.flowLayoutPanelJogador);
            this.panelJogo.Controls.Add(this.flowLayoutPanelBanca);
            this.panelJogo.Location = new System.Drawing.Point(0, 0);
            this.panelJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelJogo.Name = "panelJogo";
            this.panelJogo.Size = new System.Drawing.Size(913, 642);
            this.panelJogo.TabIndex = 5;
            this.panelJogo.Visible = false;
            // 
            // ButtonReiniciar
            // 
            this.ButtonReiniciar.Location = new System.Drawing.Point(713, 398);
            this.ButtonReiniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReiniciar.Name = "ButtonReiniciar";
            this.ButtonReiniciar.Size = new System.Drawing.Size(145, 66);
            this.ButtonReiniciar.TabIndex = 7;
            this.ButtonReiniciar.Text = "Reiniciar";
            this.ButtonReiniciar.UseVisualStyleBackColor = true;
            this.ButtonReiniciar.Click += new System.EventHandler(this.ButtonReiniciar_Click);
            // 
            // ButtonParar
            // 
            this.ButtonParar.Location = new System.Drawing.Point(713, 230);
            this.ButtonParar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonParar.Name = "ButtonParar";
            this.ButtonParar.Size = new System.Drawing.Size(145, 66);
            this.ButtonParar.TabIndex = 6;
            this.ButtonParar.Text = "Parar";
            this.ButtonParar.UseVisualStyleBackColor = true;
            this.ButtonParar.Click += new System.EventHandler(this.ButtonParar_Click);
            // 
            // ButtonComprar
            // 
            this.ButtonComprar.Location = new System.Drawing.Point(713, 71);
            this.ButtonComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonComprar.Name = "ButtonComprar";
            this.ButtonComprar.Size = new System.Drawing.Size(145, 66);
            this.ButtonComprar.TabIndex = 5;
            this.ButtonComprar.Text = "Comprar";
            this.ButtonComprar.UseVisualStyleBackColor = true;
            this.ButtonComprar.Click += new System.EventHandler(this.ButtonComprar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.escolhaBarText);
            this.panelMenu.Controls.Add(this.BarComumButton);
            this.panelMenu.Location = new System.Drawing.Point(-4, -1);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(885, 530);
            this.panelMenu.TabIndex = 6;
            // 
            // lblPontosJogador
            // 
            this.lblPontosJogador.AutoSize = true;
            this.lblPontosJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosJogador.Location = new System.Drawing.Point(13, 209);
            this.lblPontosJogador.Name = "lblPontosJogador";
            this.lblPontosJogador.Size = new System.Drawing.Size(92, 32);
            this.lblPontosJogador.TabIndex = 8;
            this.lblPontosJogador.Text = "label1";
            // 
            // lblPontosBanca
            // 
            this.lblPontosBanca.AutoSize = true;
            this.lblPontosBanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosBanca.Location = new System.Drawing.Point(13, 472);
            this.lblPontosBanca.Name = "lblPontosBanca";
            this.lblPontosBanca.Size = new System.Drawing.Size(92, 32);
            this.lblPontosBanca.TabIndex = 9;
            this.lblPontosBanca.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(873, 528);
            this.Controls.Add(this.panelJogo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelJogo.ResumeLayout(false);
            this.panelJogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label escolhaBarText;
        private System.Windows.Forms.Button BarComumButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelJogador;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBanca;
        private System.Windows.Forms.Panel panelJogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button ButtonComprar;
        private System.Windows.Forms.Button ButtonReiniciar;
        private System.Windows.Forms.Button ButtonParar;
        private System.Windows.Forms.Label lblPontosJogador;
        private System.Windows.Forms.Label lblPontosBanca;
    }
}

