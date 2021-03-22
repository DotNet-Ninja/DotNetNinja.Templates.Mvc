using System;
using Autofac.Extras.Moq;
using DotNetNinja.Templates.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DotNetNinja.Templates.Mvc.Tests.Controllers
{
    public class HomeControllerTests
    {
        private readonly AutoMock _mocks = AutoMock.GetLoose();

        [Fact]
        public void Instantiation_WithNullLogger_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => new HomeController(null));
        }

        [Fact]
        public void Index_ReturnsDefaultView()
        {
            // Arrange
            var controller = _mocks.Create<HomeController>();

            // Act
            var response = controller.Index();

            // Assert
            Assert.NotNull(response);
            Assert.IsType<ViewResult>(response);
            var view = (ViewResult)response;
            view.AssertIsDefaultViewForAction<HomeController>(c=>c.Index());
        }
    }
}