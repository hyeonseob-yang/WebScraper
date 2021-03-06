
namespace WebScraper {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.scrapeButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.RichTextBox();
            this.siteUrlTextbox = new System.Windows.Forms.TextBox();
            this.classTextbox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.keywordTextbox = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.pullButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.baseUrlTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scrapeButton
            // 
            this.scrapeButton.Location = new System.Drawing.Point(713, 43);
            this.scrapeButton.Name = "scrapeButton";
            this.scrapeButton.Size = new System.Drawing.Size(75, 24);
            this.scrapeButton.TabIndex = 0;
            this.scrapeButton.Text = "Scrape";
            this.scrapeButton.UseVisualStyleBackColor = true;
            this.scrapeButton.Click += new System.EventHandler(this.ScrapeButton_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(12, 77);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.Size = new System.Drawing.Size(776, 324);
            this.resultsBox.TabIndex = 1;
            this.resultsBox.Text = "";
            // 
            // siteUrlTextbox
            // 
            this.siteUrlTextbox.Location = new System.Drawing.Point(55, 12);
            this.siteUrlTextbox.Name = "siteUrlTextbox";
            this.siteUrlTextbox.Size = new System.Drawing.Size(334, 22);
            this.siteUrlTextbox.TabIndex = 2;
            // 
            // classTextbox
            // 
            this.classTextbox.Location = new System.Drawing.Point(154, 44);
            this.classTextbox.Name = "classTextbox";
            this.classTextbox.Size = new System.Drawing.Size(235, 22);
            this.classTextbox.TabIndex = 3;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 12);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(40, 17);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.Text = "URL:";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(12, 44);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(136, 17);
            this.classLabel.TabIndex = 5;
            this.classLabel.Text = "Element Classname:";
            // 
            // keywordTextbox
            // 
            this.keywordTextbox.Location = new System.Drawing.Point(482, 43);
            this.keywordTextbox.Name = "keywordTextbox";
            this.keywordTextbox.Size = new System.Drawing.Size(221, 22);
            this.keywordTextbox.TabIndex = 6;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(397, 46);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(66, 17);
            this.queryLabel.TabIndex = 7;
            this.queryLabel.Text = "Keyword:";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(109, 407);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(194, 32);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // pullButton
            // 
            this.pullButton.Location = new System.Drawing.Point(309, 407);
            this.pullButton.Name = "pullButton";
            this.pullButton.Size = new System.Drawing.Size(194, 31);
            this.pullButton.TabIndex = 9;
            this.pullButton.Text = "Pull";
            this.pullButton.UseVisualStyleBackColor = true;
            this.pullButton.Click += new System.EventHandler(this.PullButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(509, 406);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(194, 32);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Base URL:";
            // 
            // baseUrlTextbox
            // 
            this.baseUrlTextbox.Location = new System.Drawing.Point(482, 13);
            this.baseUrlTextbox.Name = "baseUrlTextbox";
            this.baseUrlTextbox.Size = new System.Drawing.Size(305, 22);
            this.baseUrlTextbox.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baseUrlTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.pullButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.keywordTextbox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.classTextbox);
            this.Controls.Add(this.siteUrlTextbox);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.scrapeButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scrapeButton;
        private System.Windows.Forms.RichTextBox resultsBox;
        private System.Windows.Forms.TextBox siteUrlTextbox;
        private System.Windows.Forms.TextBox classTextbox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox keywordTextbox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button pullButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baseUrlTextbox;
    }
}

