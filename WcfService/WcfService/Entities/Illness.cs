﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.Entities
{
    [Serializable]
    public class Illness
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
