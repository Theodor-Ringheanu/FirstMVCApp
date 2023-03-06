using FirstMVCApp.Models;
using FirstMVCApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly MembershipTypesRepository _repository;
        public MembershipTypesController(MembershipTypesRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var membershipTypes = _repository.GetMembershipTypes();
            return View("Index", membershipTypes);
        }

        public ActionResult Details(Guid id)
        {
            MembershipTypeModel membershipType = _repository.GetMembershipTypeById(id);
            return View("Details", membershipType);
        }

        [HttpPost]
        public IActionResult Create(IFormCollection collection)
        {
            MembershipTypeModel membershipType = new MembershipTypeModel();
            TryUpdateModelAsync(membershipType);
            _repository.AddMembershipType(membershipType);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            MembershipTypeModel membershipType = _repository.GetMembershipTypeById(id);
            return View("Edit", membershipType);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, IFormCollection collection)
        {
            MembershipTypeModel membershipType = new();
            TryUpdateModelAsync(membershipType);
            _repository.UpdateMembershipType(membershipType);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            MembershipTypeModel membershipType = _repository.GetMembershipTypeById(id);
            return View("Delete", membershipType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            _repository.GetMembershipTypeById(id);
            return RedirectToAction("Index");
        }
    }
}
