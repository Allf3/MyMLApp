using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLayer.Entity
{
    public class Comment
    {
        public string Text { get; set; }

        public DateTime PostedDate { get; set; }

        public bool Toxic { get; set; }
    }
}
