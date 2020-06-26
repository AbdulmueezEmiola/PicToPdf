using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicToPdf
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*jpeg;*jpg;*png";
            openFileDialog.Title = "Select Images to convert to Pdf";
            openFileDialog.Multiselect = true;
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {
                foreach(string file in openFileDialog.FileNames)
                {
                    ListViewItem item = new ListViewItem(file);
                    listViewImages.Items.Add(item);
                    list.Add(file);
                }
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string destination = textBoxDestination.Text + "/" + DateTime.Now.Ticks + ".pdf";
            string caption = "Cannot convert";
            if (textBoxDestination.TextLength <= 0)
            {
                string message = "No destination has been specified";
                MessageBox.Show(message, caption);
                return;
            }
            else if (listViewImages.Items.Count <= 0)
            {
                string message = "No image has been added";
                MessageBox.Show(message, caption);
                return;
            }
            pictureBox1.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string caption = "Delete Items";
            string messageForNoSelected = "No item has been selected for deleting";
            string messageForSelected = "Are you sure you want to delete this items";
            if(listViewImages.SelectedItems.Count == 0)
            {
                MessageBox.Show(messageForNoSelected, caption);
            }
            else
            {
                var result = MessageBox.Show(messageForSelected, caption, MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    foreach(ListViewItem item in listViewImages.SelectedItems)
                    {
                        list.RemoveAt(item.Index);
                        item.Remove();
                    }
                }
            }
        }

        private void buttonDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void Convert(List<string> images, string destination)
        {
            PdfDocument doc = new PdfDocument();
            for (int i = 0; i < images.Count; i++)
            {
                
                var page = doc.AddPage();
                XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[i]);
                XImage img = XImage.FromFile(images[i]);
                xgr.DrawImage(img, 0, 0, page.Width, page.Height);
            }
            doc.Save(destination);
        }

        private void textBoxDestination_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            string destination = textBoxDestination.Text + "/" + DateTime.Now.Ticks + ".pdf";
            Convert(list, destination);
            var optimizedpath = destination.Replace(".pdf", "optimized.pdf");
            PDFCompressor.compressFiles(destination, optimizedpath);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            MessageBox.Show("Image has been converted and compressed", "DONE");
        }
    }
}
