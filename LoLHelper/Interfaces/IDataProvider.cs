﻿using LoLHelper.Models;

namespace LoLHelper.Interfaces
{
    public interface IDataProvider
    {
        public List<Champ> GetChamps();
        public Task<PickManager> GetChampAsync(int champ);
        public List<Item> GetItems();
        public Task<Item> GetItemAsync(int id);
        public Task<int> GetContrPickAsync(string champ);
        public List<Spell> GetSpells();
        public List<MainRune> GetAllMainRunes();
        public List<Rune> GetAllRunes();
        public List<ExtraRune> GetAlExtraRunes();

    }
}
