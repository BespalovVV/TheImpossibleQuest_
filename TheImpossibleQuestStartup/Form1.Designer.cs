namespace TheImpossibleQuestStartup
{
    partial class Form1
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
            this.startup = new System.Windows.Forms.TextBox();
            this.Console = new System.Windows.Forms.Button();
            this.forms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startup
            // 
            this.startup.Location = new System.Drawing.Point(12, 12);
            this.startup.Multiline = true;
            this.startup.Name = "startup";
            this.startup.ReadOnly = true;
            this.startup.Size = new System.Drawing.Size(458, 258);
            this.startup.TabIndex = 1;
            this.startup.Text = "В какую версию игры вы хотите играть?";
            this.startup.TextChanged += new System.EventHandler(this.story_TextChanged);
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(12, 276);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(458, 86);
            this.Console.TabIndex = 2;
            this.Console.Text = "Консольное приложение";
            this.Console.UseVisualStyleBackColor = true;
            this.Console.Click += new System.EventHandler(this.button1_Click);
            // 
            // forms
            // 
            this.forms.Location = new System.Drawing.Point(12, 368);
            this.forms.Name = "forms";
            this.forms.Size = new System.Drawing.Size(458, 102);
            this.forms.TabIndex = 3;
            this.forms.Text = "Windows Form приложение";
            this.forms.UseVisualStyleBackColor = true;
            this.forms.Click += new System.EventHandler(this.forms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 482);
            this.Controls.Add(this.forms);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.startup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startup;
        private System.Windows.Forms.Button Console;
        private System.Windows.Forms.Button forms;
    }
}

