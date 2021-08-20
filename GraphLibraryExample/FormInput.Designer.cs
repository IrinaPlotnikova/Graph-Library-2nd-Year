
namespace GraphLibraryExample
{
    partial class FormInput
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGraphType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNodeType = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.comboBoxLinkType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1000, 1000);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Основа графа";
            // 
            // comboBoxGraphType
            // 
            this.comboBoxGraphType.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxGraphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGraphType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxGraphType.ItemHeight = 29;
            this.comboBoxGraphType.Items.AddRange(new object[] {
            "массив",
            "список"});
            this.comboBoxGraphType.Location = new System.Drawing.Point(200, 17);
            this.comboBoxGraphType.Name = "comboBoxGraphType";
            this.comboBoxGraphType.Size = new System.Drawing.Size(240, 37);
            this.comboBoxGraphType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип данных";
            // 
            // comboBoxNodeType
            // 
            this.comboBoxNodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNodeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxNodeType.Items.AddRange(new object[] {
            "целочисленный",
            "город"});
            this.comboBoxNodeType.Location = new System.Drawing.Point(200, 74);
            this.comboBoxNodeType.Name = "comboBoxNodeType";
            this.comboBoxNodeType.Size = new System.Drawing.Size(240, 37);
            this.comboBoxNodeType.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Thistle;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCreate.Location = new System.Drawing.Point(118, 255);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(295, 45);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Приступить к работе";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // comboBoxLinkType
            // 
            this.comboBoxLinkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLinkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBoxLinkType.Items.AddRange(new object[] {
            "—",
            "целочисленный",
            "строковый"});
            this.comboBoxLinkType.Location = new System.Drawing.Point(200, 130);
            this.comboBoxLinkType.Name = "comboBoxLinkType";
            this.comboBoxLinkType.Size = new System.Drawing.Size(240, 37);
            this.comboBoxLinkType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(10, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Тип рёбер";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxLinkType);
            this.panel1.Controls.Add(this.comboBoxNodeType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxGraphType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 190);
            this.panel1.TabIndex = 14;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(528, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.radioButton1);
            this.Name = "FormInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGraphType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNodeType;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox comboBoxLinkType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

