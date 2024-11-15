namespace NoteCheck
{
    partial class DevolverNotebook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverNotebook));
            this.tmrTelas = new System.Windows.Forms.Timer(this.components);
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlProgram = new System.Windows.Forms.Panel();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lblNumeroNote = new System.Windows.Forms.Label();
            this.txtNumeroNote = new System.Windows.Forms.TextBox();
            this.lblCampoNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblRetirar = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlBack.SuspendLayout();
            this.pnlProgram.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTelas
            // 
            this.tmrTelas.Enabled = true;
            this.tmrTelas.Interval = 1;
            this.tmrTelas.Tick += new System.EventHandler(this.tmrTelas_Tick);
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
            this.pnlBack.TabIndex = 3;
            // 
            // pnlProgram
            // 
            this.pnlProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlProgram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.pnlProgram.Controls.Add(this.pnlTimer);
            this.pnlProgram.Controls.Add(this.btnVoltar);
            this.pnlProgram.Controls.Add(this.btnDevolver);
            this.pnlProgram.Controls.Add(this.lblNumeroNote);
            this.pnlProgram.Controls.Add(this.txtNumeroNote);
            this.pnlProgram.Controls.Add(this.lblCampoNomeAluno);
            this.pnlProgram.Controls.Add(this.txtNomeAluno);
            this.pnlProgram.Controls.Add(this.lblRetirar);
            this.pnlProgram.Controls.Add(this.pnlControles);
            this.pnlProgram.Location = new System.Drawing.Point(56, 12);
            this.pnlProgram.Name = "pnlProgram";
            this.pnlProgram.Size = new System.Drawing.Size(969, 510);
            this.pnlProgram.TabIndex = 2;
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Location = new System.Drawing.Point(870, 477);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(110, 43);
            this.pnlTimer.TabIndex = 21;
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
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::NoteCheck.Properties.Resources.seta;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(11, 59);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 27);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "‬Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnDevolver.Location = new System.Drawing.Point(409, 369);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(150, 37);
            this.btnDevolver.TabIndex = 18;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lblNumeroNote
            // 
            this.lblNumeroNote.AutoSize = true;
            this.lblNumeroNote.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroNote.Location = new System.Drawing.Point(203, 292);
            this.lblNumeroNote.Name = "lblNumeroNote";
            this.lblNumeroNote.Size = new System.Drawing.Size(167, 17);
            this.lblNumeroNote.TabIndex = 12;
            this.lblNumeroNote.Text = "Número do notebook:";
            // 
            // txtNumeroNote
            // 
            this.txtNumeroNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNumeroNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroNote.Location = new System.Drawing.Point(427, 293);
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
            this.lblCampoNomeAluno.Location = new System.Drawing.Point(203, 216);
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
            this.txtNomeAluno.Location = new System.Drawing.Point(427, 216);
            this.txtNomeAluno.Multiline = true;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(339, 20);
            this.txtNomeAluno.TabIndex = 9;
            this.txtNomeAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRetirar
            // 
            this.lblRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRetirar.AutoSize = true;
            this.lblRetirar.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirar.ForeColor = System.Drawing.Color.Black;
            this.lblRetirar.Location = new System.Drawing.Point(377, 144);
            this.lblRetirar.Name = "lblRetirar";
            this.lblRetirar.Size = new System.Drawing.Size(214, 32);
            this.lblRetirar.TabIndex = 8;
            this.lblRetirar.Text = "Devolver notebooks";
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlControles.Controls.Add(this.imgLogo);
            this.pnlControles.Controls.Add(this.btnMinimizar);
            this.pnlControles.Controls.Add(this.btnFechar);
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(969, 40);
            this.pnlControles.TabIndex = 2;
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
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = global::NoteCheck.Properties.Resources.LogoTipoNoteCheckFinal;
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Location = new System.Drawing.Point(27, 6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(166, 30);
            this.imgLogo.TabIndex = 4;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // DevolverNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1080, 535);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevolverNotebook";
            this.Text = "DevolverNotebook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DevolverNotebook_Load);
            this.pnlBack.ResumeLayout(false);
            this.pnlProgram.ResumeLayout(false);
            this.pnlProgram.PerformLayout();
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTelas;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Panel pnlProgram;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label lblNumeroNote;
        private System.Windows.Forms.TextBox txtNumeroNote;
        private System.Windows.Forms.Label lblCampoNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblRetirar;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}