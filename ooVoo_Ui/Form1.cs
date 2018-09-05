using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooVoo_Ui
{
    public partial class Form1 : Form
    {
        int panelWidth;
        bool Hidden;

        public Form1()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 10;
                if (PanelSlide.Width >= panelWidth)
                {
                    timer1.Start();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 10;
                if(PanelSlide.Width<=0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelSlide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
