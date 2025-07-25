﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace BORIS.Models
{
    public class Specialisation
    {
        public int ID { get; init; }
        public string Title { get; set; }
        public string Description { get; set; }

        
    }

    public static class SpecialisationList
    {
        public static List<SelectListItem> SelectionItems =
        [
            new SelectListItem { Text = "Keine Auswahl", Value = "NONE" },
            new SelectListItem { Text = "Systemintegration", Value="FISI" },
            new SelectListItem { Text = "Anwendungsentwicklung", Value ="FIAE" },
            new SelectListItem { Text = "Daten- und Prozessanalyse", Value = "FIDPA"}
            
        ];

    }
}
