using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FontAwesomeControls.Infrastucture.Entities;
using System.Text;
using System.Threading.Tasks;
using FontAwesomeControls.Data;
using Svg;

namespace FontAwesomeControls.Business
{
    class IconBusiness
    {
        public static Image GetImage(Infrastucture.Entities.Icon request)
        {
            Image response = null;

            IconData iconData = IconData.GetInstance();
            var iconFind = iconData.Icons.Where(x => x.Type == request.Type && x.Name == request.Name).FirstOrDefault();

            if (iconFind != null)
            {
                request.Svg = iconFind.Svg;

                SvgDocument svg = SvgDocument.FromSvg<SvgDocument>(request.Svg);
                svg.Fill = new SvgColourServer(request.Color);

                if (request.Height == null && request.Width == null)
                {
                    request.Width = 50;
                    request.Height = 50;
                }
                else
                {
                    if (request.Width == null)
                    {
                        response = svg.Draw();
                        request.Width = response.Width * request.Height / response.Height;
                    }
                    else if (request.Height == null)
                    {
                        response = svg.Draw();
                        request.Height = response.Height * request.Width / response.Width;
                    }
                }

                response = svg.Draw(request.Width.Value, request.Height.Value);
            }

            return response;
        }
    }
}
