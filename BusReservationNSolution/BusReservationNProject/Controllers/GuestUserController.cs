﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace BusReservationNProject.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class GuestUserController : ApiController
    {
        
        private BusReservationEntities db = new BusReservationEntities();
        // GET: api/JourneyRoutes
        [HttpGet]
        public List<proc_GuestUserDetail_Result> Get()
        {
            List<proc_GuestUserDetail_Result> list = new List<proc_GuestUserDetail_Result>();
            foreach (var item in db.proc_GuestUserDetail())
            {
                list.Add(item);

            }
            return list;
        }

        [ResponseType(typeof(GuestUserDetail))]
        [HttpPost]
        public IHttpActionResult PostGuestUserDetail(GuestUserDetail guestUserDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.proc_InsertGuestUserDetail(guestUserDetail.FirstName,guestUserDetail.Lastname,guestUserDetail.EmailId,guestUserDetail.PhoneNumber);
            //db.tblUsers.Add(tblUser);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = guestUserDetail.GID }, guestUserDetail);
        }
    }
}
