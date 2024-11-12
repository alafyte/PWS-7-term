using Lab06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace WebApplication.Controllers
{
    public class StudentsController : Controller
    {
        private StudentsModel _service;

        public StudentsController()
        {
            _service = new StudentsModel(new Uri("http://localhost:52567/StudentService.svc"));
        }

        // GET: Students
        public ActionResult Index()
        {
            var students = _service.student.AsEnumerable();
            var notes = _service.note.AsEnumerable();
            ViewBag.Notes = notes; // Passing notes to the view via ViewBag
            return View(students);
        }

        // POST: Students/Create
        [HttpPost]
        public ActionResult Create(string studentName)
        {
            try
            {
                var student = new student { name = studentName };
                _service.AddTostudent(student);
                _service.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: Students/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var student = _service.student.AsEnumerable().First(i => i.id ==id);

                if (student != null)
                {
                    _service.DeleteObject(student);
                    _service.SaveChanges(); // Persist the deletion
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: Students/Update
        [HttpPost]
        public ActionResult Update(int id, string newName)
        {
            try
            {
                var student = _service.student.AsEnumerable().First(i => i.id == id);
                if (student != null)
                {
                    student.name = newName;
                    _service.UpdateObject(student);
                    _service.SaveChanges(); // Save the updated student
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }


        // POST: Notes/Create
        [HttpPost]
        public ActionResult CreateNote(int studentId, string subject, int noteValue)
        {
            try
            {
                var note = new note
                {
                    stud_id = studentId,
                    subject = subject,
                    note1 = noteValue
                };
                _service.AddTonote(note);
                _service.SaveChanges(); // Save changes in OData service
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: Notes/Delete/5
        [HttpPost]
        public ActionResult DeleteNote(int id)
        {
            try
            {
                var note = _service.note.AsEnumerable().First(n => n.id == id);
                if (note != null)
                {
                    _service.DeleteObject(note);
                    _service.SaveChanges(); // Persist the deletion
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: Notes/Update
        [HttpPost]
        public ActionResult UpdateNote(int id, int studentId, string subject, int noteValue)
        {
            try
            {
                var note = _service.note.AsEnumerable().First(n => n.id == id);
                if (note != null)
                {
                    note.stud_id = studentId;
                    note.subject = subject;
                    note.note1 = noteValue;
                    _service.UpdateObject(note);
                    _service.SaveChanges(); // Save the updated note
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message; 
                return RedirectToAction("Index");
            }
        }

        // Similar methods can be created for managing notes
    }
}