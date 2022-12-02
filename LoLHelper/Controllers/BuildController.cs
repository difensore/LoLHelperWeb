using LoLHelper.Interfaces;
using LoLHelper.Models;
using LoLHelper.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
namespace LoLHelper.Controllers
{
    public class BuildController:Controller
    {
        private readonly IDataProvider _dataprovider;
        public BuildController(IDataProvider datapovider)
        {
            
            _dataprovider = datapovider;
        }

    }
}
