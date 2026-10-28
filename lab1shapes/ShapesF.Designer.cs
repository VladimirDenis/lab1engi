namespace lab1shapes
{
    partial class ShapesF
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
            this.panelShape = new System.Windows.Forms.Panel();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lstCopies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panelShape
            // 
            this.panelShape.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelShape.Location = new System.Drawing.Point(12, 21);
            this.panelShape.Name = "panelShape";
            this.panelShape.Size = new System.Drawing.Size(270, 216);
            this.panelShape.TabIndex = 0;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(63, 278);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(79, 43);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "randomchik)";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(148, 278);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(79, 43);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(91, 252);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(108, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Фигура не выбрана";
            // 
            // lstCopies
            // 
            this.lstCopies.FormattingEnabled = true;
            this.lstCopies.Location = new System.Drawing.Point(299, 21);
            this.lstCopies.Name = "lstCopies";
            this.lstCopies.Size = new System.Drawing.Size(177, 212);
            this.lstCopies.TabIndex = 4;
            this.lstCopies.SelectedIndexChanged += new System.EventHandler(this.lstCopies_SelectedIndexChanged);
            // 
            // ShapesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 348);
            this.Controls.Add(this.lstCopies);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.panelShape);
            this.Name = "ShapesF";
            this.Text = "Желание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelShape;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstCopies;
    }
}

