namespace PuzzleGameForm
{
    partial class frmPuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzle));
            this.pnlGameArea = new System.Windows.Forms.Panel();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.pnlDisplayImage = new System.Windows.Forms.Panel();
            this.imgOriginal = new System.Windows.Forms.PictureBox();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.pnlGameSelect = new System.Windows.Forms.Panel();
            this.rdbHard = new System.Windows.Forms.RadioButton();
            this.rdbMiddle = new System.Windows.Forms.RadioButton();
            this.rdbEasy = new System.Windows.Forms.RadioButton();
            this.pnlGameStart = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.pnlDisplayImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).BeginInit();
            this.pnlScore.SuspendLayout();
            this.pnlGameSelect.SuspendLayout();
            this.pnlGameStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameArea
            // 
            this.pnlGameArea.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlGameArea.Controls.Add(this.img4);
            this.pnlGameArea.Controls.Add(this.img3);
            this.pnlGameArea.Controls.Add(this.img2);
            this.pnlGameArea.Controls.Add(this.img1);
            this.pnlGameArea.Location = new System.Drawing.Point(10, 10);
            this.pnlGameArea.Name = "pnlGameArea";
            this.pnlGameArea.Size = new System.Drawing.Size(480, 480);
            this.pnlGameArea.TabIndex = 0;
            // 
            // img4
            // 
            this.img4.Location = new System.Drawing.Point(240, 240);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(240, 240);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img4.TabIndex = 3;
            this.img4.TabStop = false;
            this.img4.DragDrop += new System.Windows.Forms.DragEventHandler(this.img_DragDrop);
            this.img4.DragEnter += new System.Windows.Forms.DragEventHandler(this.img_DragEnter);
            this.img4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_MouseDown);
            this.img4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img_MouseMove);
            this.img4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_MouseUp);
            // 
            // img3
            // 
            this.img3.Location = new System.Drawing.Point(0, 240);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(240, 240);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3.TabIndex = 2;
            this.img3.TabStop = false;
            this.img3.DragDrop += new System.Windows.Forms.DragEventHandler(this.img_DragDrop);
            this.img3.DragEnter += new System.Windows.Forms.DragEventHandler(this.img_DragEnter);
            this.img3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_MouseDown);
            this.img3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img_MouseMove);
            this.img3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_MouseUp);
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(240, 0);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(240, 240);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 1;
            this.img2.TabStop = false;
            this.img2.DragDrop += new System.Windows.Forms.DragEventHandler(this.img_DragDrop);
            this.img2.DragEnter += new System.Windows.Forms.DragEventHandler(this.img_DragEnter);
            this.img2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_MouseDown);
            this.img2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img_MouseMove);
            this.img2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_MouseUp);
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(0, 0);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(240, 240);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            this.img1.DragDrop += new System.Windows.Forms.DragEventHandler(this.img_DragDrop);
            this.img1.DragEnter += new System.Windows.Forms.DragEventHandler(this.img_DragEnter);
            this.img1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_MouseDown);
            this.img1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img_MouseMove);
            this.img1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_MouseUp);
            // 
            // pnlDisplayImage
            // 
            this.pnlDisplayImage.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlDisplayImage.Controls.Add(this.imgOriginal);
            this.pnlDisplayImage.Location = new System.Drawing.Point(507, 67);
            this.pnlDisplayImage.Name = "pnlDisplayImage";
            this.pnlDisplayImage.Size = new System.Drawing.Size(300, 300);
            this.pnlDisplayImage.TabIndex = 1;
            // 
            // imgOriginal
            // 
            this.imgOriginal.Location = new System.Drawing.Point(0, 0);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(300, 300);
            this.imgOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOriginal.TabIndex = 0;
            this.imgOriginal.TabStop = false;
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlScore.Controls.Add(this.lblTime);
            this.pnlScore.Controls.Add(this.lblStep);
            this.pnlScore.Location = new System.Drawing.Point(507, 10);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(300, 50);
            this.pnlScore.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(220, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 26);
            this.lblTime.TabIndex = 1;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStep.ForeColor = System.Drawing.Color.White;
            this.lblStep.Location = new System.Drawing.Point(12, 12);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(0, 26);
            this.lblStep.TabIndex = 0;
            // 
            // pnlGameSelect
            // 
            this.pnlGameSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlGameSelect.Controls.Add(this.rdbHard);
            this.pnlGameSelect.Controls.Add(this.rdbMiddle);
            this.pnlGameSelect.Controls.Add(this.rdbEasy);
            this.pnlGameSelect.Location = new System.Drawing.Point(507, 379);
            this.pnlGameSelect.Name = "pnlGameSelect";
            this.pnlGameSelect.Size = new System.Drawing.Size(300, 50);
            this.pnlGameSelect.TabIndex = 2;
            // 
            // rdbHard
            // 
            this.rdbHard.AutoSize = true;
            this.rdbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbHard.ForeColor = System.Drawing.Color.White;
            this.rdbHard.Location = new System.Drawing.Point(220, 12);
            this.rdbHard.Name = "rdbHard";
            this.rdbHard.Size = new System.Drawing.Size(62, 30);
            this.rdbHard.TabIndex = 1;
            this.rdbHard.TabStop = true;
            this.rdbHard.Text = "Zor";
            this.rdbHard.UseVisualStyleBackColor = true;
            this.rdbHard.CheckedChanged += new System.EventHandler(this.rdbHard_CheckedChanged);
            // 
            // rdbMiddle
            // 
            this.rdbMiddle.AutoSize = true;
            this.rdbMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbMiddle.ForeColor = System.Drawing.Color.White;
            this.rdbMiddle.Location = new System.Drawing.Point(120, 12);
            this.rdbMiddle.Name = "rdbMiddle";
            this.rdbMiddle.Size = new System.Drawing.Size(72, 30);
            this.rdbMiddle.TabIndex = 1;
            this.rdbMiddle.TabStop = true;
            this.rdbMiddle.Text = "Orta";
            this.rdbMiddle.UseVisualStyleBackColor = true;
            this.rdbMiddle.CheckedChanged += new System.EventHandler(this.rdbMiddle_CheckedChanged);
            // 
            // rdbEasy
            // 
            this.rdbEasy.AutoSize = true;
            this.rdbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbEasy.ForeColor = System.Drawing.Color.White;
            this.rdbEasy.Location = new System.Drawing.Point(12, 12);
            this.rdbEasy.Name = "rdbEasy";
            this.rdbEasy.Size = new System.Drawing.Size(85, 30);
            this.rdbEasy.TabIndex = 0;
            this.rdbEasy.TabStop = true;
            this.rdbEasy.Text = "Kolay";
            this.rdbEasy.UseVisualStyleBackColor = true;
            this.rdbEasy.CheckedChanged += new System.EventHandler(this.rdbEasy_CheckedChanged);
            // 
            // pnlGameStart
            // 
            this.pnlGameStart.BackColor = System.Drawing.Color.Transparent;
            this.pnlGameStart.Controls.Add(this.btnStart);
            this.pnlGameStart.Location = new System.Drawing.Point(507, 440);
            this.pnlGameStart.Name = "pnlGameStart";
            this.pnlGameStart.Size = new System.Drawing.Size(300, 50);
            this.pnlGameStart.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(300, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Oyuna Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 506);
            this.Controls.Add(this.pnlGameStart);
            this.Controls.Add(this.pnlGameSelect);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.pnlDisplayImage);
            this.Controls.Add(this.pnlGameArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPuzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle Oyunu";
            this.Load += new System.EventHandler(this.frmPuzzle_Load);
            this.pnlGameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.pnlDisplayImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.pnlGameSelect.ResumeLayout(false);
            this.pnlGameSelect.PerformLayout();
            this.pnlGameStart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameArea;
        private System.Windows.Forms.Panel pnlDisplayImage;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Panel pnlGameSelect;
        private System.Windows.Forms.Panel pnlGameStart;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img4;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox imgOriginal;
        private System.Windows.Forms.RadioButton rdbHard;
        private System.Windows.Forms.RadioButton rdbMiddle;
        private System.Windows.Forms.RadioButton rdbEasy;
        private System.Windows.Forms.Button btnStart;
    }
}

