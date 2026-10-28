namespace lab1lift
{
    partial class LiftF
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
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnShowRooms = new System.Windows.Forms.Button();
            this.lblElevator = new System.Windows.Forms.Label();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFloor
            // 
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(17, 25);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(186, 21);
            this.cmbFloor.TabIndex = 0;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(17, 100);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(90, 52);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Поехать";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnShowRooms
            // 
            this.btnShowRooms.Location = new System.Drawing.Point(113, 100);
            this.btnShowRooms.Name = "btnShowRooms";
            this.btnShowRooms.Size = new System.Drawing.Size(90, 52);
            this.btnShowRooms.TabIndex = 2;
            this.btnShowRooms.Text = "Показать комнаты";
            this.btnShowRooms.UseVisualStyleBackColor = true;
            this.btnShowRooms.Click += new System.EventHandler(this.btnShowRooms_Click);
            // 
            // lblElevator
            // 
            this.lblElevator.AutoSize = true;
            this.lblElevator.Location = new System.Drawing.Point(14, 69);
            this.lblElevator.Name = "lblElevator";
            this.lblElevator.Size = new System.Drawing.Size(132, 13);
            this.lblElevator.TabIndex = 3;
            this.lblElevator.Text = "Выберете этаж и едьте..";
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.Location = new System.Drawing.Point(229, 25);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(134, 134);
            this.lstRooms.TabIndex = 4;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(14, 177);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(206, 13);
            this.lblLog.TabIndex = 6;
            this.lblLog.Text = "Начните перемещение(вверх или вниз)";
            // 
            // LiftF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 204);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.lblElevator);
            this.Controls.Add(this.btnShowRooms);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.cmbFloor);
            this.Name = "LiftF";
            this.Text = "RP лифт закройте глаза";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnShowRooms;
        private System.Windows.Forms.Label lblElevator;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Label lblLog;
    }
}

