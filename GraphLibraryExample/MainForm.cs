using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using GraphLibrary;
using ListLibrary;



namespace GraphLibraryExample
{


    public partial class MainForm : Form
    {
        Graphics panel;
        Label[] labels;
        Label prevPrevLabel = null;
        Label prevLabel = null;

        IGraph<int, int> GraphIntInt;
        IGraph<int, string> GraphIntString;
        IGraph<City, int> GraphCityInt;
        IGraph<City, string> GraphCityString;
        bool IsLinkValueVisible;

        MyType type;
        string _graphType, _nodeType, _linkType;

        private enum MyType { int_int, int_string, city_int, city_string }

        private void InitializeGraph(string graphType, string nodeType, string linkType)
        {
            _graphType = graphType;
            _nodeType = nodeType;
            _linkType = linkType;
            if (nodeType == "целочисленный")
            {
                if (linkType == "целочисленный")
                    type = MyType.int_int;
                else // linkType == "строковый"
                    type = MyType.int_string;
            }
            else // nodeType == "город"
            {
                if (linkType == "целочисленный")
                    type = MyType.city_int;
                else // linkType == "строковый"
                    type = MyType.city_string;
            }
            IsLinkValueVisible = linkType != "—";
            switch (type)
            {
                case MyType.int_int:
                    if (graphType == "массив")
                        GraphIntInt = new ArrayGraph<int, int>();
                    else
                        GraphIntInt = new LinkedGraph<int, int>();
                    break;
                case MyType.int_string:
                    if (graphType == "массив")
                        GraphIntString = new ArrayGraph<int, string>();
                    else
                        GraphIntString = new LinkedGraph<int, string>();
                    break;
                case MyType.city_int:
                    if (graphType == "массив")
                        GraphCityInt = new ArrayGraph<City, int>();
                    else
                        GraphCityInt = new LinkedGraph<City, int>();
                    break;
                case MyType.city_string:
                    if (graphType == "массив")
                        GraphCityString = new ArrayGraph<City, string>();
                    else
                        GraphCityString = new LinkedGraph<City, string>();
                    break;
            }
        }

        public MainForm(string graphType, string nodeType, string linkType)
        {
            InitializeComponent();
            InitializeGraph(graphType, nodeType, linkType);

            panel = mainPanel.CreateGraphics();
            changeLocations();
            bringToFront();
        }

        private void changeLocations()
        {
            if (type == MyType.city_int || type == MyType.city_string)
            {
                lblVertexInput1.Text = "Название:";
                lblVertexInput3.Text = "Название:";
                btnRandomVertex.Location = new Point(500, 41);
                lblFrom.Location = new Point(520, 41);
                lblTo.Location = new Point(520, 77);
                lblEdgeInput.Location = new Point(590, 41);
                rtbEdgeInput.Location = new Point(590, 77);
            }
            else
            {
                lblVertexInput1.Text = "Значение:";
                lblVertexInput3.Text = "Значение:";
                btnRandomVertex.Location = new Point(281, 41);
                lblFrom.Location = new Point(274, 41);
                lblTo.Location = new Point(274, 77);
                lblEdgeInput.Location = new Point(337, 41);
                rtbEdgeInput.Location = new Point(337, 77);
            }
        }
        private void bringToFront()
        {
            rtbAlgorithm.BringToFront();
            lblAlgorithmResult.BringToFront();
            rtbInfo.BringToFront();
            lblVertexInput1.BringToFront();
            rtbVertexInput1.BringToFront();
            lblVertexInput2.BringToFront();
            rtbVertexInput2.BringToFront();
            btnRandomVertex.BringToFront();
            lblVertexInput3.BringToFront();
            rtbVertexInput3.BringToFront();
            lblVertexInput4.BringToFront();
            rtbVertexInput4.BringToFront();
            lblFrom.BringToFront();
            lblTo.BringToFront();
            lblEdgeInput.BringToFront();
            rtbEdgeInput.BringToFront();
            lblCountVertices.BringToFront();
            lblCountEdges.BringToFront();

            btnRunAlgorithmDFSNO.BringToFront();
            btnRunAlgorithmDFSOK.BringToFront();
            btnRunAlgorithmBFSNO.BringToFront();
            btnRunAlgorithmBFSOK.BringToFront();
            btnDeleteEdgeNO.BringToFront();
            btnDeleteEdgeOK.BringToFront();
            btnAddEdgeNO.BringToFront();
            btnAddEdgeOK.BringToFront();
            btnDeleteVertexNO.BringToFront();
            btnDeleteVertexOK.BringToFront();
            btnAddVertexOK.BringToFront();
            btnAddVertexNO.BringToFront();
        }
     
        private void Draw()
        {
            if (type == MyType.int_int)
                DrawGraph<int, int>(ref GraphIntInt);
            else if (type == MyType.int_string)
                DrawGraph<int, string>(ref GraphIntString);
            else if (type == MyType.city_int)
                DrawGraph<City, int>(ref GraphCityInt);
            else
                DrawGraph<City, string>(ref GraphCityString);
        }


