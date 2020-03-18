namespace ImageTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxAPIKey = new System.Windows.Forms.TextBox();
            this.labelAPIKey = new System.Windows.Forms.Label();
            this.textBoxAPIEndPoint = new System.Windows.Forms.TextBox();
            this.labelAPIEndpoint = new System.Windows.Forms.Label();
            this.textBoxProjectID = new System.Windows.Forms.TextBox();
            this.labelProjectID = new System.Windows.Forms.Label();
            this.buttonGetTags = new System.Windows.Forms.Button();
            this.textBoxTagName = new System.Windows.Forms.TextBox();
            this.labelTagName = new System.Windows.Forms.Label();
            this.textBoxTagDescription = new System.Windows.Forms.TextBox();
            this.labelTagDescription = new System.Windows.Forms.Label();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxSelectedItemID = new System.Windows.Forms.TextBox();
            this.richTextBoxNewImagesJSON = new System.Windows.Forms.RichTextBox();
            this.buttonLoadImages = new System.Windows.Forms.Button();
            this.buttonCleanTags = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAPIKey
            // 
            this.textBoxAPIKey.Location = new System.Drawing.Point(12, 12);
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.Size = new System.Drawing.Size(357, 26);
            this.textBoxAPIKey.TabIndex = 0;
            this.textBoxAPIKey.Text = "98e6a4e356c24e94ac5c41479e58b210";
            // 
            // labelAPIKey
            // 
            this.labelAPIKey.AutoSize = true;
            this.labelAPIKey.Location = new System.Drawing.Point(375, 15);
            this.labelAPIKey.Name = "labelAPIKey";
            this.labelAPIKey.Size = new System.Drawing.Size(68, 20);
            this.labelAPIKey.TabIndex = 1;
            this.labelAPIKey.Text = "API Key";
            // 
            // textBoxAPIEndPoint
            // 
            this.textBoxAPIEndPoint.Location = new System.Drawing.Point(12, 44);
            this.textBoxAPIEndPoint.Name = "textBoxAPIEndPoint";
            this.textBoxAPIEndPoint.Size = new System.Drawing.Size(357, 26);
            this.textBoxAPIEndPoint.TabIndex = 2;
            this.textBoxAPIEndPoint.Text = "https://eastus.api.cognitive.microsoft.com/";
            // 
            // labelAPIEndpoint
            // 
            this.labelAPIEndpoint.AutoSize = true;
            this.labelAPIEndpoint.Location = new System.Drawing.Point(375, 47);
            this.labelAPIEndpoint.Name = "labelAPIEndpoint";
            this.labelAPIEndpoint.Size = new System.Drawing.Size(105, 20);
            this.labelAPIEndpoint.TabIndex = 3;
            this.labelAPIEndpoint.Text = "API Endpoint";
            // 
            // textBoxProjectID
            // 
            this.textBoxProjectID.Location = new System.Drawing.Point(12, 76);
            this.textBoxProjectID.Name = "textBoxProjectID";
            this.textBoxProjectID.Size = new System.Drawing.Size(357, 26);
            this.textBoxProjectID.TabIndex = 4;
            this.textBoxProjectID.Text = "9e454eb5-d8a3-4e84-96cf-049c8502d990";
            // 
            // labelProjectID
            // 
            this.labelProjectID.AutoSize = true;
            this.labelProjectID.Location = new System.Drawing.Point(375, 79);
            this.labelProjectID.Name = "labelProjectID";
            this.labelProjectID.Size = new System.Drawing.Size(84, 20);
            this.labelProjectID.TabIndex = 5;
            this.labelProjectID.Text = "Project ID";
            // 
            // buttonGetTags
            // 
            this.buttonGetTags.Location = new System.Drawing.Point(12, 108);
            this.buttonGetTags.Name = "buttonGetTags";
            this.buttonGetTags.Size = new System.Drawing.Size(100, 30);
            this.buttonGetTags.TabIndex = 6;
            this.buttonGetTags.Text = "Get Tags";
            this.buttonGetTags.UseVisualStyleBackColor = true;
            this.buttonGetTags.Click += new System.EventHandler(this.ButtonGetTags_Click);
            // 
            // textBoxTagName
            // 
            this.textBoxTagName.Location = new System.Drawing.Point(12, 144);
            this.textBoxTagName.Name = "textBoxTagName";
            this.textBoxTagName.Size = new System.Drawing.Size(357, 26);
            this.textBoxTagName.TabIndex = 7;
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Location = new System.Drawing.Point(375, 147);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(124, 20);
            this.labelTagName.TabIndex = 8;
            this.labelTagName.Text = "New Tag Name";
            // 
            // textBoxTagDescription
            // 
            this.textBoxTagDescription.Location = new System.Drawing.Point(12, 176);
            this.textBoxTagDescription.Name = "textBoxTagDescription";
            this.textBoxTagDescription.Size = new System.Drawing.Size(357, 26);
            this.textBoxTagDescription.TabIndex = 9;
            // 
            // labelTagDescription
            // 
            this.labelTagDescription.AutoSize = true;
            this.labelTagDescription.Location = new System.Drawing.Point(375, 179);
            this.labelTagDescription.Name = "labelTagDescription";
            this.labelTagDescription.Size = new System.Drawing.Size(166, 20);
            this.labelTagDescription.TabIndex = 10;
            this.labelTagDescription.Text = "New Tag Description";
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.Location = new System.Drawing.Point(562, 174);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(100, 30);
            this.buttonAddTag.TabIndex = 11;
            this.buttonAddTag.Text = "Add Tag";
            this.buttonAddTag.UseVisualStyleBackColor = true;
            this.buttonAddTag.Click += new System.EventHandler(this.ButtonAddTag_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 184);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // textBoxSelectedItemID
            // 
            this.textBoxSelectedItemID.Location = new System.Drawing.Point(12, 400);
            this.textBoxSelectedItemID.Name = "textBoxSelectedItemID";
            this.textBoxSelectedItemID.Size = new System.Drawing.Size(357, 26);
            this.textBoxSelectedItemID.TabIndex = 14;
            // 
            // richTextBoxNewImagesJSON
            // 
            this.richTextBoxNewImagesJSON.Location = new System.Drawing.Point(12, 432);
            this.richTextBoxNewImagesJSON.Name = "richTextBoxNewImagesJSON";
            this.richTextBoxNewImagesJSON.Size = new System.Drawing.Size(776, 444);
            this.richTextBoxNewImagesJSON.TabIndex = 15;
            this.richTextBoxNewImagesJSON.Text = resources.GetString("richTextBoxNewImagesJSON.Text");
            // 
            // buttonLoadImages
            // 
            this.buttonLoadImages.Location = new System.Drawing.Point(667, 396);
            this.buttonLoadImages.Name = "buttonLoadImages";
            this.buttonLoadImages.Size = new System.Drawing.Size(121, 30);
            this.buttonLoadImages.TabIndex = 16;
            this.buttonLoadImages.Text = "Load Images";
            this.buttonLoadImages.UseVisualStyleBackColor = true;
            this.buttonLoadImages.Click += new System.EventHandler(this.ButtonLoadImages_Click);
            // 
            // buttonCleanTags
            // 
            this.buttonCleanTags.Location = new System.Drawing.Point(667, 360);
            this.buttonCleanTags.Name = "buttonCleanTags";
            this.buttonCleanTags.Size = new System.Drawing.Size(121, 30);
            this.buttonCleanTags.TabIndex = 17;
            this.buttonCleanTags.Text = "Clean Tags";
            this.buttonCleanTags.UseVisualStyleBackColor = true;
            this.buttonCleanTags.Click += new System.EventHandler(this.ButtonCleanTags_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 888);
            this.Controls.Add(this.buttonCleanTags);
            this.Controls.Add(this.buttonLoadImages);
            this.Controls.Add(this.richTextBoxNewImagesJSON);
            this.Controls.Add(this.textBoxSelectedItemID);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAddTag);
            this.Controls.Add(this.labelTagDescription);
            this.Controls.Add(this.textBoxTagDescription);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.textBoxTagName);
            this.Controls.Add(this.buttonGetTags);
            this.Controls.Add(this.labelProjectID);
            this.Controls.Add(this.textBoxProjectID);
            this.Controls.Add(this.labelAPIEndpoint);
            this.Controls.Add(this.textBoxAPIEndPoint);
            this.Controls.Add(this.labelAPIKey);
            this.Controls.Add(this.textBoxAPIKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAPIKey;
        private System.Windows.Forms.Label labelAPIKey;
        private System.Windows.Forms.TextBox textBoxAPIEndPoint;
        private System.Windows.Forms.Label labelAPIEndpoint;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.Label labelProjectID;
        private System.Windows.Forms.Button buttonGetTags;
        private System.Windows.Forms.TextBox textBoxTagName;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.TextBox textBoxTagDescription;
        private System.Windows.Forms.Label labelTagDescription;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxSelectedItemID;
        private System.Windows.Forms.RichTextBox richTextBoxNewImagesJSON;
        private System.Windows.Forms.Button buttonLoadImages;
        private System.Windows.Forms.Button buttonCleanTags;
    }
}

