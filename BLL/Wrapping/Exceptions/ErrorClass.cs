﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Wrapping.Exceptions
{
    public class ErrorClass
    {
        public int StatusCode { get; set; }
        public string Title { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
