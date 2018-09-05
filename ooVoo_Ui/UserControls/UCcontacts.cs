using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooVoo_Ui.UserControls
{
    public partial class UCcontacts : UserControl
    {
        public UCcontacts()
        {
            InitializeComponent();
        }
        private Image ProfileImage
        {
            get
            {
                return pictureBox.Image;
            }

            set { pictureBox.Image = value; }
        }
        public string TxtName
        {
            get { return label_Name.Text; }
            set { label_Name.Text = value; }
        }
        public string TxtStatus
        {
            get { return label_Status.Text; }
            set { label_Status.Text = value; }
        }

       
    }
}
