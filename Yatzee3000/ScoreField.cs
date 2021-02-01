using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzee3000
{
    class ScoreField
    {
        public string  label{ get; set; }
        public int p1 { get; set; }
        public int p2 { get; set; }

        public ScoreField(string label, int p1, int p2) {
            this.label = label;
            this.p1 = p1;
            this.p2 = p2;
        }
    }
}
