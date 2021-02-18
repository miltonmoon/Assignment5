﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFAssignment5Repository : IAssignment5Repository
    {
        private Assignment5DBContext _context;

        public EFAssignment5Repository (Assignment5DBContext context)
        {
            _context = context;
        }

        public IQueryable<Textbook> Textbooks => _context.Textbooks;
    }
}
