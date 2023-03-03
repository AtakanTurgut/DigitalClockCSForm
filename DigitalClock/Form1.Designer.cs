namespace DigitalClock
{
    partial class formControl
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
            this.lblHoursMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblColorTheme = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHoursMinutes
            // 
            this.lblHoursMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoursMinutes.AutoSize = true;
            this.lblHoursMinutes.Font = new System.Drawing.Font("Digital-7", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursMinutes.ForeColor = System.Drawing.Color.Lime;
            this.lblHoursMinutes.Location = new System.Drawing.Point(120, 68);
            this.lblHoursMinutes.Name = "lblHoursMinutes";
            this.lblHoursMinutes.Size = new System.Drawing.Size(329, 132);
            this.lblHoursMinutes.TabIndex = 0;
            this.lblHoursMinutes.Text = "00:00";
            // 
            // lblSeconds
            // 
            this.lblSeconds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Digital-7", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.Lime;
            this.lblSeconds.Location = new System.Drawing.Point(426, 101);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(125, 92);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "00";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Digital-7", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Lime;
            this.lblDate.Location = new System.Drawing.Point(90, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(293, 109);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "12.12.01";
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Digital-7", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Lime;
            this.lblDay.Location = new System.Drawing.Point(471, 251);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(104, 58);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "Wed";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClose.ForeColor = System.Drawing.Color.Lime;
            this.lblClose.Location = new System.Drawing.Point(665, 1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 30);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblColorTheme
            // 
            this.lblColorTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorTheme.AutoSize = true;
            this.lblColorTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblColorTheme.ForeColor = System.Drawing.Color.Aqua;
            this.lblColorTheme.Location = new System.Drawing.Point(638, 1);
            this.lblColorTheme.Name = "lblColorTheme";
            this.lblColorTheme.Size = new System.Drawing.Size(30, 29);
            this.lblColorTheme.TabIndex = 5;
            this.lblColorTheme.Text = "☼";
            this.lblColorTheme.Click += new System.EventHandler(this.lblColorTheme_Click);
            // 
            // lblTheme
            // 
            this.lblTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.lblTheme.Location = new System.Drawing.Point(612, 1);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(30, 29);
            this.lblTheme.TabIndex = 6;
            this.lblTheme.Text = "☼";
            this.lblTheme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTheme.Click += new System.EventHandler(this.lblTheme_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // formControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblColorTheme);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblHoursMinutes);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.formControl_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formControl_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoursMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblColorTheme;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Timer timer3;
    }
}

