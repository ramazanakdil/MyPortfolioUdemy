﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.features.ToList();
            return View(values);
        }
    }
}
