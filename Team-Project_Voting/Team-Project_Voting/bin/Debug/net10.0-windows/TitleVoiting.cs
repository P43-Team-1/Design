using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Team_Project_Voting
{
    public partial class TitleVoiting : UserControl
    {
        public TitleVoiting()
        {
            InitializeComponent();
        }

        #region Properties
        private string _title;
        private string _voted;
        private Image _background;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Voting")]
        public string title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("Voting")]
        public string Voted
        {
            get { return _voted; }
            set { _voted = value; lblVoted.Text = value; }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("Voting")]
        public Image Background
        {
            get { return _background; }
            set { _background = value; lblBackground.Image = value; }
        }
        #endregion

    }
}