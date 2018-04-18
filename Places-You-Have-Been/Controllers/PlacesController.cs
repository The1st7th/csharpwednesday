using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create()
    {
      Place newPlace = new Place (Request.Form["new-place"], Request.Form["new-image"]);

      List<Place> allPlaces = Place.GetAll();
      return View("Index", allPlaces);
    }

    [HttpGet("/places/{id}")]
    public ActionResult Details(int id)
    {
      Place location = Place.Find(id);
      return View(location);
    }

  }



}
