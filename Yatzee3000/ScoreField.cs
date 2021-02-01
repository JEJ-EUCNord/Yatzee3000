using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzee3000
{
    class ScoreField
    {
        public string Label{ get; set; }
        public int P1 { get; set; }
        public int P2 { get; set; }

        public ScoreField(string label, int p1, int p2) {
            this.Label = label;
            this.P1 = p1;
            this.P2 = p2;
        }
    }
}
