namespace Setup
{
    partial class SETUP
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTt = new System.Windows.Forms.Label();
            this.lblDs = new System.Windows.Forms.Label();
            this.lblAg = new System.Windows.Forms.Label();
            this.cmdVl = new System.Windows.Forms.Button();
            this.cmdPr = new System.Windows.Forms.Button();
            this.cmdCnc = new System.Windows.Forms.Button();
            this.txtLic = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(0, -1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(70, 63);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTt
            // 
            this.lblTt.BackColor = System.Drawing.Color.White;
            this.lblTt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTt.Location = new System.Drawing.Point(70, -1);
            this.lblTt.Name = "lblTt";
            this.lblTt.Size = new System.Drawing.Size(447, 29);
            this.lblTt.TabIndex = 1;
            this.lblTt.Text = "Título";
            // 
            // lblDs
            // 
            this.lblDs.BackColor = System.Drawing.Color.White;
            this.lblDs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDs.Location = new System.Drawing.Point(70, 28);
            this.lblDs.Name = "lblDs";
            this.lblDs.Size = new System.Drawing.Size(447, 34);
            this.lblDs.TabIndex = 2;
            this.lblDs.Text = "Descrição";
            // 
            // lblAg
            // 
            this.lblAg.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAg.Location = new System.Drawing.Point(0, 81);
            this.lblAg.Name = "lblAg";
            this.lblAg.Size = new System.Drawing.Size(517, 44);
            this.lblAg.TabIndex = 3;
            this.lblAg.Text = "Seja bem-vindo!";
            // 
            // cmdVl
            // 
            this.cmdVl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVl.Location = new System.Drawing.Point(241, 422);
            this.cmdVl.Name = "cmdVl";
            this.cmdVl.Size = new System.Drawing.Size(90, 28);
            this.cmdVl.TabIndex = 5;
            this.cmdVl.Text = "< &Voltar";
            this.cmdVl.UseVisualStyleBackColor = true;
            this.cmdVl.Click += new System.EventHandler(this.cmdVl_Click);
            // 
            // cmdPr
            // 
            this.cmdPr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPr.Location = new System.Drawing.Point(337, 422);
            this.cmdPr.Name = "cmdPr";
            this.cmdPr.Size = new System.Drawing.Size(87, 28);
            this.cmdPr.TabIndex = 6;
            this.cmdPr.Text = "&Próximo >";
            this.cmdPr.UseVisualStyleBackColor = true;
            this.cmdPr.Click += new System.EventHandler(this.cmdPr_Click);
            // 
            // cmdCnc
            // 
            this.cmdCnc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCnc.Location = new System.Drawing.Point(430, 422);
            this.cmdCnc.Name = "cmdCnc";
            this.cmdCnc.Size = new System.Drawing.Size(75, 28);
            this.cmdCnc.TabIndex = 7;
            this.cmdCnc.Text = "&Cancelar";
            this.cmdCnc.UseVisualStyleBackColor = true;
            this.cmdCnc.Click += new System.EventHandler(this.cmdCnc_Click);
            // 
            // txtLic
            // 
            this.txtLic.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLic.Location = new System.Drawing.Point(73, 128);
            this.txtLic.Name = "txtLic";
            this.txtLic.Size = new System.Drawing.Size(444, 288);
            this.txtLic.TabIndex = 8;
            this.txtLic.Text = "É um prazer ter você como nosso usuário. Trabalhamos muito para que nossos produt" +
    "os fiquem perfeitos, assim como se espera de uma equipe responsável.";
            // 
            // SETUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 462);
            this.Controls.Add(this.txtLic);
            this.Controls.Add(this.cmdCnc);
            this.Controls.Add(this.cmdPr);
            this.Controls.Add(this.cmdVl);
            this.Controls.Add(this.lblAg);
            this.Controls.Add(this.lblDs);
            this.Controls.Add(this.lblTt);
            this.Controls.Add(this.picLogo);
            this.MaximizeBox = false;
            this.Name = "SETUP";
            this.Text = "Instalação";
            this.Load += new System.EventHandler(this.SETUP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTt;
        private System.Windows.Forms.Label lblDs;
        private System.Windows.Forms.Label lblAg;
        private System.Windows.Forms.Button cmdVl;
        private System.Windows.Forms.Button cmdPr;
        private System.Windows.Forms.Button cmdCnc;
        private System.Windows.Forms.RichTextBox txtLic;
    }
}

