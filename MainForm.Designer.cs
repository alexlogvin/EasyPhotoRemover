
namespace Easy_Photo_Remover
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
            this.imageViewer = new System.Windows.Forms.PictureBox();
            this.btnFolderChooser = new System.Windows.Forms.Button();
            this.lblChoosenFolder = new System.Windows.Forms.Label();
            this.folderChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblTotalImages = new System.Windows.Forms.Label();
            this.lblImagesToDelete = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnDeleteImages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // imageViewer
            // 
            this.imageViewer.Location = new System.Drawing.Point(12, 52);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(1234, 1139);
            this.imageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageViewer.TabIndex = 0;
            this.imageViewer.TabStop = false;
            // 
            // btnFolderChooser
            // 
            this.btnFolderChooser.Location = new System.Drawing.Point(12, 12);
            this.btnFolderChooser.Name = "btnFolderChooser";
            this.btnFolderChooser.Size = new System.Drawing.Size(154, 34);
            this.btnFolderChooser.TabIndex = 1;
            this.btnFolderChooser.Text = "Chose folder...";
            this.btnFolderChooser.UseVisualStyleBackColor = true;
            this.btnFolderChooser.Click += new System.EventHandler(this.btnFolderChooser_Click);
            // 
            // lblChoosenFolder
            // 
            this.lblChoosenFolder.AutoSize = true;
            this.lblChoosenFolder.Location = new System.Drawing.Point(172, 17);
            this.lblChoosenFolder.Name = "lblChoosenFolder";
            this.lblChoosenFolder.Size = new System.Drawing.Size(166, 25);
            this.lblChoosenFolder.TabIndex = 2;
            this.lblChoosenFolder.Text = "Folder not choosen";
            // 
            // lblTotalImages
            // 
            this.lblTotalImages.AutoSize = true;
            this.lblTotalImages.Location = new System.Drawing.Point(12, 1194);
            this.lblTotalImages.Name = "lblTotalImages";
            this.lblTotalImages.Size = new System.Drawing.Size(130, 25);
            this.lblTotalImages.TabIndex = 3;
            this.lblTotalImages.Text = "Total images: 0";
            // 
            // lblImagesToDelete
            // 
            this.lblImagesToDelete.AutoSize = true;
            this.lblImagesToDelete.Location = new System.Drawing.Point(13, 1223);
            this.lblImagesToDelete.Name = "lblImagesToDelete";
            this.lblImagesToDelete.Size = new System.Drawing.Size(164, 25);
            this.lblImagesToDelete.TabIndex = 4;
            this.lblImagesToDelete.Text = "Images to delete: 0";
            // 
            // lblAction
            // 
            this.lblAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAction.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAction.Location = new System.Drawing.Point(1118, 69);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(112, 45);
            this.lblAction.TabIndex = 5;
            this.lblAction.Text = "Action";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteImages
            // 
            this.btnDeleteImages.Location = new System.Drawing.Point(1017, 1197);
            this.btnDeleteImages.Name = "btnDeleteImages";
            this.btnDeleteImages.Size = new System.Drawing.Size(229, 52);
            this.btnDeleteImages.TabIndex = 6;
            this.btnDeleteImages.Text = "Delete marked images";
            this.btnDeleteImages.UseVisualStyleBackColor = true;
            this.btnDeleteImages.Click += new System.EventHandler(this.btnDeleteImages_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 1261);
            this.Controls.Add(this.btnDeleteImages);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblImagesToDelete);
            this.Controls.Add(this.lblTotalImages);
            this.Controls.Add(this.lblChoosenFolder);
            this.Controls.Add(this.btnFolderChooser);
            this.Controls.Add(this.imageViewer);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

