namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreInput = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.recordInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeDown
            // 
            this.pipeDown.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown.Image")));
            this.pipeDown.Location = new System.Drawing.Point(491, -77);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(100, 291);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 0;
            this.pipeDown.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(106, 223);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(69, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipe
            // 
            this.pipe.Image = ((System.Drawing.Image)(resources.GetObject("pipe.Image")));
            this.pipe.Location = new System.Drawing.Point(491, 396);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(100, 333);
            this.pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe.TabIndex = 0;
            this.pipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 495);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(699, 114);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // scoreInput
            // 
            this.scoreInput.AutoSize = true;
            this.scoreInput.BackColor = System.Drawing.Color.White;
            this.scoreInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreInput.Location = new System.Drawing.Point(12, 530);
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(115, 31);
            this.scoreInput.TabIndex = 1;
            this.scoreInput.Text = "Score:0";
            this.scoreInput.Click += new System.EventHandler(this.Score_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timerEvent);
            // 
            // recordInput
            // 
            this.recordInput.AutoSize = true;
            this.recordInput.BackColor = System.Drawing.Color.White;
            this.recordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recordInput.Location = new System.Drawing.Point(13, 9);
            this.recordInput.Name = "recordInput";
            this.recordInput.Size = new System.Drawing.Size(87, 25);
            this.recordInput.TabIndex = 2;
            this.recordInput.Text = "Rekor:0";
            this.recordInput.Click += new System.EventHandler(this.record_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(696, 606);
            this.Controls.Add(this.recordInput);
            this.Controls.Add(this.scoreInput);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreInput;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label recordInput;
    }
}

