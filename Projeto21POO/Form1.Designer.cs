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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonComprar = new System.Windows.Forms.Button();
            this.panelJogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // escolhaBarText
            // 
            this.escolhaBarText.AutoSize = true;
            this.escolhaBarText.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolhaBarText.Location = new System.Drawing.Point(192, 46);
            this.escolhaBarText.Name = "escolhaBarText";
            this.escolhaBarText.Size = new System.Drawing.Size(483, 55);
            this.escolhaBarText.TabIndex = 0;
            this.escolhaBarText.Text = "ESCOLHA SEU BARALHO!";
            this.escolhaBarText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BarComumButton
            // 
            this.BarComumButton.Location = new System.Drawing.Point(366, 267);
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
            this.flowLayoutPanelJogador.Location = new System.Drawing.Point(18, 19);
            this.flowLayoutPanelJogador.Name = "flowLayoutPanelJogador";
            this.flowLayoutPanelJogador.Size = new System.Drawing.Size(431, 229);
            this.flowLayoutPanelJogador.TabIndex = 3;
            this.flowLayoutPanelJogador.WrapContents = false;
            // 
            // flowLayoutPanelBanca
            // 
            this.flowLayoutPanelBanca.AutoScroll = true;
            this.flowLayoutPanelBanca.BackColor = System.Drawing.Color.SeaGreen;
            this.flowLayoutPanelBanca.Location = new System.Drawing.Point(18, 254);
            this.flowLayoutPanelBanca.Name = "flowLayoutPanelBanca";
            this.flowLayoutPanelBanca.Size = new System.Drawing.Size(431, 250);
            this.flowLayoutPanelBanca.TabIndex = 4;
            this.flowLayoutPanelBanca.WrapContents = false;
            // 
            // panelJogo
            // 
            this.panelJogo.Controls.Add(this.ButtonComprar);
            this.panelJogo.Controls.Add(this.flowLayoutPanelJogador);
            this.panelJogo.Controls.Add(this.flowLayoutPanelBanca);
            this.panelJogo.Location = new System.Drawing.Point(0, 0);
            this.panelJogo.Name = "panelJogo";
            this.panelJogo.Size = new System.Drawing.Size(913, 642);
            this.panelJogo.TabIndex = 5;
            this.panelJogo.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.escolhaBarText);
            this.panelMenu.Controls.Add(this.BarComumButton);
            this.panelMenu.Location = new System.Drawing.Point(-4, -1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(885, 531);
            this.panelMenu.TabIndex = 6;
            // 
            // ButtonComprar
            // 
            this.ButtonComprar.Location = new System.Drawing.Point(471, 69);
            this.ButtonComprar.Name = "ButtonComprar";
            this.ButtonComprar.Size = new System.Drawing.Size(145, 66);
            this.ButtonComprar.TabIndex = 5;
            this.ButtonComprar.Text = "Comprar";
            this.ButtonComprar.UseVisualStyleBackColor = true;
            this.ButtonComprar.Click += new System.EventHandler(this.ButtonComprar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(873, 528);
            this.Controls.Add(this.panelJogo);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelJogo.ResumeLayout(false);
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
    }
}

