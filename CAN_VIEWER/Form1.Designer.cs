namespace CAN_VIEWER
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ECU");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ECU 노드");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("메세지");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("시그널");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("네트워크", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trNode = new System.Windows.Forms.TreeView();
            this.dgCanView = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbFltName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Colunm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trNode
            // 
            this.trNode.Location = new System.Drawing.Point(-1, 81);
            this.trNode.Name = "trNode";
            treeNode1.Name = "ECU";
            treeNode1.Text = "ECU";
            treeNode2.Name = "ECU_NODE";
            treeNode2.Text = "ECU 노드";
            treeNode3.Name = "MESSAGE";
            treeNode3.Text = "메세지";
            treeNode4.Name = "SIGNAL";
            treeNode4.Text = "시그널";
            treeNode5.Name = "네트워크";
            treeNode5.Text = "네트워크";
            this.trNode.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.trNode.Size = new System.Drawing.Size(401, 958);
            this.trNode.TabIndex = 0;
            this.trNode.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trNode_NodeMouseClick);
            // 
            // dgCanView
            // 
            this.dgCanView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCanView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colunm1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgCanView.Location = new System.Drawing.Point(406, 81);
            this.dgCanView.Name = "dgCanView";
            this.dgCanView.RowTemplate.Height = 23;
            this.dgCanView.Size = new System.Drawing.Size(1499, 774);
            this.dgCanView.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(406, 861);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1499, 184);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1508, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "CAN_DB 저장";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1710, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tbFltName
            // 
            this.tbFltName.Location = new System.Drawing.Point(523, 29);
            this.tbFltName.Name = "tbFltName";
            this.tbFltName.Size = new System.Drawing.Size(135, 21);
            this.tbFltName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(698, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(746, 29);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(135, 21);
            this.tbID.TabIndex = 7;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(988, 29);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(275, 20);
            this.cbFilter.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(939, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "필터 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1906, 82);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 52);
            this.label4.TabIndex = 13;
            this.label4.Text = "CAN_DB_EDITOR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1305, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 78);
            this.button3.TabIndex = 12;
            this.button3.Text = "CAN_DB 불러오기";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Colunm1
            // 
            this.Colunm1.HeaderText = "이름";
            this.Colunm1.Name = "Colunm1";
            this.Colunm1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "프로토콜";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "코멘트";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "멀티플렉싱";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "버스타입";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbFltName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgCanView);
            this.Controls.Add(this.trNode);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAN_DB_EDITOR";
            ((System.ComponentModel.ISupportInitialize)(this.dgCanView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trNode;
        private System.Windows.Forms.DataGridView dgCanView;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbFltName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colunm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

