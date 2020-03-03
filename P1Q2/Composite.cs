using System;
using System.Collections.Generic;
using System.Text;

namespace P1Q2
{
    class Composite : Component
    {
        private IList<Component> childs = new List<Component>();
        public override int Val { get; set; }

        public Composite(string name ,int val):base(name,val)
        {
        }

        public override void AddChild(Component comp)
        {
            childs.Add(comp);
        }

        public override void RemoveChild(Component comp)
        {
            childs.Remove(comp);
        }
        public IList<Component> GettAllChilds()
        {
            return childs;
        }

        public override int GetSum()
        {
            int sum = Val;
            if (GettAllChilds() != null)
            {
                foreach (Component c in childs)
                {
                    sum += c.GetSum();
                }
            }
            
            return sum;
        }

        public override bool IsOdd()
        {
            if (this.Val % 2 == 0)
                return false;
            if (GettAllChilds() != null)
                foreach (Component c in childs)
                {
                    if (c.IsOdd())
                        return false;
                }
            return true;

        }
    }
}
