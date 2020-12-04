namespace WindowsFormsApp2
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
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btcreate = new System.Windows.Forms.Button();
            this.btpar = new System.Windows.Forms.Button();
            this.rbwagon = new System.Windows.Forms.RadioButton();
            this.rbTrain = new System.Windows.Forms.RadioButton();
            this.tbcount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(6, 9);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 0;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(6, 32);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 1;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(214, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 327);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.rbRectangle_CheckedChanged);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbPaint_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(6, 110);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(85, 20);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(6, 136);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(85, 20);
            this.tb2.TabIndex = 6;
            // 
            // btcreate
            // 
            this.btcreate.Location = new System.Drawing.Point(120, 9);
            this.btcreate.Name = "btcreate";
            this.btcreate.Size = new System.Drawing.Size(76, 36);
            this.btcreate.TabIndex = 7;
            this.btcreate.Text = "Создать";
            this.btcreate.UseVisualStyleBackColor = true;
            this.btcreate.Click += new System.EventHandler(this.btcreate_Click);
            // 
            // btpar
            // 
            this.btpar.Location = new System.Drawing.Point(120, 60);
            this.btpar.Name = "btpar";
            this.btpar.Size = new System.Drawing.Size(76, 36);
            this.btpar.TabIndex = 8;
            this.btpar.Text = "Задать параметры";
            this.btpar.UseVisualStyleBackColor = true;
            this.btpar.Click += new System.EventHandler(this.btpar_Click);
            // 
            // rbwagon
            // 
            this.rbwagon.AutoSize = true;
            this.rbwagon.Location = new System.Drawing.Point(6, 55);
            this.rbwagon.Name = "rbwagon";
            this.rbwagon.Size = new System.Drawing.Size(60, 17);
            this.rbwagon.TabIndex = 9;
            this.rbwagon.TabStop = true;
            this.rbwagon.Text = "Wagon";
            this.rbwagon.UseVisualStyleBackColor = true;
            this.rbwagon.CheckedChanged += new System.EventHandler(this.rbwagon_CheckedChanged);
            // 
            // rbTrain
            // 
            this.rbTrain.AutoSize = true;
            this.rbTrain.Location = new System.Drawing.Point(6, 79);
            this.rbTrain.Name = "rbTrain";
            this.rbTrain.Size = new System.Drawing.Size(49, 17);
            this.rbTrain.TabIndex = 10;
            this.rbTrain.TabStop = true;
            this.rbTrain.Text = "Train";
            this.rbTrain.UseVisualStyleBackColor = true;
            this.rbTrain.CheckedChanged += new System.EventHandler(this.rbTrain_CheckedChanged);
            // 
            // tbcount
            // 
            this.tbcount.Location = new System.Drawing.Point(6, 162);
            this.tbcount.Name = "tbcount";
            this.tbcount.Size = new System.Drawing.Size(85, 20);
            this.tbcount.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 389);
            this.Controls.Add(this.tbcount);
            this.Controls.Add(this.rbTrain);
            this.Controls.Add(this.rbwagon);
            this.Controls.Add(this.btpar);
            this.Controls.Add(this.btcreate);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbCircle);
            this.Controls.Add(this.rbRectangle);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btcreate;
        private System.Windows.Forms.Button btpar;
        private System.Windows.Forms.RadioButton rbwagon;
        private System.Windows.Forms.RadioButton rbTrain;
        private System.Windows.Forms.TextBox tbcount;
    }
}

