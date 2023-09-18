namespace ai_test
{
    partial class Form_test
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
            this.text_source = new System.Windows.Forms.TextBox();
            this.text_target = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_source
            // 
            this.text_source.Location = new System.Drawing.Point(12, 12);
            this.text_source.Multiline = true;
            this.text_source.Name = "text_source";
            this.text_source.Size = new System.Drawing.Size(762, 110);
            this.text_source.TabIndex = 0;
            this.text_source.Text = "Исходный";
            // 
            // text_target
            // 
            this.text_target.Location = new System.Drawing.Point(12, 149);
            this.text_target.Multiline = true;
            this.text_target.Name = "text_target";
            this.text_target.Size = new System.Drawing.Size(762, 110);
            this.text_target.TabIndex = 0;
            this.text_target.Text = "Результат";
            // 
            // Form_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_target);
            this.Controls.Add(this.text_source);
            this.Name = "Form_test";
            this.Text = "Болталка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_source;
        private System.Windows.Forms.TextBox text_target;
    }
}

