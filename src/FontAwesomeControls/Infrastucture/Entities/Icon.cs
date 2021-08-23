using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontAwesomeControls.Infrastucture.Entities
{
    enum IconType
    {
        Solid,
        Brands,
        Regular,
        Light,
        Duotone
    }

    class Icon
    {
        private IconType? _Type = null;
        public IconType? Type { get { return _Type; } set { _Type = value; } }
        public string Name { get; set; }
        public string Svg { get; set; }
        public Color Color { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }
}
