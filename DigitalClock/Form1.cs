using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class formControl : Form
    {
        public formControl()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoursMinutes.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd.MM.yy");
            lblDay.Text = DateTime.Now.ToString("ddd");
            lblSeconds.Location = new Point(lblHoursMinutes.Location.X + lblHoursMinutes.Width, lblSeconds.Location.Y);
            lblDay.Location = new Point(lblDate.Location.X + lblDate.Width, lblDay.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        bool formMove = false;
        Point startingPoint = new Point(0, 0);

        private void formControl_MouseDown(object sender, MouseEventArgs e)
        {
            formMove = true;
            startingPoint = new Point(e.X, e.Y);
        }

        private void formControl_MouseUp(object sender, MouseEventArgs e)
        {
            formMove = false;
        }

        private void formControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.startingPoint.X, point.Y - this.startingPoint.Y);
            }
        }

        private void formControl_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblColorTheme_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lblColorTheme.ForeColor == Color.Aqua)
            {
                lblClose.ForeColor = Color.Aqua;
                lblHoursMinutes.ForeColor = Color.Aqua;
                lblSeconds.ForeColor = Color.Aqua;
                lblDate.ForeColor = Color.Aqua;
                lblDay.ForeColor = Color.Aqua;

                lblColorTheme.ForeColor = Color.Lime;
                timer2.Stop();
            }
            else if (lblColorTheme.ForeColor == Color.Lime)
            {
                lblClose.ForeColor = Color.Lime;
                lblHoursMinutes.ForeColor = Color.Lime;
                lblSeconds.ForeColor = Color.Lime;
                lblDate.ForeColor = Color.Lime;
                lblDay.ForeColor = Color.Lime;

                lblColorTheme.ForeColor = Color.Crimson;
                timer2.Stop();
            }
            else if (lblColorTheme.ForeColor == Color.Crimson)
            {
                lblClose.ForeColor = Color.Crimson;
                lblHoursMinutes.ForeColor = Color.Crimson;
                lblSeconds.ForeColor = Color.Crimson;
                lblDate.ForeColor = Color.Crimson;
                lblDay.ForeColor = Color.Crimson;

                lblColorTheme.ForeColor = Color.Aqua;
                timer2.Stop();
            }
        }

        private void lblTheme_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (lblTheme.ForeColor == Color.FromArgb(159, 159, 159))
            {
                lblClose.ForeColor = Color.FromArgb(27, 27, 27);
                lblHoursMinutes.ForeColor = Color.FromArgb(27, 27, 27);
                lblSeconds.ForeColor = Color.FromArgb(27, 27, 27);
                lblDate.ForeColor = Color.FromArgb(27, 27, 27);
                lblDay.ForeColor = Color.FromArgb(27, 27, 27);

                lblTheme.ForeColor = Color.FromArgb(27, 27, 27);
                this.BackColor = Color.FromArgb(159, 159, 159);
                timer3.Stop();
            }
            else if (lblTheme.ForeColor == Color.FromArgb(27, 27, 27))
            {
                lblClose.ForeColor = Color.FromArgb(159, 159, 159);
                lblHoursMinutes.ForeColor = Color.FromArgb(159, 159, 159);
                lblSeconds.ForeColor = Color.FromArgb(159, 159, 159);
                lblDate.ForeColor = Color.FromArgb(159, 159, 159);
                lblDay.ForeColor = Color.FromArgb(159, 159, 159);

                lblTheme.ForeColor = Color.FromArgb(159, 159, 159);
                this.BackColor = Color.FromArgb(27, 27, 27);
                timer3.Stop();
            }
        }
    }
}
