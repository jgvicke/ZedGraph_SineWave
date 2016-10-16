namespace SineWave
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.generateData = new System.Windows.Forms.Timer(this.components);
            this.graphUpdate = new System.Windows.Forms.Timer(this.components);
            this.resumeScrolling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(10, 11);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(425, 295);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.ScrollEvent += new System.Windows.Forms.ScrollEventHandler(this.zedGraphControl1_ScrollEvent);
            // 
            // generateData
            // 
            this.generateData.Enabled = true;
            this.generateData.Interval = 10;
            this.generateData.Tick += new System.EventHandler(this.generateData_Tick);
            // 
            // graphUpdate
            // 
            this.graphUpdate.Enabled = true;
            this.graphUpdate.Tick += new System.EventHandler(this.graphUpdate_Tick);
            // 
            // resumeScrolling
            // 
            this.resumeScrolling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resumeScrolling.Location = new System.Drawing.Point(9, 319);
            this.resumeScrolling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resumeScrolling.Name = "resumeScrolling";
            this.resumeScrolling.Size = new System.Drawing.Size(426, 30);
            this.resumeScrolling.TabIndex = 1;
            this.resumeScrolling.Text = "Resume Scrolling";
            this.resumeScrolling.UseVisualStyleBackColor = true;
            this.resumeScrolling.Click += new System.EventHandler(this.resumeScrolling_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 359);
            this.Controls.Add(this.resumeScrolling);
            this.Controls.Add(this.zedGraphControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "SineWave by John Vickers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Timer generateData;
        private System.Windows.Forms.Timer graphUpdate;
        private System.Windows.Forms.Button resumeScrolling;
    }
}

