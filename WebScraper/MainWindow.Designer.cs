
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
            this.rtb_debugDisplay = new System.Windows.Forms.RichTextBox();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.classTextbox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.queryTextbox = new System.Windows.Forms.TextBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.pullButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scrapeButton
            // 
            this.scrapeButton.Location = new System.Drawing.Point(704, 39);
            this.scrapeButton.Name = "scrapeButton";
            this.scrapeButton.Size = new System.Drawing.Size(75, 23);
            this.scrapeButton.TabIndex = 0;
            this.scrapeButton.Text = "Scrape";
            this.scrapeButton.UseVisualStyleBackColor = true;
            this.scrapeButton.Click += new System.EventHandler(this.scrapeButton_Click);
            // 
            // rtb_debugDisplay
            // 
            this.rtb_debugDisplay.Location = new System.Drawing.Point(12, 77);
            this.rtb_debugDisplay.Name = "rtb_debugDisplay";
            this.rtb_debugDisplay.Size = new System.Drawing.Size(776, 324);
            this.rtb_debugDisplay.TabIndex = 1;
            this.rtb_debugDisplay.Text = "";
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(55, 12);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(334, 22);
            this.urlTextbox.TabIndex = 2;
            // 
            // classTextbox
            // 
            this.classTextbox.Location = new System.Drawing.Point(533, 11);
            this.classTextbox.Name = "classTextbox";
            this.classTextbox.Size = new System.Drawing.Size(246, 22);
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
            this.classLabel.Location = new System.Drawing.Point(395, 15);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(136, 17);
            this.classLabel.TabIndex = 5;
            this.classLabel.Text = "Element Classname:";
            // 
            // queryTextbox
            // 
            this.queryTextbox.Location = new System.Drawing.Point(109, 39);
            this.queryTextbox.Name = "queryTextbox";
            this.queryTextbox.Size = new System.Drawing.Size(584, 22);
            this.queryTextbox.TabIndex = 6;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(12, 43);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(95, 17);
            this.queryLabel.TabIndex = 7;
            this.queryLabel.Text = "Query Terms:";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(109, 407);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(194, 32);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // pullButton
            // 
            this.pullButton.Location = new System.Drawing.Point(309, 407);
            this.pullButton.Name = "pullButton";
            this.pullButton.Size = new System.Drawing.Size(194, 31);
            this.pullButton.TabIndex = 9;
            this.pullButton.Text = "Pull";
            this.pullButton.UseVisualStyleBackColor = true;
            this.pullButton.Click += new System.EventHandler(this.pullButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(509, 406);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(194, 32);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.pullButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.queryTextbox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.classTextbox);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.rtb_debugDisplay);
            this.Controls.Add(this.scrapeButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scrapeButton;
        private System.Windows.Forms.RichTextBox rtb_debugDisplay;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.TextBox classTextbox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox queryTextbox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button pullButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

