namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.идеальныйОтражательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autolevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссаФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собеляФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.морфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.открытьToolStripMenuItem.Text = "открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличениеЯркостиToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.волны1ToolStripMenuItem,
            this.волныцToolStripMenuItem,
            this.идеальныйОтражательToolStripMenuItem,
            this.autolevelsToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // увеличениеЯркостиToolStripMenuItem
            // 
            this.увеличениеЯркостиToolStripMenuItem.Name = "увеличениеЯркостиToolStripMenuItem";
            this.увеличениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.увеличениеЯркостиToolStripMenuItem.Text = "увеличение яркости";
            this.увеличениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеЯркостиToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.поворотToolStripMenuItem.Text = "поворот";
            this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click_1);
            // 
            // волны1ToolStripMenuItem
            // 
            this.волны1ToolStripMenuItem.Name = "волны1ToolStripMenuItem";
            this.волны1ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.волны1ToolStripMenuItem.Text = "волны1";
            this.волны1ToolStripMenuItem.Click += new System.EventHandler(this.волны1ToolStripMenuItem_Click);
            // 
            // волныцToolStripMenuItem
            // 
            this.волныцToolStripMenuItem.Name = "волныцToolStripMenuItem";
            this.волныцToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.волныцToolStripMenuItem.Text = "волны2";
            this.волныцToolStripMenuItem.Click += new System.EventHandler(this.волныцToolStripMenuItem_Click);
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            this.идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            this.идеальныйОтражательToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.идеальныйОтражательToolStripMenuItem.Text = "идеальный отражатель";
            this.идеальныйОтражательToolStripMenuItem.Click += new System.EventHandler(this.идеальныйОтражательToolStripMenuItem_Click);
            // 
            // autolevelsToolStripMenuItem
            // 
            this.autolevelsToolStripMenuItem.Name = "autolevelsToolStripMenuItem";
            this.autolevelsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.autolevelsToolStripMenuItem.Text = "autolevels";
            this.autolevelsToolStripMenuItem.Click += new System.EventHandler(this.autolevelsToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.гауссаФильтрToolStripMenuItem,
            this.собеляФильтрToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.медианныйФильтрToolStripMenuItem,
            this.морфологияToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // гауссаФильтрToolStripMenuItem
            // 
            this.гауссаФильтрToolStripMenuItem.Name = "гауссаФильтрToolStripMenuItem";
            this.гауссаФильтрToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.гауссаФильтрToolStripMenuItem.Text = "гаусса фильтр";
            this.гауссаФильтрToolStripMenuItem.Click += new System.EventHandler(this.гауссаФильтрToolStripMenuItem_Click);
            // 
            // собеляФильтрToolStripMenuItem
            // 
            this.собеляФильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поXToolStripMenuItem,
            this.поYToolStripMenuItem});
            this.собеляФильтрToolStripMenuItem.Name = "собеляФильтрToolStripMenuItem";
            this.собеляФильтрToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.собеляФильтрToolStripMenuItem.Text = "Собеля фильтр";
            // 
            // поXToolStripMenuItem
            // 
            this.поXToolStripMenuItem.Name = "поXToolStripMenuItem";
            this.поXToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.поXToolStripMenuItem.Text = "по X";
            this.поXToolStripMenuItem.Click += new System.EventHandler(this.поXToolStripMenuItem_Click);
            // 
            // поYToolStripMenuItem
            // 
            this.поYToolStripMenuItem.Name = "поYToolStripMenuItem";
            this.поYToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.поYToolStripMenuItem.Text = "по Y";
            this.поYToolStripMenuItem.Click += new System.EventHandler(this.поYToolStripMenuItem_Click_1);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.резкостьToolStripMenuItem.Text = "резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.тиснениеToolStripMenuItem.Text = "тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click_1);
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.медианныйФильтрToolStripMenuItem.Text = "медианный фильтр";
            this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 384);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(605, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // морфологияToolStripMenuItem
            // 
            this.морфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сужениеToolStripMenuItem,
            this.расширениеToolStripMenuItem});
            this.морфологияToolStripMenuItem.Name = "морфологияToolStripMenuItem";
            this.морфологияToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.морфологияToolStripMenuItem.Text = "морфология";
            // 
            // сужениеToolStripMenuItem
            // 
            this.сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            this.сужениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сужениеToolStripMenuItem.Text = "сужение";
            this.сужениеToolStripMenuItem.Click += new System.EventHandler(this.сужениеToolStripMenuItem_Click);
            // 
            // расширениеToolStripMenuItem
            // 
            this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.расширениеToolStripMenuItem.Text = "расширение";
            this.расширениеToolStripMenuItem.Click += new System.EventHandler(this.расширениеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссаФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениеЯркостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собеляФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волны1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волныцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autolevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem морфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem;
    }
}

