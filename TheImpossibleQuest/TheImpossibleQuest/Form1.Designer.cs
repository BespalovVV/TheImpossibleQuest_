namespace TheImpossibleQuest
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
            this.story = new System.Windows.Forms.TextBox();
            this.choosebutton1 = new System.Windows.Forms.Button();
            this.choosebutton2 = new System.Windows.Forms.Button();
            this.choosebutton3 = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // story
            // 
            this.story.Enabled = false;
            this.story.Location = new System.Drawing.Point(12, 12);
            this.story.Multiline = true;
            this.story.Name = "story";
            this.story.ReadOnly = true;
            this.story.Size = new System.Drawing.Size(458, 258);
            this.story.TabIndex = 0;
            this.story.Text = "Ты просыпаешься в самолетном кресле.За окном белые,как пена,облака.Рядом с тобой " +
    "храпит какой-то толстяк,его нога уперлась в твою ногу.";
            // 
            // choosebutton1
            // 
            this.choosebutton1.Location = new System.Drawing.Point(12, 276);
            this.choosebutton1.Name = "choosebutton1";
            this.choosebutton1.Size = new System.Drawing.Size(458, 58);
            this.choosebutton1.TabIndex = 1;
            this.choosebutton1.Text = "Аккуратно подвинуть ногу";
            this.choosebutton1.UseVisualStyleBackColor = true;
            this.choosebutton1.Click += new System.EventHandler(this.choosebutton1_Click);
            // 
            // choosebutton2
            // 
            this.choosebutton2.Location = new System.Drawing.Point(12, 340);
            this.choosebutton2.Name = "choosebutton2";
            this.choosebutton2.Size = new System.Drawing.Size(458, 58);
            this.choosebutton2.TabIndex = 2;
            this.choosebutton2.Text = "Разбудить толстяка";
            this.choosebutton2.UseVisualStyleBackColor = true;
            this.choosebutton2.Click += new System.EventHandler(this.choosebutton2_Click);
            // 
            // choosebutton3
            // 
            this.choosebutton3.Location = new System.Drawing.Point(12, 404);
            this.choosebutton3.Name = "choosebutton3";
            this.choosebutton3.Size = new System.Drawing.Size(458, 58);
            this.choosebutton3.TabIndex = 3;
            this.choosebutton3.Text = "Разбудить толстяка криком";
            this.choosebutton3.UseVisualStyleBackColor = true;
            this.choosebutton3.Click += new System.EventHandler(this.choosebutton3_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(12, 276);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(458, 186);
            this.Restart.TabIndex = 4;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 482);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.choosebutton3);
            this.Controls.Add(this.choosebutton2);
            this.Controls.Add(this.choosebutton1);
            this.Controls.Add(this.story);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox story;
        private System.Windows.Forms.Button choosebutton1;
        private System.Windows.Forms.Button choosebutton2;
        private System.Windows.Forms.Button choosebutton3;
        private System.Windows.Forms.Button Restart;
    }
}

