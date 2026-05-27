using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vertex_Generator
{
    public partial class Form1 : Form
    {
        TreeNodeCustom workingNode = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = "static positions = [\r\n";

            foreach(TreeNodeCustom node in treeView1.Nodes)
            {
                var mesh = node.mesh;

                foreach(double[] point in mesh.vertices)
                {
                    data += point[0].ToString() + ", " + point[1].ToString() + ", ";
                }
            }

            data += "\r\n]\r\nstatic sections = [\r\n";

            foreach (TreeNodeCustom node in treeView1.Nodes)
            {
                data += "{count:" + (node.mesh.vertices.Count).ToString() + ", offsetX:" + node.mesh.offsetX.ToString() + ", offsetY:" + node.mesh.offsetY.ToString() + "},\r\n";
            }
            data += "\r\n]\r\n";

            Clipboard.SetText(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private List<double[]> CreateTriangleMesh(double[] point1, double[] point2, double[] point3)
        {
            var output = new List<double[]>();

            output.Add(point1);
            output.Add(point2);
            output.Add(point3);

            return output;
        }

        private List<double[]> CreateLineMesh(double width, double[] point)
        {
            width = width / 2;
            var output = new List<double[]>();

            var angle = GetRotation(point);

            double[] rotated = RotatePoint(point, angle * -1);

            var points = new List<double[]>();

            points.Add(new double[] { -width, width });
            points.Add(new double[] { -width, -width });
            points.Add(new double[] { rotated[0] + width, width });
            points.Add(new double[] { rotated[0] + width, -width });

            for(var i = 0; i < points.Count; i++)
            {
                points[i] = RotatePoint(points[i], angle);
            }

            output = new List<double[]> { points[0], points[1], points[3], points[3], points[2], points[0]};

            return output;
        }

        private List<double[]> CreateCurveMesh(double innerRadius, double innerRadiusDev, double outerRadius, double outerRadiusDev, double startAngle, double endAngle, double innerPoints)
        {
            var output = new List<double[]>();

            var angleChange = (endAngle - startAngle) / (innerPoints + 1);
            var inChange = innerRadiusDev / (innerPoints + 1);
            var outChange = outerRadiusDev / (innerPoints + 1);

            var points1 = new List<double[]>();
            var points2 = new List<double[]>();

            for (int i = 0; i < innerPoints + 2; i++)
            {
                points1.Add(RotatePoint(new double[] { outerRadius + (outChange * i), 0 }, ((i * angleChange) % (Math.PI * 2)) + startAngle));
                points2.Add(RotatePoint(new double[] { innerRadius + (inChange * i), 0 }, ((i * angleChange % (Math.PI * 2))) + startAngle));
            }

            var innerIndex = 0;
            var outerIndex = 0;

            while(innerIndex < points2.Count - 1)
            {
                output.Add(points1[outerIndex]);
                output.Add(points1[outerIndex + 1]);
                output.Add(points2[innerIndex + 1]);

                output.Add(points2[innerIndex + 1]);
                output.Add(points2[innerIndex]);
                output.Add(points1[outerIndex]);

                innerIndex++;
                outerIndex++;
            }

            return output;
        }

        private List<double[]> CreateCurveMesh(double width1, double width2, double radius, double startAngle, double endAngle, double innerPoints)
        {
            var innerRadius = radius - (width1 / 2);
            var outerRadius = radius + (width1 / 2);
            var innerRadiusDev = ((width2 - width1) / 2) * -1;
            var outerRadiusDev = (width2 - width1) / 2;

            var output = new List<double[]>();

            var angleChange = (endAngle -  startAngle) / (innerPoints + 1);
            var inChange = innerRadiusDev / (innerPoints + 1);
            var outChange = outerRadiusDev / (innerPoints + 1);

            var points1 = new List<double[]>();
            var points2 = new List<double[]>();

            for (int i = 0; i < innerPoints + 2; i++)
            {
                points1.Add(RotatePoint(new double[] { outerRadius + (outChange * i), 0 }, (i * angleChange) + startAngle));
                points2.Add(RotatePoint(new double[] { innerRadius + (inChange * i), 0 }, (i * angleChange) + startAngle));
            }

            var innerIndex = 0;
            var outerIndex = 0;

            while (innerIndex < points2.Count - 1)
            {
                output.Add(points1[outerIndex]);
                output.Add(points1[outerIndex + 1]);
                output.Add(points2[innerIndex + 1]);

                output.Add(points2[innerIndex + 1]);
                output.Add(points2[innerIndex]);
                output.Add(points1[outerIndex]);

                innerIndex++;
                outerIndex++;
            }

            return output;
        }

        private List<double[]> CreateCircleMesh(double radius, double radiusDev, double startAngle, double endAngle, double innerPoints)
        {
            var output = new List<double[]>();

            var angleChange = (endAngle - startAngle) / (innerPoints + 1);
            var inChange = radiusDev / (innerPoints + 1);

            var points1 = new List<double[]>();

            for (int i = 0; i < innerPoints + 2; i++)
            {
                points1.Add(RotatePoint(new double[] { radius + (inChange * i), 0 }, (i * angleChange) + startAngle));
            }

            var index = 0;

            while (index < points1.Count - 1)
            {
                output.Add(points1[index]);
                output.Add(points1[index + 1]);
                output.Add(new double[] {0,0});

                index++;
            }

            return output;
        }

        private double GetRotation(double[] point)
        {
            double hyp = Math.Sqrt((point[0] * point[0]) + (point[1] * point[1]));
            double angleC = Math.Acos(point[0] / hyp);
            double angleS = Math.Asin(point[1] / hyp);

            var angle = angleC;

            if(angleC > (Math.PI / 2) && angleS < 0)
            {
                angle = Math.PI - angleS;
            }

            if (angleC <= (Math.PI / 2) && angleS < 0)
            {
                angle = angleS;
            }

            return angle;
        }

        private double[] RotatePoint(double[] point, double rad)
        {
            return new double[]{ 
                                    (Math.Cos(rad) * point[0]) - (Math.Sin(rad) * point[1]),
                                    (Math.Sin(rad) * point[0]) + (Math.Cos(rad) * point[1])
                                };
            
        }

        private string GetOpenName(string baseName)
        {
            var currentValue = 0;
            foreach (TreeNodeCustom node in treeView1.Nodes)
            {
                if (node.Text.Contains(baseName))
                {
                    var index = baseName.Length;
                    var start = -1;
                    var end = -1;
                    while (index < node.Text.Length)
                    {
                        var numeric = node.Text[index] >= 0x30 && node.Text[index] <= 0x39;

                        if (numeric && start == -1)
                        {
                            start = index;
                        }

                        if (numeric)
                        {
                            end = index;
                            break;
                        }
                    }

                    if (start != -1 && end != -1)
                    {
                        int value = int.Parse(node.Text.Substring(start, (end - start) + 1));

                        if(value > currentValue)
                            currentValue = value + 1;
                    }
                }
            }
            return baseName + currentValue.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            double Scaling = tBScaling.Text != "" ? double.Parse(tBScaling.Text) : 1;
            double x1 = double.Parse(X1.Text) * Scaling;
            double x2 = double.Parse(X2.Text) * Scaling;
            double x3 = double.Parse(X3.Text) * Scaling;
            double y1 = double.Parse(Y1.Text) * Scaling;
            double y2 = double.Parse(Y2.Text) * Scaling;
            double y3 = double.Parse(Y3.Text) * Scaling;
            double angle = double.Parse(Angle.Text);
            double startAngle = double.Parse(StartAngle.Text);
            double endAngle = double.Parse(EndAngle.Text);
            double radius = double.Parse(Radius.Text) * Scaling;
            double radiusDev = double.Parse(RadiusDev.Text) * Scaling;
            double innerRadius = double.Parse(InnRad.Text) * Scaling;
            double innerRadiusDev = double.Parse(InnRadDev.Text) * Scaling;
            double outerRadius = double.Parse(OutRad.Text) * Scaling;
            double outerRadiusDev = double.Parse(OutRadDev.Text) * Scaling;
            double width1 = double.Parse(Width1.Text) * Scaling;
            double width2 = double.Parse(Width2.Text) * Scaling;
            double innerPoints = double.Parse(IPoints.Text);
            double offsetX = double.Parse(OffsetX.Text) * Scaling;
            double offsetY = double.Parse(OffsetY.Text) * Scaling;

            angle = angle * (Math.PI/180);
            startAngle = startAngle * (Math.PI / 180);
            endAngle = endAngle * (Math.PI / 180);

            if (VertexMeshType.SelectedItem != null)
            {
                var type = (VertexMeshType.SelectedItem as string).ToLower().Trim();

                switch (type)
                {
                    case "curve1":
                        {
                            Mesh mesh = new Mesh();
                            mesh.vertices = CreateCurveMesh(innerRadius, innerRadiusDev, outerRadius, outerRadiusDev, startAngle, endAngle, innerPoints);
                            mesh.innerRadius = innerRadius;
                            mesh.innerRadiusDev = innerRadiusDev;
                            mesh.outerRadius = outerRadius;
                            mesh.outerRadiusDev = outerRadiusDev;
                            mesh.startAngle = startAngle;
                            mesh.endAngle = endAngle;
                            mesh.innerPoints = innerPoints;

                            mesh.offsetX = offsetX;
                            mesh.offsetY = offsetY;

                            var name = GetOpenName("Curve1");

                            TreeNodeCustom newNode = new TreeNodeCustom(name, mesh);

                            treeView1.Nodes.Add(newNode);

                            break;
                        }
                    case "curve2":
                        {
                            Mesh mesh = new Mesh();
                            mesh.vertices = CreateCurveMesh(width1, width2, radius, startAngle, endAngle, innerPoints);
                            mesh.width1 = width1;
                            mesh.width2 = width2;
                            mesh.radius = radius;
                            mesh.startAngle = startAngle;
                            mesh.endAngle = endAngle;
                            mesh.innerPoints = innerPoints;

                            mesh.offsetX = offsetX;
                            mesh.offsetY = offsetY;

                            var name = GetOpenName("Curve2");

                            TreeNodeCustom newNode = new TreeNodeCustom(name, mesh);

                            treeView1.Nodes.Add(newNode);

                            break;
                        }
                    case "circle1":
                        {
                            Mesh mesh = new Mesh();
                            mesh.vertices = CreateCircleMesh(radius, radiusDev, startAngle, endAngle, innerPoints);
                            mesh.radius = radius;
                            mesh.radiusDev = radiusDev;
                            mesh.startAngle = startAngle;
                            mesh.endAngle = endAngle;
                            mesh.innerPoints = innerPoints;

                            mesh.offsetX = offsetX;
                            mesh.offsetY = offsetY;

                            var name = GetOpenName("Circle1");

                            TreeNodeCustom newNode = new TreeNodeCustom(name, mesh);

                            treeView1.Nodes.Add(newNode);

                            break;
                        }
                    case "line1":
                        {
                            Mesh mesh = new Mesh();
                            mesh.vertices = CreateLineMesh(width1, new double[] {x1, y1});
                            mesh.width1 = width1;
                            mesh.x1 = x1;
                            mesh.y1 = y1;

                            mesh.offsetX = offsetX;
                            mesh.offsetY = offsetY;

                            var name = GetOpenName("Line1");

                            TreeNodeCustom newNode = new TreeNodeCustom(name, mesh);

                            treeView1.Nodes.Add(newNode);

                            break;
                        }
                    case "triangle1":
                        {
                            Mesh mesh = new Mesh();
                            mesh.vertices = CreateTriangleMesh(new double[] {x1, y1}, new double[] {x2, y2}, new double[] {x3, y3});
                            mesh.x1 = x1;
                            mesh.x2 = x2;
                            mesh.x3 = x3;
                            mesh.y1 = y1;
                            mesh.y2 = y2;
                            mesh.y3 = y3;

                            mesh.offsetX = offsetX;
                            mesh.offsetY = offsetY;

                            var name = GetOpenName("Triangle1");

                            TreeNodeCustom newNode = new TreeNodeCustom(name, mesh);

                            treeView1.Nodes.Add(newNode);

                            break;
                        }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = (VertexMeshType.SelectedItem as string).ToLower().Trim();

            switch (value)
            {
                case "curve1":
                    {
                        X1.Visible = false;
                        X1l.Visible = false;
                        X2.Visible = false;
                        X2l.Visible = false;
                        X3.Visible = false;
                        X3l.Visible = false;
                        Y1.Visible = false;
                        Y1l.Visible = false;
                        Y2.Visible = false;
                        Y2l.Visible = false;
                        Y3.Visible = false;
                        Y3l.Visible = false;
                        Angle.Visible = false;
                        Anglel.Visible = false;
                        StartAngle.Visible = true;
                        StartAnglel.Visible = true;
                        EndAngle.Visible = true;
                        EndAnglel.Visible = true;
                        Radius.Visible = false;
                        Radiusl.Visible = false;
                        RadiusDev.Visible = false;
                        RadiusDevl.Visible = false;
                        InnRad.Visible = true;
                        InnRadl.Visible = true;
                        InnRadDev.Visible = true;
                        InnRadDevl.Visible = true;
                        OutRad.Visible = true;
                        OutRadl.Visible = true;
                        OutRadDev.Visible = true;
                        OutRadDevl.Visible = true;
                        Width1.Visible = false;
                        Width1l.Visible = false;
                        Width2.Visible = false;
                        Width2l.Visible = false;
                        IPoints.Visible = true;
                        IPointsl.Visible = true;
                        break;
                    }
                case "curve2":
                    {
                        X1.Visible = false;
                        X1l.Visible = false;
                        X2.Visible = false;
                        X2l.Visible = false;
                        X3.Visible = false;
                        X3l.Visible = false;
                        Y1.Visible = false;
                        Y1l.Visible = false;
                        Y2.Visible = false;
                        Y2l.Visible = false;
                        Y3.Visible = false;
                        Y3l.Visible = false;
                        Angle.Visible = false;
                        Anglel.Visible = false;
                        StartAngle.Visible = true;
                        StartAnglel.Visible = true;
                        EndAngle.Visible = true;
                        EndAnglel.Visible = true;
                        Radius.Visible = true;
                        Radiusl.Visible = true;
                        RadiusDev.Visible = false;
                        RadiusDevl.Visible = false;
                        InnRad.Visible = false;
                        InnRadl.Visible = false;
                        InnRadDev.Visible = false;
                        InnRadDevl.Visible = false;
                        OutRad.Visible = false;
                        OutRadl.Visible = false;
                        OutRadDev.Visible = false;
                        OutRadDevl.Visible = false;
                        Width1.Visible = true;
                        Width1l.Visible = true;
                        Width2.Visible = true;
                        Width2l.Visible = true;
                        IPoints.Visible = true;
                        IPointsl.Visible = true;
                        break;
                    }
                case "circle1":
                    {
                        X1.Visible = false;
                        X1l.Visible = false;
                        X2.Visible = false;
                        X2l.Visible = false;
                        X3.Visible = false;
                        X3l.Visible = false;
                        Y1.Visible = false;
                        Y1l.Visible = false;
                        Y2.Visible = false;
                        Y2l.Visible = false;
                        Y3.Visible = false;
                        Y3l.Visible = false;
                        Angle.Visible = false;
                        Anglel.Visible = false;
                        StartAngle.Visible = true;
                        StartAnglel.Visible = true;
                        EndAngle.Visible = true;
                        EndAnglel.Visible = true;
                        Radius.Visible = true;
                        Radiusl.Visible = true;
                        RadiusDev.Visible = true;
                        RadiusDevl.Visible = true;
                        InnRad.Visible = false;
                        InnRadl.Visible = false;
                        InnRadDev.Visible = false;
                        InnRadDevl.Visible = false;
                        OutRad.Visible = false;
                        OutRadl.Visible = false;
                        OutRadDev.Visible = false;
                        OutRadDevl.Visible = false;
                        Width1.Visible = false;
                        Width1l.Visible = false;
                        Width2.Visible = false;
                        Width2l.Visible = false;
                        IPoints.Visible = true;
                        IPointsl.Visible = true;
                        break;
                    }
                case "line1":
                    {
                        X1.Visible = true;
                        X1l.Visible = true;
                        X2.Visible = false;
                        X2l.Visible = false;
                        X3.Visible = false;
                        X3l.Visible = false;
                        Y1.Visible = true;
                        Y1l.Visible = true;
                        Y2.Visible = false;
                        Y2l.Visible = false;
                        Y3.Visible = false;
                        Y3l.Visible = false;
                        Angle.Visible = false;
                        Anglel.Visible = false;
                        StartAngle.Visible = false;
                        StartAnglel.Visible = false;
                        EndAngle.Visible = false;
                        EndAnglel.Visible = false;
                        Radius.Visible = false;
                        Radiusl.Visible = false;
                        RadiusDev.Visible = false;
                        RadiusDevl.Visible = false;
                        InnRad.Visible = false;
                        InnRadl.Visible = false;
                        InnRadDev.Visible = false;
                        InnRadDev.Visible = false;
                        OutRad.Visible = false;
                        OutRadl.Visible = false;
                        OutRadDev.Visible = false;
                        OutRadDevl.Visible = false;
                        Width1.Visible = true;
                        Width1l.Visible = true;
                        Width2.Visible = false;
                        Width2l.Visible = false;
                        IPoints.Visible = false;
                        IPoints.Visible = false;
                        break;
                    }
                case "triangle1":
                    {
                        X1.Visible = true;
                        X1l.Visible = true;
                        X2.Visible = true;
                        X2l.Visible = true;
                        X3.Visible = true;
                        X3l.Visible = true;
                        Y1.Visible = true;
                        Y1l.Visible = true;
                        Y2.Visible = true;
                        Y2l.Visible = true;
                        Y3.Visible = true;
                        Y3l.Visible = true;
                        Angle.Visible = false;
                        Anglel.Visible = false;
                        StartAngle.Visible = false;
                        StartAngle.Visible = false;
                        EndAngle.Visible = false;
                        EndAnglel.Visible = false;
                        Radius.Visible = false;
                        Radiusl.Visible = false;
                        RadiusDev.Visible = false;
                        RadiusDevl.Visible = false;
                        InnRad.Visible = false;
                        InnRadl.Visible = false;
                        InnRadDev.Visible = false;
                        InnRadDevl.Visible = false;
                        OutRad.Visible = false;
                        OutRadl.Visible = false;
                        OutRadDev.Visible = false;
                        OutRadDevl.Visible = false;
                        Width1.Visible = false;
                        Width1l.Visible = false;
                        Width2.Visible = false;
                        Width2l.Visible = false;
                        IPoints.Visible = false;
                        IPointsl.Visible = false;
                        break;
                    }
            }
        }

        private void treeView1_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            workingNode = e.Node as TreeNodeCustom;
            contextMenuStrip1.Show(treeView1, e.Location);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(workingNode != null)
                treeView1.Nodes.Remove(workingNode);
            workingNode = null;
        }

        private void shiftUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNodeCustom node1 = workingNode;

            var ind = treeView1.Nodes.IndexOf(workingNode);

            if(ind != 0)
            {
                TreeNodeCustom node2 = treeView1.Nodes[ind - 1] as TreeNodeCustom;

                treeView1.Nodes.Remove(node1);
                treeView1.Nodes.Remove(node2);

                treeView1.Nodes.Insert(ind - 1, node1);
                treeView1.Nodes.Insert(ind, node2);
            }
        }

        private void shiftDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNodeCustom node1 = workingNode;

            var ind = treeView1.Nodes.IndexOf(workingNode);

            if (ind != treeView1.Nodes.Count - 1)
            {
                TreeNodeCustom node2 = treeView1.Nodes[ind + 1] as TreeNodeCustom;

                treeView1.Nodes.Remove(node1);
                treeView1.Nodes.Remove(node2);

                treeView1.Nodes.Insert(ind, node2);
                treeView1.Nodes.Insert(ind + 1, node1);
            }
        }
    }

    public class Mesh
    {
        public List<double[]> vertices = new List<double[]>();
        public double x1 = 0;
        public double x2 = 0;
        public double x3 = 0;
        public double y1 = 0;
        public double y2 = 0;
        public double y3 = 0;
        public double angle = 0;
        public double startAngle = 0;
        public double endAngle = 0;
        public double radius = 0;
        public double radiusDev = 0;
        public double innerRadius = 0;
        public double innerRadiusDev = 0;
        public double outerRadius = 0;
        public double outerRadiusDev = 0;
        public double width1 = 0;
        public double width2 = 0;
        public double innerPoints = 0;
        public double offsetX = 0;
        public double offsetY = 0;
        public string type = string.Empty;
    }
    
    public class TreeNodeCustom : TreeNode
    {
        public Mesh mesh;
        public TreeNodeCustom(string text, Mesh mesh) : base(text)
        {
            this.mesh = mesh;
        }
    }
        
}
