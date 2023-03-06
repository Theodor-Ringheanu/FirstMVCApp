using FirstMVCApp.Models;
using FirstMVCApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class MembershipsController : Controller
    {
        private readonly MembershipsRepository _repository;
        public MembershipsController(MembershipsRepository repository)
        {
            _repository = repository;
        }

        // GET: MembershipsController
        public IActionResult Index()
        {
            var memberships = _repository.GetMemberships();
            return View("Index", memberships);
        }

        // GET: MembershipsController/Details/5
        public ActionResult Details(Guid id)
        {
            MembershipModel membership = _repository.GetMembershipById(id);
            return View("Details", membership);
        }

        // GET: MembershipsController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: MembershipsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            MembershipModel membership = new MembershipModel();
            TryUpdateModelAsync(membership);
            _repository.AddMembership(membership);
            return RedirectToAction("Index");
        }

        // GET: MembershipsController/Edit/5
        public ActionResult Edit(Guid id)
        {
            MembershipModel membership = _repository.GetMembershipById(id);
            return View("Edit", membership);
        }

        // POST: MembershipsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, IFormCollection collection)
        {
            MembershipModel membership = new MembershipModel();
            TryUpdateModelAsync(membership);
            _repository.UpdateMembership(membership);
            return RedirectToAction("Index");
        }

        // GET: MembershipsController/Delete/5
        public ActionResult Delete(Guid id)
        {
            MembershipModel membership = _repository.GetMembershipById(id);
            return View("Delete", membership);
        }

        // POST: MembershipsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            _repository.DeleteMembership(id);
            return RedirectToAction("Index");
            
        }
    }
}
