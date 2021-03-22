using System;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DotNetNinja.Templates.Mvc.Tests
{
    public static class ViewExtensions
    {
        public static void AssertIsDefaultViewForAction<TController>(this ViewResult view, Action<TController> action)
            where TController : Controller
        {
            var actionName = action.Method.Name;
            Assert.True(string.IsNullOrWhiteSpace(view.ViewName) || view.ViewName.Equals(actionName, StringComparison.CurrentCultureIgnoreCase), $"Expected view {actionName} but was {view.ViewName}.");
        }
    }
}