namespace LifelessEmotionAnalyzer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DPF = new System.Windows.Forms.Button();
            this.openFiles = new System.Windows.Forms.Button();
            this.numUpTimeRange = new System.Windows.Forms.NumericUpDown();
            this.numUpTimeStart = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTimeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTimeStart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DPF);
            this.tabPage1.Controls.Add(this.openFiles);
            this.tabPage1.Controls.Add(this.numUpTimeRange);
            this.tabPage1.Controls.Add(this.numUpTimeStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DPF
            // 
            this.DPF.Location = new System.Drawing.Point(8, 63);
            this.DPF.Name = "DPF";
            this.DPF.Size = new System.Drawing.Size(246, 23);
            this.DPF.TabIndex = 6;
            this.DPF.Text = "Дискретное преобразование Фурье";
            this.DPF.UseVisualStyleBackColor = true;
            // 
            // openFiles
            // 
            this.openFiles.Location = new System.Drawing.Point(8, 34);
            this.openFiles.Name = "openFiles";
            this.openFiles.Size = new System.Drawing.Size(246, 23);
            this.openFiles.TabIndex = 5;
            this.openFiles.Text = "Открыть .wav файл(-ы)";
            this.openFiles.UseVisualStyleBackColor = true;
            // 
            // numUpTimeRange
            // 
            this.numUpTimeRange.Location = new System.Drawing.Point(134, 6);
            this.numUpTimeRange.Name = "numUpTimeRange";
            this.numUpTimeRange.Size = new System.Drawing.Size(120, 22);
            this.numUpTimeRange.TabIndex = 4;
            // 
            // numUpTimeStart
            // 
            this.numUpTimeStart.Location = new System.Drawing.Point(8, 6);
            this.numUpTimeStart.Name = "numUpTimeStart";
            this.numUpTimeStart.Size = new System.Drawing.Size(120, 22);
            this.numUpTimeStart.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpTimeRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTimeStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button openFiles;
        public System.Windows.Forms.NumericUpDown numUpTimeRange;
        public System.Windows.Forms.NumericUpDown numUpTimeStart;
        public System.Windows.Forms.Button DPF;
    }
}

