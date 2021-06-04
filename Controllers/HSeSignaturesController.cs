using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PremierAthletics.Models;

namespace PremierAthletics.Controllers
{
  public class AthletesController : Controller
  {
    public IActionResult SignDocument(HSeSignature signatureRequest)
    {
      var signURL = HSeSignature.GetSignURL(signatureRequest);
      return View(signURL);
    }

    [HttpPost]
    public IActionResult AssignSignatureRequest(Document document, Athlete athlete)
    {
      HSeSignature.CreateEmbeddedSignatureRequest(document, athlete);
      return RedirectToAction("ManageDocuments");
    }

    public IActionResult ReviewSignatureRequest(HSeSignature signatureRequest)
    {
      var signatureObject = HSeSignature.GetSignatureRequest(signatureRequest);
      return View(signatureObject.Status);
    }

  }
}