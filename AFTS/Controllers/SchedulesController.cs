﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AFTS.Models;
using Microsoft.AspNetCore.Http;

namespace AFTS.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly tennisContext _context;

        public SchedulesController(tennisContext context)
        {
            _context = context;
        }

        // GET: Schedules
        public async Task<IActionResult> Index()
        {

            var MemberIdString = HttpContext.Session.GetString("MemberId");
            var RoleIdString = HttpContext.Session.GetString("RoleId");

            Int32.TryParse(MemberIdString, out int MemberId);
            Int32.TryParse(RoleIdString, out int RoleId);

            if (MemberIdString != null)
            {



                var coachEvents = from m in _context.Member
                                     join s in _context.Schedule on m.MemberId equals s.MemberId
                                     join e in _context.Event on s.EventId equals e.EventId
                                     where s.Event.MemberId == MemberId
                                     select e;




                var eVM = _context.Schedule.Select(s => new EventSchduleViewModel
                {
                    Events = coachEvents.ToList()

                });

                var eVM2 = new EventSchduleViewModel
                {
                    
                    Events = coachEvents.ToList()

                };

                return View(eVM2);
            }


            return RedirectToAction("Login", "Home");
        }

        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MemberId = HttpContext.Session.GetString("MemberId");
            var RoleIdString = HttpContext.Session.GetString("RoleId");

            Int32.TryParse(RoleIdString, out int RoleId);

            if (MemberId != null)
            {
                var schedule = _context.Schedule.FirstOrDefault(s => s.ScheduleId == id);

                var selectedEvent = _context.Event.FirstOrDefault(e => e.EventId == id);



                if (schedule == null)
                {
                    return NotFound();
                }

                var coachEvents = _context.Event.Where(c => c.MemberId == RoleId).ToList();

                var members = _context.Member.Where(c => c.MemberId == schedule.MemberId).ToList();

                var membersInEvent = from m in _context.Member

                                     join s in _context.Schedule on m.MemberId equals s.MemberId
                                     join e in _context.Event on s.EventId equals e.EventId
                                     where e.EventId == selectedEvent.EventId
                                     select m;

                var eVM = _context.Schedule.Select(s => new EventSchduleViewModel
                {
                    Members = membersInEvent.ToList()
               });

                var eVM2 = new EventSchduleViewModel
                {
                    Members = membersInEvent.ToList()

                };

                return View(eVM2);
            }


            return RedirectToAction("Login", "Home");


        }

        // GET: Schedules/Create
        public IActionResult Create()
        {

            var MemberId = HttpContext.Session.GetString("MemberId");
            var RoleId = HttpContext.Session.GetString("RoleId");

            if (MemberId != null && RoleId == "1" || RoleId == "2")
            {
                return View();
            }


            return RedirectToAction("Login", "Home");
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScheduleId")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MemberId = HttpContext.Session.GetString("MemberId");
            var RoleId = HttpContext.Session.GetString("RoleId");

            if (MemberId != null && RoleId == "1" || RoleId == "2")
            {
                var schedule = await _context.Schedule.FindAsync(id);
                if (schedule == null)
                {
                    return NotFound();
                }
                return View(schedule);
            }


            return RedirectToAction("Login", "Home");


        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScheduleId")] Schedule schedule)
        {
            if (id != schedule.ScheduleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.ScheduleId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MemberId = HttpContext.Session.GetString("MemberId");
            var RoleId = HttpContext.Session.GetString("RoleId");

            if (MemberId != null && RoleId == "1" || RoleId == "2")
            {
                var schedule = await _context.Schedule
                    .FirstOrDefaultAsync(m => m.ScheduleId == id);
                if (schedule == null)
                {
                    return NotFound();
                }

                return View(schedule);
            }


            return RedirectToAction("Login", "Home");

        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            _context.Schedule.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
            return _context.Schedule.Any(e => e.ScheduleId == id);
        }
    }
}
