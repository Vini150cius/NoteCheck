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
            this.pnlControles = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblCampoNomeAluno = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblDevolver = new System.Windows.Forms.Label();
            this.lblNumeroNote = new System.Windows.Forms.Label();
            this.txtNumeroNote = new System.Windows.Forms.TextBox();
            this.tmrTelas = new System.Windows.Forms.Timer(this.components);
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
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
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(969, 40);
            this.pnlControles.TabIndex = 3;
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
            // 
            // lblCampoNomeAluno
            // 
            this.lblCampoNomeAluno.AutoSize = true;
            this.lblCampoNomeAluno.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoNomeAluno.Location = new System.Drawing.Point(203, 221);
            this.lblCampoNomeAluno.Name = "lblCampoNomeAluno";
            this.lblCampoNomeAluno.Size = new System.Drawing.Size(178, 17);
            this.lblCampoNomeAluno.TabIndex = 25;
            this.lblCampoNomeAluno.Text = "Insira o nome do aluno:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(427, 221);
            this.txtNomeAluno.Multiline = true;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(339, 20);
            this.txtNomeAluno.TabIndex = 24;
            this.txtNomeAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDevolver
            // 
            this.lblDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDevolver.AutoSize = true;
            this.lblDevolver.Font = new System.Drawing.Font("Bebas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolver.ForeColor = System.Drawing.Color.Black;
            this.lblDevolver.Location = new System.Drawing.Point(383, 134);
            this.lblDevolver.Name = "lblDevolver";
            this.lblDevolver.Size = new System.Drawing.Size(203, 32);
            this.lblDevolver.TabIndex = 23;
            this.lblDevolver.Text = "Devolver Notebook";
            // 
            // lblNumeroNote
            // 
            this.lblNumeroNote.AutoSize = true;
            this.lblNumeroNote.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroNote.Location = new System.Drawing.Point(203, 274);
            this.lblNumeroNote.Name = "lblNumeroNote";
            this.lblNumeroNote.Size = new System.Drawing.Size(167, 17);
            this.lblNumeroNote.TabIndex = 27;
            this.lblNumeroNote.Text = "Numero do notebook:";
            // 
            // txtNumeroNote
            // 
            this.txtNumeroNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNumeroNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroNote.Location = new System.Drawing.Point(427, 274);
            this.txtNumeroNote.Multiline = true;
            this.txtNumeroNote.Name = "txtNumeroNote";
            this.txtNumeroNote.Size = new System.Drawing.Size(339, 20);
            this.txtNumeroNote.TabIndex = 26;
            this.txtNumeroNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrTelas
            // 
            this.tmrTelas.Enabled = true;
            this.tmrTelas.Interval = 1;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.btnDevolver.Location = new System.Drawing.Point(409, 339);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(150, 37);
            this.btnDevolver.TabIndex = 28;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Louis George Cafe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::NoteCheck.Properties.Resources.seta;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(11, 58);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 27);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "‬Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(73)))), ((int)(((byte)(96)))));
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Location = new System.Drawing.Point(870, 475);
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
            // DevolverNotebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(969, 510);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.lblNumeroNote);
            this.Controls.Add(this.txtNumeroNote);
            this.Controls.Add(this.lblCampoNomeAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblDevolver);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pnlControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevolverNotebook";
            this.Text = "DevolverNotebook";
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
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
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCampoNomeAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblDevolver;
        private System.Windows.Forms.Label lblNumeroNote;
        private System.Windows.Forms.TextBox txtNumeroNote;
        private System.Windows.Forms.Timer tmrTelas;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Label lblTimer;
    }
}