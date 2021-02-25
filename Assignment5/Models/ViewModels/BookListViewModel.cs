﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Textbook> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
