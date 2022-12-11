using LoLHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

using Rune = LoLHelper.Models.Rune;


namespace DAL.ViewModels
{
    public class PickViewModel
    {
        public List<SelectListItem> champs { get; set; }=new List<SelectListItem>();
        public int SelectedChamp { get; set; }
        public List<SelectListItem> spells { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> mainRunes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> runes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> extraRunes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> items { get; set; } = new List<SelectListItem>();
        public List<string> roles { get; set; }=new List<string>() {"Top","Jungle","Mid","Adc","Support" };
        
    }
}
