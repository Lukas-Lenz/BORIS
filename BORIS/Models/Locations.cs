using Microsoft.AspNetCore.Mvc.Rendering;

namespace BORIS.Models
{

    public class Location
    {
        public int ID { get; init; }
        public string Name { get; set; }
    }

    public class LocationList
    {
        public static List<SelectListItem> SelectionItems =
            [
                new SelectListItem { Text = "Keine Auswahl", Value = "NONE" },
                new SelectListItem { Text = "Neuss", Value = "NEUSS" },
                new SelectListItem { Text = "Bochum", Value = "BOCHUM" }
            ];
    }
}
