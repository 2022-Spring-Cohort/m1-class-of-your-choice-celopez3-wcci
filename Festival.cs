using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_class_of_your_choice
{
    class Festival
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Location { get; set; }
        public List<string> Amenities { get; set; }

        public bool IsCamping { get; set; }

        public Festival()
        {
            Amenities = new List<string>();
        }

        public void AddAmenity(string perk)
        {
            Amenities.Add(perk);
        }
    }
}
