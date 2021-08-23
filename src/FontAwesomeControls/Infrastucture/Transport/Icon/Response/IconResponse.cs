using System.Collections.Generic;

namespace FontAwesomeControls.Infrastucture.Transport.Icon.Response
{
    class IconResponse
    {
        public List<Entities.Icon> Solid { get; set; }
        public List<Entities.Icon> Brands { get; set; }
        public List<Entities.Icon> Regular { get; set; }
        public List<Entities.Icon> Light { get; set; }
        public List<Entities.Icon> Duotone { get; set; }
    }
}
