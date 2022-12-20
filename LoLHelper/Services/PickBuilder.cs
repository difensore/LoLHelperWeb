﻿using DAL.ViewModels;
using LoLHelper.Models;

namespace LoLHelper.Services
{
    public class PickBuilder
    {
        private readonly LolHelperContext db;

        public PickBuilder(LolHelperContext context)
        {
            db = context;
        }
        public void CreateBuild(PickViewModel model)
        {
            try
            {
                Random rnd = new Random();
                int idr = rnd.Next(10000, 100000000);
                int idp = rnd.Next(10000, 100000000);
                db.RunesBuilds.Add(new RunesBuild
                {
                    Id = idr,
                    MainrRune = model.SelectedFirstMainRune,
                    FirstRune = model.SelectedFirstRune,
                    SecondRune = model.SelectedSecondRune,
                    ThirdRune = model.SelectedThirdRune,
                    FourthRune = model.SelectedFourthRune,
                    SecondMainRune = model.SelectedSecondMainRune,
                    FirstRuneS = model.SelectedSecondRune,
                    SecondRuneS = model.SelectedSecondRuneS,
                    FirstExtraRune = model.SelectedFirstExtraRune,
                    SecondExtraRune = model.SelectedSecondExtraRune,
                    ThirdExtraRune = model.SelectedSecondExtraRune
                });
                db.SaveChanges();
                db.Picks.Add(new Pick
                {
                    Id=idp,
                    Champ = model.SelectedChamp,
                    RunesBuild = idr,
                    FirstSpell = model.SelectedFirstSpell,
                    SecondSpell = model.SelectedSecondSpell,
                    FirstStartedItem = model.SelectedFirstStartedItem,
                    SecondStartedItem = model.SelectedFirstStartedItem,
                    ThirdStartedItem = model.SelectedThirdStartedItem,
                    FirstMainItem = model.SelectedFirstMainItem,
                    SecondMainItem = model.SelectedSecondMainItem,
                    ThirdMainItem = model.SelectedThirdMainItem,
                    FivthMainItem = model.SelectedFivthMainItem
                });
                db.UsersBuilds.Add(new UsersBuild { BuildId = idp, UserId = model.currentUser });

            }
            catch
            {

            }
        }
    }
}