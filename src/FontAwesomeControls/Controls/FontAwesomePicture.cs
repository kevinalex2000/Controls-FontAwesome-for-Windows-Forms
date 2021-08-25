using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FontAwesomeControls.Business;
using FontAwesomeControls.Infrastucture.Entities;
using FontAwesomeControls.Utils;

namespace FontAwesomeControls
{
    public partial class FontAwesomePicture : PictureBox
    {

        #region Icon Image
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

        private Color _IconColor = Color.White;
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

        private int _IconWidth = 25;
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
        #endregion

        #region Background Icon Image
        private IconType _BackgroundIconType = IconType.Solid;
        [Category(Category.FontAwesomeBackgroundIcon)]
        public IconType BackgroundIconType
        {
            get { return _BackgroundIconType; }
            set
            {
                _BackgroundIconType = value;
                PaintIconBackgroundImage();
            }
        }

        private string _BackgroundIconName = "circle";
        [Category(Category.FontAwesomeBackgroundIcon)]
        public string BackgroundIconName
        {
            get { return _BackgroundIconName; }
            set
            {
                _BackgroundIconName = value.ToLower();
                PaintIconBackgroundImage();
            }
        }

        private Color _BackgroundIconColor = Color.Black;
        [Category(Category.FontAwesomeBackgroundIcon)]
        public Color BackgroundIconColor
        {
            get { return _BackgroundIconColor; }
            set
            {
                _BackgroundIconColor = value;
                PaintIconBackgroundImage();
            }
        }

        private int _BackgroundIconWidth = 200;
        [Category(Category.FontAwesomeBackgroundIcon)]
        public int BackgroundIconWidth
        {
            get { return _BackgroundIconWidth; }
            set
            {
                _BackgroundIconWidth = value;
                PaintIconBackgroundImage();
            }
        }

        #endregion

        public FontAwesomePicture()
        {
            InitializeComponent();
            PaintIconImage();
            PaintIconBackgroundImage();

            SizeMode = PictureBoxSizeMode.CenterImage;
            BackgroundImageLayout = ImageLayout.Stretch;
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
        private void PaintIconBackgroundImage()
        {
            BackgroundImage = IconBusiness.GetImage(new Infrastucture.Entities.Icon
            {
                Color = BackgroundIconColor,
                Width = BackgroundIconWidth,
                Name = BackgroundIconName,
                Type = BackgroundIconType
            });
        }
    }
}
