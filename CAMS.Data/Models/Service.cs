﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMS.Data.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
        //public DateTime[] AvailableTimeSlots { get; set; }

        public virtual ICollection<ServiceDate> ServiceDates { get; set; }
        //public virtual ICollection<DateTimeSlotGroup> DateTimeSlotGroup { get; set; }

        // Many-to-Many relationship (Appointment and Service)
        //public virtual ICollection<AppointmentService> AppointmentServices { get; set; }
        public virtual ICollection<Appointment> Appointmens { get; set; }
    }
}
