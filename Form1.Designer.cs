namespace Hello_Word
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGo = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.txtShow1 = new System.Windows.Forms.TextBox();
            this.txtShow2 = new System.Windows.Forms.TextBox();
            this.txtShow3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(584, 240);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(263, 121);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "開始";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtShow
            // 
            this.txtShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShow.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.Location = new System.Drawing.Point(601, 458);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(228, 39);
            this.txtShow.TabIndex = 1;
            this.txtShow.Text = "輸入文字框";
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // txtShow1
            // 
            this.txtShow1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow1.Location = new System.Drawing.Point(617, 552);
            this.txtShow1.Name = "txtShow1";
            this.txtShow1.Size = new System.Drawing.Size(212, 46);
            this.txtShow1.TabIndex = 2;
            this.txtShow1.Text = "輸入文字框";
            // 
            // txtShow2
            // 
            this.txtShow2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShow2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow2.Location = new System.Drawing.Point(289, 277);
            this.txtShow2.Name = "txtShow2";
            this.txtShow2.Size = new System.Drawing.Size(158, 39);
            this.txtShow2.TabIndex = 3;
            this.txtShow2.Text = "輸入文字框";
            // 
            // txtShow3
            // 
            this.txtShow3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShow3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow3.Location = new System.Drawing.Point(967, 267);
            this.txtShow3.Name = "txtShow3";
            this.txtShow3.Size = new System.Drawing.Size(168, 39);
            this.txtShow3.TabIndex = 4;
            this.txtShow3.Text = "輸入文字框";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 880);
            this.Controls.Add(this.txtShow3);
            this.Controls.Add(this.txtShow2);
            this.Controls.Add(this.txtShow1);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.TextBox txtShow1;
        private System.Windows.Forms.TextBox txtShow2;
        private System.Windows.Forms.TextBox txtShow3;
    }
}

