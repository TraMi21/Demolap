namespace DemoForm
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
            this.btnCong = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(223, 69);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(122, 34);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cong";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(59, 94);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(105, 22);
            this.txtB.TabIndex = 2;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(59, 51);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(105, 22);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(377, 75);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(100, 22);
            this.txtKetQua.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 348);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnCong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

