namespace NoteCheck
{
    partial class HistoricoRetirada
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
            this.pnlControles = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.dtpDataDesejada = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.pnlTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlControles.Controls.Add(this.imgLogo);
            this.pnlControles.Controls.Add(this.lblLogo);
            this.pnlControles.Controls.Add(this.btnMinimizar);
            this.pnlControles.Controls.Add(this.btnFechar);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(953, 40);
            this.pnlControles.TabIndex = 5;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.lblLogo.Location = new System.Drawing.Point(45, 4);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(117, 32);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "NoteCheck";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizar.Location = new System.Drawing.Point(870, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 27);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "➖";
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(921, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 27);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "❌";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = global::NoteCheck.Properties.Resources.logoBeta;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Location = new System.Drawing.Point(11, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(36, 33);
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.Black;
            this.lblBoasVindas.Location = new System.Drawing.Point(363, 67);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(227, 32);
            this.lblBoasVindas.TabIndex = 25;
            this.lblBoasVindas.Text = "Histórico de Retirada";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(12, 139);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(928, 286);
            this.dgvHistorico.TabIndex = 26;
            // 
            // dtpDataDesejada
            // 
            this.dtpDataDesejada.Font = new System.Drawing.Font("Louis George Cafe", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDesejada.Location = new System.Drawing.Point(12, 111);
            this.dtpDataDesejada.Name = "dtpDataDesejada";
            this.dtpDataDesejada.Size = new System.Drawing.Size(276, 22);
            this.dtpDataDesejada.TabIndex = 27;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::NoteCheck.Properties.Resources.seta;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(11, 51);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 27);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "‬Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Location = new System.Drawing.Point(854, 437);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(99, 35);
            this.pnlTimer.TabIndex = 29;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTimer.Location = new System.Drawing.Point(19, 5);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(60, 24);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00";
            // 
            // HistoricoRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 471);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtpDataDesejada);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.pnlControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoricoRetirada";
            this.Text = "HistoricoRetirada";
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.DateTimePicker dtpDataDesejada;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Label lblTimer;
    }
}