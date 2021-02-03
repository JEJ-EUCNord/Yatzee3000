using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class ScoreField
    {
        public string Label{ get; set; }
        public int P1 { get; set; }
        public int P2 { get; set; }

        public ScoreField(string label, int p1, int p2) {
            Label = label;
            P1 = p1;
            P2 = p2;
        }
    }
}
