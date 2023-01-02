using DAL.ViewModels;
using LoLHelper.Controllers;
using LoLHelper.Interfaces;
using LoLHelper.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Rune = LoLHelper.Models.Rune;

namespace LoLHelper.Tests
{
    public class BuildControllerTests
    {
        [Fact]
        public void BuildTest()
        {
            var mockIDP = new Mock<IDataProvider>();
            var mockIPB = new Mock<IPickBuilder>();
            mockIDP.Setup(IDP => IDP.GetChamps()).Returns(GetTestChamp());
            mockIDP.Setup(IDP => IDP.GetItems()).Returns(GetTestItem());
            mockIDP.Setup(IDP => IDP.GetSpells()).Returns(GetTestSpell());
            mockIDP.Setup(IDP => IDP.GetAllRunes()).Returns(GetTestRune());
            mockIDP.Setup(IDP => IDP.GetAllMainRunes()).Returns(GetTestMainRune());
            mockIDP.Setup(IDP => IDP.GetAlExtraRunes()).Returns(GetTestExtraRune());
            BuildController controller = new BuildController(mockIDP.Object,mockIPB.Object);
            var result = controller.Build();
            var viewResult=Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<PickViewModel>(viewResult.Model);            
        }
        private IQueryable<Champ> GetTestChamp()
        {
            List<Champ> champs= new List<Champ>
            {
               new Champ{Id=101, Name="Test"},
               new Champ{Id=102, Name="testS"}
            };
            return champs.AsQueryable();
        }
        private List<Item> GetTestItem()
        {
            List<Item> items = new List<Item>
            {
               new Item{Id=101, Name="Test"},
               new Item{Id=102, Name="testS"}
            };
            return items;
        }
        private List<Spell> GetTestSpell()
        {
            List<Spell> spells = new List<Spell>
            {
               new Spell{Id=101, Name="Test"},
               new Spell{Id=102, Name="testS"}
            };
            return spells;
        }
        private List<Rune> GetTestRune()
        {
            List<Rune> runes = new List<Rune>
            {
               new Rune{Id=101, Name="Test",MainRune=1},
               new Rune{Id=102, Name="testS",MainRune=1}
            };
            return runes;
        }
        private List<MainRune> GetTestMainRune()
        {
            List<MainRune> runes = new List<MainRune>
            {
               new MainRune{Id=101, Name="Test"},
               new MainRune{Id=102, Name="testS"}
            };
            return runes;
        }
        private List<ExtraRune> GetTestExtraRune()
        {
            List<ExtraRune> runes = new List<ExtraRune>
            {
               new ExtraRune{Id=101, Name="Test"},
               new ExtraRune{Id=102, Name="testS"}
            };
            return runes;
        }
    }
}
