using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pt2pt
{
    public partial class MyForm : Form
    {
        static Figure f,f1,f2;
        Point ptX, ptY, mouse;
        PointF inicio,final,inicio1,final1,inicio2,final2;
        Bitmap bmpX, bmpY;
        Graphics gX, gY;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;
        bool Button1pic = true;
        bool Button2pic = false;
        bool Button3pic = false;
        Canvas canvas;
        float deltaX = 0;
        float deltaY = 1, inicioDeltaY, finalDeltaY = 1;
        Scene scene, scene1, scene2;
        bool isMouseDown = false;

        const int WM_KEYUP = 0x0101;
        const int WM_KEYDOWN = 0x0100;

        public MyForm()
        {
            InitializeComponent();
            Init();
            IsMouseDownX = false;            
        }

        private void Init()
        {   
            bmpX = new Bitmap(PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height);
            bmpY = new Bitmap(PCT_SLIDEER_Y.Width, PCT_SLIDEER_Y.Height);

            gX = Graphics.FromImage(bmpX);
            gY = Graphics.FromImage(bmpY);

            PCT_SLIDEER_X.Image = bmpX;
            PCT_SLIDEER_Y.Image = bmpY;

            gX.DrawLine(Pens.DimGray, 0, bmpX.Height / 2, bmpX.Width, bmpX.Height / 2);
            gX.FillEllipse(Brushes.Aquamarine, bmpX.Width / 2, bmpX.Height / 4, bmpX.Height / 2, bmpX.Height / 2);

            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0,  bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            //LINEA AMARILLA
            scene = new Scene();
            scene1 = new Scene();
            scene2 = new Scene();
            //Figure fig = new Figure();
            //fig.Add(new PointF(20, 120));
            //fig.Add(new PointF(930, 120));
            //scene.Figures.Add(fig);
            
        }
        Stopwatch stopWatch = new Stopwatch();
        Stopwatch stopwatchrot = new Stopwatch();
        private void PCT_SLIDEER_Y_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownY = false;
            gY.Clear(Color.Transparent);
            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            stopWatch.Stop();
            PCT_SLIDEER_Y.Invalidate();
        }
      
        private void PCT_SLIDEER_Y_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownY)
            {
                gY.Clear(Color.Transparent);
                gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
                gY.FillEllipse(Brushes.Aquamarine, bmpY.Width / 4, e.Y, bmpX.Height / 2, bmpX.Height / 2);

                PCT_SLIDEER_Y.Invalidate();
                deltaY += (float)(ptY.Y - e.Location.Y) / 500;//------------------                
                ptY.Y = e.Location.Y;
            }
        }

        private void PCT_SLIDEER_Y_MouseDown(object sender, MouseEventArgs e)
        {
            ptY = e.Location;
            IsMouseDownY = true;
            stopWatch.Start();
        }
        private void PCT_SLIDEER_X_MouseDown(object sender, MouseEventArgs e)
        {
            ptX = e.Location;
            IsMouseDownX = true;
            stopwatchrot.Start();
        }

        private void PCT_SLIDEER_X_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownX)
            {
                gX.Clear(Color.Transparent);
                gX.DrawLine(Pens.DimGray, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
                gX.FillEllipse(Brushes.Aquamarine, e.X, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

                PCT_SLIDEER_X.Invalidate();
                deltaX += (float)(e.Location.X - ptX.X) / 3;//------------------
                ptX.X = e.Location.X;
            }
        }

        private void PCT_SLIDEER_X_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownX = false;
            gX.Clear(Color.Transparent);
            gX.DrawLine(Pens.DimGray, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
            gX.FillEllipse(Brushes.Aquamarine, PCT_SLIDEER_X.Width / 2, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

            stopwatchrot.Stop();
            PCT_SLIDEER_X.Invalidate();
        }

        private void MyForm_Resize(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS);
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            if (f != null && (IsMouseDownX|| IsMouseDownY))
            {
                f.TranslateToOrigin();
                f.Scale(deltaY);
                f.Rotate(deltaX);                
                f.TranslatePoints(f.Centroid);   
            }

            //deltaX = 0;
            //deltaY = 1;
            canvas.Render(scene);
        }

        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                f.UpdateAttributes();
        }

        private void BTN_EXE_Click(object sender, EventArgs e)
        {
            f = new Figure();
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig" + (TREE.Nodes.Count + 1));
            node.Tag = f;
            TREE.Nodes.Add(node);
            Button1pic = true;
            Button2pic = false;
            Button3pic = false;
        }

        private void BTN_EXE1_Click(object sender, EventArgs e)
        {
            f1 = new Figure();
            scene.Figures.Add(f1);
            Button1pic = false;
            Button2pic = true;
            Button3pic = false;
        }
        private void BTN_EXE2_Click(object sender, EventArgs e)
        {
            f2 = new Figure();
            scene.Figures.Add(f2);
            Button1pic = false;
            Button2pic = false;
            Button3pic = true;
        }

        private void TREE_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)TREE.SelectedNode.Tag;
            BTN_EXE.Select();
        }


        public static bool IsControlDown()
        {
            return (Control.ModifierKeys & Keys.Control) == Keys.Control;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (f == null)
                return false;
            
            switch (keyData)
            {
                case Keys.Left:
                    f.Centroid.X -= 3;                  
                    break;
                case Keys.Right:
                    f.Centroid.X += 3;
                    break;
                case Keys.Up:
                    f.Centroid.Y += -3;
                    break;
                case Keys.Down:
                    f.Centroid.Y += 3;
                    break;
                case Keys.Space:
                    break;
            }
            if (f1 == null)
                return false;

            switch (keyData)
            {
                case Keys.Left:
                    f1.Centroid.X -= 3;
                    break;
                case Keys.Right:
                    f1.Centroid.X += 3;
                    break;
                case Keys.Up:
                    f1.Centroid.Y += -3;
                    break;
                case Keys.Down:
                    f1.Centroid.Y += 3;
                    break;
                case Keys.Space:
                    break;
            }

            if (f2 == null)
                return false;

            switch (keyData)
            {
                case Keys.Left:
                    f2.Centroid.X -= 3;
                    break;
                case Keys.Right:
                    f2.Centroid.X += 3;
                    break;
                case Keys.Up:
                    f2.Centroid.Y += -3;
                    break;
                case Keys.Down:
                    f2.Centroid.Y += 3;
                    break;
                case Keys.Space:
                    break;
            }
            PCT_CANVAS.Select();
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            isMouseDown = true;
        }


        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            PCT_CANVAS.Select();
        }


        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                mouse.X -= e.X;
                mouse.Y -= e.Y;
                f.TranslatePoints(new Point(-mouse.X,-mouse.Y));
                mouse = e.Location;
            }            
        }

          private void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null && Button2pic == false && Button3pic == false && Button1pic == true)
            {
                canvas.DrawPixel(e.X, e.Y, Color.White);
                f.Add(new PointF(e.X, e.Y));
            }

            if (f1 != null && Button2pic == true)
            {
                canvas.DrawPixel(e.X, e.Y, Color.White);
                f1.Add(new PointF(e.X, e.Y));
            }

            if (f2 != null && Button3pic == true)
            {
                canvas.DrawPixel(e.X, e.Y, Color.White);
                f2.Add(new PointF(e.X, e.Y));
            }
        }

        private void TREE_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }

        private void TIMERPASIZE_Tick(object sender, EventArgs e)
        {
           deltaY = 1;
          
        }
        private void TIMERPAROT_Tick(object sender, EventArgs e)
        {
            deltaX = 0;

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
            LBL_STATUS.Text = " ::: " + (float)trackBar1.Value / 100;            
            f.Follow(scene.Figures[0].Pts[0], scene.Figures[0].Pts[1], (float)trackBar1.Value / 100);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            LBL_STATUS.Text = " ::: " + (float)trackBar1.Value / 100;
            f.Follow(scene.Figures[0].Pts[0], scene.Figures[0].Pts[1], (float)trackBar1.Value / 100);
            f1.Follow(scene1.Figures[0].Pts[0], scene1.Figures[0].Pts[1], (float)trackBar1.Value / 100);
            f2.Follow(scene2.Figures[0].Pts[0], scene2.Figures[0].Pts[1], (float)trackBar1.Value / 100);
            f.Scale(deltaY);
            f.Rotate(deltaX * ((float)0.3));
            f1.Scale(deltaY);
            f1.Rotate(deltaX * ((float)0.3));
            f2.Scale(deltaY);
            f2.Rotate(deltaX * ((float)0.3));
        }

        private void PRUEBATIMER_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value < 100)
            {
                trackBar1.Value += 1;
            }
            
        }

        private void GRABAR_Click(object sender, EventArgs e)
        {
            inicio = new PointF(f.Centroid.X, f.Centroid.Y);
            //inicio1 = new PointF(f.Centroid.X, f.Centroid.Y);
            //inicio2 = new PointF(f.Centroid.X, f.Centroid.Y);

        }

        private void GRABAR2_Click(object sender, EventArgs e)
        {
            inicio1 = new PointF(f1.Centroid.X, f1.Centroid.Y);
        }

        private void GRABAR3_Click(object sender, EventArgs e)
        {
            inicio2 = new PointF(f2.Centroid.X, f2.Centroid.Y);
        }

        private void PARAR_Click(object sender, EventArgs e)
        {
            final = new PointF(f.Centroid.X, f.Centroid.Y);
            scene = new Scene();
            Figure fig = new Figure();
            fig.Add(inicio);
            fig.Add(final);
            scene.Figures.Add(fig);
            //final1 = new PointF(f.Centroid.X, f.Centroid.Y);
            //scene1 = new Scene();
            //Figure fig1 = new Figure();
            //fig1.Add(inicio1);
            //fig1.Add(final1);
            //scene1.Figures.Add(fig1);
            //final2 = new PointF(f.Centroid.X, f.Centroid.Y);
            //scene2 = new Scene();
            //Figure fig2 = new Figure();
            //fig2.Add(inicio2);
            //fig2.Add(final2);
            //scene2.Figures.Add(fig2);
        }

        private void PARAR2_Click(object sender, EventArgs e)
        {
            final1 = new PointF(f1.Centroid.X, f1.Centroid.Y);
            scene1 = new Scene();
            Figure fig1 = new Figure();
            fig1.Add(inicio1);
            fig1.Add(final1);
            scene1.Figures.Add(fig1);

        }

        private void PARAR3_Click(object sender, EventArgs e)
        {
            final2 = new PointF(f2.Centroid.X, f2.Centroid.Y);
            scene2 = new Scene();
            Figure fig2 = new Figure();
            fig2.Add(inicio2);
            fig2.Add(final2);
            scene2.Figures.Add(fig2);
        }

        private void PLAY_Click(object sender, EventArgs e)
        {
            PRUEBATIMER.Enabled = true;
            if(stopWatch.ElapsedMilliseconds != 0)
            {
                TIMERPASIZE.Interval = (int)stopWatch.ElapsedMilliseconds;
                TIMERPASIZE.Enabled = true;
            }
            if (stopwatchrot.ElapsedMilliseconds != 0)
            {
              TIMERPAROT.Interval = (int)stopwatchrot.ElapsedMilliseconds;
              //TIMERPAROT.Enabled = true;
            }


        }

    }
}
