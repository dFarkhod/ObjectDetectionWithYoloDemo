namespace ObjectDetectionDemo
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rasmniYuklashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narsalarniAniqlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rasmniYuklashToolStripMenuItem,
            this.narsalarniAniqlashToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // rasmniYuklashToolStripMenuItem
            // 
            this.rasmniYuklashToolStripMenuItem.Name = "rasmniYuklashToolStripMenuItem";
            this.rasmniYuklashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rasmniYuklashToolStripMenuItem.Text = "Rasmni Yuklash...";
            this.rasmniYuklashToolStripMenuItem.Click += new System.EventHandler(this.rasmniYuklashToolStripMenuItem_Click);
            // 
            // narsalarniAniqlashToolStripMenuItem
            // 
            this.narsalarniAniqlashToolStripMenuItem.Name = "narsalarniAniqlashToolStripMenuItem";
            this.narsalarniAniqlashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.narsalarniAniqlashToolStripMenuItem.Text = "Narsalarni Aniqlash";
            this.narsalarniAniqlashToolStripMenuItem.Click += new System.EventHandler(this.narsalarniAniqlashToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rasmniYuklashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narsalarniAniqlashToolStripMenuItem;
    }
}

