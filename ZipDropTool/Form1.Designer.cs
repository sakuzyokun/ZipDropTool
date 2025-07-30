namespace DragDropZipper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDropHere = new System.Windows.Forms.Label();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.buttonZip = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDropHere
            // 
            this.labelDropHere.AutoSize = true;
            this.labelDropHere.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDropHere.Location = new System.Drawing.Point(12, 9);
            this.labelDropHere.Name = "labelDropHere";
            this.labelDropHere.Size = new System.Drawing.Size(357, 21);
            this.labelDropHere.TabIndex = 0;
            this.labelDropHere.Text = "ここにファイルをドラッグ＆ドロップしてください";
            this.labelDropHere.Click += new System.EventHandler(this.labelDropHere_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 12;
            this.listBoxFiles.Location = new System.Drawing.Point(16, 33);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(353, 220);
            this.listBoxFiles.TabIndex = 1;
            // 
            // buttonZip
            // 
            this.buttonZip.Location = new System.Drawing.Point(16, 259);
            this.buttonZip.Name = "buttonZip";
            this.buttonZip.Size = new System.Drawing.Size(353, 29);
            this.buttonZip.TabIndex = 2;
            this.buttonZip.Text = "ZIPに圧縮する";
            this.buttonZip.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(294, 230);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "削除";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 295);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonZip);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.labelDropHere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ZipDropTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDropHere;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonZip;
        private System.Windows.Forms.Button buttonRemove;
    }
}

