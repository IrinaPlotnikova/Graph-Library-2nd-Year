
namespace GraphLibraryExample
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rtbAlgorithm = new System.Windows.Forms.RichTextBox();
            this.lblAlgorithmResult = new System.Windows.Forms.Label();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.lblVertexInput1 = new System.Windows.Forms.Label();
            this.rtbVertexInput1 = new System.Windows.Forms.RichTextBox();
            this.lblVertexInput2 = new System.Windows.Forms.Label();
            this.rtbVertexInput2 = new System.Windows.Forms.RichTextBox();
            this.btnRandomVertex = new System.Windows.Forms.Button();
            this.lblVertexInput3 = new System.Windows.Forms.Label();
            this.rtbVertexInput3 = new System.Windows.Forms.RichTextBox();
            this.lblVertexInput4 = new System.Windows.Forms.Label();
            this.rtbVertexInput4 = new System.Windows.Forms.RichTextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblEdgeInput = new System.Windows.Forms.Label();
            this.rtbEdgeInput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСФайломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddVertexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteVertexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteEdgeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RunAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обходВГлубинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обходВШиринуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаНаАцикличностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОГрафеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeUnmutableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRunAlgorithmDFSNO = new System.Windows.Forms.Button();
            this.btnRunAlgorithmDFSOK = new System.Windows.Forms.Button();
            this.btnDeleteEdgeNO = new System.Windows.Forms.Button();
            this.btnDeleteEdgeOK = new System.Windows.Forms.Button();
            this.btnAddEdgeNO = new System.Windows.Forms.Button();
            this.btnAddEdgeOK = new System.Windows.Forms.Button();
            this.btnDeleteVertexNO = new System.Windows.Forms.Button();
            this.btnDeleteVertexOK = new System.Windows.Forms.Button();
            this.btnAddVertexOK = new System.Windows.Forms.Button();
            this.btnAddVertexNO = new System.Windows.Forms.Button();
            this.btnRunAlgorithmBFSOK = new System.Windows.Forms.Button();
            this.btnRunAlgorithmBFSNO = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCountVertices = new System.Windows.Forms.Label();
            this.lblCountEdges = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPanel.Location = new System.Drawing.Point(10, 45);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1100, 700);
            this.mainPanel.TabIndex = 0;
            // 
            // rtbAlgorithm
            // 
            this.rtbAlgorithm.BackColor = System.Drawing.Color.Azure;
            this.rtbAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAlgorithm.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAlgorithm.Location = new System.Drawing.Point(1122, 95);
            this.rtbAlgorithm.Name = "rtbAlgorithm";
            this.rtbAlgorithm.ReadOnly = true;
            this.rtbAlgorithm.Size = new System.Drawing.Size(356, 742);
            this.rtbAlgorithm.TabIndex = 7;
            this.rtbAlgorithm.TabStop = false;
            this.rtbAlgorithm.Text = "";
            // 
            // lblAlgorithmResult
            // 
            this.lblAlgorithmResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlgorithmResult.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAlgorithmResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAlgorithmResult.Location = new System.Drawing.Point(1122, 48);
            this.lblAlgorithmResult.Name = "lblAlgorithmResult";
            this.lblAlgorithmResult.Size = new System.Drawing.Size(356, 38);
            this.lblAlgorithmResult.TabIndex = 8;
            this.lblAlgorithmResult.Text = "Результат выполнения алгоритма:";
            this.lblAlgorithmResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.Color.Thistle;
            this.rtbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbInfo.Location = new System.Drawing.Point(10, 749);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(1100, 88);
            this.rtbInfo.TabIndex = 9;
            this.rtbInfo.TabStop = false;
            this.rtbInfo.Text = "";
            // 
            // lblVertexInput1
            // 
            this.lblVertexInput1.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVertexInput1.Enabled = false;
            this.lblVertexInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVertexInput1.Location = new System.Drawing.Point(12, 50);
            this.lblVertexInput1.Name = "lblVertexInput1";
            this.lblVertexInput1.Size = new System.Drawing.Size(118, 38);
            this.lblVertexInput1.TabIndex = 10;
            this.lblVertexInput1.Text = "Значение:";
            this.lblVertexInput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVertexInput1.Visible = false;
            // 
            // rtbVertexInput1
            // 
            this.rtbVertexInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbVertexInput1.Enabled = false;
            this.rtbVertexInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbVertexInput1.Location = new System.Drawing.Point(130, 50);
            this.rtbVertexInput1.Name = "rtbVertexInput1";
            this.rtbVertexInput1.Size = new System.Drawing.Size(221, 38);
            this.rtbVertexInput1.TabIndex = 11;
            this.rtbVertexInput1.Text = "";
            this.rtbVertexInput1.Visible = false;
            this.rtbVertexInput1.TextChanged += new System.EventHandler(this.rtbVertexInput1_TextChanged);
            this.rtbVertexInput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbVertexInput1_KeyPress);
            // 
            // lblVertexInput2
            // 
            this.lblVertexInput2.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVertexInput2.Enabled = false;
            this.lblVertexInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVertexInput2.Location = new System.Drawing.Point(360, 50);
            this.lblVertexInput2.Name = "lblVertexInput2";
            this.lblVertexInput2.Size = new System.Drawing.Size(160, 38);
            this.lblVertexInput2.TabIndex = 12;
            this.lblVertexInput2.Text = "Год основания:";
            this.lblVertexInput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVertexInput2.Visible = false;
            // 
            // rtbVertexInput2
            // 
            this.rtbVertexInput2.Enabled = false;
            this.rtbVertexInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbVertexInput2.Location = new System.Drawing.Point(523, 50);
            this.rtbVertexInput2.Name = "rtbVertexInput2";
            this.rtbVertexInput2.Size = new System.Drawing.Size(139, 38);
            this.rtbVertexInput2.TabIndex = 13;
            this.rtbVertexInput2.Text = "";
            this.rtbVertexInput2.Visible = false;
            this.rtbVertexInput2.TextChanged += new System.EventHandler(this.rtbVertexInput2_TextChanged);
            this.rtbVertexInput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbVertexInput2_KeyPress);
            // 
            // btnRandomVertex
            // 
            this.btnRandomVertex.BackColor = System.Drawing.Color.Thistle;
            this.btnRandomVertex.Enabled = false;
            this.btnRandomVertex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandomVertex.Location = new System.Drawing.Point(375, 50);
            this.btnRandomVertex.Name = "btnRandomVertex";
            this.btnRandomVertex.Size = new System.Drawing.Size(246, 38);
            this.btnRandomVertex.TabIndex = 0;
            this.btnRandomVertex.Text = "Случайное значение";
            this.btnRandomVertex.UseVisualStyleBackColor = false;
            this.btnRandomVertex.Visible = false;
            this.btnRandomVertex.Click += new System.EventHandler(this.btnRandomVertex_Click);
            // 
            // lblVertexInput3
            // 
            this.lblVertexInput3.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVertexInput3.Enabled = false;
            this.lblVertexInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVertexInput3.Location = new System.Drawing.Point(12, 95);
            this.lblVertexInput3.Name = "lblVertexInput3";
            this.lblVertexInput3.Size = new System.Drawing.Size(118, 38);
            this.lblVertexInput3.TabIndex = 14;
            this.lblVertexInput3.Text = "Значение:";
            this.lblVertexInput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVertexInput3.Visible = false;
            // 
            // rtbVertexInput3
            // 
            this.rtbVertexInput3.Enabled = false;
            this.rtbVertexInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbVertexInput3.Location = new System.Drawing.Point(130, 95);
            this.rtbVertexInput3.Name = "rtbVertexInput3";
            this.rtbVertexInput3.Size = new System.Drawing.Size(221, 38);
            this.rtbVertexInput3.TabIndex = 14;
            this.rtbVertexInput3.Text = "";
            this.rtbVertexInput3.Visible = false;
            this.rtbVertexInput3.TextChanged += new System.EventHandler(this.rtbVertexInput3_TextChanged);
            this.rtbVertexInput3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbVertexInput3_KeyPress);
            // 
            // lblVertexInput4
            // 
            this.lblVertexInput4.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVertexInput4.Enabled = false;
            this.lblVertexInput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVertexInput4.Location = new System.Drawing.Point(360, 95);
            this.lblVertexInput4.Name = "lblVertexInput4";
            this.lblVertexInput4.Size = new System.Drawing.Size(160, 38);
            this.lblVertexInput4.TabIndex = 14;
            this.lblVertexInput4.Text = "Год основания:";
            this.lblVertexInput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVertexInput4.Visible = false;
            // 
            // rtbVertexInput4
            // 
            this.rtbVertexInput4.Enabled = false;
            this.rtbVertexInput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbVertexInput4.Location = new System.Drawing.Point(523, 95);
            this.rtbVertexInput4.Name = "rtbVertexInput4";
            this.rtbVertexInput4.Size = new System.Drawing.Size(140, 38);
            this.rtbVertexInput4.TabIndex = 14;
            this.rtbVertexInput4.Text = "";
            this.rtbVertexInput4.Visible = false;
            this.rtbVertexInput4.TextChanged += new System.EventHandler(this.rtbVertexInput4_TextChanged);
            this.rtbVertexInput4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbVertexInput4_KeyPress);
            // 
            // lblFrom
            // 
            this.lblFrom.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFrom.Enabled = false;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(365, 50);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(60, 38);
            this.lblFrom.TabIndex = 14;
            this.lblFrom.Text = "(ИЗ)";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFrom.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTo.Enabled = false;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(365, 95);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(60, 38);
            this.lblTo.TabIndex = 15;
            this.lblTo.Text = "(В)";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTo.Visible = false;
            // 
            // lblEdgeInput
            // 
            this.lblEdgeInput.BackColor = System.Drawing.Color.AliceBlue;
            this.lblEdgeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEdgeInput.Location = new System.Drawing.Point(449, 50);
            this.lblEdgeInput.Name = "lblEdgeInput";
            this.lblEdgeInput.Size = new System.Drawing.Size(172, 38);
            this.lblEdgeInput.TabIndex = 0;
            this.lblEdgeInput.Text = "Значение ребра:";
            this.lblEdgeInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEdgeInput.Visible = false;
            // 
            // rtbEdgeInput
            // 
            this.rtbEdgeInput.Enabled = false;
            this.rtbEdgeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbEdgeInput.Location = new System.Drawing.Point(449, 95);
            this.rtbEdgeInput.Name = "rtbEdgeInput";
            this.rtbEdgeInput.Size = new System.Drawing.Size(172, 38);
            this.rtbEdgeInput.TabIndex = 16;
            this.rtbEdgeInput.Text = "";
            this.rtbEdgeInput.Visible = false;
            this.rtbEdgeInput.TextChanged += new System.EventHandler(this.rtbEdgeInput_TextChanged);
            this.rtbEdgeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbEdgeInput_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСФайломToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.RunAlgorithmToolStripMenuItem,
            this.changeTypeToolStripMenuItem,
            this.информацияОГрафеToolStripMenuItem,
            this.ChangeUnmutableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1502, 40);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСФайломToolStripMenuItem
            // 
            this.работаСФайломToolStripMenuItem.AutoSize = false;
            this.работаСФайломToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.работаСФайломToolStripMenuItem.Name = "работаСФайломToolStripMenuItem";
            this.работаСФайломToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.работаСФайломToolStripMenuItem.Size = new System.Drawing.Size(69, 36);
            this.работаСФайломToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.AutoSize = false;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.openToolStripMenuItem.Text = "открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.AutoSize = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.saveAsToolStripMenuItem.Text = "сохранить...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddVertexToolStripMenuItem,
            this.AddEdgeToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.addToolStripMenuItem.Text = "Добавить";
            // 
            // AddVertexToolStripMenuItem
            // 
            this.AddVertexToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.AddVertexToolStripMenuItem.Name = "AddVertexToolStripMenuItem";
            this.AddVertexToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.AddVertexToolStripMenuItem.Text = "вершину";
            this.AddVertexToolStripMenuItem.Click += new System.EventHandler(this.AddVertexToolStripMenuItem_Click);
            // 
            // AddEdgeToolStripMenuItem
            // 
            this.AddEdgeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.AddEdgeToolStripMenuItem.Name = "AddEdgeToolStripMenuItem";
            this.AddEdgeToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.AddEdgeToolStripMenuItem.Text = "ребро";
            this.AddEdgeToolStripMenuItem.Click += new System.EventHandler(this.AddEdgeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteVertexToolStripMenuItem1,
            this.DeleteEdgeToolStripMenuItem1});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.deleteToolStripMenuItem.Text = "Удалить";
            // 
            // DeleteVertexToolStripMenuItem1
            // 
            this.DeleteVertexToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Window;
            this.DeleteVertexToolStripMenuItem1.Name = "DeleteVertexToolStripMenuItem1";
            this.DeleteVertexToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.DeleteVertexToolStripMenuItem1.Text = "вершину";
            this.DeleteVertexToolStripMenuItem1.Click += new System.EventHandler(this.DeleteVertexToolStripMenuItem1_Click);
            // 
            // DeleteEdgeToolStripMenuItem1
            // 
            this.DeleteEdgeToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Window;
            this.DeleteEdgeToolStripMenuItem1.Name = "DeleteEdgeToolStripMenuItem1";
            this.DeleteEdgeToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.DeleteEdgeToolStripMenuItem1.Text = "ребро";
            this.DeleteEdgeToolStripMenuItem1.Click += new System.EventHandler(this.DeleteEdgeToolStripMenuItem1_Click);
            // 
            // RunAlgorithmToolStripMenuItem
            // 
            this.RunAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обходВГлубинуToolStripMenuItem,
            this.обходВШиринуToolStripMenuItem,
            this.проверкаНаАцикличностьToolStripMenuItem});
            this.RunAlgorithmToolStripMenuItem.Name = "RunAlgorithmToolStripMenuItem";
            this.RunAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(202, 36);
            this.RunAlgorithmToolStripMenuItem.Text = "Выполнить алгоритм";
            // 
            // обходВГлубинуToolStripMenuItem
            // 
            this.обходВГлубинуToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.обходВГлубинуToolStripMenuItem.Name = "обходВГлубинуToolStripMenuItem";
            this.обходВГлубинуToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.обходВГлубинуToolStripMenuItem.Text = "обход в глубину";
            this.обходВГлубинуToolStripMenuItem.Click += new System.EventHandler(this.DFSToolStripMenuItem_Click);
            // 
            // обходВШиринуToolStripMenuItem
            // 
            this.обходВШиринуToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.обходВШиринуToolStripMenuItem.Name = "обходВШиринуToolStripMenuItem";
            this.обходВШиринуToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.обходВШиринуToolStripMenuItem.Text = "обход в ширину";
            this.обходВШиринуToolStripMenuItem.Click += new System.EventHandler(this.BFSToolStripMenuItem_Click);
            // 
            // проверкаНаАцикличностьToolStripMenuItem
            // 
            this.проверкаНаАцикличностьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.проверкаНаАцикличностьToolStripMenuItem.Name = "проверкаНаАцикличностьToolStripMenuItem";
            this.проверкаНаАцикличностьToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.проверкаНаАцикличностьToolStripMenuItem.Text = "проверка на ацикличность";
            this.проверкаНаАцикличностьToolStripMenuItem.Click += new System.EventHandler(this.IsAcyclicToolStripMenuItem_Click);
            // 
            // changeTypeToolStripMenuItem
            // 
            this.changeTypeToolStripMenuItem.Name = "changeTypeToolStripMenuItem";
            this.changeTypeToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
            this.changeTypeToolStripMenuItem.Text = "Сменить тип";
            this.changeTypeToolStripMenuItem.Click += new System.EventHandler(this.сменитьТипToolStripMenuItem_Click);
            // 
            // информацияОГрафеToolStripMenuItem
            // 
            this.информацияОГрафеToolStripMenuItem.Name = "информацияОГрафеToolStripMenuItem";
            this.информацияОГрафеToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.информацияОГрафеToolStripMenuItem.Text = "Информация о графе";
            this.информацияОГрафеToolStripMenuItem.Click += new System.EventHandler(this.информацияОГрафеToolStripMenuItem_Click);
            // 
            // ChangeUnmutableToolStripMenuItem
            // 
            this.ChangeUnmutableToolStripMenuItem.Name = "ChangeUnmutableToolStripMenuItem";
            this.ChangeUnmutableToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.ChangeUnmutableToolStripMenuItem.Text = "Сделать неизменяемым";
            this.ChangeUnmutableToolStripMenuItem.Click += new System.EventHandler(this.сделатьНеизменяемымToolStripMenuItem_Click);
            // 
            // btnRunAlgorithmDFSNO
            // 
            this.btnRunAlgorithmDFSNO.BackColor = System.Drawing.Color.Thistle;
            this.btnRunAlgorithmDFSNO.Enabled = false;
            this.btnRunAlgorithmDFSNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAlgorithmDFSNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunAlgorithmDFSNO.Location = new System.Drawing.Point(1015, 95);
            this.btnRunAlgorithmDFSNO.Name = "btnRunAlgorithmDFSNO";
            this.btnRunAlgorithmDFSNO.Size = new System.Drawing.Size(92, 38);
            this.btnRunAlgorithmDFSNO.TabIndex = 18;
            this.btnRunAlgorithmDFSNO.Text = "Х";
            this.btnRunAlgorithmDFSNO.UseVisualStyleBackColor = false;
            this.btnRunAlgorithmDFSNO.Visible = false;
            this.btnRunAlgorithmDFSNO.Click += new System.EventHandler(this.btnRunAlgorithmNO_Click);
            // 
            // btnRunAlgorithmDFSOK
            // 
            this.btnRunAlgorithmDFSOK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRunAlgorithmDFSOK.Enabled = false;
            this.btnRunAlgorithmDFSOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAlgorithmDFSOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunAlgorithmDFSOK.Location = new System.Drawing.Point(1015, 50);
            this.btnRunAlgorithmDFSOK.Name = "btnRunAlgorithmDFSOK";
            this.btnRunAlgorithmDFSOK.Size = new System.Drawing.Size(92, 38);
            this.btnRunAlgorithmDFSOK.TabIndex = 17;
            this.btnRunAlgorithmDFSOK.Text = "✓";
            this.btnRunAlgorithmDFSOK.UseVisualStyleBackColor = false;
            this.btnRunAlgorithmDFSOK.Visible = false;
            this.btnRunAlgorithmDFSOK.Click += new System.EventHandler(this.btnRunAlgorithmOK_Click);
            // 
            // btnDeleteEdgeNO
            // 
            this.btnDeleteEdgeNO.BackColor = System.Drawing.Color.Thistle;
            this.btnDeleteEdgeNO.Enabled = false;
            this.btnDeleteEdgeNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEdgeNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEdgeNO.Location = new System.Drawing.Point(1015, 95);
            this.btnDeleteEdgeNO.Name = "btnDeleteEdgeNO";
            this.btnDeleteEdgeNO.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteEdgeNO.TabIndex = 7;
            this.btnDeleteEdgeNO.Text = "Х";
            this.btnDeleteEdgeNO.UseVisualStyleBackColor = false;
            this.btnDeleteEdgeNO.Visible = false;
            this.btnDeleteEdgeNO.Click += new System.EventHandler(this.btnDeleteEdgeNO_Click);
            // 
            // btnDeleteEdgeOK
            // 
            this.btnDeleteEdgeOK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteEdgeOK.Enabled = false;
            this.btnDeleteEdgeOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEdgeOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEdgeOK.Location = new System.Drawing.Point(1015, 50);
            this.btnDeleteEdgeOK.Name = "btnDeleteEdgeOK";
            this.btnDeleteEdgeOK.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteEdgeOK.TabIndex = 4;
            this.btnDeleteEdgeOK.Text = "✓";
            this.btnDeleteEdgeOK.UseVisualStyleBackColor = false;
            this.btnDeleteEdgeOK.Visible = false;
            this.btnDeleteEdgeOK.Click += new System.EventHandler(this.btnDeleteEdgeOK_Click);
            // 
            // btnAddEdgeNO
            // 
            this.btnAddEdgeNO.BackColor = System.Drawing.Color.Thistle;
            this.btnAddEdgeNO.Enabled = false;
            this.btnAddEdgeNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEdgeNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEdgeNO.Location = new System.Drawing.Point(1015, 95);
            this.btnAddEdgeNO.Name = "btnAddEdgeNO";
            this.btnAddEdgeNO.Size = new System.Drawing.Size(92, 38);
            this.btnAddEdgeNO.TabIndex = 6;
            this.btnAddEdgeNO.Text = "Х";
            this.btnAddEdgeNO.UseVisualStyleBackColor = false;
            this.btnAddEdgeNO.Visible = false;
            this.btnAddEdgeNO.Click += new System.EventHandler(this.btnAddEdgeNO_Click);
            // 
            // btnAddEdgeOK
            // 
            this.btnAddEdgeOK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddEdgeOK.Enabled = false;
            this.btnAddEdgeOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEdgeOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEdgeOK.Location = new System.Drawing.Point(1015, 50);
            this.btnAddEdgeOK.Name = "btnAddEdgeOK";
            this.btnAddEdgeOK.Size = new System.Drawing.Size(92, 38);
            this.btnAddEdgeOK.TabIndex = 3;
            this.btnAddEdgeOK.Text = "✓";
            this.btnAddEdgeOK.UseVisualStyleBackColor = false;
            this.btnAddEdgeOK.Visible = false;
            this.btnAddEdgeOK.Click += new System.EventHandler(this.btnAddEdgeOK_Click);
            // 
            // btnDeleteVertexNO
            // 
            this.btnDeleteVertexNO.BackColor = System.Drawing.Color.Thistle;
            this.btnDeleteVertexNO.Enabled = false;
            this.btnDeleteVertexNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVertexNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteVertexNO.Location = new System.Drawing.Point(1015, 95);
            this.btnDeleteVertexNO.Name = "btnDeleteVertexNO";
            this.btnDeleteVertexNO.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteVertexNO.TabIndex = 5;
            this.btnDeleteVertexNO.Text = "Х";
            this.btnDeleteVertexNO.UseVisualStyleBackColor = false;
            this.btnDeleteVertexNO.Visible = false;
            this.btnDeleteVertexNO.Click += new System.EventHandler(this.btnDeleteVertexNO_Click);
            // 
            // btnDeleteVertexOK
            // 
            this.btnDeleteVertexOK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteVertexOK.Enabled = false;
            this.btnDeleteVertexOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVertexOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteVertexOK.Location = new System.Drawing.Point(1015, 50);
            this.btnDeleteVertexOK.Name = "btnDeleteVertexOK";
            this.btnDeleteVertexOK.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteVertexOK.TabIndex = 2;
            this.btnDeleteVertexOK.Text = "✓";
            this.btnDeleteVertexOK.UseVisualStyleBackColor = false;
            this.btnDeleteVertexOK.Visible = false;
            this.btnDeleteVertexOK.Click += new System.EventHandler(this.btnDeleteVertexOK_Click);
            // 
            // btnAddVertexOK
            // 
            this.btnAddVertexOK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddVertexOK.Enabled = false;
            this.btnAddVertexOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVertexOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddVertexOK.Location = new System.Drawing.Point(1015, 50);
            this.btnAddVertexOK.Name = "btnAddVertexOK";
            this.btnAddVertexOK.Size = new System.Drawing.Size(92, 38);
            this.btnAddVertexOK.TabIndex = 0;
            this.btnAddVertexOK.Text = "✓";
            this.btnAddVertexOK.UseVisualStyleBackColor = false;
            this.btnAddVertexOK.Visible = false;
            this.btnAddVertexOK.Click += new System.EventHandler(this.btnAddVertexOK_Click);
            // 
            // btnAddVertexNO
            // 
            this.btnAddVertexNO.BackColor = System.Drawing.Color.Thistle;
            this.btnAddVertexNO.Enabled = false;
            this.btnAddVertexNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVertexNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddVertexNO.Location = new System.Drawing.Point(1015, 95);
            this.btnAddVertexNO.Name = "btnAddVertexNO";
            this.btnAddVertexNO.Size = new System.Drawing.Size(92, 38);
            this.btnAddVertexNO.TabIndex = 1;
            this.btnAddVertexNO.Text = "Х";
            this.btnAddVertexNO.UseVisualStyleBackColor = false;
            this.btnAddVertexNO.Visible = false;
            this.btnAddVertexNO.Click += new System.EventHandler(this.btnAddVertexNO_Click);
            // 
            // btnRunAlgorithmBFSOK
            // 
            this.btnRunAlgorithmBFSOK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRunAlgorithmBFSOK.Enabled = false;
            this.btnRunAlgorithmBFSOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAlgorithmBFSOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunAlgorithmBFSOK.Location = new System.Drawing.Point(1015, 50);
            this.btnRunAlgorithmBFSOK.Name = "btnRunAlgorithmBFSOK";
            this.btnRunAlgorithmBFSOK.Size = new System.Drawing.Size(92, 38);
            this.btnRunAlgorithmBFSOK.TabIndex = 20;
            this.btnRunAlgorithmBFSOK.Text = "✓";
            this.btnRunAlgorithmBFSOK.UseVisualStyleBackColor = false;
            this.btnRunAlgorithmBFSOK.Visible = false;
            this.btnRunAlgorithmBFSOK.Click += new System.EventHandler(this.btnRunAlgorithmBFSOK_Click);
            // 
            // btnRunAlgorithmBFSNO
            // 
            this.btnRunAlgorithmBFSNO.BackColor = System.Drawing.Color.Thistle;
            this.btnRunAlgorithmBFSNO.Enabled = false;
            this.btnRunAlgorithmBFSNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAlgorithmBFSNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunAlgorithmBFSNO.Location = new System.Drawing.Point(1015, 95);
            this.btnRunAlgorithmBFSNO.Name = "btnRunAlgorithmBFSNO";
            this.btnRunAlgorithmBFSNO.Size = new System.Drawing.Size(92, 38);
            this.btnRunAlgorithmBFSNO.TabIndex = 21;
            this.btnRunAlgorithmBFSNO.Text = "Х";
            this.btnRunAlgorithmBFSNO.UseVisualStyleBackColor = false;
            this.btnRunAlgorithmBFSNO.Visible = false;
            this.btnRunAlgorithmBFSNO.Click += new System.EventHandler(this.btnRunAlgorithmBFSNO_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblCountVertices
            // 
            this.lblCountVertices.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCountVertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountVertices.Location = new System.Drawing.Point(12, 660);
            this.lblCountVertices.Name = "lblCountVertices";
            this.lblCountVertices.Size = new System.Drawing.Size(259, 38);
            this.lblCountVertices.TabIndex = 22;
            this.lblCountVertices.Text = "Количество вершин: 0";
            this.lblCountVertices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountEdges
            // 
            this.lblCountEdges.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCountEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountEdges.Location = new System.Drawing.Point(12, 700);
            this.lblCountEdges.Name = "lblCountEdges";
            this.lblCountEdges.Size = new System.Drawing.Size(259, 38);
            this.lblCountEdges.TabIndex = 23;
            this.lblCountEdges.Text = "Количество ребер: 0";
            this.lblCountEdges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1502, 857);
            this.Controls.Add(this.lblCountEdges);
            this.Controls.Add(this.lblCountVertices);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.rtbAlgorithm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblAlgorithmResult);
            this.Controls.Add(this.btnRunAlgorithmDFSOK);
            this.Controls.Add(this.btnDeleteEdgeOK);
            this.Controls.Add(this.btnAddVertexOK);
            this.Controls.Add(this.btnAddEdgeOK);
            this.Controls.Add(this.btnDeleteVertexOK);
            this.Controls.Add(this.btnRunAlgorithmBFSOK);
            this.Controls.Add(this.btnRunAlgorithmBFSNO);
            this.Controls.Add(this.btnRunAlgorithmDFSNO);
            this.Controls.Add(this.btnDeleteEdgeNO);
            this.Controls.Add(this.btnAddEdgeNO);
            this.Controls.Add(this.btnDeleteVertexNO);
            this.Controls.Add(this.btnAddVertexNO);
            this.Controls.Add(this.lblVertexInput1);
            this.Controls.Add(this.lblVertexInput3);
            this.Controls.Add(this.rtbVertexInput1);
            this.Controls.Add(this.rtbVertexInput3);
            this.Controls.Add(this.lblVertexInput2);
            this.Controls.Add(this.lblVertexInput4);
            this.Controls.Add(this.rtbEdgeInput);
            this.Controls.Add(this.rtbVertexInput4);
            this.Controls.Add(this.lblEdgeInput);
            this.Controls.Add(this.btnRandomVertex);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.rtbVertexInput2);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с графом";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RichTextBox rtbAlgorithm;
        private System.Windows.Forms.Label lblAlgorithmResult;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label lblVertexInput1;
        private System.Windows.Forms.RichTextBox rtbVertexInput1;
        private System.Windows.Forms.Label lblVertexInput2;
        private System.Windows.Forms.RichTextBox rtbVertexInput2;
        private System.Windows.Forms.Button btnRandomVertex;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.RichTextBox rtbVertexInput4;
        private System.Windows.Forms.Label lblVertexInput4;
        private System.Windows.Forms.RichTextBox rtbVertexInput3;
        private System.Windows.Forms.Label lblVertexInput3;
        private System.Windows.Forms.Label lblEdgeInput;
        private System.Windows.Forms.RichTextBox rtbEdgeInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddVertexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEdgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteVertexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteEdgeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RunAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обходВГлубинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обходВШиринуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаНаАцикличностьToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteVertexNO;
        private System.Windows.Forms.Button btnDeleteVertexOK;
        private System.Windows.Forms.Button btnAddEdgeNO;
        private System.Windows.Forms.Button btnAddEdgeOK;
        private System.Windows.Forms.Button btnDeleteEdgeNO;
        private System.Windows.Forms.Button btnDeleteEdgeOK;
        private System.Windows.Forms.Button btnAddVertexOK;
        private System.Windows.Forms.Button btnAddVertexNO;
        private System.Windows.Forms.Button btnRunAlgorithmDFSNO;
        private System.Windows.Forms.Button btnRunAlgorithmDFSOK;
        private System.Windows.Forms.ToolStripMenuItem changeTypeToolStripMenuItem;
        private System.Windows.Forms.Button btnRunAlgorithmBFSOK;
        private System.Windows.Forms.Button btnRunAlgorithmBFSNO;
        private System.Windows.Forms.ToolStripMenuItem работаСФайломToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeUnmutableToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCountVertices;
        private System.Windows.Forms.Label lblCountEdges;
        private System.Windows.Forms.ToolStripMenuItem информацияОГрафеToolStripMenuItem;
    }
}