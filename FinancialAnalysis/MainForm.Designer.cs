namespace FinancialAnalysis
{
    partial class MainForm
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
            this.lbIdUser = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbFullBalance = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIdUser
            // 
            this.lbIdUser.AutoSize = true;
            this.lbIdUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbIdUser.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdUser.Location = new System.Drawing.Point(26, 24);
            this.lbIdUser.Margin = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.lbIdUser.Name = "lbIdUser";
            this.lbIdUser.Size = new System.Drawing.Size(44, 28);
            this.lbIdUser.TabIndex = 8;
            this.lbIdUser.Text = "#id";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(186)))), ((int)(((byte)(243)))));
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(30, 2);
            this.lbName.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(214, 38);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Фамилия Имя";
            // 
            // lbFullBalance
            // 
            this.lbFullBalance.AutoSize = true;
            this.lbFullBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFullBalance.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullBalance.Location = new System.Drawing.Point(26, 100);
            this.lbFullBalance.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbFullBalance.Name = "lbFullBalance";
            this.lbFullBalance.Size = new System.Drawing.Size(168, 28);
            this.lbFullBalance.TabIndex = 10;
            this.lbFullBalance.Text = "Всего средств: ";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(193, 102);
            this.lbBalance.Margin = new System.Windows.Forms.Padding(0);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(83, 26);
            this.lbBalance.TabIndex = 10;
            this.lbBalance.Text = "00.00 ₽";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(186)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(-6, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 44);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1046, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "28.01.2023";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbFullBalance);
            this.Controls.Add(this.lbIdUser);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ финансов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbFullBalance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

