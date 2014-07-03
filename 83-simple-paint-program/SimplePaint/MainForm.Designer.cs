namespace SimplePaint
{
    partial class MainForm
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
            this.paintingBox = new System.Windows.Forms.PictureBox();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.brownBox = new System.Windows.Forms.PictureBox();
            this.pinkBox = new System.Windows.Forms.PictureBox();
            this.purpleBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.yellowBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.whiteBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentBox = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentBox)).BeginInit();
            this.SuspendLayout();
            // 
            // paintingBox
            // 
            this.paintingBox.Location = new System.Drawing.Point(12, 12);
            this.paintingBox.Name = "paintingBox";
            this.paintingBox.Size = new System.Drawing.Size(372, 320);
            this.paintingBox.TabIndex = 0;
            this.paintingBox.TabStop = false;
            this.paintingBox.Click += new System.EventHandler(this.paintingBox_Click);
            this.paintingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintingBox_MouseDown);
            this.paintingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintingBox_MouseMove);
            this.paintingBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintingBox_MouseUp);
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(12, 338);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(36, 31);
            this.redBox.TabIndex = 1;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.redBox_Click);
            // 
            // blackBox
            // 
            this.blackBox.Location = new System.Drawing.Point(348, 338);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(36, 31);
            this.blackBox.TabIndex = 2;
            this.blackBox.TabStop = false;
            this.blackBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // brownBox
            // 
            this.brownBox.Location = new System.Drawing.Point(306, 338);
            this.brownBox.Name = "brownBox";
            this.brownBox.Size = new System.Drawing.Size(36, 31);
            this.brownBox.TabIndex = 3;
            this.brownBox.TabStop = false;
            this.brownBox.Click += new System.EventHandler(this.brownBox_Click);
            // 
            // pinkBox
            // 
            this.pinkBox.Location = new System.Drawing.Point(264, 338);
            this.pinkBox.Name = "pinkBox";
            this.pinkBox.Size = new System.Drawing.Size(36, 31);
            this.pinkBox.TabIndex = 4;
            this.pinkBox.TabStop = false;
            this.pinkBox.Click += new System.EventHandler(this.pinkBox_Click);
            // 
            // purpleBox
            // 
            this.purpleBox.Location = new System.Drawing.Point(222, 338);
            this.purpleBox.Name = "purpleBox";
            this.purpleBox.Size = new System.Drawing.Size(36, 31);
            this.purpleBox.TabIndex = 5;
            this.purpleBox.TabStop = false;
            this.purpleBox.Click += new System.EventHandler(this.purpleBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.Location = new System.Drawing.Point(180, 338);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(36, 31);
            this.orangeBox.TabIndex = 6;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.orangeBox_Click);
            // 
            // greenBox
            // 
            this.greenBox.Location = new System.Drawing.Point(138, 338);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(36, 31);
            this.greenBox.TabIndex = 7;
            this.greenBox.TabStop = false;
            this.greenBox.Click += new System.EventHandler(this.greenBox_Click);
            // 
            // yellowBox
            // 
            this.yellowBox.Location = new System.Drawing.Point(96, 338);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(36, 31);
            this.yellowBox.TabIndex = 8;
            this.yellowBox.TabStop = false;
            this.yellowBox.Click += new System.EventHandler(this.yellowBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.Location = new System.Drawing.Point(54, 338);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(36, 31);
            this.blueBox.TabIndex = 9;
            this.blueBox.TabStop = false;
            this.blueBox.Click += new System.EventHandler(this.blueBox_Click);
            // 
            // whiteBox
            // 
            this.whiteBox.Location = new System.Drawing.Point(12, 375);
            this.whiteBox.Name = "whiteBox";
            this.whiteBox.Size = new System.Drawing.Size(36, 31);
            this.whiteBox.TabIndex = 10;
            this.whiteBox.TabStop = false;
            this.whiteBox.Click += new System.EventHandler(this.whiteBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current:";
            // 
            // currentBox
            // 
            this.currentBox.Location = new System.Drawing.Point(138, 375);
            this.currentBox.Name = "currentBox";
            this.currentBox.Size = new System.Drawing.Size(36, 31);
            this.currentBox.TabIndex = 12;
            this.currentBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(309, 375);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 31);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 411);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.currentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.whiteBox);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.yellowBox);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.orangeBox);
            this.Controls.Add(this.purpleBox);
            this.Controls.Add(this.pinkBox);
            this.Controls.Add(this.brownBox);
            this.Controls.Add(this.blackBox);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.paintingBox);
            this.Name = "MainForm";
            this.Text = "Simple Paint";
            ((System.ComponentModel.ISupportInitialize)(this.paintingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paintingBox;
        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.PictureBox blackBox;
        private System.Windows.Forms.PictureBox brownBox;
        private System.Windows.Forms.PictureBox pinkBox;
        private System.Windows.Forms.PictureBox purpleBox;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.PictureBox yellowBox;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.PictureBox whiteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox currentBox;
        private System.Windows.Forms.Button clearButton;
    }
}

