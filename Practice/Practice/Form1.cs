using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class OneLineMemo : Form
    {
        public OneLineMemo()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("保存しますか？", "ファイルに追加", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "ファイルを保存する"; // ダイアログタイトル
                    saveFileDialog.OverwritePrompt = true;       // 上書き時に警告する
                    saveFileDialog.RestoreDirectory = true;      // 直前のフォルダを記憶する
                    DialogResult result = saveFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        using (var sw = new System.IO.StreamWriter(saveFileDialog.FileName, true, Encoding.GetEncoding("UTF-8")))
                        {
                            sw.WriteLine(textBox1.Text);
                        }
                        MessageBox.Show("保存しました。");
                    }
                }
            }
            else
            {
                MessageBox.Show("文字を入力してください。", "文字未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("書き直しますか", "書き直し確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    textBox1.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("入力がありません。", "文字未入力", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("終了しますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
