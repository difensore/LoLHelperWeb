using LoLHelper.Interfaces;
using LoLHelper.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LoLHelper.Services
{
    public class DataProvider:IDataProvider
    {
        private readonly LolHelperContext db;
        public DataProvider(LolHelperContext context)
        {
            db = context;
        }
        public List<Champ> GetChamps()
        {
            var champ= db.Champs.ToList();
            return champ;
        }
        public async Task<PickManager> GetChampAsync(int champ)
        {
             var pick = db.Picks.First(x => x.Champ == champ);
            var runesbuild = db.RunesBuilds.First(x => x.Id == pick.RunesBuild);
            PickManager pickM=new PickManager() 
            {
                pick = pick,
                champ= await db.Champs.FirstAsync(x=>x.Id==champ),
                MainRune= await db.MainRunes.FirstAsync(x=>x.Id==runesbuild.MainrRune),
                SecondMainRune = await db.MainRunes.FirstAsync(x => x.Id == runesbuild.SecondMainRune),
                FirstRune = await db.Runes.FirstAsync(x => x.Id == runesbuild.FirstRune),
                SecondRune =await db.Runes.FirstAsync(x => x.Id == runesbuild.SecondRune),
                ThirdRune = await db.Runes.FirstAsync(x => x.Id == runesbuild.ThirdRune),
                FourthRune = await db.Runes.FirstAsync(x => x.Id == runesbuild.FourthRune),
                FirstRuneS = await db.Runes.FirstAsync(x=>x.Id==runesbuild.FirstRuneS),
                SecondRuneS = await db.Runes.FirstAsync(x => x.Id == runesbuild.SecondRuneS),
                FirstExtraRune = await db.ExtraRunes.FirstAsync(x => x.Id == runesbuild.FirstExtraRune),
                SecondExtraRune = await db.ExtraRunes.FirstAsync(x => x.Id == runesbuild.SecondExtraRune),
                ThirdExtraRune = await db.ExtraRunes.FirstAsync(x => x.Id == runesbuild.ThirdExtraRune)
            };
            return pickM;
        }
    }
}
