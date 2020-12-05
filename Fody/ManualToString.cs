using System;
using System.Collections.Generic;
using System.Text;

namespace FodyCourse
{
    [ToString]
    public class ManualToString
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        [IgnoreDuringToString]
        public string Password { get; set; }
    }
}
