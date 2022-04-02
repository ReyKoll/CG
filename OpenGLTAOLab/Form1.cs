using System.Windows.Forms;
using Tao.OpenGl;

namespace OpenGLTAOLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GlCanvas.InitializeContexts();
        }

        private void Clear()
        {
            Gl.glViewport(0, 0, GlCanvas.Width, GlCanvas.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
        }

        private void DrawTriangle()
        {
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(0, 1, 0);
            Gl.glVertex3f(-0.5f, 0.5f, 0);
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex3f(0.5f, 0.5f, 0);
            Gl.glColor3f(0, 0, 1);
            Gl.glVertex3f(0, -0.5f, 0);
            Gl.glEnd();
        }

        private void DrawDot()
        {
            Gl.glColor3f(0, 0, 0);
            Gl.glPointSize(20f);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(0, 0);
            Gl.glVertex2f(0.5f, 0.5f);
            Gl.glVertex2f(-0.5f, 0.5f);
            Gl.glVertex2f(0.5f, -0.5f);
            Gl.glVertex2f(-0.5f, -0.5f);
            Gl.glEnd();
        }

        private void DrawLines()
        {
            Gl.glLineWidth(7);
            Gl.glColor3f(0, 0, 1);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(-1.0f, 1.0f);
            Gl.glVertex2f(1.0f, -1.0f);
            Gl.glVertex2f(1.0f, 1.0f);
            Gl.glVertex2f(-1.0f, -1.0f);
            Gl.glEnd();
        }

        private void DrawStripLines()
        {
            Gl.glLineWidth(7);
            Gl.glColor3f(1, 0, 1);
            Gl.glBegin(Gl.GL_LINE_STRIP);

            Gl.glVertex2f(0.5f, 0.5f); 
            Gl.glVertex2f(-0.5f, 0.5f); 
                                   
            Gl.glVertex2f(0.5f, -0.5f); 
            Gl.glVertex2f(-0.5f, -0.5f); 
            Gl.glEnd();
        }

        private void DrawLinesLoop()
        {
            Gl.glLineWidth(7);
            Gl.glColor3f(1, 0, 1);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2f(0.5f, 0.5f);
            Gl.glVertex2f(-0.5f, 0.5f);
            Gl.glVertex2f(0.5f, -0.5f);
            Gl.glVertex2f(-0.5f, -0.5f);
            Gl.glEnd();
        }

        private void DrawTriangleFan()
        {
            Gl.glLineWidth(7);
            Gl.glColor3f(1, 0, 1);
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            Gl.glVertex2f(0.0f, 0.0f);
            Gl.glVertex2f(0.5f, 0.5f);
            Gl.glVertex2f(-0.5f, 0.5f);
            Gl.glVertex2f(0.5f, -0.5f);
            Gl.glVertex2f(-0.5f, -0.5f);
            Gl.glEnd();
        }

        private void DrawQuads()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(1, 0, 1);
            Gl.glVertex2f(-0.5f, 0.5f);
            Gl.glVertex2f(-0.5f, -0.5f);
            Gl.glVertex2f(0.5f, -0.5f);
            Gl.glColor3f(1, 1, 1);
            Gl.glVertex2f(0.5f, 0.5f);
            Gl.glEnd();
        }

        private void DrawQuadsStrip()
        {
            Gl.glColor3f(0, 0, 0);
            Gl.glBegin(Gl.GL_QUAD_STRIP);
            Gl.glVertex2f(-0.5f, 0.5f);
            Gl.glVertex2f(-0.5f, -0.5f);
            Gl.glVertex2f(0.5f, 0.5f);
            Gl.glColor3f(1, 1, 1);
            Gl.glVertex2f(0.5f, -0.3f);
            Gl.glEnd();
        }

        private void DrawPolygon()
        {
            Gl.glColor3f(0, 0, 0);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(-0.3f, 0.5f);
            Gl.glVertex2f(0.3f, 0.5f);
            Gl.glVertex2f(0.6f, 0.0f);
            Gl.glVertex2f(0.3f, -0.5f);
            Gl.glColor3f(1, 1, 1);
            Gl.glVertex2f(-0.3f, -0.5f);
            Gl.glColor3f(1, 1, 1);
            Gl.glVertex2f(-0.6f, 0.0f);
            Gl.glEnd();
        }

        private void DrawTriangleStrip()
        {
            Gl.glColor3f(0, 0, 0);
            Gl.glBegin(Gl.GL_TRIANGLE_STRIP);
            Gl.glVertex2f(-0.5f, 0.0f);
            Gl.glColor3f(1, 0, 1);
            Gl.glVertex2f(0.0f, -0.7f);
            Gl.glVertex2f(0.0f, 0.7f);
            Gl.glVertex2f(0.5f, 0.0f);
            Gl.glEnd();
        }

        private void Task()
        {
            Gl.glColor3f(0, 0, 0);
            Gl.glPointSize(10f);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(0, 0);
            Gl.glEnd();
            Gl.glColor3f(0, 0, 0);
            Gl.glLineWidth(2);
            Gl.glBegin(Gl.GL_LINES);

            Gl.glVertex2f(0.8f, 0.8f);
            Gl.glVertex2f(-0.8f, 0.8f);

            Gl.glVertex2f(0.8f, -0.8f);
            Gl.glVertex2f(-0.8f, -0.8f);

            Gl.glVertex2f(-0.8f, 0.8f);
            Gl.glVertex2f(-0.8f, -0.8f);

            Gl.glVertex2f(0.8f, -0.8f);
            Gl.glVertex2f(0.8f, 0.8f);

            Gl.glVertex2f(-0.5f, 0.5f);
            Gl.glVertex2f(-0.5f, -0.5f);

            Gl.glVertex2f(-0.5f, -0.5f);
            Gl.glVertex2f(0.3f, -0.3f);

            Gl.glVertex2f(0.3f, -0.3f);
            Gl.glVertex2f(0.0f, 0.0f);

            Gl.glVertex2f(0.0f, 0.0f);
            Gl.glVertex2f(0.3f, 0.3f);

            Gl.glVertex2f(0.3f, 0.3f);
            Gl.glVertex2f(-0.5f, 0.5f);

            Gl.glEnd();
        }

        private void labTaskToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            Task();
            GlCanvas.Invalidate();
        }

        private void dotsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawDot();
            GlCanvas.Invalidate();
        }

        private void linesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawLines();
            GlCanvas.Invalidate();
        }

        private void stripToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawStripLines();
            GlCanvas.Invalidate();
        }

        private void loopToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawLinesLoop();
            GlCanvas.Invalidate();
        }

        private void trianglesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawTriangle();
            GlCanvas.Invalidate();
        }

        private void trianglesStripToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawTriangleStrip();
            GlCanvas.Invalidate();
        }

        private void trianglesFanToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawTriangleFan();
            GlCanvas.Invalidate();
        }

        private void quadsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawQuads();
            GlCanvas.Invalidate();
        }

        private void quadsStripToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawQuadsStrip();
            GlCanvas.Invalidate();
        }

        private void polygonToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
            DrawPolygon();
            GlCanvas.Invalidate();
        }
    }
}