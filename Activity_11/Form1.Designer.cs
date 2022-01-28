namespace Activity_11
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
            this.RollBtn = new System.Windows.Forms.Button();
            this.Res1Txb = new System.Windows.Forms.TextBox();
            this.Res2Txb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RollBtn
            // 
            this.RollBtn.Location = new System.Drawing.Point(32, 53);
            this.RollBtn.Name = "RollBtn";
            this.RollBtn.Size = new System.Drawing.Size(175, 68);
            this.RollBtn.TabIndex = 0;
            this.RollBtn.Text = "Roll Dice";
            this.RollBtn.UseVisualStyleBackColor = true;
            this.RollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // Res1Txb
            // 
            this.Res1Txb.Location = new System.Drawing.Point(239, 53);
            this.Res1Txb.Name = "Res1Txb";
            this.Res1Txb.Size = new System.Drawing.Size(100, 22);
            this.Res1Txb.TabIndex = 1;
            // 
            // Res2Txb
            // 
            this.Res2Txb.Location = new System.Drawing.Point(239, 99);
            this.Res2Txb.Name = "Res2Txb";
            this.Res2Txb.Size = new System.Drawing.Size(100, 22);
            this.Res2Txb.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 168);
            this.Controls.Add(this.Res2Txb);
            this.Controls.Add(this.Res1Txb);
            this.Controls.Add(this.RollBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollBtn;
        private System.Windows.Forms.TextBox Res1Txb;
        private System.Windows.Forms.TextBox Res2Txb;
    }
}

