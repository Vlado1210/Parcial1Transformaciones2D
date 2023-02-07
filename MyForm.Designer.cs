namespace Pt2pt
{
    partial class MyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.LBL_TITLE = new System.Windows.Forms.Label();
            this.PNL_BOTTOM = new System.Windows.Forms.Panel();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.PNL_LEFT = new System.Windows.Forms.Panel();
            this.BTN_EXE2 = new System.Windows.Forms.Button();
            this.BTN_EXE1 = new System.Windows.Forms.Button();
            this.PLAY = new System.Windows.Forms.Button();
            this.PARAR = new System.Windows.Forms.Button();
            this.GRABAR = new System.Windows.Forms.Button();
            this.CHK_TRANSLATE = new System.Windows.Forms.CheckBox();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.TREE = new System.Windows.Forms.TreeView();
            this.PNL_RIGHT = new System.Windows.Forms.Panel();
            this.PCT_SLIDEER_Y = new System.Windows.Forms.PictureBox();
            this.PCT_SLIDEER_X = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.PRUEBATIMER = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TIMERPASIZE = new System.Windows.Forms.Timer(this.components);
            this.TIMERPAROT = new System.Windows.Forms.Timer(this.components);
            this.GRABAR2 = new System.Windows.Forms.Button();
            this.PARAR2 = new System.Windows.Forms.Button();
            this.GRABAR3 = new System.Windows.Forms.Button();
            this.PARAR3 = new System.Windows.Forms.Button();
            this.PNL_HEADER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.PNL_LEFT.SuspendLayout();
            this.PNL_RIGHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_HEADER.Controls.Add(this.LBL_STATUS);
            this.PNL_HEADER.Controls.Add(this.LBL_TITLE);
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(1924, 80);
            this.PNL_HEADER.TabIndex = 0;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.ForeColor = System.Drawing.Color.Gray;
            this.LBL_STATUS.Location = new System.Drawing.Point(492, 29);
            this.LBL_STATUS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(136, 29);
            this.LBL_STATUS.TabIndex = 0;
            this.LBL_STATUS.Text = "WELCOME";
            // 
            // LBL_TITLE
            // 
            this.LBL_TITLE.AutoSize = true;
            this.LBL_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITLE.Location = new System.Drawing.Point(18, 14);
            this.LBL_TITLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_TITLE.Name = "LBL_TITLE";
            this.LBL_TITLE.Size = new System.Drawing.Size(455, 47);
            this.LBL_TITLE.TabIndex = 0;
            this.LBL_TITLE.Text = "GRAPHIX 2023 UDLAP";
            // 
            // PNL_BOTTOM
            // 
            this.PNL_BOTTOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 1005);
            this.PNL_BOTTOM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(1924, 45);
            this.PNL_BOTTOM.TabIndex = 1;
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(237, 155);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1725, 815);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDoubleClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // PNL_LEFT
            // 
            this.PNL_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_LEFT.Controls.Add(this.PARAR2);
            this.PNL_LEFT.Controls.Add(this.PARAR3);
            this.PNL_LEFT.Controls.Add(this.GRABAR2);
            this.PNL_LEFT.Controls.Add(this.BTN_EXE2);
            this.PNL_LEFT.Controls.Add(this.GRABAR3);
            this.PNL_LEFT.Controls.Add(this.BTN_EXE1);
            this.PNL_LEFT.Controls.Add(this.PLAY);
            this.PNL_LEFT.Controls.Add(this.PARAR);
            this.PNL_LEFT.Controls.Add(this.GRABAR);
            this.PNL_LEFT.Controls.Add(this.CHK_TRANSLATE);
            this.PNL_LEFT.Controls.Add(this.BTN_EXE);
            this.PNL_LEFT.Controls.Add(this.TREE);
            this.PNL_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNL_LEFT.Location = new System.Drawing.Point(0, 80);
            this.PNL_LEFT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNL_LEFT.Name = "PNL_LEFT";
            this.PNL_LEFT.Size = new System.Drawing.Size(225, 925);
            this.PNL_LEFT.TabIndex = 3;
            // 
            // BTN_EXE2
            // 
            this.BTN_EXE2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_EXE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BTN_EXE2.FlatAppearance.BorderSize = 0;
            this.BTN_EXE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE2.ForeColor = System.Drawing.Color.Snow;
            this.BTN_EXE2.Location = new System.Drawing.Point(18, 158);
            this.BTN_EXE2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_EXE2.Name = "BTN_EXE2";
            this.BTN_EXE2.Size = new System.Drawing.Size(184, 42);
            this.BTN_EXE2.TabIndex = 9;
            this.BTN_EXE2.Text = "ADD3";
            this.BTN_EXE2.UseVisualStyleBackColor = false;
            this.BTN_EXE2.Click += new System.EventHandler(this.BTN_EXE2_Click);
            // 
            // BTN_EXE1
            // 
            this.BTN_EXE1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_EXE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BTN_EXE1.FlatAppearance.BorderSize = 0;
            this.BTN_EXE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE1.ForeColor = System.Drawing.Color.Snow;
            this.BTN_EXE1.Location = new System.Drawing.Point(18, 230);
            this.BTN_EXE1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_EXE1.Name = "BTN_EXE1";
            this.BTN_EXE1.Size = new System.Drawing.Size(184, 42);
            this.BTN_EXE1.TabIndex = 8;
            this.BTN_EXE1.Text = "ADD2";
            this.BTN_EXE1.UseVisualStyleBackColor = false;
            this.BTN_EXE1.Click += new System.EventHandler(this.BTN_EXE1_Click);
            // 
            // PLAY
            // 
            this.PLAY.Location = new System.Drawing.Point(60, 794);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(106, 44);
            this.PLAY.TabIndex = 5;
            this.PLAY.Text = "PLAY";
            this.PLAY.UseVisualStyleBackColor = true;
            this.PLAY.Click += new System.EventHandler(this.PLAY_Click);
            // 
            // PARAR
            // 
            this.PARAR.Location = new System.Drawing.Point(60, 720);
            this.PARAR.Name = "PARAR";
            this.PARAR.Size = new System.Drawing.Size(106, 53);
            this.PARAR.TabIndex = 4;
            this.PARAR.Text = "PARAR";
            this.PARAR.UseVisualStyleBackColor = true;
            this.PARAR.Click += new System.EventHandler(this.PARAR_Click);
            // 
            // GRABAR
            // 
            this.GRABAR.Location = new System.Drawing.Point(60, 644);
            this.GRABAR.Name = "GRABAR";
            this.GRABAR.Size = new System.Drawing.Size(106, 57);
            this.GRABAR.TabIndex = 3;
            this.GRABAR.Text = "GRABAR";
            this.GRABAR.UseVisualStyleBackColor = true;
            this.GRABAR.Click += new System.EventHandler(this.GRABAR_Click);
            // 
            // CHK_TRANSLATE
            // 
            this.CHK_TRANSLATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHK_TRANSLATE.AutoSize = true;
            this.CHK_TRANSLATE.FlatAppearance.BorderSize = 0;
            this.CHK_TRANSLATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHK_TRANSLATE.Location = new System.Drawing.Point(28, 873);
            this.CHK_TRANSLATE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CHK_TRANSLATE.Name = "CHK_TRANSLATE";
            this.CHK_TRANSLATE.Size = new System.Drawing.Size(113, 24);
            this.CHK_TRANSLATE.TabIndex = 2;
            this.CHK_TRANSLATE.Text = "TRASLATE";
            this.CHK_TRANSLATE.UseVisualStyleBackColor = true;
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_EXE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BTN_EXE.FlatAppearance.BorderSize = 0;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.ForeColor = System.Drawing.Color.Snow;
            this.BTN_EXE.Location = new System.Drawing.Point(18, 282);
            this.BTN_EXE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(184, 42);
            this.BTN_EXE.TabIndex = 1;
            this.BTN_EXE.Text = "ADD";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // TREE
            // 
            this.TREE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TREE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TREE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TREE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TREE.Location = new System.Drawing.Point(0, 0);
            this.TREE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TREE.Name = "TREE";
            this.TREE.Size = new System.Drawing.Size(216, 554);
            this.TREE.TabIndex = 0;
            this.TREE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterSelect);
            this.TREE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TREE_KeyPress);
            // 
            // PNL_RIGHT
            // 
            this.PNL_RIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_RIGHT.Controls.Add(this.PCT_SLIDEER_Y);
            this.PNL_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.PNL_RIGHT.Location = new System.Drawing.Point(1699, 80);
            this.PNL_RIGHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNL_RIGHT.Name = "PNL_RIGHT";
            this.PNL_RIGHT.Size = new System.Drawing.Size(225, 925);
            this.PNL_RIGHT.TabIndex = 4;
            // 
            // PCT_SLIDEER_Y
            // 
            this.PCT_SLIDEER_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCT_SLIDEER_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PCT_SLIDEER_Y.Location = new System.Drawing.Point(28, 55);
            this.PCT_SLIDEER_Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PCT_SLIDEER_Y.Name = "PCT_SLIDEER_Y";
            this.PCT_SLIDEER_Y.Size = new System.Drawing.Size(22, 880);
            this.PCT_SLIDEER_Y.TabIndex = 6;
            this.PCT_SLIDEER_Y.TabStop = false;
            this.PCT_SLIDEER_Y.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseDown);
            this.PCT_SLIDEER_Y.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseMove);
            this.PCT_SLIDEER_Y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseUp);
            // 
            // PCT_SLIDEER_X
            // 
            this.PCT_SLIDEER_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCT_SLIDEER_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PCT_SLIDEER_X.Location = new System.Drawing.Point(21, 17);
            this.PCT_SLIDEER_X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PCT_SLIDEER_X.Name = "PCT_SLIDEER_X";
            this.PCT_SLIDEER_X.Size = new System.Drawing.Size(1678, 23);
            this.PCT_SLIDEER_X.TabIndex = 5;
            this.PCT_SLIDEER_X.TabStop = false;
            this.PCT_SLIDEER_X.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseDown);
            this.PCT_SLIDEER_X.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseMove);
            this.PCT_SLIDEER_X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.PCT_SLIDEER_X);
            this.panel3.Location = new System.Drawing.Point(237, 977);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1722, 58);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Location = new System.Drawing.Point(240, 89);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1722, 58);
            this.panel4.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1722, 58);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 40;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // PRUEBATIMER
            // 
            this.PRUEBATIMER.Interval = 50;
            this.PRUEBATIMER.Tick += new System.EventHandler(this.PRUEBATIMER_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // TIMERPASIZE
            // 
            this.TIMERPASIZE.Tick += new System.EventHandler(this.TIMERPASIZE_Tick);
            // 
            // TIMERPAROT
            // 
            this.TIMERPAROT.Tick += new System.EventHandler(this.TIMERPAROT_Tick);
            // 
            // GRABAR2
            // 
            this.GRABAR2.Location = new System.Drawing.Point(60, 497);
            this.GRABAR2.Name = "GRABAR2";
            this.GRABAR2.Size = new System.Drawing.Size(106, 57);
            this.GRABAR2.TabIndex = 8;
            this.GRABAR2.Text = "GRABAR2";
            this.GRABAR2.UseVisualStyleBackColor = true;
            this.GRABAR2.Click += new System.EventHandler(this.GRABAR2_Click);
            // 
            // PARAR2
            // 
            this.PARAR2.Location = new System.Drawing.Point(60, 573);
            this.PARAR2.Name = "PARAR2";
            this.PARAR2.Size = new System.Drawing.Size(106, 53);
            this.PARAR2.TabIndex = 9;
            this.PARAR2.Text = "PARAR2";
            this.PARAR2.UseVisualStyleBackColor = true;
            this.PARAR2.Click += new System.EventHandler(this.PARAR2_Click);
            // 
            // GRABAR3
            // 
            this.GRABAR3.Location = new System.Drawing.Point(60, 332);
            this.GRABAR3.Name = "GRABAR3";
            this.GRABAR3.Size = new System.Drawing.Size(106, 57);
            this.GRABAR3.TabIndex = 10;
            this.GRABAR3.Text = "GRABAR3";
            this.GRABAR3.UseVisualStyleBackColor = true;
            this.GRABAR3.Click += new System.EventHandler(this.GRABAR3_Click);
            // 
            // PARAR3
            // 
            this.PARAR3.Location = new System.Drawing.Point(60, 418);
            this.PARAR3.Name = "PARAR3";
            this.PARAR3.Size = new System.Drawing.Size(106, 53);
            this.PARAR3.TabIndex = 11;
            this.PARAR3.Text = "PARAR3";
            this.PARAR3.UseVisualStyleBackColor = true;
            this.PARAR3.Click += new System.EventHandler(this.PARAR3_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PNL_RIGHT);
            this.Controls.Add(this.PNL_LEFT);
            this.Controls.Add(this.PCT_CANVAS);
            this.Controls.Add(this.PNL_BOTTOM);
            this.Controls.Add(this.PNL_HEADER);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.MyForm_Resize);
            this.PNL_HEADER.ResumeLayout(false);
            this.PNL_HEADER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.PNL_LEFT.ResumeLayout(false);
            this.PNL_LEFT.PerformLayout();
            this.PNL_RIGHT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_HEADER;
        private System.Windows.Forms.Panel PNL_BOTTOM;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Panel PNL_LEFT;
        private System.Windows.Forms.Panel PNL_RIGHT;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_X;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView TREE;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_Y;
        private System.Windows.Forms.Label LBL_TITLE;
        private System.Windows.Forms.CheckBox CHK_TRANSLATE;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button GRABAR;
        private System.Windows.Forms.Button PARAR;
        private System.Windows.Forms.Button PLAY;
        private System.Windows.Forms.Timer PRUEBATIMER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TIMERPASIZE;
        private System.Windows.Forms.Timer TIMERPAROT;
        private System.Windows.Forms.Button BTN_EXE1;
        private System.Windows.Forms.Button BTN_EXE2;
        private System.Windows.Forms.Button GRABAR2;
        private System.Windows.Forms.Button PARAR2;
        private System.Windows.Forms.Button GRABAR3;
        private System.Windows.Forms.Button PARAR3;
    }
}