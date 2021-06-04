// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using PremierAthletics.Models;

// namespace PremierAthletics.Controllers
// {
//   public class AthletesController : Controller
//   {

//     // public IActionResult Details(int id)
//     // {
//     //   var thisRating = Rating.GetDetails(id);
//     //   return View(thisRating);
//     // }

//     // [HttpPost]
//     // public IActionResult Rate(int id, Rating rating)
//     // {
//     //   var thisPlace = Place.GetPlaces.Where(p => p.PlaceId == id);
//     //   ViewBag.Place = thisPlace;
//     //   Rating.Post(rating);
//     //   return RedirectToAction("Places/{placeId}");
//     // }  

//     public IActionResult SignDocument(HSeSignature signatureRequest)
//     {
//       var signURL = HSeSignature.GetSignURL(signatureRequest);
//       return View(signURL);
//     }

//     [HttpPost]
//     public IActionResult Details(int id, Rating rating)
//     {
//       rating.RatingId = id;
//       Rating.Put(rating);
//       return RedirectToAction("Details", id);
//     }

//     public IActionResult Delete(int id)
//     {
//       Rating.Delete(id);
//       return RedirectToAction("Index");
//     }


//   }
// }