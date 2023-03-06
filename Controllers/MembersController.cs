using FirstMVCApp.Models;
using FirstMVCApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class MembersController : Controller
    {
        private readonly MembersRepository _repository;
        public MembersController(MembersRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var member = _repository.GetMember();
            return View("Index", member);
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            MemberModel member = new MemberModel();
            TryUpdateModelAsync(member);
            _repository.AddMember(member);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            MemberModel member = _repository.GetMemberById(id);
            return View("Edit", member);
        }
        [HttpPost]
        public IActionResult Edit(Guid id, IFormCollection collection)
        {
            MemberModel member = new();
            TryUpdateModelAsync(member);
            _repository.UpdateMember(member);

            return RedirectToAction("Index");
        }

        public IActionResult Details(Guid id)
        {
            return View("Details", _repository.GetMemberById(id));
        }

        public ActionResult Delete(Guid id)
        {
            MemberModel members = _repository.GetMemberById(id);
            return View("Delete", members);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            _repository.DeleteMemberById(id);
            return RedirectToAction("Index");
        }
    }
}