        private void DrawGraph<N, L>(ref IGraph<N, L> graph)
        {
            panel.Clear(Color.AliceBlue);

            lblCountVertices.Text = "Количество вершин: " + graph.Count;
            lblCountEdges.Text = "Количество ребер: " + graph.CountLinks;

            Font drawFont = new Font("Consolas", 12);

            int n = graph.Count;
            labels = new Label[graph.Count];
            Point[] positions = new Point[n];
            Point centre = new Point(425, 300);

            Controls.Add(mainPanel);
            mainPanel.Controls.Clear();

            int j = 0;
            foreach (N node in graph)
            {
                double tmp = 2 * Math.PI * j / n;
                labels[j] = new Label();
                labels[j].Text = node.ToString();
                int w = TextRenderer.MeasureText(labels[j].Text, drawFont).Width;
                if (labels[j].Text.Length > 2)
                    w = (int)(0.9 * w);
                labels[j].Width = w;
                int X = Convert.ToInt32(170 * Math.Cos(tmp));
                int Y = Convert.ToInt32(170 * Math.Sin(tmp));
                int tmpX = 0;
                int tmpY = 0;
                if (Math.Cos(tmp) < 0) tmpX = -w;
                else tmpX = 10;
                if (Math.Sin(tmp) < 0) tmpY = -20;
                mainPanel.Controls.Add(labels[j]);
                labels[j].Location = new Point(centre.X + X + tmpX, centre.Y + Y + tmpY);
                positions[j] = new Point(centre.X + X, centre.Y + Y);
                j++;
            }


            Pen pStr = new Pen(Color.Black, 1);
            int i = 0;
            foreach(N node in graph)
            {
                foreach ((N, L) link in graph.Links(node))
                {
                    int idx = graph.IndexOf(link.Item1);
                    if (i != idx)
                    {
                        panel.DrawLine(pStr, positions[i], positions[idx]);
                        double length = Math.Sqrt((positions[i].X - positions[idx].X) * (positions[i].X - positions[idx].X) +
                                                  (positions[i].Y - positions[idx].Y) * (positions[i].Y - positions[idx].Y));
                        Point lVector = new Point(positions[idx].X - positions[i].X, positions[idx].Y - positions[i].Y);
                        Point nVector = new Point(positions[i].Y - positions[idx].Y, positions[idx].X - positions[i].X);
                        int w = 20;
                        int h = 5;
                        Point oPoint = new Point((int)(positions[idx].X - lVector.X * w / length), (int)(positions[idx].Y - lVector.Y * w / length));
                        Point p1 = new Point((int)(oPoint.X + nVector.X * h / length), (int)(oPoint.Y + nVector.Y * h / length));
                        Point p2 = new Point((int)(oPoint.X - nVector.X * h / length), (int)(oPoint.Y - nVector.Y * h / length));
                        panel.DrawLine(pStr, p1, positions[idx]);
                        panel.DrawLine(pStr, p2, positions[idx]);
                    }
                }
                i++;
            }
        }
   


        private void rtbVertexInput1_TextChanged(object sender, EventArgs e)
        {
            bool flag = rtbVertexInput1.TextLength > 0 && rtbVertexInput1.Text != "-";
            if (type == MyType.city_int || type == MyType.city_string)
                flag = flag && rtbVertexInput2.TextLength > 0;
            btnAddVertexOK.Enabled = flag;
            btnDeleteVertexOK.Enabled = flag;
            btnRunAlgorithmDFSOK.Enabled = flag;
            btnRunAlgorithmBFSOK.Enabled = flag;

            flag = flag && rtbVertexInput3.TextLength > 0;
            if (type == MyType.city_int || type == MyType.city_string)
                flag = flag && rtbVertexInput4.TextLength > 0;
            btnDeleteEdgeOK.Enabled = flag;

            if (IsLinkValueVisible)
                flag = flag && rtbEdgeInput.TextLength > 0;
            btnAddEdgeOK.Enabled = flag;
        }

        private void rtbVertexInput2_TextChanged(object sender, EventArgs e)
        {
            bool flag = rtbVertexInput1.TextLength > 0 && rtbVertexInput2.TextLength > 0 && rtbVertexInput1.Text != "-";
            btnAddVertexOK.Enabled = flag;
            btnDeleteVertexOK.Enabled = flag;
            btnRunAlgorithmDFSOK.Enabled = flag;
            btnRunAlgorithmBFSOK.Enabled = flag;

            flag = flag && rtbVertexInput3.TextLength > 0 && rtbVertexInput4.TextLength > 0;
            btnDeleteEdgeOK.Enabled = flag;
            if (IsLinkValueVisible)
                flag = flag && rtbEdgeInput.TextLength > 0;
            btnAddEdgeOK.Enabled = flag;

        }
        private void rtbVertexInput3_TextChanged(object sender, EventArgs e)
        {
            bool flag;
            flag = rtbVertexInput1.TextLength > 0 && rtbVertexInput3.TextLength > 0;
            if (type == MyType.city_int || type == MyType.city_string)
                flag = flag && rtbVertexInput2.TextLength > 0 && rtbVertexInput4.TextLength > 0;
            btnDeleteEdgeOK.Enabled = flag;
            if (IsLinkValueVisible)
                flag = flag && rtbEdgeInput.TextLength > 0;
            btnAddEdgeOK.Enabled = flag;

        }

        private void rtbVertexInput4_TextChanged(object sender, EventArgs e)
        {
            bool flag = rtbVertexInput1.TextLength > 0 && rtbVertexInput2.TextLength > 0 &&
                        rtbVertexInput3.TextLength > 0 && rtbVertexInput4.TextLength > 0;
            btnDeleteEdgeOK.Enabled = flag;
            if (IsLinkValueVisible)
                flag = flag && rtbEdgeInput.TextLength > 0;
            btnAddEdgeOK.Enabled = flag;

        }

        private void rtbEdgeInput_TextChanged(object sender, EventArgs e)
        {
            bool flag = rtbVertexInput1.TextLength > 0 && rtbVertexInput3.TextLength > 0 && rtbEdgeInput.TextLength > 0;
            if (type == MyType.city_int || type == MyType.city_string)
                flag = flag && rtbVertexInput2.TextLength > 0 && rtbVertexInput4.TextLength > 0;
            btnAddEdgeOK.Enabled = flag;
            btnDeleteEdgeOK.Enabled = flag;
        }

