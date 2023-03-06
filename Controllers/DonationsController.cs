using FirstMVCApp.Models;
using FirstMVCApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class DonationsController : Controller
    {
        public readonly DonationsRepository _repository;

        public DonationsController(DonationsRepository repository)
        {
            _repository = repository;
        }

        // GET: DonationsController
        public IActionResult Index()
        {
            var donation = _repository.GetDonation();
            return View("Index", donation);
        }

        // GET: DonationsController/Details/5
        public IActionResult Details(Guid id)
        {
            return View("Details", _repository.GetDonationById(id));
        }

        // GET: DonationsController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: DonationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            DonationModel donation = new DonationModel();
            TryUpdateModelAsync(donation);
            _repository.AddDonation(donation);
            return RedirectToAction("Index");
        }

        // GET: DonationsController/Edit/5
        public ActionResult Edit(Guid id)
        {
            DonationModel donation = _repository.GetDonationById(id);
            return View("Edit", donation);
        }

        // POST: DonationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, IFormCollection collection)
        {
            DonationModel donation = new();
            TryUpdateModelAsync(donation);
            _repository.AddDonation(donation);
            return RedirectToAction("Index"); 
        }

        // GET: DonationsController/Delete/5
        public IActionResult Delete(Guid id)
        {
            DonationModel donation = _repository.GetDonationById(id);
            return View("Delete", donation);
        }

        // POST: DonationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            _repository.DeleteDonation(id);
            return RedirectToAction("Index");
        }
    }
}
