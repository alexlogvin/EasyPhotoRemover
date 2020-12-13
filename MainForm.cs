using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Easy_Photo_Remover
{
    public partial class MainForm : Form
    {
        class ImageInfo
        {
            public string Path;
            public bool ToDelete = false;
        }

        private string SourceFolder;

        private ImageInfo CurrentImage = null;
        private int CurrentImageIndex
        {
            get => _currentImageIndex; set
            {
                if (value < 0)
                    _currentImageIndex = ImagesCount - 1;
                else if (value >= ImagesCount)
                    _currentImageIndex = 0;
                else _currentImageIndex = value;
                CurrentImage = Images.ElementAtOrDefault(_currentImageIndex);
                UpdateImageViewer();
            }
        }
        private int _currentImageIndex = 0;

        private List<ImageInfo> Images
        {
            get => _images; set
            {
                _images = value;
                ImagesCount = _images.Count();
                ImagesToDeleteCount = 0;
                lblTotalImages.Text = $"Total images: {ImagesCount}";
                if (ImagesCount > 0)
                    CurrentImageIndex = 0;
            }
        }
        private List<ImageInfo> _images = new List<ImageInfo>();
        private int ImagesCount = 0;
        private int ImagesToDeleteCount
        {
            get => _imagesToDeleteCount; set
            {
                _imagesToDeleteCount = value;
                lblImagesToDelete.Text = $"Images to delete: {ImagesToDeleteCount}";
            }
        }
        private int _imagesToDeleteCount = 0;

        private readonly List<string> AllowedExtentions = new List<string> { ".jpg", ".png", ".jpeg" };

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFolderChooser_Click(object sender, EventArgs e)
        {
            DialogResult result = folderChooser.ShowDialog();
            if (result == DialogResult.OK)
                UpdateImagesList(folderChooser.SelectedPath);
        }

        private void UpdateImagesList(string folderPath)
        {
            lblChoosenFolder.Text = SourceFolder = folderPath;
            Images = Directory.GetFiles(SourceFolder).Where(x => AllowedExtentions.Contains(new FileInfo(x).Extension)).Select(x => new ImageInfo { Path = x }).ToList();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (ImagesCount > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    ImageInfo image = Images[CurrentImageIndex];
                    image.ToDelete = !image.ToDelete;
                    ImagesToDeleteCount += image.ToDelete ? 1 : -1;

                    if (image.ToDelete)
                        CurrentImageIndex++;
                    UpdateImageStatus();
                }

                else if (e.KeyCode == Keys.Left)
                    CurrentImageIndex--;
                else if (e.KeyCode == Keys.Right)
                    CurrentImageIndex++;
            }
            imageViewer.Focus();
        }

        private void UpdateImageStatus()
        {
            lblAction.Text = CurrentImage.ToDelete ? "Delete" : "Save";
            lblAction.BackColor = CurrentImage.ToDelete ? Color.Red : Color.Green;
        }

        private void UpdateImageViewer()
        {
            imageViewer.Image?.Dispose();

            if (CurrentImage == null)
                return;

            imageViewer.Image = Image.FromFile(CurrentImage.Path);

            //If image is larger than picturebox
            if (imageViewer.Image.Width > imageViewer.ClientSize.Width || imageViewer.Image.Height > imageViewer.ClientSize.Height)
                imageViewer.SizeMode = PictureBoxSizeMode.Zoom;

            //If image is smaller than picturebox
            else
                imageViewer.SizeMode = PictureBoxSizeMode.CenterImage;

            UpdateImageStatus();
        }

        private void btnDeleteImages_Click(object sender, EventArgs e)
        {
            if (ImagesCount > 0)
            {
                imageViewer.Image?.Dispose();

                foreach (ImageInfo image in Images)
                    if (image.ToDelete)
                        if (new FileInfo(image.Path).Exists)
                            File.Delete(image.Path);

                UpdateImagesList(SourceFolder);
            }
        }
    }
}
