using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region   实现给每行数据首尾添加单引号和逗号

        private void Init()
        {
            //默认选择处理方法1
            listBox_HandleMethod.SelectedIndex = 0;
        }

        string selectHandeMethodName = "";
        private void listBox_HandleMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox_HandleMethod.SelectedItem.ToString();
            int index = listBox_HandleMethod.FindString(curItem);
            selectHandeMethodName = curItem;
        }

        string selectConvertMethodName="";
        private void listBox_ConvertOpreation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox_ConvertOpreation.SelectedItem.ToString();
            int index = listBox_HandleMethod.FindString(curItem);
            selectConvertMethodName = curItem;
        }

        bool isClearFirstAndLastSpace = false;
        private void checkBox_IsClearFirstAndLastSpace_Click(object sender, EventArgs e)
        {
            if (checkBox_IsClearFirstAndLastSpace.Checked)
            {
                isClearFirstAndLastSpace = true;
                checkBox_IsClearFirstAndLastSpace.Text = "清除每行内容的首尾空格";
                checkBox_IsClearFirstAndLastSpace.ForeColor = Color.Green;
            }
            else
            {
                isClearFirstAndLastSpace = false;
                checkBox_IsClearFirstAndLastSpace.Text = "不清除每行内容的首尾空格";
                checkBox_IsClearFirstAndLastSpace.ForeColor = Color.Black;
            }
        }


        private delegate void TextBoxPaste(bool use);
        private TextBoxPaste textBoxPaste;


        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys))
            {
                int keyNum = msg.WParam.ToInt32();
                //keyNum=86是Ctrl+V的数字
                if (keyNum == 86)
                {
                    textBoxPaste(true);
                }
                return true;

            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void textBox_Datas1_KeyDown(object sender, KeyEventArgs e)
        {
            ////禁用默认的Ctrl+V粘贴
            //textBox_Datas1.ShortcutsEnabled = false;

            ////同时按下Ctrl+V粘贴数据到Text控件中
            //if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            //{
            //    isCopyClipboard = false;
            //    GetClipboardTextDatas(textBox_Datas1);
            //}
            textBoxPaste += textBox_Datas1_KeyDown;
           
        }

        private void textBox_Datas1_KeyDown(bool use)
        {
            if (use)
            {
                GetClipboardTextDatas(textBox_Datas1);
                isCopyClipboard = false;
            }
           
        }

        private void button_AddCharacter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            switch (selectHandeMethodName)
            {
                case "处理方法一":
                    HandleDataMethod1(textBox_Datas1, textBox_Datas2, selectConvertMethodName, isClearFirstAndLastSpace);
                    break;
                case "处理方法二":
                    HandleDataMethod2(textBox_Datas1, textBox_Datas2, selectConvertMethodName, isClearFirstAndLastSpace);
                    break;
                case "处理方法三":
                    HandleDataMethod3(textBox_Datas1, textBox_Datas2, selectConvertMethodName, isClearFirstAndLastSpace);
                    break;
                default:
                    HandleDataMethod1(textBox_Datas1, textBox_Datas2, selectConvertMethodName, isClearFirstAndLastSpace);
                    break;
            }
            
            stopwatch.Stop();
            label_Tips0.Text = $"花费时间是【{stopwatch.ElapsedMilliseconds}】毫秒";
            label_Tips0.ForeColor = Color.Orange;
        }

        private void button_CopyDatas2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBox_Datas2.Text);
        }

        private void button_ClearClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void button_ClearDatas1Datas2_Click(object sender, EventArgs e)
        {
            isCopyClipboard = false;
            
            textBox_Datas1.Text = "";
            textBox_Datas2.Text = "";
            label_Tips0.Text = "方法花费时间";
        }


        private void textBox_Datas1_MouseDown(object sender, MouseEventArgs e)
        {
            /*原计划是实现按下鼠标右键且选择粘贴才执行逻辑；但尝试许久无法实现*/

            //现在修改为使用按下鼠标右键配合文本内容改变事件使用
            if (e.Button == MouseButtons.Right)
            {
                isCopyClipboard = true;
                clipboardLen = Clipboard.GetText().Length;
                textBox_Datas1.Text = "";
            }

        }

        bool isCopyClipboard = false;
        int clipboardLen = -1;
        private void textBox_Datas1_TextChanged(object sender, EventArgs e)
        {
            if (isCopyClipboard && textBox_Datas1.Text.Length != clipboardLen)
            {
                isCopyClipboard = false;
                GetClipboardTextDatas(textBox_Datas1);
            }

            label_Tips1.Text = $"当前数据1共有【{textBox_Datas1.Lines.Length-1}】行数据";
        }

        private void textBox_Datas2_TextChanged(object sender, EventArgs e)
        {
            //获取焦点
            textBox_Datas2.Focus();
            //光标定位到文本最后
            textBox_Datas2.Select(textBox_Datas2.TextLength, 0);
            //滚动到光标处
            textBox_Datas2.ScrollToCaret();

            label_Tips2.Text = $"当前数据2共有【{textBox_Datas2.Lines.Length - 1}】行数据";
        }


        /// <summary>
        /// 获取数据并添加前后单引号末尾添加逗号方法1
        /// </summary>
        /// <param name="OriginalDataTextBox">原始数据的TextBox控件</param>
        /// <param name="acceptTextBox">接收处理后数据的TextBox控件</param>
        /// <param name="selectConvertMethodName">选择转换的方法名称</param>
        /// <param name="isClearFirstAndLastSpace">是否去除每行内容的首尾空格</param>
        private void HandleDataMethod1(TextBox OriginalDataTextBox, TextBox acceptTextBox, string selectConvertMethodName = "不做任何转换", bool isClearFirstAndLastSpace = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(OriginalDataTextBox.Text);

            if (sb.ToString().Contains('\r'))
            {
                acceptTextBox.Text = "";

                try
                {
                    char[] splitChars = new char[] { '\r', '\n' };
                    string[] strArray = sb.ToString().Split(splitChars);
                    StringBuilder sb2 = new StringBuilder();

                    int len = strArray.Length;
                    int realLen = (len - 1) / 2;

                    for (int i = 0; i < len; i++)
                    {
                        string strTmp = strArray[i];
                        if (string.IsNullOrEmpty(strTmp))
                        {
                            continue;
                        }
                        if (isClearFirstAndLastSpace)
                        {
                            strTmp = strTmp.Replace('\n', ' ').Trim();
                        }

                        switch (selectConvertMethodName)
                        {
                            case "不做任何转换":
                                break;
                            case "全部转为大写":
                                strTmp = strTmp.ToUpper();
                                break;
                            case "全部转为小写":
                                strTmp = strTmp.ToLower();
                                break;
                            default:
                                break;
                        }

                        string str = $"'{strTmp}'";
                        realLen--;
                        if (realLen > 0)
                        {
                            str += ",";
                        }
                        sb2.AppendLine(str);

                        //System.Threading.Thread.Sleep(10);
                    }


                    acceptTextBox.Text = sb2.ToString();

                    sb2.Clear();
                    Array.Clear(strArray, 0, strArray.Length);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sb.Clear();
                }

            }
            else
            {
                MessageBox.Show("当前需处理的数据1不包含[\t]字符不用不符合处理规则，无法处理！！！", "错误提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// 获取数据并添加前后单引号末尾添加逗号方法2
        /// </summary>
        /// <param name="OriginalDataTextBox">原始数据的TextBox控件</param>
        /// <param name="acceptTextBox">接收处理后数据的TextBox控件</param>
        /// <param name="selectConvertMethodName">选择转换的方法名称</param>
        /// <param name="isClearFirstAndLastSpace">是否去除每行内容的首尾空格</param>
        private void HandleDataMethod2(TextBox OriginalDataTextBox, TextBox acceptTextBox,string selectConvertMethodName = "不做任何转换", bool isClearFirstAndLastSpace = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(OriginalDataTextBox.Text);

            if (sb.ToString().Contains('\r'))
            {
                acceptTextBox.Text = "";

                try
                {
                    string[] strArray = sb.ToString().Split('\r');
                    StringBuilder sb2 = new StringBuilder();

                    int len = strArray.Length;

                    for (int i = 0; i < len - 1; i++)
                    {
                        string strTmp = strArray[i];

                        if (strTmp.Contains('\n'))
                        {
                            if (isClearFirstAndLastSpace)
                            {
                                strTmp = strTmp.Replace('\n', ' ').Trim();
                            }
                            else
                            {
                                strTmp = strTmp.Split('\n')[1];
                            }
                           
                        }

                        switch (selectConvertMethodName)
                        {
                            case "不做任何转换":
                               
                                break;
                            case "全部转为大写":
                                strTmp = strTmp.ToUpper();
                                break;
                            case "全部转为小写":
                                strTmp = strTmp.ToLower();
                                break;
                            default:
                                break;
                        }

                        string str = $"'{strTmp}'";

                        if (i < len - 2)
                        {
                            str += ",";
                        }
                        sb2.AppendLine(str);

                        //System.Threading.Thread.Sleep(10);
                    }

                    acceptTextBox.Text = sb2.ToString();

                    sb2.Clear();
                    Array.Clear(strArray, 0, strArray.Length);

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sb.Clear();
                }
            }
            else
            {
                MessageBox.Show("当前需处理的数据1不包含[\t]字符不用不符合处理规则，无法处理！！！", "错误提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 获取数据并添加前后单引号末尾添加逗号方法3
        /// </summary>
        /// <param name="OriginalDataTextBox">原始数据的TextBox控件</param>
        /// <param name="acceptTextBox">接收处理后数据的TextBox控件</param>
        /// <param name="selectConvertMethodName">选择转换的方法名称</param>
        /// <param name="isClearFirstAndLastSpace">是否去除每行内容的首尾空格</param>
        private void HandleDataMethod3(TextBox OriginalDataTextBox,TextBox acceptTextBox,string selectConvertMethodName = "不做任何转换", bool isClearFirstAndLastSpace=false)
        {
            if (!string.IsNullOrEmpty(OriginalDataTextBox.Text))
            {
                int len = OriginalDataTextBox.Lines.Length;
                string[] tmpArray = OriginalDataTextBox.Lines;
                StringBuilder sb = new StringBuilder();
                try
                {
                    acceptTextBox.Text = "";

                    string strTmp = "";
                    string str = "";
                    for (int i = 0; i < len - 1; i++)
                    {
                        strTmp = tmpArray[i];
                        if (isClearFirstAndLastSpace)
                        {
                            strTmp = strTmp.Trim();
                        }

                        switch (selectConvertMethodName)
                        {
                            case "不做任何转换":
                               
                                break;
                            case "全部转为大写":
                                strTmp = strTmp.ToUpper();
                                break;
                            case "全部转为小写":
                                strTmp = strTmp.ToLower();
                                break;
                            default:
                                break;
                        }

                        if (i == len - 2)
                        {
                            str = $"'{strTmp}'";
                        }
                        else
                        {
                            str = $"'{strTmp}',";
                        }

                        sb.AppendLine(str);

                    }

                    acceptTextBox.Text = sb.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    Array.Clear(tmpArray, 0, tmpArray.Length);
                    sb?.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("当前需处理的数据1不能为空，请检查后重试！", "错误提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// 获取剪贴板的文本数据
        /// </summary>
        /// <param name="textBox">需要显示粘贴板数据的TextBox控件</param>
        private void GetClipboardTextDatas(TextBox textBox)
        {
            if (Clipboard.ContainsText())
            {
                textBox.Text = Clipboard.GetText();
                ////让光标显示在内容最后
                //textBox_Datas1.SelectionStart= textBox_Datas1.Text.Length;
                //光标定位到文本最后
                textBox.Select(textBox.TextLength, 0);
                //滚动到光标处
                textBox.ScrollToCaret();
            }
        }




        #endregion

        private void linkLabel_Author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel_Author.LinkVisited = true;
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://coffeemilk.blog.csdn.net") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }//Class_end
}
