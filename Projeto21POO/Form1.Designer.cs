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
            this.lblPontosBanca = new System.Windows.Forms.Label();
            this.lblPontosJogador = new System.Windows.Forms.Label();
            this.ButtonComprar = new System.Windows.Forms.Button();
            this.ButtonParar = new System.Windows.Forms.Button();
            this.ButtonReiniciar = new System.Windows.Forms.Button();
            this.panelAposta = new System.Windows.Forms.Panel();
            this.ButtonApostar = new System.Windows.Forms.Button();
            this.numValorAposta = new System.Windows.Forms.NumericUpDown();
            this.lblApostaAtual = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelIdade = new System.Windows.Forms.Label();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarArtisticoButton = new System.Windows.Forms.Button();
            this.panelJogo.SuspendLayout();
            this.panelAposta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorAposta)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // escolhaBarText
            // 
            this.escolhaBarText.AutoSize = true;
            this.escolhaBarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolhaBarText.Location = new System.Drawing.Point(194, 60);
            this.escolhaBarText.Name = "escolhaBarText";
            this.escolhaBarText.Size = new System.Drawing.Size(463, 78);
            this.escolhaBarText.TabIndex = 0;
            this.escolhaBarText.Text = "21!\r\nESCOLHA SEU BARALHO!";
            this.escolhaBarText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BarComumButton
            // 
            this.BarComumButton.Location = new System.Drawing.Point(464, 374);
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
            this.flowLayoutPanelJogador.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanelJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelJogador.Name = "flowLayoutPanelJogador";
            this.flowLayoutPanelJogador.Size = new System.Drawing.Size(665, 199);
            this.flowLayoutPanelJogador.TabIndex = 3;
            this.flowLayoutPanelJogador.WrapContents = false;
            // 
            // flowLayoutPanelBanca
            // 
            this.flowLayoutPanelBanca.AutoScroll = true;
            this.flowLayoutPanelBanca.BackColor = System.Drawing.Color.SeaGreen;
            this.flowLayoutPanelBanca.Location = new System.Drawing.Point(3, 275);
            this.flowLayoutPanelBanca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelBanca.Name = "flowLayoutPanelBanca";
            this.flowLayoutPanelBanca.Size = new System.Drawing.Size(665, 211);
            this.flowLayoutPanelBanca.TabIndex = 4;
            this.flowLayoutPanelBanca.WrapContents = false;
            // 
            // panelJogo
            // 
            this.panelJogo.Controls.Add(this.flowLayoutPanelBanca);
            this.panelJogo.Controls.Add(this.flowLayoutPanelJogador);
            this.panelJogo.Controls.Add(this.lblPontosBanca);
            this.panelJogo.Controls.Add(this.lblPontosJogador);
            this.panelJogo.Controls.Add(this.ButtonComprar);
            this.panelJogo.Controls.Add(this.ButtonParar);
            this.panelJogo.Controls.Add(this.ButtonReiniciar);
            this.panelJogo.Controls.Add(this.panelAposta);
            this.panelJogo.Location = new System.Drawing.Point(0, 0);
            this.panelJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelJogo.Name = "panelJogo";
            this.panelJogo.Size = new System.Drawing.Size(913, 642);
            this.panelJogo.TabIndex = 5;
            this.panelJogo.Visible = false;
            // 
            // lblPontosBanca
            // 
            this.lblPontosBanca.AutoSize = true;
            this.lblPontosBanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosBanca.Location = new System.Drawing.Point(13, 488);
            this.lblPontosBanca.Name = "lblPontosBanca";
            this.lblPontosBanca.Size = new System.Drawing.Size(92, 32);
            this.lblPontosBanca.TabIndex = 9;
            this.lblPontosBanca.Text = "label1";
            // 
            // lblPontosJogador
            // 
            this.lblPontosJogador.AutoSize = true;
            this.lblPontosJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosJogador.Location = new System.Drawing.Point(13, 219);
            this.lblPontosJogador.Name = "lblPontosJogador";
            this.lblPontosJogador.Size = new System.Drawing.Size(92, 32);
            this.lblPontosJogador.TabIndex = 8;
            this.lblPontosJogador.Text = "label1";
            // 
            // ButtonComprar
            // 
            this.ButtonComprar.Location = new System.Drawing.Point(716, 88);
            this.ButtonComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonComprar.Name = "ButtonComprar";
            this.ButtonComprar.Size = new System.Drawing.Size(145, 66);
            this.ButtonComprar.TabIndex = 5;
            this.ButtonComprar.Text = "Comprar";
            this.ButtonComprar.UseVisualStyleBackColor = true;
            this.ButtonComprar.Click += new System.EventHandler(this.ButtonComprar_Click);
            // 
            // ButtonParar
            // 
            this.ButtonParar.Location = new System.Drawing.Point(716, 170);
            this.ButtonParar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonParar.Name = "ButtonParar";
            this.ButtonParar.Size = new System.Drawing.Size(145, 66);
            this.ButtonParar.TabIndex = 6;
            this.ButtonParar.Text = "Parar";
            this.ButtonParar.UseVisualStyleBackColor = true;
            this.ButtonParar.Click += new System.EventHandler(this.ButtonParar_Click);
            // 
            // ButtonReiniciar
            // 
            this.ButtonReiniciar.Location = new System.Drawing.Point(716, 252);
            this.ButtonReiniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReiniciar.Name = "ButtonReiniciar";
            this.ButtonReiniciar.Size = new System.Drawing.Size(145, 66);
            this.ButtonReiniciar.TabIndex = 7;
            this.ButtonReiniciar.Text = "Reiniciar";
            this.ButtonReiniciar.UseVisualStyleBackColor = true;
            this.ButtonReiniciar.Click += new System.EventHandler(this.ButtonReiniciar_Click);
            // 
            // panelAposta
            // 
            this.panelAposta.Controls.Add(this.ButtonApostar);
            this.panelAposta.Controls.Add(this.numValorAposta);
            this.panelAposta.Controls.Add(this.lblApostaAtual);
            this.panelAposta.Controls.Add(this.lblSaldo);
            this.panelAposta.Location = new System.Drawing.Point(0, 0);
            this.panelAposta.Name = "panelAposta";
            this.panelAposta.Size = new System.Drawing.Size(930, 590);
            this.panelAposta.TabIndex = 0;
            // 
            // ButtonApostar
            // 
            this.ButtonApostar.Location = new System.Drawing.Point(738, 488);
            this.ButtonApostar.Name = "ButtonApostar";
            this.ButtonApostar.Size = new System.Drawing.Size(120, 28);
            this.ButtonApostar.TabIndex = 3;
            this.ButtonApostar.Text = "APOSTAR!";
            this.ButtonApostar.UseVisualStyleBackColor = true;
            this.ButtonApostar.Click += new System.EventHandler(this.ButtonApostar_Click);
            // 
            // numValorAposta
            // 
            this.numValorAposta.Location = new System.Drawing.Point(738, 460);
            this.numValorAposta.Name = "numValorAposta";
            this.numValorAposta.Size = new System.Drawing.Size(120, 22);
            this.numValorAposta.TabIndex = 2;
            // 
            // lblApostaAtual
            // 
            this.lblApostaAtual.AutoSize = true;
            this.lblApostaAtual.Location = new System.Drawing.Point(735, 432);
            this.lblApostaAtual.Name = "lblApostaAtual";
            this.lblApostaAtual.Size = new System.Drawing.Size(44, 16);
            this.lblApostaAtual.TabIndex = 1;
            this.lblApostaAtual.Text = "label1";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(735, 398);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 16);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "label1";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelIdade);
            this.panelMenu.Controls.Add(this.numIdade);
            this.panelMenu.Controls.Add(this.escolhaBarText);
            this.panelMenu.Controls.Add(this.BarComumButton);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.BarArtisticoButton);
            this.panelMenu.Location = new System.Drawing.Point(-4, -1);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(885, 530);
            this.panelMenu.TabIndex = 6;
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdade.Location = new System.Drawing.Point(242, 409);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(117, 26);
            this.labelIdade.TabIndex = 9;
            this.labelIdade.Text = "Sua Idade:";
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(247, 438);
            this.numIdade.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.numIdade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(143, 22);
            this.numIdade.TabIndex = 8;
            this.numIdade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto21POO.Properties.Resources.Gemini_Generated_Image_dr2lemdr2lemdr2l;
            this.pictureBox1.Location = new System.Drawing.Point(247, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BarArtisticoButton
            // 
            this.BarArtisticoButton.Location = new System.Drawing.Point(247, 375);
            this.BarArtisticoButton.Name = "BarArtisticoButton";
            this.BarArtisticoButton.Size = new System.Drawing.Size(143, 31);
            this.BarArtisticoButton.TabIndex = 7;
            this.BarArtisticoButton.Text = "Baralho Artistico";
            this.BarArtisticoButton.UseVisualStyleBackColor = true;
            this.BarArtisticoButton.Click += new System.EventHandler(this.BarArtisticoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(873, 528);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelJogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelJogo.ResumeLayout(false);
            this.panelJogo.PerformLayout();
            this.panelAposta.ResumeLayout(false);
            this.panelAposta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorAposta)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAposta;
        private System.Windows.Forms.Button BarArtisticoButton;
        private System.Windows.Forms.Button ButtonApostar;
        private System.Windows.Forms.NumericUpDown numValorAposta;
        private System.Windows.Forms.Label lblApostaAtual;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.NumericUpDown numIdade;
    }
}

