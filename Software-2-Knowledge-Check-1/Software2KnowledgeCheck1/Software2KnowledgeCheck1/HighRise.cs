﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class HighRise : Building
    {
        public int NumberOfStories { get; set; }
        public string OwnerName { get; set; }
        public List<string> Directory  { get; set; }
    }
}
