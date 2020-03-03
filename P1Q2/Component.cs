using System;
using System.Collections.Generic;
using System.Text;

namespace P1Q2
{
    public abstract class Component
    {
        protected string Name;

        public abstract int Val { get; set; }

        public Component(string name, int val)
        {
            this.Name = name;
            this.Val= val;
        }
        

        public abstract void AddChild(Component c);


        public abstract void RemoveChild(Component c);


        public abstract int GetSum();
        
        public string GetName()
        {
            return this.Name;
        }
        public abstract bool IsOdd();
    }
}
