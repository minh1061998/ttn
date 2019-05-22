namespace ThucTapNhom
{
    partial class FormDANHMUC
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
            this.btnKKSL = new System.Windows.Forms.Button();
            this.btnCT_KKSL = new System.Windows.Forms.Button();
            this.btnKKCL = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKKSL
            // 
            this.btnKKSL.BackColor = System.Drawing.Color.Green;
            this.btnKKSL.Location = new System.Drawing.Point(41, 237);
            this.btnKKSL.Name = "btnKKSL";
            this.btnKKSL.Size = new System.Drawing.Size(147, 125);
            this.btnKKSL.TabIndex = 0;
            this.btnKKSL.Text = "Phiếu kiểm kê số lượng";
            this.btnKKSL.UseVisualStyleBackColor = false;
            this.btnKKSL.Click += new System.EventHandler(this.btnKKSL_Click);
            // 
            // btnCT_KKSL
            // 
            this.btnCT_KKSL.BackColor = System.Drawing.Color.Navy;
            this.btnCT_KKSL.Location = new System.Drawing.Point(194, 236);
            this.btnCT_KKSL.Name = "btnCT_KKSL";
            this.btnCT_KKSL.Size = new System.Drawing.Size(149, 125);
            this.btnCT_KKSL.TabIndex = 1;
            this.btnCT_KKSL.Text = "Chi tiết phiếu kiểm kê số lượng";
            this.btnCT_KKSL.UseVisualStyleBackColor = false;
            this.btnCT_KKSL.Click += new System.EventHandler(this.btnCT_KKSL_Click);
            // 
            // btnKKCL
            // 
            this.btnKKCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKKCL.Location = new System.Drawing.Point(440, 236);
            this.btnKKCL.Name = "btnKKCL";
            this.btnKKCL.Size = new System.Drawing.Size(155, 126);
            this.btnKKCL.TabIndex = 2;
            this.btnKKCL.Text = "Phiếu kiểm kê chất lượng";
            this.btnKKCL.UseVisualStyleBackColor = false;
            this.btnKKCL.Click += new System.EventHandler(this.btnKKCL_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(601, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 126);
            this.button3.TabIndex = 3;
            this.button3.Text = "Chi tiết phiếu kiểm kê chất lượng";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(245, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH MỤC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDANHMUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKKCL);
            this.Controls.Add(this.btnCT_KKSL);
            this.Controls.Add(this.btnKKSL);
            this.Name = "FormDANHMUC";
            this.Text = "FormDANHMUC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKKSL;
        private System.Windows.Forms.Button btnCT_KKSL;
        private System.Windows.Forms.Button btnKKCL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}