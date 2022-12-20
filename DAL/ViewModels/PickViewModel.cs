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
        public string? currentUser { get; set; }
        public int SelectedChamp { get; set; }
        public int SelectedFirstSpell { get; set; }
        public int SelectedSecondSpell { get; set; }
        public int SelectedFirstMainRune { get; set; }
        public int SelectedFirstRune { get; set; }
        public int SelectedSecondRune { get; set; }
        public int SelectedThirdRune { get; set; }
        public int SelectedFourthRune { get; set; }
        public int SelectedSecondMainRune { get; set; }
        public int SelectedFirstRuneS { get; set; }
        public int SelectedSecondRuneS { get; set; }
        public int SelectedFirstExtraRune { get; set; }
        public int SelectedSecondExtraRune { get; set; }
        public int SelectedThirdExtraRune { get; set; }
        public int SelectedFirstStartedItem { get; set; }
        public int SelectedSecondStartedItem { get; set; }
        public int? SelectedThirdStartedItem { get; set; }
        public int SelectedFirstMainItem { get; set; }
        public int SelectedSecondMainItem { get; set; }
        public int SelectedThirdMainItem { get; set; }
        public int SelectedFivthMainItem { get; set; }
        public int? UserBuild { get; set; }
        public List<SelectListItem> spells { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> mainRunes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> runes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> extraRunes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> items { get; set; } = new List<SelectListItem>();
        public List<string> roles { get; set; }=new List<string>() {"Top","Jungle","Mid","Adc","Support" };
        
    }
}
