namespace OpenTKGameEngine
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
            this.glControl1 = new OpenTK.GLControl();
            this.buttonDivideNMK = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.buttonScalePlus = new System.Windows.Forms.Button();
            this.buttonScaleMinus = new System.Windows.Forms.Button();
            this.labelScale = new System.Windows.Forms.Label();
            this.buttonRotateZPlus = new System.Windows.Forms.Button();
            this.buttonRotateYMinus = new System.Windows.Forms.Button();
            this.buttonRotateYPlus = new System.Windows.Forms.Button();
            this.buttonRotateXMinus = new System.Windows.Forms.Button();
            this.buttonRotateXPlus = new System.Windows.Forms.Button();
            this.buttonRotateZMinus = new System.Windows.Forms.Button();
            this.labelRotateZ = new System.Windows.Forms.Label();
            this.labelRotateY = new System.Windows.Forms.Label();
            this.labelRotateX = new System.Windows.Forms.Label();
            this.textBoxNodeCOunt = new System.Windows.Forms.TextBox();
            this.textBoxIsNormCount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxChooseNode = new System.Windows.Forms.ComboBox();
            this.buttonTexture = new System.Windows.Forms.Button();
            this.buttonColorfulQuads = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(12, 8);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(614, 293);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // buttonDivideNMK
            // 
            this.buttonDivideNMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivideNMK.Location = new System.Drawing.Point(327, 388);
            this.buttonDivideNMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDivideNMK.Name = "buttonDivideNMK";
            this.buttonDivideNMK.Size = new System.Drawing.Size(137, 33);
            this.buttonDivideNMK.TabIndex = 1;
            this.buttonDivideNMK.Text = "도형분할 (m*n*k)";
            this.buttonDivideNMK.UseVisualStyleBackColor = true;
            this.buttonDivideNMK.Click += new System.EventHandler(this.buttonDivideNMK_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(323, 312);
            this.labelN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(32, 17);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "n = ";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelM.Location = new System.Drawing.Point(324, 336);
            this.labelM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(35, 17);
            this.labelM.TabIndex = 4;
            this.labelM.Text = "m = ";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.Location = new System.Drawing.Point(324, 360);
            this.labelK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(31, 17);
            this.labelK.TabIndex = 5;
            this.labelK.Text = "k = ";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(359, 312);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(60, 21);
            this.textBoxN.TabIndex = 6;
            this.textBoxN.Text = "1";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(359, 360);
            this.textBoxK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(60, 21);
            this.textBoxK.TabIndex = 7;
            this.textBoxK.Text = "1";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(359, 336);
            this.textBoxM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(60, 21);
            this.textBoxM.TabIndex = 8;
            this.textBoxM.Text = "1";
            // 
            // buttonScalePlus
            // 
            this.buttonScalePlus.Location = new System.Drawing.Point(12, 349);
            this.buttonScalePlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonScalePlus.Name = "buttonScalePlus";
            this.buttonScalePlus.Size = new System.Drawing.Size(38, 20);
            this.buttonScalePlus.TabIndex = 9;
            this.buttonScalePlus.Text = "+";
            this.buttonScalePlus.UseVisualStyleBackColor = true;
            this.buttonScalePlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonScaleMinus
            // 
            this.buttonScaleMinus.Location = new System.Drawing.Point(54, 349);
            this.buttonScaleMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonScaleMinus.Name = "buttonScaleMinus";
            this.buttonScaleMinus.Size = new System.Drawing.Size(38, 20);
            this.buttonScaleMinus.TabIndex = 10;
            this.buttonScaleMinus.Text = "-";
            this.buttonScaleMinus.UseVisualStyleBackColor = true;
            this.buttonScaleMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(96, 352);
            this.labelScale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(32, 17);
            this.labelScale.TabIndex = 11;
            this.labelScale.Text = "크기";
            // 
            // buttonRotateZPlus
            // 
            this.buttonRotateZPlus.Location = new System.Drawing.Point(154, 352);
            this.buttonRotateZPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateZPlus.Name = "buttonRotateZPlus";
            this.buttonRotateZPlus.Size = new System.Drawing.Size(38, 20);
            this.buttonRotateZPlus.TabIndex = 12;
            this.buttonRotateZPlus.Text = "+";
            this.buttonRotateZPlus.UseVisualStyleBackColor = true;
            this.buttonRotateZPlus.Click += new System.EventHandler(this.buttonRotateZPlus_Click);
            // 
            // buttonRotateYMinus
            // 
            this.buttonRotateYMinus.Location = new System.Drawing.Point(54, 397);
            this.buttonRotateYMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateYMinus.Name = "buttonRotateYMinus";
            this.buttonRotateYMinus.Size = new System.Drawing.Size(38, 20);
            this.buttonRotateYMinus.TabIndex = 13;
            this.buttonRotateYMinus.Text = "-";
            this.buttonRotateYMinus.UseVisualStyleBackColor = true;
            this.buttonRotateYMinus.Click += new System.EventHandler(this.buttonRotateYMinus_Click);
            // 
            // buttonRotateYPlus
            // 
            this.buttonRotateYPlus.Location = new System.Drawing.Point(11, 397);
            this.buttonRotateYPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateYPlus.Name = "buttonRotateYPlus";
            this.buttonRotateYPlus.Size = new System.Drawing.Size(38, 20);
            this.buttonRotateYPlus.TabIndex = 14;
            this.buttonRotateYPlus.Text = "+";
            this.buttonRotateYPlus.UseVisualStyleBackColor = true;
            this.buttonRotateYPlus.Click += new System.EventHandler(this.buttonRotateYPlus_Click);
            // 
            // buttonRotateXMinus
            // 
            this.buttonRotateXMinus.Location = new System.Drawing.Point(54, 373);
            this.buttonRotateXMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateXMinus.Name = "buttonRotateXMinus";
            this.buttonRotateXMinus.Size = new System.Drawing.Size(38, 20);
            this.buttonRotateXMinus.TabIndex = 15;
            this.buttonRotateXMinus.Text = "-";
            this.buttonRotateXMinus.UseVisualStyleBackColor = true;
            this.buttonRotateXMinus.Click += new System.EventHandler(this.buttonRotateXMinus_Click);
            // 
            // buttonRotateXPlus
            // 
            this.buttonRotateXPlus.Location = new System.Drawing.Point(12, 373);
            this.buttonRotateXPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateXPlus.Name = "buttonRotateXPlus";
            this.buttonRotateXPlus.Size = new System.Drawing.Size(38, 20);
            this.buttonRotateXPlus.TabIndex = 16;
            this.buttonRotateXPlus.Text = "+";
            this.buttonRotateXPlus.UseVisualStyleBackColor = true;
            this.buttonRotateXPlus.Click += new System.EventHandler(this.buttonRotateXPlus_Click);
            // 
            // buttonRotateZMinus
            // 
            this.buttonRotateZMinus.Location = new System.Drawing.Point(196, 352);
            this.buttonRotateZMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateZMinus.Name = "buttonRotateZMinus";
            this.buttonRotateZMinus.Size = new System.Drawing.Size(38, 20);
            this.buttonRotateZMinus.TabIndex = 17;
            this.buttonRotateZMinus.Text = "-";
            this.buttonRotateZMinus.UseVisualStyleBackColor = true;
            this.buttonRotateZMinus.Click += new System.EventHandler(this.buttonRotateZMinus_Click);
            // 
            // labelRotateZ
            // 
            this.labelRotateZ.AutoSize = true;
            this.labelRotateZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRotateZ.Location = new System.Drawing.Point(238, 353);
            this.labelRotateZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotateZ.Name = "labelRotateZ";
            this.labelRotateZ.Size = new System.Drawing.Size(55, 17);
            this.labelRotateZ.TabIndex = 18;
            this.labelRotateZ.Text = "z축 회전";
            // 
            // labelRotateY
            // 
            this.labelRotateY.AutoSize = true;
            this.labelRotateY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRotateY.Location = new System.Drawing.Point(96, 398);
            this.labelRotateY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotateY.Name = "labelRotateY";
            this.labelRotateY.Size = new System.Drawing.Size(55, 17);
            this.labelRotateY.TabIndex = 19;
            this.labelRotateY.Text = "y축 회전";
            // 
            // labelRotateX
            // 
            this.labelRotateX.AutoSize = true;
            this.labelRotateX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRotateX.Location = new System.Drawing.Point(96, 373);
            this.labelRotateX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotateX.Name = "labelRotateX";
            this.labelRotateX.Size = new System.Drawing.Size(54, 17);
            this.labelRotateX.TabIndex = 20;
            this.labelRotateX.Text = "x축 회전";
            // 
            // textBoxNodeCOunt
            // 
            this.textBoxNodeCOunt.Location = new System.Drawing.Point(633, 231);
            this.textBoxNodeCOunt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNodeCOunt.Name = "textBoxNodeCOunt";
            this.textBoxNodeCOunt.Size = new System.Drawing.Size(79, 21);
            this.textBoxNodeCOunt.TabIndex = 21;
            this.textBoxNodeCOunt.Visible = false;
            // 
            // textBoxIsNormCount
            // 
            this.textBoxIsNormCount.Location = new System.Drawing.Point(716, 231);
            this.textBoxIsNormCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIsNormCount.Name = "textBoxIsNormCount";
            this.textBoxIsNormCount.Size = new System.Drawing.Size(79, 21);
            this.textBoxIsNormCount.TabIndex = 22;
            this.textBoxIsNormCount.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.X,
            this.Y,
            this.Z});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(634, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.RowTemplate.Height = 15;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(288, 173);
            this.dataGridView1.TabIndex = 24;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 35;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 60;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Width = 60;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            this.Z.Width = 60;
            // 
            // comboBoxChooseNode
            // 
            this.comboBoxChooseNode.FormattingEnabled = true;
            this.comboBoxChooseNode.Location = new System.Drawing.Point(634, 281);
            this.comboBoxChooseNode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxChooseNode.Name = "comboBoxChooseNode";
            this.comboBoxChooseNode.Size = new System.Drawing.Size(95, 20);
            this.comboBoxChooseNode.TabIndex = 27;
            this.comboBoxChooseNode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonTexture
            // 
            this.buttonTexture.Location = new System.Drawing.Point(109, 308);
            this.buttonTexture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTexture.Name = "buttonTexture";
            this.buttonTexture.Size = new System.Drawing.Size(96, 27);
            this.buttonTexture.TabIndex = 28;
            this.buttonTexture.Text = "텍스쳐";
            this.buttonTexture.UseVisualStyleBackColor = true;
            this.buttonTexture.Click += new System.EventHandler(this.buttonTexture_Click);
            // 
            // buttonColorfulQuads
            // 
            this.buttonColorfulQuads.Location = new System.Drawing.Point(12, 308);
            this.buttonColorfulQuads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonColorfulQuads.Name = "buttonColorfulQuads";
            this.buttonColorfulQuads.Size = new System.Drawing.Size(93, 27);
            this.buttonColorfulQuads.TabIndex = 29;
            this.buttonColorfulQuads.Text = "컬러메쉬";
            this.buttonColorfulQuads.UseVisualStyleBackColor = true;
            this.buttonColorfulQuads.Click += new System.EventHandler(this.buttonColorfulQuads_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "빌트인 프리셋 가져오기";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // info1
            // 
            this.info1.Location = new System.Drawing.Point(823, 410);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(99, 23);
            this.info1.TabIndex = 31;
            this.info1.Text = "도움말 및 정보";
            this.info1.UseVisualStyleBackColor = true;
            this.info1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 434);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonColorfulQuads);
            this.Controls.Add(this.buttonTexture);
            this.Controls.Add(this.comboBoxChooseNode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxIsNormCount);
            this.Controls.Add(this.textBoxNodeCOunt);
            this.Controls.Add(this.labelRotateX);
            this.Controls.Add(this.labelRotateY);
            this.Controls.Add(this.labelRotateZ);
            this.Controls.Add(this.buttonRotateZMinus);
            this.Controls.Add(this.buttonRotateXPlus);
            this.Controls.Add(this.buttonRotateXMinus);
            this.Controls.Add(this.buttonRotateYPlus);
            this.Controls.Add(this.buttonRotateYMinus);
            this.Controls.Add(this.buttonRotateZPlus);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.buttonScaleMinus);
            this.Controls.Add(this.buttonScalePlus);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonDivideNMK);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "3D Editor Engine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button buttonDivideNMK;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button buttonScalePlus;
        private System.Windows.Forms.Button buttonScaleMinus;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Button buttonRotateZPlus;
        private System.Windows.Forms.Button buttonRotateYMinus;
        private System.Windows.Forms.Button buttonRotateYPlus;
        private System.Windows.Forms.Button buttonRotateXMinus;
        private System.Windows.Forms.Button buttonRotateXPlus;
        private System.Windows.Forms.Button buttonRotateZMinus;
        private System.Windows.Forms.Label labelRotateZ;
        private System.Windows.Forms.Label labelRotateY;
        private System.Windows.Forms.Label labelRotateX;
        private System.Windows.Forms.TextBox textBoxNodeCOunt;
        private System.Windows.Forms.TextBox textBoxIsNormCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.ComboBox comboBoxChooseNode;
        private System.Windows.Forms.Button buttonTexture;
        private System.Windows.Forms.Button buttonColorfulQuads;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button info1;
    }
}

