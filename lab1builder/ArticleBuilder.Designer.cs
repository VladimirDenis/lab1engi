namespace lab1builder
{
    partial class ArticleBuilder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(153, 93);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 50);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить файл";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(150, 49);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(105, 13);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "Загрузите txt файл!";
            this.lblRes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ofdFile
            // 
            this.ofdFile.InitialDirectory = "C://";
            // 
            // ArticleBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 155);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnLoad);
            this.Name = "ArticleBuilder";
            this.Text = "Делание дел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

