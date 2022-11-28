using Microsoft.AspNetCore.Http.Features;

namespace LoLHelper.Models
{
    public class PickManager
    {
        public Pick pick {get; set;}
        public Champ champ {get; set;}
        public MainRune MainRune {get; set;}
        public MainRune SecondMainRune { get; set; }
        public Rune FirstRune {get; set; }
        public Rune SecondRune { get; set; }
        public Rune ThirdRune { get; set; }
        public Rune FourthRune { get; set; }
        public Rune FirstRuneS { get; set; }
        public Rune SecondRuneS { get; set; }
        public ExtraRune FirstExtraRune { get; set; }
        public ExtraRune SecondExtraRune { get; set; }
        public ExtraRune ThirdExtraRune { get; set; }
        public Item FirstStartedItem { get; set; }
        public Item SecondStartedItem { get; set; }
        public Item ThirdStartedItem { get; set; }
        public Item FirstMainItem { get; set; }
        public Item SecondMainItem  { get; set; }
        public Item ThirdMainItem { get; set; }
        public Item FivthMainItem { get; set; }
    }
}
