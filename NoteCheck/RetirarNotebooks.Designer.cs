namespace NoteCheck
{
    partial class RetirarNotebooks
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
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlProgram = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPronto = new System.Windows.Forms.Button();
            this.lblAte = new System.Windows.Forms.Label();
            this.mtbTempoFinal = new System.Windows.Forms.MaskedTextBox();
            this.mtbTempoInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblTempoUso = new System.Windows.Forms.Label();
            this.lblNumeroNote = new System.Windows.Forms.Label();
            this.txtNumeroNote = new System.Windows.Forms.TextBox();
            this.lblCampoNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlBack.SuspendLayout();
            this.pnlProgram.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBack.Controls.Add(this.pnlProgram);
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1080, 535);
            this.pnlBack.TabIndex = 2;
            // 
            // pnlProgram
            // 
            this.pnlProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlProgram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.pnlProgram.Controls.Add(this.btnVoltar);
            this.pnlProgram.Controls.Add(this.btnPronto);
            this.pnlProgram.Controls.Add(this.lblAte);
            this.pnlProgram.Controls.Add(this.mtbTempoFinal);
            this.pnlProgram.Controls.Add(this.mtbTempoInicial);
            this.pnlProgram.Controls.Add(this.lblTempoUso);
            this.pnlProgram.Controls.Add(this.lblNumeroNote);
            this.pnlProgram.Controls.Add(this.txtNumeroNote);
            this.pnlProgram.Controls.Add(this.lblCampoNomeAluno);
            this.pnlProgram.Controls.Add(this.txtNomeAluno);
            this.pnlProgram.Controls.Add(this.lblBoasVindas);
            this.pnlProgram.Controls.Add(this.pnlControles);
            this.pnlProgram.Location = new System.Drawing.Point(56, 12);
            this.pnlProgram.Name = "pnlProgram";
            this.pnlProgram.Size = new System.Drawing.Size(969, 510);
            this.pnlProgram.TabIndex = 2;
            this.pnlProgram.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProgram_Paint);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::NoteCheck.Properties.Resources.seta;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(27, 59);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 27);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "‬Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPronto
            // 
            this.btnPronto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.btnPronto.FlatAppearance.BorderSize = 0;
            this.btnPronto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPronto.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnPronto.Location = new System.Drawing.Point(409, 373);
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Size = new System.Drawing.Size(150, 37);
            this.btnPronto.TabIndex = 18;
            this.btnPronto.Text = "Pronto";
            this.btnPronto.UseVisualStyleBackColor = false;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(510, 299);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(33, 17);
            this.lblAte.TabIndex = 17;
            this.lblAte.Text = "Até";
            // 
            // mtbTempoFinal
            // 
            this.mtbTempoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTempoFinal.Location = new System.Drawing.Point(567, 294);
            this.mtbTempoFinal.Mask = "00:00";
            this.mtbTempoFinal.Name = "mtbTempoFinal";
            this.mtbTempoFinal.Size = new System.Drawing.Size(60, 26);
            this.mtbTempoFinal.TabIndex = 16;
            this.mtbTempoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTempoFinal.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTempoInicial
            // 
            this.mtbTempoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTempoInicial.Location = new System.Drawing.Point(427, 294);
            this.mtbTempoInicial.Mask = "00:00";
            this.mtbTempoInicial.Name = "mtbTempoInicial";
            this.mtbTempoInicial.Size = new System.Drawing.Size(60, 26);
            this.mtbTempoInicial.TabIndex = 15;
            this.mtbTempoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTempoInicial.ValidatingType = typeof(System.DateTime);
            // 
            // lblTempoUso
            // 
            this.lblTempoUso.AutoSize = true;
            this.lblTempoUso.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoUso.Location = new System.Drawing.Point(203, 299);
            this.lblTempoUso.Name = "lblTempoUso";
            this.lblTempoUso.Size = new System.Drawing.Size(220, 17);
            this.lblTempoUso.TabIndex = 14;
            this.lblTempoUso.Text = "Quanto tempo vai ser usado:";
            // 
            // lblNumeroNote
            // 
            this.lblNumeroNote.AutoSize = true;
            this.lblNumeroNote.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroNote.Location = new System.Drawing.Point(203, 244);
            this.lblNumeroNote.Name = "lblNumeroNote";
            this.lblNumeroNote.Size = new System.Drawing.Size(167, 17);
            this.lblNumeroNote.TabIndex = 12;
            this.lblNumeroNote.Text = "Numero do notebook:";
            // 
            // txtNumeroNote
            // 
            this.txtNumeroNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNumeroNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroNote.Location = new System.Drawing.Point(427, 244);
            this.txtNumeroNote.Multiline = true;
            this.txtNumeroNote.Name = "txtNumeroNote";
            this.txtNumeroNote.Size = new System.Drawing.Size(339, 20);
            this.txtNumeroNote.TabIndex = 11;
            this.txtNumeroNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCampoNomeAluno
            // 
            this.lblCampoNomeAluno.AutoSize = true;
            this.lblCampoNomeAluno.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoNomeAluno.Location = new System.Drawing.Point(203, 186);
            this.lblCampoNomeAluno.Name = "lblCampoNomeAluno";
            this.lblCampoNomeAluno.Size = new System.Drawing.Size(178, 17);
            this.lblCampoNomeAluno.TabIndex = 10;
            this.lblCampoNomeAluno.Text = "Insira o nome do aluno:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(427, 186);
            this.txtNomeAluno.Multiline = true;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(339, 20);
            this.txtNomeAluno.TabIndex = 9;
            this.txtNomeAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.Black;
            this.lblBoasVindas.Location = new System.Drawing.Point(369, 99);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(198, 32);
            this.lblBoasVindas.TabIndex = 8;
            this.lblBoasVindas.Text = "Retirar notebooks";
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlControles.Controls.Add(this.label2);
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.imgLogo);
            this.pnlControles.Controls.Add(this.lblLogo);
            this.pnlControles.Controls.Add(this.btnMinimizar);
            this.pnlControles.Controls.Add(this.btnFechar);
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(969, 40);
            this.pnlControles.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(555, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "curso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome do prof";
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
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.lblLogo.Location = new System.Drawing.Point(53, 4);
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
            this.btnMinimizar.Size = new System.Drawing.Size(45, 27);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "➖";
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnFechar.Size = new System.Drawing.Size(45, 27);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "❌";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // RetirarNotebooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 535);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetirarNotebooks";
            this.Text = "RetirarNotebooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RetirarNotebooks_Load);
            this.pnlBack.ResumeLayout(false);
            this.pnlProgram.ResumeLayout(false);
            this.pnlProgram.PerformLayout();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlProgram;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCampoNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNumeroNote;
        private System.Windows.Forms.TextBox txtNumeroNote;
        private System.Windows.Forms.Label lblTempoUso;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.MaskedTextBox mtbTempoFinal;
        private System.Windows.Forms.MaskedTextBox mtbTempoInicial;
        private System.Windows.Forms.Button btnPronto;
        private System.Windows.Forms.Button btnVoltar;
    }
}