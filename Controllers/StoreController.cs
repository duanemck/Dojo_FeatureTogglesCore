using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojo_FeatureTogglesCore.Models;

namespace Dojo_FeatureTogglesCore.Controllers
{
  public class StoreController : Controller
  {

    public ActionResult Index()
    {
      var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };

      var viewModel = new StoreIndexViewModel
      {
        NumberOfGenres = genres.Count(),
        Genres = genres
      };

      ViewBag.Starred = new List<string> { "Rock", "Jazz" };

      return this.View(viewModel);
    }

    public ActionResult Browse(string genre)
    {
      var genreModel = new Genre()
      {
        Name = genre
      };

      var albums = new List<Album>()
            {
                new Album() { Title = genre + " Album 1" },
                new Album() { Title = genre + " Album 2" }
            };

      var viewModel = new StoreBrowseViewModel()
      {
        Genre = genreModel,
        Albums = albums
      };

      return this.View(viewModel);
    }

    public ActionResult Details(int id)
    {
      var album = new Album { Title = "Sample Album" };

      return this.View(album);
    }
  }
}