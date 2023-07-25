using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScubeMarbleChallenge
{
 
    // comment
    public class Marble
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Double Weight { get; set; }

        public override String ToString()
        {
            // { id: 1, color: "blue", name: "Bob", weight: 0.5 },
            return "{ id: " + Id + ", color: " + Color + ", name: " + Name + ", weight: " + Weight + " }";
        }
    }
}
