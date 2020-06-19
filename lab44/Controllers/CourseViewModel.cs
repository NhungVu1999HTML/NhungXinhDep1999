using System;
using System.Collections.Generic;
using lab44.Models;

namespace lab44.Controllers
{
    internal class CourseViewModel
    {
        public List<Category> Categories { get; set; }
        public byte Category { get; internal set; }
        public string Place { get; internal set; }

        internal DateTime GetDateTime()
        {
            throw new NotImplementedException();
        }
    }
}