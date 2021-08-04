﻿using System;
namespace CodingEventsDemo.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public EventCategory()
        {

        }

        public EventCategory(string name) : this()
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }


        public override bool Equals(object obj)
        {
            return obj is EventCategory @event &&
                   this.Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }
    }
}
