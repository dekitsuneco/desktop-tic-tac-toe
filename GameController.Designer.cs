namespace KrestikiNoliki
{
    partial class GameController
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameController));
            this.button1 = new System.Windows.Forms.Button();
            this.checkboxAIPlayFirst = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Играть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartGame);
            // 
            // checkboxAIPlayFirst
            // 
            this.checkboxAIPlayFirst.AutoSize = true;
            this.checkboxAIPlayFirst.Location = new System.Drawing.Point(306, 15);
            this.checkboxAIPlayFirst.Name = "checkboxAIPlayFirst";
            this.checkboxAIPlayFirst.Size = new System.Drawing.Size(105, 17);
            this.checkboxAIPlayFirst.TabIndex = 1;
            this.checkboxAIPlayFirst.Text = "Первый ход ИИ";
            this.checkboxAIPlayFirst.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 85);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel2.Location = new System.Drawing.Point(97, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 85);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel3.Location = new System.Drawing.Point(182, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 85);
            this.panel3.TabIndex = 4;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel4.Location = new System.Drawing.Point(12, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 85);
            this.panel4.TabIndex = 5;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel5.Location = new System.Drawing.Point(97, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 85);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel6.Location = new System.Drawing.Point(182, 97);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(85, 85);
            this.panel6.TabIndex = 4;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel7.Location = new System.Drawing.Point(12, 182);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(85, 85);
            this.panel7.TabIndex = 4;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel8.Location = new System.Drawing.Point(97, 182);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(85, 85);
            this.panel8.TabIndex = 4;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel9.Location = new System.Drawing.Point(182, 182);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(85, 85);
            this.panel9.TabIndex = 4;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // GameController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkboxAIPlayFirst);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 320);
            this.MinimumSize = new System.Drawing.Size(477, 320);
            this.Name = "GameController";
            this.Text = "Крестики Нолики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkboxAIPlayFirst;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel9; 
    }
}