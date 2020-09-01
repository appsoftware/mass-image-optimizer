using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AppSoftware.MassImageOptimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetUpForm();
        }

        private void SetUpForm()
        {
            m_progressBar.Maximum = 100;
            m_progressBar.Step = 100;
            m_resultsListBox.HorizontalScrollbar = true;
            m_maxHeightTxtBox.Enabled = false;
            m_maxWidthTxtBox.Enabled = false;
            DisplayQualityTrackBarValue();
            
        }


        private void m_browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select Folder Containing Images to Be Optimized";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                m_folderPathTxtBox.Text = folderBrowser.SelectedPath;
            }
        }


        private void m_goBtn_Click(object sender, EventArgs e)
        {
            ResetFormValues();

            m_goBtn.Enabled = false;

            if ( ! String.IsNullOrEmpty(m_folderPathTxtBox.Text ))
            {
                VoidMethodsDelegate processImagesDelegate = delegate()
                {
                    ProcessImagesInDirectory(m_folderPathTxtBox.Text, m_intTrackBarValue);
                };

                processImagesDelegate.BeginInvoke(DisplayImagesProcessedResult, null);
            }
            else
            {
                MessageBox.Show("Please select the folder containing the images you want to optimize.", "Please Select a Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            m_goBtn.Text = "Optimize Images in Directory";
        }

  
        private void ProcessImagesInDirectory( string dirPath, int imageQuality )
        {
            DirectoryInfo dirInfo = new DirectoryInfo( dirPath );

            FileInfo[] fileInfoArr = dirInfo.GetFiles();

            m_fileCount = fileInfoArr.Length;

            m_saveDirectory = dirPath + "\\Optimized_Images\\";

            string fileName = "";

            string imageSavePath = "";


            SingleStringArgDelegate confirmSuccessStatus;


            int maxWidth = 450; // Defaults in case text box empty
            int maxHeight = 450;

            if (!String.IsNullOrEmpty(m_maxHeightTxtBox.Text))
            {
                maxHeight = int.Parse(m_maxHeightTxtBox.Text);
            }
            if (!String.IsNullOrEmpty(m_maxWidthTxtBox.Text))
            {
                maxWidth = int.Parse(m_maxWidthTxtBox.Text);
            }

            foreach (FileInfo fileInfo in fileInfoArr)
            {
                string fileExtension = fileInfo.Extension.ToLower();
                fileExtension = fileExtension.Replace(".", "");

                ImageFormat format;

                try
                {
                    format = (ImageFormat) Enum.Parse(typeof(ImageFormat), fileExtension, ignoreCase: true);
                }
                catch
                {
                    format = ImageFormat.Unrecognised;
                }

                fileName = fileInfo.Name;

                imageSavePath = m_saveDirectory + fileName;

                if (format != ImageFormat.Unrecognised)
                {
                    FileStream fileStream = fileInfo.OpenRead();

                    if (!Directory.Exists(m_saveDirectory))
                    {
                        Directory.CreateDirectory(m_saveDirectory);
                    }

                    Bitmap bitmap = new Bitmap(fileStream);

                    if (m_resizeImagesChkBx.Checked)
                    {

                        bitmap = ImageResizer.ResizeBitmap(bitmap, maxHeight, maxWidth);
                    }

                    ImageCompressor imageCompressor = new ImageCompressor();

                    imageCompressor.CompressAndSaveImage(bitmap, imageSavePath, format, imageQuality);

                    // Assign success message to delegate
                    confirmSuccessStatus = new SingleStringArgDelegate(AddImageProcessSuccessMessage);
                    
                    // Free up resources
                    bitmap.Dispose();
                    fileStream.Dispose();
                }
                else
                {
                    // Assign failure message to delegate
                    confirmSuccessStatus = new SingleStringArgDelegate(AddImageProcessFailureMessage);
                };

                this.BeginInvoke(confirmSuccessStatus, new object[] { fileName });
            }
        }


        private void DisplayImagesProcessedResult(IAsyncResult ar)
        {
            if (ar.IsCompleted == true)
            {
                if (m_filesSuccessfullyProcessed > 0)
                {
                    MessageBox.Show("Optimization Complete!\n\nYour optimized images have been saved in " + m_saveDirectory, "Optimization Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There were no image files in a recogniseable format in the folder you specified.", "No Image Files Fount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                VoidMethodsDelegate resetFormControlsDelegate = delegate()
                {
                    this.m_progressBar.Value = 0;
                    this.m_goBtn.Enabled = true;
                };

                this.BeginInvoke(resetFormControlsDelegate);

            }
            else
            {
                //
            }
        }


        private void AddImageProcessSuccessMessage(string arg)
        {
            this.m_resultsListBox.Items.Add("Image optimized: " + arg);
            UpdateForm();
        }

        private void AddImageProcessFailureMessage(string arg)
        {
            this.m_resultsListBox.Items.Add("Failed to Optimize Image: " + arg);
            UpdateForm();
        }


        private void UpdateForm()
        {
            lock (this)
            {
                m_filesProcessedCount++;
                m_filesSuccessfullyProcessed++;
                m_resultsListBox.Update();
                m_progressCheck = ((100.00 / m_fileCount) * m_filesProcessedCount);

                if (m_progressCheck <= 100)
                {
                    m_progressBar.Value = (int)m_progressCheck;
                }
            }
        }


        private void m_resizeImagesChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (m_resizeImagesChkBx.Checked)
            {
                m_maxHeightTxtBox.Enabled = true;
                m_maxWidthTxtBox.Enabled = true;
            }
            else
            {
                m_maxHeightTxtBox.Enabled = false;
                m_maxWidthTxtBox.Enabled = false;
            }
        }

        private void ResetFormValues()
        {
            m_progressCheck = 0;
            m_resultsListBox.Items.Clear();
            m_fileCount = 0;
            m_filesProcessedCount = 0;
        }

        private void DisplayQualityTrackBarValue()
        {
            m_intTrackBarValue = m_qualityTrackBar.Value * 2;

            m_qualitySliderValTxtBox.Text = m_intTrackBarValue.ToString();
            
        }

        private void m_qualityTrackBar_Scroll(object sender, EventArgs e)
        {
            DisplayQualityTrackBarValue();
        }


        private delegate void SingleStringArgDelegate(string stringValue);

        private delegate void VoidMethodsDelegate();


        private double m_progressCheck = 0;

        int m_intTrackBarValue = 0;

        int m_filesProcessedCount = 0;

        int m_filesSuccessfullyProcessed = 0;

        int m_fileCount = 0;

        string m_saveDirectory = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
