
namespace EasyPhotoRemover
{
    partial class MainForm
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
            imageViewer = new System.Windows.Forms.PictureBox();
            btnFolderChooser = new System.Windows.Forms.Button();
            lblChoosenFolder = new System.Windows.Forms.Label();
            folderChooser = new System.Windows.Forms.FolderBrowserDialog();
            lblTotalImages = new System.Windows.Forms.Label();
            lblImagesToDelete = new System.Windows.Forms.Label();
            lblAction = new System.Windows.Forms.Label();
            btnDeleteImages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)imageViewer).BeginInit();
            SuspendLayout();
            // 
            // imageViewer
            // 
            imageViewer.Location = new System.Drawing.Point(8, 41);
            imageViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            imageViewer.Name = "imageViewer";
            imageViewer.Size = new System.Drawing.Size(864, 673);
            imageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            imageViewer.TabIndex = 0;
            imageViewer.TabStop = false;
            // 
            // btnFolderChooser
            // 
            btnFolderChooser.Location = new System.Drawing.Point(8, 7);
            btnFolderChooser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnFolderChooser.Name = "btnFolderChooser";
            btnFolderChooser.Size = new System.Drawing.Size(108, 31);
            btnFolderChooser.TabIndex = 1;
            btnFolderChooser.Text = "Chose folder...";
            btnFolderChooser.UseVisualStyleBackColor = true;
            btnFolderChooser.Click += btnFolderChooser_Click;
            // 
            // lblChoosenFolder
            // 
            lblChoosenFolder.AutoSize = true;
            lblChoosenFolder.Location = new System.Drawing.Point(120, 15);
            lblChoosenFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblChoosenFolder.Name = "lblChoosenFolder";
            lblChoosenFolder.Size = new System.Drawing.Size(109, 15);
            lblChoosenFolder.TabIndex = 2;
            lblChoosenFolder.Text = "Folder not choosen";
            // 
            // lblTotalImages
            // 
            lblTotalImages.AutoSize = true;
            lblTotalImages.Location = new System.Drawing.Point(8, 716);
            lblTotalImages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTotalImages.Name = "lblTotalImages";
            lblTotalImages.Size = new System.Drawing.Size(86, 15);
            lblTotalImages.TabIndex = 3;
            lblTotalImages.Text = "Total images: 0";
            // 
            // lblImagesToDelete
            // 
            lblImagesToDelete.AutoSize = true;
            lblImagesToDelete.Location = new System.Drawing.Point(9, 734);
            lblImagesToDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblImagesToDelete.Name = "lblImagesToDelete";
            lblImagesToDelete.Size = new System.Drawing.Size(106, 15);
            lblImagesToDelete.TabIndex = 4;
            lblImagesToDelete.Text = "Images to delete: 0";
            // 
            // lblAction
            // 
            lblAction.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblAction.AutoSize = true;
            lblAction.Font = new System.Drawing.Font("Segoe UI", 16F);
            lblAction.ForeColor = System.Drawing.SystemColors.Control;
            lblAction.Location = new System.Drawing.Point(783, 41);
            lblAction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAction.Name = "lblAction";
            lblAction.Size = new System.Drawing.Size(74, 30);
            lblAction.TabIndex = 5;
            lblAction.Text = "Action";
            lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteImages
            // 
            btnDeleteImages.Location = new System.Drawing.Point(712, 718);
            btnDeleteImages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnDeleteImages.Name = "btnDeleteImages";
            btnDeleteImages.Size = new System.Drawing.Size(160, 31);
            btnDeleteImages.TabIndex = 6;
            btnDeleteImages.Text = "Delete marked images";
            btnDeleteImages.UseVisualStyleBackColor = true;
            btnDeleteImages.Click += btnDeleteImages_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(881, 757);
            Controls.Add(btnDeleteImages);
            Controls.Add(lblAction);
            Controls.Add(lblImagesToDelete);
            Controls.Add(lblTotalImages);
            Controls.Add(lblChoosenFolder);
            Controls.Add(btnFolderChooser);
            Controls.Add(imageViewer);
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "Easy Photo Remover";
            ((System.ComponentModel.ISupportInitialize)imageViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageViewer;
        private System.Windows.Forms.Button btnFolderChooser;
        private System.Windows.Forms.Label lblChoosenFolder;
        private System.Windows.Forms.FolderBrowserDialog folderChooser;
        private System.Windows.Forms.Label lblTotalImages;
        private System.Windows.Forms.Label lblImagesToDelete;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnDeleteImages;
    }
}

