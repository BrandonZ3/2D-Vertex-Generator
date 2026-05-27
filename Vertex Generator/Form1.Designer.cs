namespace Vertex_Generator
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RadiusDevl = new System.Windows.Forms.Label();
            this.RadiusDev = new System.Windows.Forms.TextBox();
            this.OffsetYl = new System.Windows.Forms.Label();
            this.OffsetY = new System.Windows.Forms.TextBox();
            this.OffsetXl = new System.Windows.Forms.Label();
            this.OffsetX = new System.Windows.Forms.TextBox();
            this.Width2l = new System.Windows.Forms.Label();
            this.Width2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.VertexMeshType = new System.Windows.Forms.ComboBox();
            this.Width1l = new System.Windows.Forms.Label();
            this.Width1 = new System.Windows.Forms.TextBox();
            this.OutRadDevl = new System.Windows.Forms.Label();
            this.OutRadDev = new System.Windows.Forms.TextBox();
            this.InnRadDevl = new System.Windows.Forms.Label();
            this.InnRadDev = new System.Windows.Forms.TextBox();
            this.OutRadl = new System.Windows.Forms.Label();
            this.OutRad = new System.Windows.Forms.TextBox();
            this.InnRadl = new System.Windows.Forms.Label();
            this.InnRad = new System.Windows.Forms.TextBox();
            this.Radiusl = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
            this.IPointsl = new System.Windows.Forms.Label();
            this.IPoints = new System.Windows.Forms.TextBox();
            this.EndAnglel = new System.Windows.Forms.Label();
            this.EndAngle = new System.Windows.Forms.TextBox();
            this.StartAnglel = new System.Windows.Forms.Label();
            this.StartAngle = new System.Windows.Forms.TextBox();
            this.Anglel = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TextBox();
            this.Y3l = new System.Windows.Forms.Label();
            this.Y3 = new System.Windows.Forms.TextBox();
            this.X3l = new System.Windows.Forms.Label();
            this.X3 = new System.Windows.Forms.TextBox();
            this.X2l = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.Y2l = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y1l = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X1l = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.TriAdd = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScale = new System.Windows.Forms.Label();
            this.tBScaling = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Import";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy Data To Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(8, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(226, 410);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblScale);
            this.tabPage2.Controls.Add(this.tBScaling);
            this.tabPage2.Controls.Add(this.RadiusDevl);
            this.tabPage2.Controls.Add(this.RadiusDev);
            this.tabPage2.Controls.Add(this.OffsetYl);
            this.tabPage2.Controls.Add(this.OffsetY);
            this.tabPage2.Controls.Add(this.OffsetXl);
            this.tabPage2.Controls.Add(this.OffsetX);
            this.tabPage2.Controls.Add(this.Width2l);
            this.tabPage2.Controls.Add(this.Width2);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.VertexMeshType);
            this.tabPage2.Controls.Add(this.Width1l);
            this.tabPage2.Controls.Add(this.Width1);
            this.tabPage2.Controls.Add(this.OutRadDevl);
            this.tabPage2.Controls.Add(this.OutRadDev);
            this.tabPage2.Controls.Add(this.InnRadDevl);
            this.tabPage2.Controls.Add(this.InnRadDev);
            this.tabPage2.Controls.Add(this.OutRadl);
            this.tabPage2.Controls.Add(this.OutRad);
            this.tabPage2.Controls.Add(this.InnRadl);
            this.tabPage2.Controls.Add(this.InnRad);
            this.tabPage2.Controls.Add(this.Radiusl);
            this.tabPage2.Controls.Add(this.Radius);
            this.tabPage2.Controls.Add(this.IPointsl);
            this.tabPage2.Controls.Add(this.IPoints);
            this.tabPage2.Controls.Add(this.EndAnglel);
            this.tabPage2.Controls.Add(this.EndAngle);
            this.tabPage2.Controls.Add(this.StartAnglel);
            this.tabPage2.Controls.Add(this.StartAngle);
            this.tabPage2.Controls.Add(this.Anglel);
            this.tabPage2.Controls.Add(this.Angle);
            this.tabPage2.Controls.Add(this.Y3l);
            this.tabPage2.Controls.Add(this.Y3);
            this.tabPage2.Controls.Add(this.X3l);
            this.tabPage2.Controls.Add(this.X3);
            this.tabPage2.Controls.Add(this.X2l);
            this.tabPage2.Controls.Add(this.Y2);
            this.tabPage2.Controls.Add(this.Y2l);
            this.tabPage2.Controls.Add(this.X2);
            this.tabPage2.Controls.Add(this.Y1l);
            this.tabPage2.Controls.Add(this.Y1);
            this.tabPage2.Controls.Add(this.X1l);
            this.tabPage2.Controls.Add(this.X1);
            this.tabPage2.Controls.Add(this.TriAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Basics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RadiusDevl
            // 
            this.RadiusDevl.AutoSize = true;
            this.RadiusDevl.Location = new System.Drawing.Point(268, 98);
            this.RadiusDevl.Name = "RadiusDevl";
            this.RadiusDevl.Size = new System.Drawing.Size(88, 13);
            this.RadiusDevl.TabIndex = 42;
            this.RadiusDevl.Text = "Radius Deviation";
            // 
            // RadiusDev
            // 
            this.RadiusDev.Location = new System.Drawing.Point(268, 114);
            this.RadiusDev.Name = "RadiusDev";
            this.RadiusDev.Size = new System.Drawing.Size(100, 20);
            this.RadiusDev.TabIndex = 41;
            this.RadiusDev.Text = "0";
            // 
            // OffsetYl
            // 
            this.OffsetYl.AutoSize = true;
            this.OffsetYl.Location = new System.Drawing.Point(481, 98);
            this.OffsetYl.Name = "OffsetYl";
            this.OffsetYl.Size = new System.Drawing.Size(45, 13);
            this.OffsetYl.TabIndex = 40;
            this.OffsetYl.Text = "Offset Y";
            // 
            // OffsetY
            // 
            this.OffsetY.Location = new System.Drawing.Point(481, 114);
            this.OffsetY.Name = "OffsetY";
            this.OffsetY.Size = new System.Drawing.Size(100, 20);
            this.OffsetY.TabIndex = 39;
            this.OffsetY.Text = "0";
            // 
            // OffsetXl
            // 
            this.OffsetXl.AutoSize = true;
            this.OffsetXl.Location = new System.Drawing.Point(481, 55);
            this.OffsetXl.Name = "OffsetXl";
            this.OffsetXl.Size = new System.Drawing.Size(45, 13);
            this.OffsetXl.TabIndex = 38;
            this.OffsetXl.Text = "Offset X";
            // 
            // OffsetX
            // 
            this.OffsetX.Location = new System.Drawing.Point(481, 71);
            this.OffsetX.Name = "OffsetX";
            this.OffsetX.Size = new System.Drawing.Size(100, 20);
            this.OffsetX.TabIndex = 37;
            this.OffsetX.Text = "0";
            // 
            // Width2l
            // 
            this.Width2l.AutoSize = true;
            this.Width2l.Location = new System.Drawing.Point(375, 98);
            this.Width2l.Name = "Width2l";
            this.Width2l.Size = new System.Drawing.Size(41, 13);
            this.Width2l.TabIndex = 36;
            this.Width2l.Text = "Width2";
            // 
            // Width2
            // 
            this.Width2.Location = new System.Drawing.Point(375, 114);
            this.Width2.Name = "Width2";
            this.Width2.Size = new System.Drawing.Size(100, 20);
            this.Width2.TabIndex = 35;
            this.Width2.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Type";
            // 
            // VertexMeshType
            // 
            this.VertexMeshType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VertexMeshType.FormattingEnabled = true;
            this.VertexMeshType.Items.AddRange(new object[] {
            "Curve1",
            "Curve2",
            "Circle1",
            "Line1",
            "Triangle1"});
            this.VertexMeshType.Location = new System.Drawing.Point(57, 31);
            this.VertexMeshType.Name = "VertexMeshType";
            this.VertexMeshType.Size = new System.Drawing.Size(418, 21);
            this.VertexMeshType.TabIndex = 33;
            this.VertexMeshType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Width1l
            // 
            this.Width1l.AutoSize = true;
            this.Width1l.Location = new System.Drawing.Point(375, 55);
            this.Width1l.Name = "Width1l";
            this.Width1l.Size = new System.Drawing.Size(41, 13);
            this.Width1l.TabIndex = 32;
            this.Width1l.Text = "Width1";
            // 
            // Width1
            // 
            this.Width1.Location = new System.Drawing.Point(375, 71);
            this.Width1.Name = "Width1";
            this.Width1.Size = new System.Drawing.Size(100, 20);
            this.Width1.TabIndex = 31;
            this.Width1.Text = "0";
            // 
            // OutRadDevl
            // 
            this.OutRadDevl.AutoSize = true;
            this.OutRadDevl.Location = new System.Drawing.Point(269, 270);
            this.OutRadDevl.Name = "OutRadDevl";
            this.OutRadDevl.Size = new System.Drawing.Size(101, 13);
            this.OutRadDevl.TabIndex = 30;
            this.OutRadDevl.Text = "Out. Rad. Deviation";
            // 
            // OutRadDev
            // 
            this.OutRadDev.Location = new System.Drawing.Point(269, 286);
            this.OutRadDev.Name = "OutRadDev";
            this.OutRadDev.Size = new System.Drawing.Size(100, 20);
            this.OutRadDev.TabIndex = 29;
            this.OutRadDev.Text = "0";
            // 
            // InnRadDevl
            // 
            this.InnRadDevl.AutoSize = true;
            this.InnRadDevl.Location = new System.Drawing.Point(269, 184);
            this.InnRadDevl.Name = "InnRadDevl";
            this.InnRadDevl.Size = new System.Drawing.Size(99, 13);
            this.InnRadDevl.TabIndex = 28;
            this.InnRadDevl.Text = "Inn. Rad. Deviation";
            // 
            // InnRadDev
            // 
            this.InnRadDev.Location = new System.Drawing.Point(269, 200);
            this.InnRadDev.Name = "InnRadDev";
            this.InnRadDev.Size = new System.Drawing.Size(100, 20);
            this.InnRadDev.TabIndex = 27;
            this.InnRadDev.Text = "0";
            // 
            // OutRadl
            // 
            this.OutRadl.AutoSize = true;
            this.OutRadl.Location = new System.Drawing.Point(269, 227);
            this.OutRadl.Name = "OutRadl";
            this.OutRadl.Size = new System.Drawing.Size(69, 13);
            this.OutRadl.TabIndex = 26;
            this.OutRadl.Text = "Outer Radius";
            // 
            // OutRad
            // 
            this.OutRad.Location = new System.Drawing.Point(269, 243);
            this.OutRad.Name = "OutRad";
            this.OutRad.Size = new System.Drawing.Size(100, 20);
            this.OutRad.TabIndex = 25;
            this.OutRad.Text = "0";
            // 
            // InnRadl
            // 
            this.InnRadl.AutoSize = true;
            this.InnRadl.Location = new System.Drawing.Point(269, 141);
            this.InnRadl.Name = "InnRadl";
            this.InnRadl.Size = new System.Drawing.Size(67, 13);
            this.InnRadl.TabIndex = 24;
            this.InnRadl.Text = "Inner Radius";
            // 
            // InnRad
            // 
            this.InnRad.Location = new System.Drawing.Point(269, 157);
            this.InnRad.Name = "InnRad";
            this.InnRad.Size = new System.Drawing.Size(100, 20);
            this.InnRad.TabIndex = 23;
            this.InnRad.Text = "0";
            // 
            // Radiusl
            // 
            this.Radiusl.AutoSize = true;
            this.Radiusl.Location = new System.Drawing.Point(269, 55);
            this.Radiusl.Name = "Radiusl";
            this.Radiusl.Size = new System.Drawing.Size(40, 13);
            this.Radiusl.TabIndex = 22;
            this.Radiusl.Text = "Radius";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(269, 71);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(100, 20);
            this.Radius.TabIndex = 21;
            this.Radius.Text = "0";
            // 
            // IPointsl
            // 
            this.IPointsl.AutoSize = true;
            this.IPointsl.Location = new System.Drawing.Point(375, 270);
            this.IPointsl.Name = "IPointsl";
            this.IPointsl.Size = new System.Drawing.Size(97, 13);
            this.IPointsl.TabIndex = 20;
            this.IPointsl.Text = "Intermediate Points";
            // 
            // IPoints
            // 
            this.IPoints.Location = new System.Drawing.Point(375, 286);
            this.IPoints.Name = "IPoints";
            this.IPoints.Size = new System.Drawing.Size(100, 20);
            this.IPoints.TabIndex = 19;
            this.IPoints.Text = "0";
            // 
            // EndAnglel
            // 
            this.EndAnglel.AutoSize = true;
            this.EndAnglel.Location = new System.Drawing.Point(163, 141);
            this.EndAnglel.Name = "EndAnglel";
            this.EndAnglel.Size = new System.Drawing.Size(56, 13);
            this.EndAnglel.TabIndex = 18;
            this.EndAnglel.Text = "End Angle";
            // 
            // EndAngle
            // 
            this.EndAngle.Location = new System.Drawing.Point(163, 157);
            this.EndAngle.Name = "EndAngle";
            this.EndAngle.Size = new System.Drawing.Size(100, 20);
            this.EndAngle.TabIndex = 17;
            this.EndAngle.Text = "0";
            // 
            // StartAnglel
            // 
            this.StartAnglel.AutoSize = true;
            this.StartAnglel.Location = new System.Drawing.Point(163, 98);
            this.StartAnglel.Name = "StartAnglel";
            this.StartAnglel.Size = new System.Drawing.Size(59, 13);
            this.StartAnglel.TabIndex = 16;
            this.StartAnglel.Text = "Start Angle";
            // 
            // StartAngle
            // 
            this.StartAngle.Location = new System.Drawing.Point(163, 114);
            this.StartAngle.Name = "StartAngle";
            this.StartAngle.Size = new System.Drawing.Size(100, 20);
            this.StartAngle.TabIndex = 15;
            this.StartAngle.Text = "0";
            // 
            // Anglel
            // 
            this.Anglel.AutoSize = true;
            this.Anglel.Location = new System.Drawing.Point(163, 55);
            this.Anglel.Name = "Anglel";
            this.Anglel.Size = new System.Drawing.Size(34, 13);
            this.Anglel.TabIndex = 14;
            this.Anglel.Text = "Angle";
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(163, 71);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(100, 20);
            this.Angle.TabIndex = 13;
            this.Angle.Text = "0";
            // 
            // Y3l
            // 
            this.Y3l.AutoSize = true;
            this.Y3l.Location = new System.Drawing.Point(57, 270);
            this.Y3l.Name = "Y3l";
            this.Y3l.Size = new System.Drawing.Size(20, 13);
            this.Y3l.TabIndex = 12;
            this.Y3l.Text = "Y3";
            // 
            // Y3
            // 
            this.Y3.Location = new System.Drawing.Point(57, 286);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(100, 20);
            this.Y3.TabIndex = 11;
            this.Y3.Text = "0";
            // 
            // X3l
            // 
            this.X3l.AutoSize = true;
            this.X3l.Location = new System.Drawing.Point(57, 227);
            this.X3l.Name = "X3l";
            this.X3l.Size = new System.Drawing.Size(20, 13);
            this.X3l.TabIndex = 10;
            this.X3l.Text = "X3";
            // 
            // X3
            // 
            this.X3.Location = new System.Drawing.Point(57, 243);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(100, 20);
            this.X3.TabIndex = 9;
            this.X3.Text = "0";
            // 
            // X2l
            // 
            this.X2l.AutoSize = true;
            this.X2l.Location = new System.Drawing.Point(57, 141);
            this.X2l.Name = "X2l";
            this.X2l.Size = new System.Drawing.Size(20, 13);
            this.X2l.TabIndex = 8;
            this.X2l.Text = "X2";
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(57, 200);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(100, 20);
            this.Y2.TabIndex = 7;
            this.Y2.Text = "0";
            // 
            // Y2l
            // 
            this.Y2l.AutoSize = true;
            this.Y2l.Location = new System.Drawing.Point(57, 184);
            this.Y2l.Name = "Y2l";
            this.Y2l.Size = new System.Drawing.Size(20, 13);
            this.Y2l.TabIndex = 6;
            this.Y2l.Text = "Y2";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(57, 157);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(100, 20);
            this.X2.TabIndex = 5;
            this.X2.Text = "0";
            // 
            // Y1l
            // 
            this.Y1l.AutoSize = true;
            this.Y1l.Location = new System.Drawing.Point(57, 98);
            this.Y1l.Name = "Y1l";
            this.Y1l.Size = new System.Drawing.Size(20, 13);
            this.Y1l.TabIndex = 4;
            this.Y1l.Text = "Y1";
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(57, 114);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(100, 20);
            this.Y1.TabIndex = 3;
            this.Y1.Text = "0";
            // 
            // X1l
            // 
            this.X1l.AutoSize = true;
            this.X1l.Location = new System.Drawing.Point(57, 55);
            this.X1l.Name = "X1l";
            this.X1l.Size = new System.Drawing.Size(20, 13);
            this.X1l.TabIndex = 2;
            this.X1l.Text = "X1";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(57, 71);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 20);
            this.X1.TabIndex = 1;
            this.X1.Text = "0";
            // 
            // TriAdd
            // 
            this.TriAdd.Location = new System.Drawing.Point(57, 334);
            this.TriAdd.Name = "TriAdd";
            this.TriAdd.Size = new System.Drawing.Size(677, 62);
            this.TriAdd.TabIndex = 0;
            this.TriAdd.Text = "Add";
            this.TriAdd.UseVisualStyleBackColor = true;
            this.TriAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.shiftUpToolStripMenuItem,
            this.shiftDownToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 92);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // shiftUpToolStripMenuItem
            // 
            this.shiftUpToolStripMenuItem.Name = "shiftUpToolStripMenuItem";
            this.shiftUpToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.shiftUpToolStripMenuItem.Text = "Shift Up";
            this.shiftUpToolStripMenuItem.Click += new System.EventHandler(this.shiftUpToolStripMenuItem_Click);
            // 
            // shiftDownToolStripMenuItem
            // 
            this.shiftDownToolStripMenuItem.Name = "shiftDownToolStripMenuItem";
            this.shiftDownToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.shiftDownToolStripMenuItem.Text = "Shift Down";
            this.shiftDownToolStripMenuItem.Click += new System.EventHandler(this.shiftDownToolStripMenuItem_Click);
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(484, 15);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(42, 13);
            this.lblScale.TabIndex = 44;
            this.lblScale.Text = "Scaling";
            // 
            // tBScaling
            // 
            this.tBScaling.Location = new System.Drawing.Point(484, 31);
            this.tBScaling.Name = "tBScaling";
            this.tBScaling.Size = new System.Drawing.Size(100, 20);
            this.tBScaling.TabIndex = 43;
            this.tBScaling.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "2D Vertex Generator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Y1l;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.Label X1l;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Button TriAdd;
        private System.Windows.Forms.Label Width1l;
        private System.Windows.Forms.TextBox Width1;
        private System.Windows.Forms.Label OutRadDevl;
        private System.Windows.Forms.TextBox OutRadDev;
        private System.Windows.Forms.Label InnRadDevl;
        private System.Windows.Forms.TextBox InnRadDev;
        private System.Windows.Forms.Label OutRadl;
        private System.Windows.Forms.TextBox OutRad;
        private System.Windows.Forms.Label InnRadl;
        private System.Windows.Forms.TextBox InnRad;
        private System.Windows.Forms.Label Radiusl;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Label IPointsl;
        private System.Windows.Forms.TextBox IPoints;
        private System.Windows.Forms.Label EndAnglel;
        private System.Windows.Forms.TextBox EndAngle;
        private System.Windows.Forms.Label StartAnglel;
        private System.Windows.Forms.TextBox StartAngle;
        private System.Windows.Forms.Label Anglel;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Label Y3l;
        private System.Windows.Forms.TextBox Y3;
        private System.Windows.Forms.Label X3l;
        private System.Windows.Forms.TextBox X3;
        private System.Windows.Forms.Label X2l;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.Label Y2l;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox VertexMeshType;
        private System.Windows.Forms.Label Width2l;
        private System.Windows.Forms.TextBox Width2;
        private System.Windows.Forms.Label OffsetYl;
        private System.Windows.Forms.TextBox OffsetY;
        private System.Windows.Forms.Label OffsetXl;
        private System.Windows.Forms.TextBox OffsetX;
        private System.Windows.Forms.Label RadiusDevl;
        private System.Windows.Forms.TextBox RadiusDev;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftDownToolStripMenuItem;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.TextBox tBScaling;
    }
}

