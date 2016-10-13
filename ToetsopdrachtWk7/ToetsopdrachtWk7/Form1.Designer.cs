namespace ToetsopdrachtWk7
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
            this.FORlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WHILElist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FORlist
            // 
            this.FORlist.FormattingEnabled = true;
            this.FORlist.Location = new System.Drawing.Point(13, 22);
            this.FORlist.Name = "FORlist";
            this.FORlist.Size = new System.Drawing.Size(120, 134);
            this.FORlist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Left side box";
            // 
            // WHILElist
            // 
            this.WHILElist.FormattingEnabled = true;
            this.WHILElist.Location = new System.Drawing.Point(140, 22);
            this.WHILElist.Name = "WHILElist";
            this.WHILElist.Size = new System.Drawing.Size(120, 134);
            this.WHILElist.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Right side box";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(13, 163);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(247, 23);
            this.Button.TabIndex = 4;
            this.Button.Text = "Go!";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(59, 190);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(201, 20);
            this.ResultBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 225);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WHILElist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FORlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FORlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox WHILElist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultBox;
    }
}

