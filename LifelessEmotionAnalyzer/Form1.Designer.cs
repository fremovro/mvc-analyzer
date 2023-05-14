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
            this.numUpIdent = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NumUpMaxCount = new System.Windows.Forms.NumericUpDown();
            this.NextButton = new System.Windows.Forms.Button();
            this.NumUpSmooth = new System.Windows.Forms.NumericUpDown();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.chosenDpfName = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.numUpTimeRange = new System.Windows.Forms.NumericUpDown();
            this.FRProgressBar = new System.Windows.Forms.ProgressBar();
            this.FileProgressBar = new System.Windows.Forms.ProgressBar();
            this.SpectrumPanel = new System.Windows.Forms.Panel();
            this.openFiles = new System.Windows.Forms.Button();
            this.numUpTimeStart = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LearnNetworkProgressBar = new System.Windows.Forms.ProgressBar();
            this.PrognozeProgressBar = new System.Windows.Forms.ProgressBar();
            this.ErrorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NeuronCountNumUp = new System.Windows.Forms.NumericUpDown();
            this.IterationCountNumUp = new System.Windows.Forms.NumericUpDown();
            this.PrognozeResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PrognozeButton = new System.Windows.Forms.Button();
            this.LearnNetworkButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpIdent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTimeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTimeStart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronCountNumUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterationCountNumUp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numUpIdent);
            this.tabPage1.Controls.Add(this.CalculateButton);
            this.tabPage1.Controls.Add(this.NumUpMaxCount);
            this.tabPage1.Controls.Add(this.NextButton);
            this.tabPage1.Controls.Add(this.NumUpSmooth);
            this.tabPage1.Controls.Add(this.ResultTextBox);
            this.tabPage1.Controls.Add(this.chosenDpfName);
            this.tabPage1.Controls.Add(this.BackButton);
            this.tabPage1.Controls.Add(this.numUpTimeRange);
            this.tabPage1.Controls.Add(this.FRProgressBar);
            this.tabPage1.Controls.Add(this.FileProgressBar);
            this.tabPage1.Controls.Add(this.SpectrumPanel);
            this.tabPage1.Controls.Add(this.openFiles);
            this.tabPage1.Controls.Add(this.numUpTimeStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Метод отношений частот";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numUpIdent
            // 
            this.numUpIdent.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpIdent.Location = new System.Drawing.Point(573, 35);
            this.numUpIdent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpIdent.Name = "numUpIdent";
            this.numUpIdent.Size = new System.Drawing.Size(102, 22);
            this.numUpIdent.TabIndex = 10;
            this.numUpIdent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(358, 63);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(317, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Вычислить отношения частот";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // NumUpMaxCount
            // 
            this.NumUpMaxCount.Location = new System.Drawing.Point(466, 35);
            this.NumUpMaxCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumUpMaxCount.Name = "NumUpMaxCount";
            this.NumUpMaxCount.Size = new System.Drawing.Size(102, 22);
            this.NumUpMaxCount.TabIndex = 9;
            this.NumUpMaxCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(785, 400);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(159, 22);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Следующий";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // NumUpSmooth
            // 
            this.NumUpSmooth.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumUpSmooth.Location = new System.Drawing.Point(358, 35);
            this.NumUpSmooth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NumUpSmooth.Name = "NumUpSmooth";
            this.NumUpSmooth.Size = new System.Drawing.Size(102, 22);
            this.NumUpSmooth.TabIndex = 0;
            this.NumUpSmooth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(681, 92);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(263, 302);
            this.ResultTextBox.TabIndex = 12;
            this.ResultTextBox.Text = "";
            // 
            // chosenDpfName
            // 
            this.chosenDpfName.Enabled = false;
            this.chosenDpfName.Location = new System.Drawing.Point(173, 400);
            this.chosenDpfName.Name = "chosenDpfName";
            this.chosenDpfName.Size = new System.Drawing.Size(606, 22);
            this.chosenDpfName.TabIndex = 0;
            this.chosenDpfName.Text = "Запись отсутсвует, необходимо вычислить отношения частот";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(8, 400);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(159, 22);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Предыдущий";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // numUpTimeRange
            // 
            this.numUpTimeRange.DecimalPlaces = 1;
            this.numUpTimeRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpTimeRange.Location = new System.Drawing.Point(173, 35);
            this.numUpTimeRange.Name = "numUpTimeRange";
            this.numUpTimeRange.Size = new System.Drawing.Size(152, 22);
            this.numUpTimeRange.TabIndex = 4;
            this.numUpTimeRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FRProgressBar
            // 
            this.FRProgressBar.Location = new System.Drawing.Point(358, 6);
            this.FRProgressBar.Name = "FRProgressBar";
            this.FRProgressBar.Size = new System.Drawing.Size(317, 23);
            this.FRProgressBar.Step = 1;
            this.FRProgressBar.TabIndex = 8;
            // 
            // FileProgressBar
            // 
            this.FileProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FileProgressBar.Location = new System.Drawing.Point(8, 6);
            this.FileProgressBar.Name = "FileProgressBar";
            this.FileProgressBar.Size = new System.Drawing.Size(317, 23);
            this.FileProgressBar.Step = 1;
            this.FileProgressBar.TabIndex = 0;
            // 
            // SpectrumPanel
            // 
            this.SpectrumPanel.Location = new System.Drawing.Point(8, 92);
            this.SpectrumPanel.Name = "SpectrumPanel";
            this.SpectrumPanel.Size = new System.Drawing.Size(667, 302);
            this.SpectrumPanel.TabIndex = 7;
            // 
            // openFiles
            // 
            this.openFiles.Location = new System.Drawing.Point(8, 63);
            this.openFiles.Name = "openFiles";
            this.openFiles.Size = new System.Drawing.Size(317, 23);
            this.openFiles.TabIndex = 5;
            this.openFiles.Text = "Открыть .wav файл(-ы)";
            this.openFiles.UseVisualStyleBackColor = true;
            // 
            // numUpTimeStart
            // 
            this.numUpTimeStart.DecimalPlaces = 1;
            this.numUpTimeStart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpTimeStart.Location = new System.Drawing.Point(8, 35);
            this.numUpTimeStart.Name = "numUpTimeStart";
            this.numUpTimeStart.Size = new System.Drawing.Size(159, 22);
            this.numUpTimeStart.TabIndex = 3;
            this.numUpTimeStart.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.LearnNetworkProgressBar);
            this.tabPage2.Controls.Add(this.PrognozeProgressBar);
            this.tabPage2.Controls.Add(this.ErrorTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.NeuronCountNumUp);
            this.tabPage2.Controls.Add(this.IterationCountNumUp);
            this.tabPage2.Controls.Add(this.PrognozeResultRichTextBox);
            this.tabPage2.Controls.Add(this.PrognozeButton);
            this.tabPage2.Controls.Add(this.LearnNetworkButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Нейросеть (Обучение&Прогноз)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "<= Количество итераций обучения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "<= Количество нейронов в скрытом слое";
            // 
            // LearnNetworkProgressBar
            // 
            this.LearnNetworkProgressBar.Location = new System.Drawing.Point(6, 63);
            this.LearnNetworkProgressBar.Name = "LearnNetworkProgressBar";
            this.LearnNetworkProgressBar.Size = new System.Drawing.Size(246, 23);
            this.LearnNetworkProgressBar.TabIndex = 8;
            // 
            // PrognozeProgressBar
            // 
            this.PrognozeProgressBar.Location = new System.Drawing.Point(8, 341);
            this.PrognozeProgressBar.Name = "PrognozeProgressBar";
            this.PrognozeProgressBar.Size = new System.Drawing.Size(246, 23);
            this.PrognozeProgressBar.Step = 1;
            this.PrognozeProgressBar.TabIndex = 7;
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.Location = new System.Drawing.Point(8, 147);
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.Size = new System.Drawing.Size(120, 22);
            this.ErrorTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "<= Ошибка обучения";
            // 
            // NeuronCountNumUp
            // 
            this.NeuronCountNumUp.Location = new System.Drawing.Point(6, 7);
            this.NeuronCountNumUp.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NeuronCountNumUp.Name = "NeuronCountNumUp";
            this.NeuronCountNumUp.Size = new System.Drawing.Size(120, 22);
            this.NeuronCountNumUp.TabIndex = 4;
            this.NeuronCountNumUp.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // IterationCountNumUp
            // 
            this.IterationCountNumUp.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IterationCountNumUp.Location = new System.Drawing.Point(6, 35);
            this.IterationCountNumUp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.IterationCountNumUp.Name = "IterationCountNumUp";
            this.IterationCountNumUp.Size = new System.Drawing.Size(120, 22);
            this.IterationCountNumUp.TabIndex = 3;
            this.IterationCountNumUp.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // PrognozeResultRichTextBox
            // 
            this.PrognozeResultRichTextBox.Location = new System.Drawing.Point(264, 63);
            this.PrognozeResultRichTextBox.Name = "PrognozeResultRichTextBox";
            this.PrognozeResultRichTextBox.Size = new System.Drawing.Size(546, 356);
            this.PrognozeResultRichTextBox.TabIndex = 2;
            this.PrognozeResultRichTextBox.Text = "";
            // 
            // PrognozeButton
            // 
            this.PrognozeButton.Location = new System.Drawing.Point(8, 370);
            this.PrognozeButton.Name = "PrognozeButton";
            this.PrognozeButton.Size = new System.Drawing.Size(246, 49);
            this.PrognozeButton.TabIndex = 1;
            this.PrognozeButton.Text = "Загрузить файлы(-ы) для прогноза";
            this.PrognozeButton.UseVisualStyleBackColor = true;
            // 
            // LearnNetworkButton
            // 
            this.LearnNetworkButton.Location = new System.Drawing.Point(6, 92);
            this.LearnNetworkButton.Name = "LearnNetworkButton";
            this.LearnNetworkButton.Size = new System.Drawing.Size(246, 49);
            this.LearnNetworkButton.TabIndex = 0;
            this.LearnNetworkButton.Text = "Обучить нейросеть";
            this.LearnNetworkButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpIdent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpMaxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTimeRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTimeStart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronCountNumUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IterationCountNumUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button openFiles;
        public System.Windows.Forms.NumericUpDown numUpTimeRange;
        public System.Windows.Forms.NumericUpDown numUpTimeStart;
        public System.Windows.Forms.Button CalculateButton;
        public System.Windows.Forms.Panel SpectrumPanel;
        public System.Windows.Forms.NumericUpDown NumUpSmooth;
        public System.Windows.Forms.NumericUpDown NumUpMaxCount;
        public System.Windows.Forms.NumericUpDown numUpIdent;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.TextBox chosenDpfName;
        public System.Windows.Forms.Button NextButton;
        public System.Windows.Forms.ProgressBar FileProgressBar;
        public System.Windows.Forms.ProgressBar FRProgressBar;
        public System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar LearnNetworkProgressBar;
        public System.Windows.Forms.ProgressBar PrognozeProgressBar;
        public System.Windows.Forms.TextBox ErrorTextBox;
        public System.Windows.Forms.NumericUpDown NeuronCountNumUp;
        public System.Windows.Forms.NumericUpDown IterationCountNumUp;
        public System.Windows.Forms.RichTextBox PrognozeResultRichTextBox;
        public System.Windows.Forms.Button PrognozeButton;
        public System.Windows.Forms.Button LearnNetworkButton;
    }
}

