﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoG2.Models
{
    public class Grinder
    {
        public string Type { get; set; }
        public string Model { get; set; }
    
        private static string StartGrinderProcess()
        {
            return "start...";
        }

        private static string StopGrinder()
        {
            return "Process end";
        }
    } 

  
}
