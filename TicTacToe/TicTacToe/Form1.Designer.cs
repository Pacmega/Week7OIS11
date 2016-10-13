namespace TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerFirst = new System.Windows.Forms.Button();
            this.BlankFirst = new System.Windows.Forms.Button();
            this.TL = new System.Windows.Forms.Button();
            this.TM = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MM = new System.Windows.Forms.Button();
            this.ML = new System.Windows.Forms.Button();
            this.BR = new System.Windows.Forms.Button();
            this.BM = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which player goes first? (also works as a reset)";
            // 
            // PlayerFirst
            // 
            this.PlayerFirst.Location = new System.Drawing.Point(13, 30);
            this.PlayerFirst.Name = "PlayerFirst";
            this.PlayerFirst.Size = new System.Drawing.Size(113, 23);
            this.PlayerFirst.TabIndex = 1;
            this.PlayerFirst.Text = "Player (X) first";
            this.PlayerFirst.UseVisualStyleBackColor = true;
            // 
            // BlankFirst
            // 
            this.BlankFirst.Location = new System.Drawing.Point(128, 30);
            this.BlankFirst.Name = "BlankFirst";
            this.BlankFirst.Size = new System.Drawing.Size(113, 23);
            this.BlankFirst.TabIndex = 2;
            this.BlankFirst.Text = "        (O) first";
            this.BlankFirst.UseVisualStyleBackColor = true;
            // 
            // TL
            // 
            this.TL.Enabled = false;
            this.TL.Location = new System.Drawing.Point(13, 60);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(70, 70);
            this.TL.TabIndex = 3;
            this.TL.UseVisualStyleBackColor = true;
            // 
            // TM
            // 
            this.TM.Enabled = false;
            this.TM.Location = new System.Drawing.Point(92, 60);
            this.TM.Name = "TM";
            this.TM.Size = new System.Drawing.Size(70, 70);
            this.TM.TabIndex = 4;
            this.TM.UseVisualStyleBackColor = true;
            // 
            // TR
            // 
            this.TR.Enabled = false;
            this.TR.Location = new System.Drawing.Point(171, 60);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(70, 70);
            this.TR.TabIndex = 5;
            this.TR.UseVisualStyleBackColor = true;
            // 
            // MR
            // 
            this.MR.Enabled = false;
            this.MR.Location = new System.Drawing.Point(171, 136);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(70, 70);
            this.MR.TabIndex = 8;
            this.MR.UseVisualStyleBackColor = true;
            // 
            // MM
            // 
            this.MM.Enabled = false;
            this.MM.Location = new System.Drawing.Point(92, 136);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(70, 70);
            this.MM.TabIndex = 7;
            this.MM.UseVisualStyleBackColor = true;
            // 
            // ML
            // 
            this.ML.Enabled = false;
            this.ML.Location = new System.Drawing.Point(13, 136);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(70, 70);
            this.ML.TabIndex = 6;
            this.ML.UseVisualStyleBackColor = true;
            // 
            // BR
            // 
            this.BR.Enabled = false;
            this.BR.Location = new System.Drawing.Point(171, 212);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(70, 70);
            this.BR.TabIndex = 11;
            this.BR.UseVisualStyleBackColor = true;
            // 
            // BM
            // 
            this.BM.Enabled = false;
            this.BM.Location = new System.Drawing.Point(92, 212);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(70, 70);
            this.BM.TabIndex = 10;
            this.BM.UseVisualStyleBackColor = true;
            // 
            // BL
            // 
            this.BL.Enabled = false;
            this.BL.Location = new System.Drawing.Point(13, 212);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(70, 70);
            this.BL.TabIndex = 9;
            this.BL.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 300);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.ML);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.TM);
            this.Controls.Add(this.TL);
            this.Controls.Add(this.BlankFirst);
            this.Controls.Add(this.PlayerFirst);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayerFirst;
        private System.Windows.Forms.Button BlankFirst;
        private System.Windows.Forms.Button TL;
        private System.Windows.Forms.Button TM;
        private System.Windows.Forms.Button TR;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button MM;
        private System.Windows.Forms.Button ML;
        private System.Windows.Forms.Button BR;
        private System.Windows.Forms.Button BM;
        private System.Windows.Forms.Button BL;
    }
}

