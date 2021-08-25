using FontAwesomeControls.Business;
using FontAwesomeControls.Infrastucture.Entities;
using FontAwesomeControls.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontAwesomeControls
{
    public partial class FontAwesomeLabel : Label
    {

        private IconType _IconType = IconType.Solid;
        [Category(Category.FontAwesomeIcon)]
        public IconType IconType
        {
            get { return _IconType; }
            set
            {
                _IconType = value;
                PaintIconImage();
            }
        }

        private string _IconName = "home";
        [Category(Category.FontAwesomeIcon)]
        public string IconName
        {
            get { return _IconName; }
            set
            {
                _IconName = value.ToLower();
                PaintIconImage();
            }
        }

        private Color _IconColor = Color.Black;
        [Category(Category.FontAwesomeIcon)]
        public Color IconColor
        {
            get { return _IconColor; }
            set
            {
                _IconColor = value;
                PaintIconImage();
            }
        }

        private int _IconWidth = 20;
        [Category(Category.FontAwesomeIcon)]
        public int IconWidth
        {
            get { return _IconWidth; }
            set
            {
                _IconWidth = value;
                PaintIconImage();
            }
        }

        public FontAwesomeLabel()
        {
            AutoSize = false;
            InitializeComponent();
            PaintIconImage();
            Size = new Size(151,32);
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleRight;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void PaintIconImage()
        {
            Image = IconBusiness.GetImage(new Infrastucture.Entities.Icon
            {
                Color = IconColor,
                Width = IconWidth,
                Name = IconName,
                Type = IconType
            });
        }
    }
}
