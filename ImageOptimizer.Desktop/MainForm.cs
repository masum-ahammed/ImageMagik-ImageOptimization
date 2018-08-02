using ImageMagick;
using ImageMagick.ImageOptimizers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOptimizer.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSourceSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = sourceFolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtSource.Text = sourceFolderDialog.SelectedPath;
            }
            
        }

        private void btnOutputFolderSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtOutput.Text = outputFolderDialog.SelectedPath;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            ProcessDirectory(txtSource.Text);

        }

        public  void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            MessageBox.Show("Done!");
        }

        public  void ProcessFile(string path)
        {
            using (TemporaryFile tempFile = new TemporaryFile(path))
            {
                string format = Path.GetExtension(path);
                if (format == ".jpg" || format == ".jpeg")
                {
                    CompressJpgImage(tempFile);

                }
                if (format == ".png")
                {
                    (new PngOptimizer()).Compress(tempFile);
                }

                
                File.Copy(tempFile.FullName, $"{txtOutput.Text }/{Path.GetFileName(path)}", true);
               // info = new MagickImageInfo(tempFile);

            }
        }

        private void CompressJpgImage(TemporaryFile tempFile)
        {
            var jpegOptimizer = new JpegOptimizer();
            if (chkQuality.Checked)
            {
                jpegOptimizer.Compress(tempFile, int.Parse(txtQuality.Text));
            }
            else
            {
                jpegOptimizer.Compress(tempFile);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
