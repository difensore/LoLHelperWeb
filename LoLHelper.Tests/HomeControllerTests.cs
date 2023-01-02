using LoLHelper.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using LoLHelper.Interfaces;

namespace LoLHelper.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexTest()
        {            
            var mockIDP = new Mock<IDataProvider>();
            var mockISPB=new Mock<ISortedPaginationBuilder>();            
            HomeController controller = new HomeController(mockIDP.Object,mockISPB.Object);            
            ViewResult result = controller.Index() as ViewResult;                
            Assert.NotNull(result);            
        }
    }
}
