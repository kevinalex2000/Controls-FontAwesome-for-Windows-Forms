using FontAwesomeControls.Business;
using FontAwesomeControls.Infrastucture.Entities;
using FontAwesomeControls.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FontAwesomeControls
{
    partial class FontAwesomeSingle : Control
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

        public FontAwesomeSingle()
        {
            InitializeComponent();
            PaintIconImage();
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PaintIconImage();
        }


        private void PaintIconImage()
        {
            BackgroundImage = IconBusiness.GetImage(new Infrastucture.Entities.Icon
            {
                Color = IconColor,
                Width = Size.Width,
                Height = Size.Height,
                Name = IconName,
                Type = IconType
            });
        }
    }
}
