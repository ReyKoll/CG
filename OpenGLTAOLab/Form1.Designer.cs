
namespace OpenGLTAOLab
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
            this.GlCanvas = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianglesStripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianglesFanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadsStripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlCanvas
            // 
            this.GlCanvas.AccumBits = ((byte)(0));
            this.GlCanvas.AutoCheckErrors = false;
            this.GlCanvas.AutoFinish = false;
            this.GlCanvas.AutoMakeCurrent = true;
            this.GlCanvas.AutoSwapBuffers = true;
            this.GlCanvas.BackColor = System.Drawing.Color.Black;
            this.GlCanvas.ColorBits = ((byte)(32));
            this.GlCanvas.DepthBits = ((byte)(16));
            this.GlCanvas.Location = new System.Drawing.Point(-2, 30);
            this.GlCanvas.Name = "GlCanvas";
            this.GlCanvas.Size = new System.Drawing.Size(804, 477);
            this.GlCanvas.StencilBits = ((byte)(0));
            this.GlCanvas.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task1ToolStripMenuItem,
            this.task2ToolStripMenuItem,
            this.task3ToolStripMenuItem,
            this.labTaskToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // task1ToolStripMenuItem
            // 
            this.task1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotsToolStripMenuItem,
            this.linesToolStripMenuItem,
            this.stripToolStripMenuItem,
            this.loopToolStripMenuItem});
            this.task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            this.task1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.task1ToolStripMenuItem.Text = "Task 1";
            // 
            // dotsToolStripMenuItem
            // 
            this.dotsToolStripMenuItem.Name = "dotsToolStripMenuItem";
            this.dotsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dotsToolStripMenuItem.Text = "Dots";
            this.dotsToolStripMenuItem.Click += new System.EventHandler(this.dotsToolStripMenuItem_Click);
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linesToolStripMenuItem.Text = "Lines";
            this.linesToolStripMenuItem.Click += new System.EventHandler(this.linesToolStripMenuItem_Click);
            // 
            // stripToolStripMenuItem
            // 
            this.stripToolStripMenuItem.Name = "stripToolStripMenuItem";
            this.stripToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stripToolStripMenuItem.Text = "Strip";
            this.stripToolStripMenuItem.Click += new System.EventHandler(this.stripToolStripMenuItem_Click);
            // 
            // loopToolStripMenuItem
            // 
            this.loopToolStripMenuItem.Name = "loopToolStripMenuItem";
            this.loopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loopToolStripMenuItem.Text = "Loop";
            this.loopToolStripMenuItem.Click += new System.EventHandler(this.loopToolStripMenuItem_Click);
            // 
            // task2ToolStripMenuItem
            // 
            this.task2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trianglesToolStripMenuItem,
            this.trianglesStripToolStripMenuItem,
            this.trianglesFanToolStripMenuItem});
            this.task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            this.task2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.task2ToolStripMenuItem.Text = "Task2";
            // 
            // trianglesToolStripMenuItem
            // 
            this.trianglesToolStripMenuItem.Name = "trianglesToolStripMenuItem";
            this.trianglesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trianglesToolStripMenuItem.Text = "Triangles";
            this.trianglesToolStripMenuItem.Click += new System.EventHandler(this.trianglesToolStripMenuItem_Click);
            // 
            // trianglesStripToolStripMenuItem
            // 
            this.trianglesStripToolStripMenuItem.Name = "trianglesStripToolStripMenuItem";
            this.trianglesStripToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trianglesStripToolStripMenuItem.Text = "Triangles Strip";
            this.trianglesStripToolStripMenuItem.Click += new System.EventHandler(this.trianglesStripToolStripMenuItem_Click);
            // 
            // trianglesFanToolStripMenuItem
            // 
            this.trianglesFanToolStripMenuItem.Name = "trianglesFanToolStripMenuItem";
            this.trianglesFanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trianglesFanToolStripMenuItem.Text = "Triangles Fan";
            this.trianglesFanToolStripMenuItem.Click += new System.EventHandler(this.trianglesFanToolStripMenuItem_Click);
            // 
            // task3ToolStripMenuItem
            // 
            this.task3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadsToolStripMenuItem,
            this.quadsStripToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.task3ToolStripMenuItem.Name = "task3ToolStripMenuItem";
            this.task3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.task3ToolStripMenuItem.Text = "Task 3";
            // 
            // quadsToolStripMenuItem
            // 
            this.quadsToolStripMenuItem.Name = "quadsToolStripMenuItem";
            this.quadsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quadsToolStripMenuItem.Text = "Quads";
            this.quadsToolStripMenuItem.Click += new System.EventHandler(this.quadsToolStripMenuItem_Click);
            // 
            // quadsStripToolStripMenuItem
            // 
            this.quadsStripToolStripMenuItem.Name = "quadsStripToolStripMenuItem";
            this.quadsStripToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quadsStripToolStripMenuItem.Text = "Quads Strip";
            this.quadsStripToolStripMenuItem.Click += new System.EventHandler(this.quadsStripToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.polygonToolStripMenuItem.Text = "Polygon";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonToolStripMenuItem_Click);
            // 
            // labTaskToolStripMenuItem
            // 
            this.labTaskToolStripMenuItem.Name = "labTaskToolStripMenuItem";
            this.labTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.labTaskToolStripMenuItem.Text = "Lab Task";
            this.labTaskToolStripMenuItem.Click += new System.EventHandler(this.labTaskToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 504);
            this.Controls.Add(this.GlCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl GlCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianglesStripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianglesFanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadsStripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labTaskToolStripMenuItem;
    }
}