        private void rtbVertexInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (type == MyType.int_int || type == MyType.int_string)
                e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || e.KeyChar == '-' && rtbVertexInput1.Text.Length != 0);
        }

        private void rtbVertexInput3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (type == MyType.int_int || type == MyType.int_string)
                e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || e.KeyChar == '-' && rtbVertexInput3.Text.Length != 0);
        }
        private void rtbVertexInput4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (type == MyType.int_int || type == MyType.int_string)
                e.Handled = !char.IsDigit(e.KeyChar);
        }
        private void rtbVertexInput2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void rtbEdgeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (type == MyType.int_int || type == MyType.city_int)
                e.Handled = e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || e.KeyChar == '-' && rtbEdgeInput.Text.Length != 0);
        }


        private void changeVisibleVertexInput1(bool flag)
        {
            if (type == MyType.city_int || type == MyType.city_string)
            {
                lblVertexInput2.Enabled = flag;
                lblVertexInput2.Visible = flag;
                rtbVertexInput2.Enabled = flag;
                rtbVertexInput2.Visible = flag;
            }
            lblVertexInput1.Enabled = flag;
            lblVertexInput1.Visible = flag;
            rtbVertexInput1.Enabled = flag;
            rtbVertexInput1.Visible = flag;
        }
        private void changeVisibleVertexInput2(bool flag)
        {
            if (type == MyType.city_int || type == MyType.city_string)
            {
                lblVertexInput4.Enabled = flag;
                lblVertexInput4.Visible = flag;
                rtbVertexInput4.Enabled = flag;
                rtbVertexInput4.Visible = flag;
            }
            lblVertexInput3.Enabled = flag;
            lblVertexInput3.Visible = flag;
            rtbVertexInput3.Enabled = flag;
            rtbVertexInput3.Visible = flag;
        }
        private void changeVisibleEdgeInput(bool flag)
        {
            if (IsLinkValueVisible)
            {
                lblEdgeInput.Visible = flag;
                lblEdgeInput.Enabled = flag;
                rtbEdgeInput.Visible = flag;
                rtbEdgeInput.Enabled = flag;
            }
        }

        
    private void hideEnableVisibleBtnOKNO(ref Button rtb1, ref Button rtb2)
        {
            rtb1.Enabled = false;
            rtb1.Visible = false;
            rtb2.Enabled = false;
            rtb2.Visible = false;
        }

        private void clearRtb()
        {
            rtbVertexInput1.Text = "";
            rtbVertexInput2.Text = "";
            rtbVertexInput3.Text = "";
            rtbVertexInput4.Text = "";
            rtbEdgeInput.Text = "";
        }

        private string makeMessageVertex()
        {
            string result = "";
            if (rtbVertexInput1.Text != "" || rtbVertexInput2.Text != "")
            {
                result += '(' + rtbVertexInput1.Text;
                if (type == MyType.city_int || type == MyType.city_string)
                    result += ", " + rtbVertexInput2.Text;
                result += ')';
            }
            return result;
        }
        private string makeMessageEdge()
        {
            string result = "";
            if (type == MyType.int_int || type == MyType.int_string)
            {
                string tmp = rtbVertexInput1.Text + "; " + rtbVertexInput3.Text;
                if (IsLinkValueVisible)
                    tmp += "; " + rtbEdgeInput.Text;
                if (tmp != "; " && tmp != "; ; ")
                    result = '(' + tmp + ')';
            }
            else
            {
                string tmp = "";
                if (rtbVertexInput1.Text != "" || rtbVertexInput2.Text != "")
                    tmp = rtbVertexInput1.Text + ", " + rtbVertexInput2.Text;
                tmp += "; ";
                if(rtbVertexInput3.Text != "" || rtbVertexInput4.Text != "")
                    tmp = rtbVertexInput3.Text + ", " + rtbVertexInput4.Text;
                if (IsLinkValueVisible)
                    tmp += "; " + rtbEdgeInput.Text;
                if (tmp != "; " && tmp != "; ; ")
                    result = '(' + tmp + ')';
            }
            return result;
        }
        

        private void LabelClickChooseVertex(object sender, EventArgs e)
        {
            if (prevLabel != null)
            {
                prevLabel.BorderStyle = BorderStyle.None;
                prevLabel.BackColor = Color.AliceBlue;
            }
            Label currLabel = sender as Label;
            currLabel.BorderStyle = BorderStyle.FixedSingle;
            currLabel.BackColor = Color.LightSkyBlue;
            prevLabel = currLabel;
            string[] words = currLabel.Text.Split(new char[] { ','});
            rtbVertexInput1.Text = words[0];
            if (words.Length > 1)
                rtbVertexInput2.Text = words[1];
        }

        private void LabelClickChooseEdge(object sender, EventArgs e)
        {
            Label currLabel = sender as Label;
            if (prevPrevLabel != null)
            {
                prevPrevLabel.BackColor = Color.AliceBlue;
                prevPrevLabel.BorderStyle = BorderStyle.None;
            }
            if (prevLabel == null)
                prevLabel = currLabel;

            prevLabel.BorderStyle = BorderStyle.FixedSingle;
            prevLabel.BackColor = Color.LightSteelBlue;
            currLabel.BorderStyle = BorderStyle.FixedSingle;
            currLabel.BackColor = Color.LightSkyBlue;

            string[] currWords = currLabel.Text.Split(new char[] { ','});
            string[] prevWords = prevLabel.Text.Split(new char[] { ','});
            rtbVertexInput1.Text = prevWords[0];
            rtbVertexInput3.Text = currWords[0];
            if (currWords.Length > 1)
            {
                rtbVertexInput2.Text = prevWords[1];
                rtbVertexInput4.Text = currWords[1];
            }

            prevPrevLabel = prevLabel;
            prevLabel = currLabel;
        }

        private void btnRandomVertex_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (type == MyType.int_int || type == MyType.int_string)
                rtbVertexInput1.Text = (rnd.Next() % 201 - 100).ToString();
            else
            {
                City tmp = City.RandomCity();
                rtbVertexInput1.Text = tmp.name;
                rtbVertexInput2.Text = tmp.year.ToString();
            }
        }



        // ДОБАВЛЕНИЕ ВЕРШИНЫ
        private void AddVertexOK<N, L>(ref IGraph<N, L> graph, N node, ref string message, ref bool isChanged)
        {
            if (graph.Contains(node))
                message = "Вершина уже существует";
            else
            {
                graph.AddNode(node);
                message = "Вершина успешно добавлена";
                isChanged = true;
                lblCountVertices.Text = "Количество вершин: " + graph.Count.ToString();
            }
            message += " (" + node.ToString() + ")\n";
        }

        private void btnAddVertexOK_Click(object sender, EventArgs e)
        {
            hideEnableVisibleBtnOKNO(ref btnAddVertexNO, ref btnAddVertexOK);
            menuStrip1.Enabled = true;
            btnRandomVertex.Enabled = false;
            btnRandomVertex.Visible = false;

            changeVisibleVertexInput1(false);

            string message = "";
            bool isChanged = false;
            if (type == MyType.int_int)
            {
                int node = Convert.ToInt32(rtbVertexInput1.Text);
                AddVertexOK<int, int>(ref GraphIntInt, node, ref message, ref isChanged);
            }
            else if (type == MyType.int_string)
            {
                int node = Convert.ToInt32(rtbVertexInput1.Text);
                AddVertexOK<int, string>(ref GraphIntString, node, ref message, ref isChanged);
            }
            else if (type == MyType.city_int)
            {
                City node = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
                AddVertexOK<City, int>(ref GraphCityInt, node, ref message, ref isChanged);
            }
            else
            {
                City node = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
                AddVertexOK<City, string>(ref GraphCityString, node, ref message, ref isChanged);
            }
            rtbInfo.Text = message + rtbInfo.Text;

            Draw();
            clearRtb();
        }

        private void btnAddVertexNO_Click(object sender, EventArgs e)
        {
            hideEnableVisibleBtnOKNO(ref btnAddVertexNO, ref btnAddVertexOK);
            changeVisibleVertexInput1(false);
            menuStrip1.Enabled = true;
            btnRandomVertex.Enabled = false;
            btnRandomVertex.Visible = false;
            rtbInfo.Text = "Отмена добавления вершины " + makeMessageVertex() + '\n' + rtbInfo.Text;
            clearRtb();
        }

        private void AddVertexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            btnAddVertexNO.Enabled = true;
            btnAddVertexNO.Visible = true;
            btnAddVertexOK.Enabled = false;
            btnAddVertexOK.Visible = true;

            changeVisibleVertexInput1(true);

            btnRandomVertex.Enabled = true;
            btnRandomVertex.Visible = true;
        }
        // КОНЕЦ ДОБАВЛЕНИЯ ВЕРШИНЫ


        // УДАЛЕНИЕ ВЕРШИНЫ
        private void DeleteVertexOK<N, L>(ref IGraph<N, L> graph, N node, ref string message, ref bool isChanged)
        {
            if (!graph.Contains(node))
                message = "Вершина отсутствует в графе";
            else
            {
                graph.RemoveNode(node);
                message = "Вершина успешно удалена";
                isChanged = true;
            }
            message += " (" + node.ToString() + ")\n";
        }
        private void btnDeleteVertexOK_Click(object sender, EventArgs e)
        {
            hideEnableVisibleBtnOKNO(ref btnDeleteVertexNO, ref btnDeleteVertexOK);
            changeVisibleVertexInput1(false);
            menuStrip1.Enabled = true;

            string message = "";
            bool isChanged = false;
            if (type == MyType.int_int)
            {
                int node = Convert.ToInt32(rtbVertexInput1.Text);
                DeleteVertexOK(ref GraphIntInt, node, ref message, ref isChanged);
            }
            else if (type == MyType.int_string)
            {
                int node = Convert.ToInt32(rtbVertexInput1.Text);
                DeleteVertexOK(ref GraphIntString, node, ref message, ref isChanged);
            }
            else if (type == MyType.city_int)
            {
                City node = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
                DeleteVertexOK(ref GraphCityInt, node, ref message, ref isChanged);
            }
            else
            {
                City node = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
                DeleteVertexOK(ref GraphCityString, node, ref message, ref isChanged);
            }
            rtbInfo.Text = message + rtbInfo.Text;
            prevLabel = null;
            Draw();
            clearRtb();
        }
        private void btnDeleteVertexNO_Click(object sender, EventArgs e)
        {
            hideEnableVisibleBtnOKNO(ref btnDeleteVertexNO, ref btnDeleteVertexOK);
            changeVisibleVertexInput1(false);
            menuStrip1.Enabled = true;
            rtbInfo.Text = "Отмена удаления вершины " + makeMessageVertex() + '\n' + rtbInfo.Text;
            clearRtb();
            if (prevLabel != null)
            {
                prevLabel.BackColor = Color.AliceBlue;
                prevLabel.BorderStyle = BorderStyle.None;
            }
            else
                prevLabel = null;
            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click -= LabelClickChooseVertex;
        }
        private void DeleteVertexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            btnDeleteVertexNO.Enabled = true;
            btnDeleteVertexNO.Visible = true;
            btnDeleteVertexOK.Enabled = false;
            btnDeleteVertexOK.Visible = true;
            
            changeVisibleVertexInput1(true);

            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click += LabelClickChooseVertex;
        }
        // КОНЕЦ УДАЛЕНИЕ ВЕРШИНЫ


        // ДОБАВЛЕНИЕ РЕБРА
        private void AddEdgeOK<N, L>(ref IGraph<N, L> graph, N node1, N node2, L link, ref string message, ref bool isChanged) where N : IComparable
        {
            if (!graph.Contains(node1))
                message = "Вершина отсутствует в графе" + " (" + node1.ToString() + ")\n";
            else if (!graph.Contains(node2))
                message = "Вершина отсутствует в графе" + " (" + node2.ToString() + ")\n";
            else
            {
                foreach ((N, L) node in graph.Links(node1))
                {
                    if (node.Item1.CompareTo(node2) == 0)
                    {
                        message = "Между вершинами уже есть ребро" + " (" + node1.ToString() + "; " + node2.ToString();
                        if (IsLinkValueVisible)
                            message += "; " + link.ToString();
                        message += ")\n";
                        return;
                    }
                }
                graph.AddLink(node1, node2, link);
                message = "Ребро успешно добавлено" + " (" + node1.ToString() + "; " + node2.ToString(); 
                if (IsLinkValueVisible)
                    message += "; " + link.ToString();
                message += ")\n";
                isChanged = true;
            }
        }
        private void btnAddEdgeNO_Click(object sender, EventArgs e)
        {
            hideEnableVisibleBtnOKNO(ref btnAddEdgeNO, ref btnAddEdgeOK);
            lblFrom.Visible = false;
            lblTo.Visible = false;
            menuStrip1.Enabled = true;
            changeVisibleVertexInput1(false);
            changeVisibleVertexInput2(false);

            if (IsLinkValueVisible)
            {
                lblEdgeInput.Visible = false;
                lblEdgeInput.Enabled = false;
                rtbEdgeInput.Visible = false;
                rtbEdgeInput.Enabled = false;
            }

            rtbInfo.Text = "Отмена добавления ребра " + makeMessageEdge() +  '\n' + rtbInfo.Text;
            if (prevLabel != null)
            {
                prevLabel.BackColor = Color.AliceBlue;
                prevLabel.BorderStyle = BorderStyle.None;
                prevLabel = null;
            }
            if (prevPrevLabel != null)
            {
                prevPrevLabel.BackColor = Color.AliceBlue;
                prevPrevLabel.BorderStyle = BorderStyle.None;
                prevPrevLabel = null;
            }
               
            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click -= LabelClickChooseEdge;
            clearRtb();
        }


        private void btnAddEdgeOK_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
            hideEnableVisibleBtnOKNO(ref btnAddEdgeNO, ref btnAddEdgeOK);
            changeVisibleVertexInput1(false);
            changeVisibleVertexInput2(false);
            changeVisibleEdgeInput(false);
            lblFrom.Visible = false;
            lblTo.Visible = false;

            string message = "";
            bool isChanged = false;
            if (type == MyType.int_int)
            {
                int node1 = Convert.ToInt32(rtbVertexInput1.Text);
                int node2 = Convert.ToInt32(rtbVertexInput3.Text);
                int link = Convert.ToInt32(rtbEdgeInput.Text);
                AddEdgeOK(ref GraphIntInt, node1, node2, link, ref message, ref isChanged);
            }
            else if (type == MyType.int_string)
            {
                int node1 = Convert.ToInt32(rtbVertexInput1.Text);
                int node2 = Convert.ToInt32(rtbVertexInput3.Text);
                string link = rtbEdgeInput.Text;
                AddEdgeOK(ref GraphIntString, node1, node2, link, ref message, ref isChanged);
            }
            else if (type == MyType.city_int)
            {
                City node1 = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
                City node2 = new City(rtbVertexInput3.Text, Convert.ToInt32(rtbVertexInput4.Text));
                int link = Convert.ToInt32(rtbEdgeInput.Text);
                AddEdgeOK(ref GraphCityInt, node1, node2, link, ref message, ref isChanged);
            }
            else
            {
                City node1 = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
                City node2 = new City(rtbVertexInput3.Text, Convert.ToInt32(rtbVertexInput4.Text));
                string link = rtbEdgeInput.Text;
                AddEdgeOK(ref GraphCityString, node1, node2, link, ref message, ref isChanged);
            }
            rtbInfo.Text = message + rtbInfo.Text;
            prevLabel = null;
            prevPrevLabel = null;
            Draw();
            clearRtb();
        }
        private void AddEdgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            btnAddEdgeNO.Enabled = true;
            btnAddEdgeNO.Visible = true;
            btnAddEdgeOK.Enabled = false;
            btnAddEdgeOK.Visible = true;

            changeVisibleVertexInput1(true);
            changeVisibleVertexInput2(true);
            changeVisibleEdgeInput(true);

            lblFrom.Visible = true;
            lblTo.Visible = true;

            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click += LabelClickChooseEdge;
        }
        // КОНЕЦ ДОБАВЛЕНИЯ РЕБРА


        // УДАЛЕНИЕ РЕБРА
        private void DeleteEdgeOK<N, L>(ref IGraph<N, L> graph, N node1, N node2, ref string message, ref bool isChanged) where N : IComparable
        {
            if (!graph.Contains(node1))
                message = "Вершина отсутствует в графе" + " (" + node1.ToString() + ")\n";
            else if (!graph.Contains(node2))
                message = "Вершина отсутствует в графе" + " (" + node2.ToString() + ")\n";
            else
            {
                MyList<(N, L)> links = graph.Links(node1);
                int n = links.Count;
                int i = 0;
                while (i < n && links[i].Item1.CompareTo(node2) != 0)
                    i++;
                if (i == n)
                    message = "Ребро  отсутствует в графе" + " (" + node1.ToString() + "; " + node2.ToString() + ")\n";
                else
                {
                    graph.RemoveLink(node1, node2);
                    message = "Ребро успешно удалено" + " (" + node1.ToString() + "; " + node2.ToString();
                    if (IsLinkValueVisible)
                        message += "; " + links[i].Item2;
                    message += ")\n";
                    isChanged = true;
                }
            }
        }
        private void btnDeleteEdgeNO_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;

            hideEnableVisibleBtnOKNO(ref btnDeleteEdgeNO, ref btnDeleteEdgeOK);
            changeVisibleVertexInput1(false);
            changeVisibleVertexInput2(false);

            lblFrom.Visible = false;
            lblTo.Visible = false;

            rtbInfo.Text = "Отмена удаления ребра " + makeMessageEdge() + '\n' + rtbInfo.Text;
            if (prevLabel != null)
            {
                prevLabel.BackColor = Color.AliceBlue;
                prevLabel.BorderStyle = BorderStyle.None;
                prevLabel = null;
            }
            if (prevPrevLabel != null)
            {
                prevPrevLabel.BackColor = Color.AliceBlue;
                prevPrevLabel.BorderStyle = BorderStyle.None;
                prevPrevLabel = null;
            }

            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click -= LabelClickChooseEdge;
            clearRtb();
        }
        private void btnDeleteEdgeOK_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;

            hideEnableVisibleBtnOKNO(ref btnDeleteEdgeNO, ref btnDeleteEdgeOK);
            changeVisibleVertexInput1(false);
            changeVisibleVertexInput2(false);

            lblFrom.Visible = false;
            lblTo.Visible = false;

            string message = "";
            bool isChanged = false;
            if (type == MyType.int_int)
            {
                int node1 = Convert.ToInt32(rtbVertexInput1.Text);
                int node2 = Convert.ToInt32(rtbVertexInput3.Text);
                DeleteEdgeOK(ref GraphIntInt, node1, node2, ref message, ref isChanged);
            }
            else if (type == MyType.int_string)
            {
                int node1 = Convert.ToInt32(rtbVertexInput1.Text);
                int node2 = Convert.ToInt32(rtbVertexInput3.Text);
                DeleteEdgeOK(ref GraphIntString, node1, node2, ref message, ref isChanged);
            }
            else if (type == MyType.city_int)
            {
                City node1 = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
                City node2 = new City(rtbVertexInput3.Text, Convert.ToInt32(rtbVertexInput4.Text));
                DeleteEdgeOK(ref GraphCityInt, node1, node2, ref message, ref isChanged);
            }
            else
            {
                City node1 = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
                City node2 = new City(rtbVertexInput3.Text, Convert.ToInt32(rtbVertexInput4.Text));
                DeleteEdgeOK(ref GraphCityString, node1, node2, ref message, ref isChanged);
            }
            rtbInfo.Text = message + rtbInfo.Text;
            prevLabel = null;
            prevPrevLabel = null;
            Draw();
            clearRtb();
        }
        private void DeleteEdgeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            btnDeleteEdgeNO.Enabled = true;
            btnDeleteEdgeNO.Visible = true;
            btnDeleteEdgeOK.Enabled = false;
            btnDeleteEdgeOK.Visible = true;
           
            changeVisibleVertexInput1(true);
            changeVisibleVertexInput2(true);

            lblFrom.Visible = true;
            lblTo.Visible = true;

            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click += LabelClickChooseEdge;
        }
        // КОНЕЦ УДАЛЕНИЕ РЕБРА


        private void RunAlgorithmDFS<N, L>(ref IGraph<N, L> graph, N node)
        {
            rtbAlgorithm.Text = "";
            if (graph.Count == 0)
                rtbAlgorithm.Text = "Граф не содержит вершин";
            else if (!graph.Contains(node))
                rtbAlgorithm.Text = "Граф не содержит данную стартовую вершину";
            else
            {
                MyList<(N, N, L)> path = GraphUtils.DFS<N, L>(graph, node);
                if (path.Count == 0)
                    rtbAlgorithm.Text = node.ToString();
                else
                {
                    foreach ((N, N, L) part in path)
                    {
                        string message = "Из: " + part.Item1.ToString() + '\n' + "В:  " + part.Item2.ToString() + '\n';
                        if (IsLinkValueVisible)
                            message += "Ребро: " + part.Item3.ToString() + '\n';
                        message += '\n';
                        rtbAlgorithm.Text += message;
                    }
                }
                rtbInfo.Text = "Выполнен обход в глубину\n"  + rtbInfo.Text;
            }
            
        }

        private void btnRunAlgorithmNO_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;

            hideEnableVisibleBtnOKNO(ref btnRunAlgorithmDFSNO, ref btnRunAlgorithmDFSOK);
            changeVisibleVertexInput1(false);

            rtbInfo.Text = "Отмена выполнения обхода в глубину" + makeMessageVertex() + '\n' + rtbInfo.Text;
            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click -= LabelClickChooseVertex;
            if (prevLabel != null)
            {
                prevLabel.BorderStyle = BorderStyle.None;
                prevLabel.BackColor = Color.AliceBlue;
                prevLabel = null;
            }
            clearRtb();
        }

        private void btnRunAlgorithmOK_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;

            hideEnableVisibleBtnOKNO(ref btnRunAlgorithmDFSOK, ref btnRunAlgorithmDFSNO);
            changeVisibleVertexInput1(false);

            int nodeInt = 0;
            City nodeCity = new City("", 0);
            if (type == MyType.int_int || type == MyType.int_string)
                nodeInt = Convert.ToInt32(rtbVertexInput1.Text);
            else
                nodeCity = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));
       
            if (type == MyType.int_int) RunAlgorithmDFS<int, int>(ref GraphIntInt, nodeInt);
            else if (type == MyType.int_string) RunAlgorithmDFS<int, string>(ref GraphIntString, nodeInt);
            else if (type == MyType.city_int) RunAlgorithmDFS<City, int>(ref GraphCityInt, nodeCity);
            else RunAlgorithmDFS<City, string>(ref GraphCityString, nodeCity);

            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click -= LabelClickChooseVertex;
            if (prevLabel != null)
            {
                prevLabel.BorderStyle = BorderStyle.None;
                prevLabel.BackColor = Color.AliceBlue;
                prevLabel = null;
            }
            clearRtb();
        }

        private void DFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            btnRunAlgorithmDFSNO.Enabled = true;
            btnRunAlgorithmDFSNO.Visible = true;
            btnRunAlgorithmDFSOK.Enabled = false;
            btnRunAlgorithmDFSOK.Visible = true;

            changeVisibleVertexInput1(true);

            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click += LabelClickChooseVertex;
        }

        private void RunAlgorithmBFS<N, L>(ref IGraph<N, L> graph, N node)
        {
            rtbAlgorithm.Text = "";
            if (graph.Count == 0)
                rtbAlgorithm.Text = "Граф не содержит вершин";
            else if (!graph.Contains(node))
                rtbAlgorithm.Text = "Граф не содержит данную стартовую вершину";
            else if (graph.Count == 1)
                rtbAlgorithm.Text = graph[0].ToString();
            else
            {
                MyList<(N, N, L)> path = GraphUtils.BFS<N, L>(graph, node);
                if (path.Count == 0)
                    rtbAlgorithm.Text = node.ToString();
                else
                {
                    foreach ((N, N, L) part in path)
                    {
                        string message = "Из: " + part.Item1.ToString() + '\n' + "В:  " + part.Item2.ToString() + '\n';
                        if (IsLinkValueVisible)
                            message += "Ребро: " + part.Item3.ToString() + '\n';
                        message += '\n';
                        rtbAlgorithm.Text += message;
                    }
                }
                rtbInfo.Text = "Выполнен обход в ширину\n" + rtbInfo.Text;
            }

        }

        private void btnRunAlgorithmBFSOK_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;

            hideEnableVisibleBtnOKNO(ref btnRunAlgorithmBFSOK, ref btnRunAlgorithmBFSNO);
            changeVisibleVertexInput1(false);

            int nodeInt = 0;
            City nodeCity = new City("", 0);
            if (type == MyType.int_int || type == MyType.int_string)
                nodeInt = Convert.ToInt32(rtbVertexInput1.Text);
            else
                nodeCity = new City(rtbVertexInput1.Text, Convert.ToInt32(rtbVertexInput2.Text));

            if (type == MyType.int_int) RunAlgorithmBFS<int, int>(ref GraphIntInt, nodeInt);
            else if (type == MyType.int_string) RunAlgorithmBFS<int, string>(ref GraphIntString, nodeInt);
            else if (type == MyType.city_int) RunAlgorithmBFS<City, int>(ref GraphCityInt, nodeCity);
            else RunAlgorithmBFS<City, string>(ref GraphCityString, nodeCity);

            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click -= LabelClickChooseVertex;
            if (prevLabel != null)
            {
                prevLabel.BorderStyle = BorderStyle.None;
                prevLabel.BackColor = Color.AliceBlue;
                prevLabel = null;
            }
            clearRtb();
        }
    

        private void btnRunAlgorithmBFSNO_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;

            hideEnableVisibleBtnOKNO(ref btnRunAlgorithmBFSNO, ref btnRunAlgorithmBFSOK);
            changeVisibleVertexInput1(false);

            rtbInfo.Text = "Отмена выполнения обхода в ширину" + makeMessageVertex() + '\n' + rtbInfo.Text;
            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click -= LabelClickChooseVertex;
            if (prevLabel != null)
            {
                prevLabel.BorderStyle = BorderStyle.None;
                prevLabel.BackColor = Color.AliceBlue;
                prevLabel = null;
            }
            clearRtb();
        }
        private void BFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            btnRunAlgorithmBFSNO.Enabled = true;
            btnRunAlgorithmBFSNO.Visible = true;
            btnRunAlgorithmBFSOK.Enabled = false;
            btnRunAlgorithmBFSOK.Visible = true;

            changeVisibleVertexInput1(true);

            int n = labels == null ? 0 : labels.Length;
            for (int i = 0; i < n; i++)
                labels[i].Click += LabelClickChooseVertex;
        }

        private void RunAlgorithmIsAcyclic<N, L>(ref IGraph<N, L> graph)
        {
            if (GraphUtils.IsAcyclic<N, L>(graph))
                rtbAlgorithm.Text = "Граф НЕ содержит циклы";
            else
                rtbAlgorithm.Text = "Граф содержит циклы";
            rtbInfo.Text = "Выполнена проверка графа на ацикличность\n" + rtbInfo.Text;
        }


        private void IsAcyclicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (type == MyType.int_int) RunAlgorithmIsAcyclic<int, int>(ref GraphIntInt);
            else if (type == MyType.int_string) RunAlgorithmIsAcyclic<int, string>(ref GraphIntString);
            else if (type == MyType.city_int) RunAlgorithmIsAcyclic<City, int>(ref GraphCityInt);
            else RunAlgorithmIsAcyclic<City, string>(ref GraphCityString);
        }

        private void сменитьТипToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormInput formInput = new FormInput();
            formInput.ShowDialog();
        }

        private void сделатьНеизменяемымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isEnabled = true;
            if (ChangeUnmutableToolStripMenuItem.Text == "Сделать неизменяемым")
            {
                ChangeUnmutableToolStripMenuItem.Text = "Сделать изменяемым";
                rtbInfo.Text = "Граф сделан неизменияемым\n" + rtbInfo.Text;
                isEnabled = false;
            }
            else
            {
                ChangeUnmutableToolStripMenuItem.Text = "Сделать неизменяемым";
                rtbInfo.Text = "Граф сделан изменяемым\n" + rtbInfo.Text;
            }
            addToolStripMenuItem.Enabled = isEnabled;
            deleteToolStripMenuItem.Enabled = isEnabled;
        }
        
        private void readIntIntGraph(ref IGraph<int, int> graph, ref StreamReader file)
        {
            int numberOfNodes = Convert.ToInt32(file.ReadLine());
            for (int i = 0; i < numberOfNodes; i++)
            {
                int vertex = Convert.ToInt32(file.ReadLine());
                graph.AddNode(vertex);
            }
            foreach (int linkFrom in graph)
            {
                int numberOfEdges = Convert.ToInt32(file.ReadLine());
                for (int j = 0; j < numberOfEdges; j++)
                {
                    int linkTo = Convert.ToInt32(file.ReadLine());
                    int linkValue = Convert.ToInt32(file.ReadLine());
                    graph.AddLink(linkFrom, linkTo, linkValue);
                }
            }
        }

        private void readCityIntGraph(ref IGraph<City, int> graph, ref StreamReader file)
        {
            int numberOfNodes = Convert.ToInt32(file.ReadLine());
            for (int i = 0; i < numberOfNodes; i++)
            {
                string[] parts = file.ReadLine().Split(new char[] { ',' });
                string name = parts[0];
                int year = Convert.ToInt32(parts[1]);
                graph.AddNode(new City(name, year));
            }
            foreach (City linkFrom in graph)
            {
                int numberOfEdges = Convert.ToInt32(file.ReadLine());
                for (int j = 0; j < numberOfEdges; j++)
                {
                    string[] parts = file.ReadLine().Split(new char[] { ',' });
                    string name = parts[0];
                    int year = Convert.ToInt32(parts[1]);
                    int linkValue = Convert.ToInt32(file.ReadLine());
                    graph.AddLink(linkFrom, new City(name, year), linkValue);
                }
            }
        }

        private void readIntStringGraph(ref IGraph<int, string> graph, ref StreamReader file)
        {
            int numberOfNodes = Convert.ToInt32(file.ReadLine());
            for (int i = 0; i < numberOfNodes; i++)
            {
                int vertex = Convert.ToInt32(file.ReadLine());
                graph.AddNode(vertex);
            }
            foreach (int linkFrom in graph)
            {
                int numberOfEdges = Convert.ToInt32(file.ReadLine());
                for (int j = 0; j < numberOfEdges; j++)
                {
                    int linkTo = Convert.ToInt32(file.ReadLine());
                    string linkValue = file.ReadLine();
                    graph.AddLink(linkFrom, linkTo, linkValue);
                }
            }
        }

        private void readCityStringGraph(ref IGraph<City, string> graph, ref StreamReader file)
        {
            int numberOfNodes = Convert.ToInt32(file.ReadLine());
            for (int i = 0; i < numberOfNodes; i++)
            {
                string[] parts = file.ReadLine().Split(new char[] { ',' });
                string name = parts[0];
                int year = Convert.ToInt32(parts[1]);
                graph.AddNode(new City(name, year));
            }
            foreach (City linkFrom in graph)
            {
                int numberOfEdges = Convert.ToInt32(file.ReadLine());
                for (int j = 0; j < numberOfEdges; j++)
                {
                    string[] parts = file.ReadLine().Split(new char[] { ',' });
                    string name = parts[0];
                    int year = Convert.ToInt32(parts[1]);
                    City linkTo = new City(name, year);
                    string linkValue = file.ReadLine();
                    graph.AddLink(linkFrom, linkTo, linkValue);
                }
            }
        }
 

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Clear(Color.AliceBlue);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                StreamReader file = new StreamReader(path);
                _graphType = file.ReadLine();
                _nodeType = file.ReadLine();
                _linkType = file.ReadLine();
                InitializeGraph(_graphType, _nodeType, _linkType);
                changeLocations();

                if (type == MyType.int_int)
                    readIntIntGraph(ref GraphIntInt, ref file);
                else if (type == MyType.int_string)
                    readIntStringGraph(ref GraphIntString, ref file);
                else if (type == MyType.city_int)
                    readCityIntGraph(ref GraphCityInt, ref file);
                else
                    readCityStringGraph(ref GraphCityString, ref file);
                file.Close();
                Draw();
                rtbInfo.Text = "Начата работа с новым графом  " + path + '\n' + rtbInfo.Text;
            }
           
        }

        private void информацияОГрафеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Основание графа: " + _graphType + '\n' +
                             "Тип вершин: " + _nodeType + '\n' + "Тип рёбер: " + _linkType;
            MessageBox.Show(message, "Информация о графе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void writeFile<N, L>(ref IGraph<N, L> graph, string path)
        {
            using (StreamWriter file = new StreamWriter(path, false))
            {
                file.WriteLine(_graphType);
                file.WriteLine(_nodeType);
                file.WriteLine(_linkType);

                file.WriteLine(graph.Count);
                foreach (N node in graph)
                    file.WriteLine(node.ToString());
                foreach (N node in graph)
                {
                    MyList<(N, L)> links = graph.Links(node);
                    file.WriteLine(links.Count);
                    foreach ((N, L) link in links)
                    {
                        file.WriteLine(link.Item1.ToString());
                        file.WriteLine(link.Item2.ToString());
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                if (type == MyType.int_int)
                    writeFile<int, int>(ref GraphIntInt, path);
                else if (type == MyType.int_string)
                    writeFile<int, string>(ref GraphIntString, path);
                else if (type == MyType.city_int)
                    writeFile<City, int>(ref GraphCityInt, path);
                else 
                    writeFile<City, string>(ref GraphCityString, path);

                rtbInfo.Text = "Граф сохранен  " + path + '\n' + rtbInfo.Text;
            }
        }
    }
}
