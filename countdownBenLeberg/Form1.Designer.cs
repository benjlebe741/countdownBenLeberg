namespace countdownBenLeberg
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
            this.playButton = new System.Windows.Forms.Button();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.stateControlTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(276, 62);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(258, 119);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "P L A Y";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            this.playButton.MouseHover += new System.EventHandler(this.playButton_MouseHover);
            // 
            // countdownLabel
            // 
            this.countdownLabel.Font = new System.Drawing.Font("Castellar", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.countdownLabel.Location = new System.Drawing.Point(230, 221);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(348, 142);
            this.countdownLabel.TabIndex = 1;
            this.countdownLabel.Text = ". . .";
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateControlTimer
            // 
            this.stateControlTimer.Enabled = true;
            this.stateControlTimer.Interval = 200;
            this.stateControlTimer.Tick += new System.EventHandler(this.stateControlTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Timer stateControlTimer;
    }
}

