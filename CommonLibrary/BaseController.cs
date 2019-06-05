﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class BaseController
    {
        public bool IsSuccessful { get; protected set; }

        public BaseController()
        {
            IsSuccessful = false;
        }

    }
}