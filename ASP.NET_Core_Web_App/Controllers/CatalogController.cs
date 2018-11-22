using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Web_App.Models.Catalog;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Web_App.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAsset _assets;

       public CatalogController(ILibraryAsset assets)
        {
            _assets = assets;
        }

        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();

            var listingResult = assetModels
                .Select(result => new AssetIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirectior = _assets.GetAuthorOrDirectior(result.Id),
                    DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                    Title = result.Title,
                    Type = _assets.GetType(result.Id)
                });

            var model = new AssetIndexModel()
            {
                Asseet = listingResult
            };

            return View(model);
        }

    }
}