using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace DragDropZipper
{
    public partial class Form1 : Form
    {
        private List<string> droppedFiles = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // フォームにドラッグ＆ドロップ許可
            this.AllowDrop = true;
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;

            // ボタンイベント
            buttonZip.Click += buttonZip_Click;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            droppedFiles.AddRange(files);
            droppedFiles = droppedFiles.Distinct().ToList(); // 重複除去

            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(droppedFiles.Select(Path.GetFileName).ToArray());
        }

        private void buttonZip_Click(object sender, EventArgs e)
        {
            if (droppedFiles.Count == 0)
            {
                MessageBox.Show("まずはファイルをドロップしてね！");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "ZIPファイル (*.zip)|*.zip";
                sfd.FileName = "CompressedFiles.zip";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ZipArchive zip = ZipFile.Open(sfd.FileName, ZipArchiveMode.Create))
                        {
                            foreach (string file in droppedFiles)
                            {
                                if (File.Exists(file))
                                    zip.CreateEntryFromFile(file, Path.GetFileName(file));
                            }
                        }

                        MessageBox.Show("圧縮完了！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("エラー: " + ex.Message);
                    }
                }
            }
        }

        private void UpdateListBox()
        {
            listBoxFiles.Items.Clear();
            foreach (var file in droppedFiles)
            {
                listBoxFiles.Items.Add(file);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var selected = listBoxFiles.SelectedItems.Cast<string>().ToList();
            foreach (var item in selected)
            {
                droppedFiles.Remove(item);
            }

            UpdateListBox();
        }

        private void labelDropHere_Click(object sender, EventArgs e)
        {

        }
    }
}
