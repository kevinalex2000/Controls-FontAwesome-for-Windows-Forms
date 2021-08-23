using FontAwesomeControls.Infrastucture.Entities;
using FontAwesomeControls.Infrastucture.Transport.Icon.Response;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace FontAwesomeControls.Data
{
    class IconData
    {
        private static readonly string UrlData = "https://kevinalex2000.github.io/FontAwesome-for-Windows-Forms-DATA/v1/icons.min.json";
        private static string PathToSave = Path.GetTempPath() + "fawf-data.tmp";
        private static IconData _IconData;

        private List<Icon> _Icons;
        public List<Icon> Icons
        {
            get { return _Icons; }
            set { _Icons = value; }
        }

        private IconData()
        {
            Icons = new List<Icon>();

            string DataString;

            if (File.Exists(PathToSave))
            {
                DataString = File.ReadAllText(PathToSave);
            }
            else
            {
                using (WebClient wc = new())
                {
                    DataString = wc.DownloadString(UrlData);
                    File.WriteAllText(PathToSave, DataString);
                }
            }

            IconResponse Response = JsonConvert.DeserializeObject<IconResponse>(DataString);

            Icons.AddRange(Response.Solid.Select(x => new Icon { Name = x.Name, Svg = x.Svg, Type = IconType.Solid }));
            Icons.AddRange(Response.Regular.Select(x => new Icon { Name = x.Name, Svg = x.Svg, Type = IconType.Regular }));
            Icons.AddRange(Response.Light.Select(x => new Icon { Name = x.Name, Svg = x.Svg, Type = IconType.Light }));
            Icons.AddRange(Response.Duotone.Select(x => new Icon { Name = x.Name, Svg = x.Svg, Type = IconType.Duotone }));
            Icons.AddRange(Response.Brands.Select(x => new Icon { Name = x.Name, Svg = x.Svg, Type = IconType.Brands }));
        }

        public static IconData GetInstance()
        {
            if (_IconData == null)
            {
                _IconData = new IconData();
            }

            return _IconData;
        }
    }
}
