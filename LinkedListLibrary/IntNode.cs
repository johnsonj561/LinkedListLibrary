using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary {
    class IntNode {

        /// <summary>
        /// Constructor creates node with integer value.
        /// Default value is null. Prev/Next Nodes are not defined.
        /// </summary>
        /// <param name="value"></param>
        public IntNode(int value) {
            this.value = value;
            prevNode = nextNode = null; 
        }


        public int value { get; set; }
        public IntNode prevNode { get; set; }
        public IntNode nextNode { get; set; }
    }
}
