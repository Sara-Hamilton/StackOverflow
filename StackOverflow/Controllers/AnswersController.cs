using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using StackOverflow.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Linq;
using System;
using System.Collections.Generic;

namespace StackOverflow.Controllers
{
    [Authorize]
    public class AnswersController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public AnswersController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            return View(_db.Answers.Where(x => x.User.Id == currentUser.Id));
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            Answer answer = new Answer();
            answer.Content = Request.Form["content"];
            answer.QuestionId = int.Parse(Request.Form["questionId"]);
            var routeId = int.Parse(Request.Form["questionId"]);
            answer.UserId = currentUser.Id;
            _db.Answers.Add(answer);
            _db.SaveChanges();
            return RedirectToAction("Details", "Questions", new { id = routeId });
        }

        [HttpPost]
        public async Task<IActionResult> Vote()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            int id = int.Parse(Request.Form["answerId"]);
            Answer answer = _db.Answers.FirstOrDefault(x => x.AnswerId == id);
            answer.VoteTally += int.Parse(Request.Form["vote"]);
            _db.Answers.Update(answer);
            _db.SaveChanges();
            return RedirectToAction("Details", "Questions", new { id = answer.QuestionId });
        }

        [HttpPost]
        public async Task<IActionResult> Best()
        {
            int answerId = int.Parse(Request.Form["aId"]);
            int questionId = int.Parse(Request.Form["qId"]);
            Answer answer = _db.Answers.FirstOrDefault(x => x.AnswerId == answerId);
            List<Answer> ansList = _db.Answers.Where(y => y.QuestionId == questionId).ToList();
            ansList = answer.SetBest(ansList, answer);
            for(int j = 0; j < ansList.Count; j++)
            {
                _db.Answers.Update(ansList[j]);
            }
            _db.SaveChanges();
            return RedirectToAction("Details", "Questions", new { id = answer.QuestionId });
        }
    }
}
