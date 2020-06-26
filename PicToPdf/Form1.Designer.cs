namespace PicToPdf
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewImages = new System.Windows.Forms.ListView();
            this.ImageFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewImages
            // 
            this.listViewImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImageFile});
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(13, 13);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(686, 451);
            this.listViewImages.TabIndex = 0;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            this.listViewImages.View = System.Windows.Forms.View.Details;
            this.listViewImages.SelectedIndexChanged += new System.EventHandler(this.listViewImages_SelectedIndexChanged);
            // 
            // ImageFile
            // 
            this.ImageFile.Text = "ImageFile";
            this.ImageFile.Width = 684;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(706, 13);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(217, 57);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(706, 245);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(217, 57);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert...";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PicToPdf.Properties.Resources.lg_circle_slack_loading_icon;
            this.pictureBox1.Location = new System.Drawing.Point(705, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(706, 93);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(217, 57);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete...";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDestination
            // 
            this.buttonDestination.Location = new System.Drawing.Point(706, 173);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(217, 57);
            this.buttonDestination.TabIndex = 6;
            this.buttonDestination.Text = "Destination...";
            this.buttonDestination.UseVisualStyleBackColor = true;
            this.buttonDestination.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(13, 471);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(686, 26);
            this.textBoxDestination.TabIndex = 7;
            this.textBoxDestination.TextChanged += new System.EventHandler(this.textBoxDestination_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 520);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.buttonDestination);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewImages);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PicsToPdf";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.ColumnHeader ImageFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

