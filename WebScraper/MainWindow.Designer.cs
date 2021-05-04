
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queryTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.scrapeButton.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Element Classname:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // queryTextbox
            // 
            this.queryTextbox.Location = new System.Drawing.Point(109, 39);
            this.queryTextbox.Name = "queryTextbox";
            this.queryTextbox.Size = new System.Drawing.Size(584, 22);
            this.queryTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Query Terms:";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(109, 407);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(194, 32);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // pullButton
            // 
            this.pullButton.Location = new System.Drawing.Point(309, 407);
            this.pullButton.Name = "pullButton";
            this.pullButton.Size = new System.Drawing.Size(194, 31);
            this.pullButton.TabIndex = 9;
            this.pullButton.Text = "Pull";
            this.pullButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(509, 406);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(194, 32);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.pullButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queryTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox queryTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button pullButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

