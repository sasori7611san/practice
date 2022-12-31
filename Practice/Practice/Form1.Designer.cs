namespace Practice
{
    partial class OneLineMemo
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 22);
            this.textBox1.TabIndex = 0;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(41, 77);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(115, 56);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(162, 77);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(115, 56);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "キャンセル";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(283, 77);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(115, 56);
            this.End.TabIndex = 3;
            this.End.Text = "End";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // OneLineMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 191);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.textBox1);
            this.Name = "OneLineMemo";
            this.Text = "OneLineMemo";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button End;
    }
}

