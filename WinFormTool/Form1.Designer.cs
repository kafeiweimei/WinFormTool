
namespace WinFormTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_Datas1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_HandleMethod = new System.Windows.Forms.ListBox();
            this.textBox_Datas2 = new System.Windows.Forms.TextBox();
            this.label_Tips0 = new System.Windows.Forms.Label();
            this.checkBox_IsClearFirstAndLastSpace = new System.Windows.Forms.CheckBox();
            this.label_Tips2 = new System.Windows.Forms.Label();
            this.button_CopyDatas2 = new System.Windows.Forms.Button();
            this.button_AddCharacter = new System.Windows.Forms.Button();
            this.button_ClearDatas1Datas2 = new System.Windows.Forms.Button();
            this.label_Tips1 = new System.Windows.Forms.Label();
            this.button_ClearClipboard = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel_Author = new System.Windows.Forms.LinkLabel();
            this.listBox_ConvertOpreation = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_Datas1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL数据处理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_Datas1
            // 
            this.textBox_Datas1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Datas1.Location = new System.Drawing.Point(17, 51);
            this.textBox_Datas1.Multiline = true;
            this.textBox_Datas1.Name = "textBox_Datas1";
            this.textBox_Datas1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Datas1.Size = new System.Drawing.Size(364, 527);
            this.textBox_Datas1.TabIndex = 0;
            this.textBox_Datas1.TextChanged += new System.EventHandler(this.textBox_Datas1_TextChanged);
            this.textBox_Datas1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Datas1_KeyDown);
            this.textBox_Datas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_Datas1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBox_ConvertOpreation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox_HandleMethod);
            this.groupBox1.Controls.Add(this.textBox_Datas2);
            this.groupBox1.Controls.Add(this.label_Tips0);
            this.groupBox1.Controls.Add(this.checkBox_IsClearFirstAndLastSpace);
            this.groupBox1.Controls.Add(this.label_Tips2);
            this.groupBox1.Controls.Add(this.button_CopyDatas2);
            this.groupBox1.Controls.Add(this.button_AddCharacter);
            this.groupBox1.Controls.Add(this.button_ClearDatas1Datas2);
            this.groupBox1.Controls.Add(this.label_Tips1);
            this.groupBox1.Controls.Add(this.button_ClearClipboard);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 582);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实现给每行数据首尾添加单引号和逗号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(909, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "数据2";
            // 
            // listBox_HandleMethod
            // 
            this.listBox_HandleMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_HandleMethod.FormattingEnabled = true;
            this.listBox_HandleMethod.ItemHeight = 17;
            this.listBox_HandleMethod.Items.AddRange(new object[] {
            "处理方法一",
            "处理方法二",
            "处理方法三"});
            this.listBox_HandleMethod.Location = new System.Drawing.Point(461, 46);
            this.listBox_HandleMethod.Name = "listBox_HandleMethod";
            this.listBox_HandleMethod.Size = new System.Drawing.Size(224, 55);
            this.listBox_HandleMethod.TabIndex = 14;
            this.listBox_HandleMethod.SelectedIndexChanged += new System.EventHandler(this.listBox_HandleMethod_SelectedIndexChanged);
            // 
            // textBox_Datas2
            // 
            this.textBox_Datas2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Datas2.Location = new System.Drawing.Point(761, 44);
            this.textBox_Datas2.Multiline = true;
            this.textBox_Datas2.Name = "textBox_Datas2";
            this.textBox_Datas2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Datas2.Size = new System.Drawing.Size(356, 527);
            this.textBox_Datas2.TabIndex = 6;
            this.textBox_Datas2.TextChanged += new System.EventHandler(this.textBox_Datas2_TextChanged);
            // 
            // label_Tips0
            // 
            this.label_Tips0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tips0.AutoSize = true;
            this.label_Tips0.Location = new System.Drawing.Point(464, 461);
            this.label_Tips0.Name = "label_Tips0";
            this.label_Tips0.Size = new System.Drawing.Size(63, 17);
            this.label_Tips0.TabIndex = 13;
            this.label_Tips0.Text = "信息提示0";
            // 
            // checkBox_IsClearFirstAndLastSpace
            // 
            this.checkBox_IsClearFirstAndLastSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_IsClearFirstAndLastSpace.AutoSize = true;
            this.checkBox_IsClearFirstAndLastSpace.Location = new System.Drawing.Point(464, 112);
            this.checkBox_IsClearFirstAndLastSpace.Name = "checkBox_IsClearFirstAndLastSpace";
            this.checkBox_IsClearFirstAndLastSpace.Size = new System.Drawing.Size(183, 21);
            this.checkBox_IsClearFirstAndLastSpace.TabIndex = 12;
            this.checkBox_IsClearFirstAndLastSpace.Text = "是否清除每行内容的首尾空格";
            this.checkBox_IsClearFirstAndLastSpace.UseVisualStyleBackColor = true;
            this.checkBox_IsClearFirstAndLastSpace.Click += new System.EventHandler(this.checkBox_IsClearFirstAndLastSpace_Click);
            // 
            // label_Tips2
            // 
            this.label_Tips2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tips2.AutoSize = true;
            this.label_Tips2.Location = new System.Drawing.Point(464, 556);
            this.label_Tips2.Name = "label_Tips2";
            this.label_Tips2.Size = new System.Drawing.Size(63, 17);
            this.label_Tips2.TabIndex = 11;
            this.label_Tips2.Text = "信息提示2";
            // 
            // button_CopyDatas2
            // 
            this.button_CopyDatas2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CopyDatas2.Location = new System.Drawing.Point(461, 315);
            this.button_CopyDatas2.Name = "button_CopyDatas2";
            this.button_CopyDatas2.Size = new System.Drawing.Size(224, 31);
            this.button_CopyDatas2.TabIndex = 3;
            this.button_CopyDatas2.Text = "复制数据2";
            this.button_CopyDatas2.UseVisualStyleBackColor = true;
            this.button_CopyDatas2.Click += new System.EventHandler(this.button_CopyDatas2_Click);
            // 
            // button_AddCharacter
            // 
            this.button_AddCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddCharacter.Location = new System.Drawing.Point(461, 266);
            this.button_AddCharacter.Name = "button_AddCharacter";
            this.button_AddCharacter.Size = new System.Drawing.Size(224, 31);
            this.button_AddCharacter.TabIndex = 2;
            this.button_AddCharacter.Text = "给每行内容首尾添加单引号与逗号";
            this.button_AddCharacter.UseVisualStyleBackColor = true;
            this.button_AddCharacter.Click += new System.EventHandler(this.button_AddCharacter_Click);
            // 
            // button_ClearDatas1Datas2
            // 
            this.button_ClearDatas1Datas2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearDatas1Datas2.Location = new System.Drawing.Point(461, 414);
            this.button_ClearDatas1Datas2.Name = "button_ClearDatas1Datas2";
            this.button_ClearDatas1Datas2.Size = new System.Drawing.Size(224, 31);
            this.button_ClearDatas1Datas2.TabIndex = 5;
            this.button_ClearDatas1Datas2.Text = "清空数据1数据2内容";
            this.button_ClearDatas1Datas2.UseVisualStyleBackColor = true;
            this.button_ClearDatas1Datas2.Click += new System.EventHandler(this.button_ClearDatas1Datas2_Click);
            // 
            // label_Tips1
            // 
            this.label_Tips1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tips1.AutoSize = true;
            this.label_Tips1.Location = new System.Drawing.Point(464, 510);
            this.label_Tips1.Name = "label_Tips1";
            this.label_Tips1.Size = new System.Drawing.Size(63, 17);
            this.label_Tips1.TabIndex = 9;
            this.label_Tips1.Text = "信息提示1";
            // 
            // button_ClearClipboard
            // 
            this.button_ClearClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearClipboard.Location = new System.Drawing.Point(461, 365);
            this.button_ClearClipboard.Name = "button_ClearClipboard";
            this.button_ClearClipboard.Size = new System.Drawing.Size(224, 31);
            this.button_ClearClipboard.TabIndex = 4;
            this.button_ClearClipboard.Text = "清空剪贴板";
            this.button_ClearClipboard.UseVisualStyleBackColor = true;
            this.button_ClearClipboard.Click += new System.EventHandler(this.button_ClearClipboard_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "工具2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel_Author
            // 
            this.linkLabel_Author.AutoSize = true;
            this.linkLabel_Author.Location = new System.Drawing.Point(1082, 9);
            this.linkLabel_Author.Name = "linkLabel_Author";
            this.linkLabel_Author.Size = new System.Drawing.Size(56, 17);
            this.linkLabel_Author.TabIndex = 1;
            this.linkLabel_Author.TabStop = true;
            this.linkLabel_Author.Text = "关于作者";
            this.linkLabel_Author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Author_LinkClicked);
            // 
            // listBox_ConvertOpreation
            // 
            this.listBox_ConvertOpreation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_ConvertOpreation.FormattingEnabled = true;
            this.listBox_ConvertOpreation.ItemHeight = 17;
            this.listBox_ConvertOpreation.Items.AddRange(new object[] {
            "不做任何转换",
            "全部转为大写",
            "全部转为小写"});
            this.listBox_ConvertOpreation.Location = new System.Drawing.Point(461, 159);
            this.listBox_ConvertOpreation.Name = "listBox_ConvertOpreation";
            this.listBox_ConvertOpreation.Size = new System.Drawing.Size(224, 55);
            this.listBox_ConvertOpreation.TabIndex = 15;
            this.listBox_ConvertOpreation.SelectedIndexChanged += new System.EventHandler(this.listBox_ConvertOpreation_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 644);
            this.Controls.Add(this.linkLabel_Author);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "桌面工具箱";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Datas1;
        private System.Windows.Forms.Button button_AddCharacter;
        private System.Windows.Forms.Button button_ClearClipboard;
        private System.Windows.Forms.Button button_CopyDatas2;
        private System.Windows.Forms.Button button_ClearDatas1Datas2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Datas2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Tips1;
        private System.Windows.Forms.Label label_Tips2;
        private System.Windows.Forms.CheckBox checkBox_IsClearFirstAndLastSpace;
        private System.Windows.Forms.Label label_Tips0;
        private System.Windows.Forms.ListBox listBox_HandleMethod;
        private System.Windows.Forms.LinkLabel linkLabel_Author;
        private System.Windows.Forms.ListBox listBox_ConvertOpreation;
    }
}

