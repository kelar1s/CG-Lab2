namespace Lab2TomogramVisualizer
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
            this.glControl1 = new OpenTK.GLControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MinimumTrackBar2 = new System.Windows.Forms.TrackBar();
            this.MaximumTrackBar3 = new System.Windows.Forms.TrackBar();
            this.MinimumTrackBar2Label = new System.Windows.Forms.Label();
            this.MaximumTrackBar3Label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumTrackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(12, 46);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(592, 458);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(990, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel1.Text = "Загрузить";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 525);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(592, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Текстура",
            "Четырёхугольник"});
            this.comboBox1.Location = new System.Drawing.Point(750, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MinimumTrackBar2
            // 
            this.MinimumTrackBar2.Location = new System.Drawing.Point(672, 125);
            this.MinimumTrackBar2.Maximum = 254;
            this.MinimumTrackBar2.Name = "MinimumTrackBar2";
            this.MinimumTrackBar2.Size = new System.Drawing.Size(154, 45);
            this.MinimumTrackBar2.TabIndex = 4;
            this.MinimumTrackBar2.Scroll += new System.EventHandler(this.MinimumTrackBar2_Scroll);
            // 
            // MaximumTrackBar3
            // 
            this.MaximumTrackBar3.Location = new System.Drawing.Point(672, 227);
            this.MaximumTrackBar3.Maximum = 255;
            this.MaximumTrackBar3.Minimum = 1;
            this.MaximumTrackBar3.Name = "MaximumTrackBar3";
            this.MaximumTrackBar3.Size = new System.Drawing.Size(154, 45);
            this.MaximumTrackBar3.TabIndex = 5;
            this.MaximumTrackBar3.Value = 255;
            this.MaximumTrackBar3.Scroll += new System.EventHandler(this.MaximumTrackBar3_Scroll);
            // 
            // MinimumTrackBar2Label
            // 
            this.MinimumTrackBar2Label.AutoSize = true;
            this.MinimumTrackBar2Label.Location = new System.Drawing.Point(854, 125);
            this.MinimumTrackBar2Label.Name = "MinimumTrackBar2Label";
            this.MinimumTrackBar2Label.Size = new System.Drawing.Size(13, 13);
            this.MinimumTrackBar2Label.TabIndex = 6;
            this.MinimumTrackBar2Label.Text = "0";
            // 
            // MaximumTrackBar3Label2
            // 
            this.MaximumTrackBar3Label2.AutoSize = true;
            this.MaximumTrackBar3Label2.Location = new System.Drawing.Point(857, 227);
            this.MaximumTrackBar3Label2.Name = "MaximumTrackBar3Label2";
            this.MaximumTrackBar3Label2.Size = new System.Drawing.Size(25, 13);
            this.MaximumTrackBar3Label2.TabIndex = 7;
            this.MaximumTrackBar3Label2.Text = "255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.MaximumTrackBar3Label2);
            this.Controls.Add(this.MinimumTrackBar2Label);
            this.Controls.Add(this.MaximumTrackBar3);
            this.Controls.Add(this.MinimumTrackBar2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumTrackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar MinimumTrackBar2;
        private System.Windows.Forms.TrackBar MaximumTrackBar3;
        private System.Windows.Forms.Label MinimumTrackBar2Label;
        private System.Windows.Forms.Label MaximumTrackBar3Label2;
    }
}

