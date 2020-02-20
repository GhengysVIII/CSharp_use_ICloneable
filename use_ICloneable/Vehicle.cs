using System;
using System.Collections.Generic;
using System.Text;

namespace use_ICloneable {

    class Vehicle : ICloneable {
        private String marque;

        public String Marque {
            get { return marque; }
            set { marque = value; }
        }

        public object Clone() {
            return this.MemberwiseClone();
        }
    }
   
}
