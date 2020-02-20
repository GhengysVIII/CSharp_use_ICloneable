using System;
using System.Collections.Generic;
using System.Text;

namespace use_ICloneable {
    class Boat : Vehicle {
        private int numWheels;

        public int NumWheels {
            get { return numWheels; }
            set { numWheels = value; }
        }

    }
}
