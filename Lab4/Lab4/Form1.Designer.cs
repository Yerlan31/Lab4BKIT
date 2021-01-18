namespace Lab4
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
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.textBoxReadTime = new System.Windows.Forms.TextBox();
            this.labelReadTime = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.textBoxSearchTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(661, 57);
            this.buttonReadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(109, 25);
            this.buttonReadFile.TabIndex = 0;
            this.buttonReadFile.Text = "Чтение файла";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // textBoxReadTime
            // 
            this.textBoxReadTime.Location = new System.Drawing.Point(423, 58);
            this.textBoxReadTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxReadTime.Name = "textBoxReadTime";
            this.textBoxReadTime.Size = new System.Drawing.Size(195, 22);
            this.textBoxReadTime.TabIndex = 2;
            // 
            // labelReadTime
            // 
            this.labelReadTime.AutoSize = true;
            this.labelReadTime.Location = new System.Drawing.Point(297, 57);
            this.labelReadTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReadTime.Name = "labelReadTime";
            this.labelReadTime.Size = new System.Drawing.Size(113, 17);
            this.labelReadTime.TabIndex = 3;
            this.labelReadTime.Text = "Выберите файл";
            this.labelReadTime.Click += new System.EventHandler(this.labelReadTime_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(661, 138);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(109, 25);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите слово для поиска";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(423, 138);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(195, 22);
            this.textBoxWord.TabIndex = 6;
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(423, 267);
            this.listBoxResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(195, 260);
            this.listBoxResults.TabIndex = 7;
            // 
            // textBoxSearchTime
            // 
            this.textBoxSearchTime.Location = new System.Drawing.Point(423, 203);
            this.textBoxSearchTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchTime.Name = "textBoxSearchTime";
            this.textBoxSearchTime.Size = new System.Drawing.Size(195, 22);
            this.textBoxSearchTime.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Время поиска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Найденные слова";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поиск слов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchTime);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelReadTime);
            this.Controls.Add(this.textBoxReadTime);
            this.Controls.Add(this.buttonReadFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.TextBox textBoxReadTime;
        private System.Windows.Forms.Label labelReadTime;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.TextBox textBoxSearchTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

