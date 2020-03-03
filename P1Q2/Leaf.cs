using System;
using System.Collections.Generic;
using System.Text;

namespace P1Q2
{
    class Leaf:Component
    {

        public override int Val { get; set; }

        public Leaf(string name, int val) : base(name, val)
        {
            this.Name = name;
            this.Val = val;
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException();
        }
        
        public IList<Component> GetAllChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException();
        }

        public override int GetSum()
        {
            return Val;
        }

        public override bool IsOdd()
        {
            return Val % 2 != 0;
        }
    }
}
}
