using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P1Q4
{
    public class EmployeesList : IEnumerator, IEnumerable
    {
        private IList<Employee> originalList = new List<Employee>();
        IList<Employee> cloneList = new List<Employee>();

        private int pos = 0;

        object IEnumerator.Current => throw new System.NotImplementedException();

        public object Current()
        {
            return cloneList[pos];
        }
  
        internal EmployeesList(IList<Employee> originalList)
        {
            this.originalList = originalList;
        }

        public EmployeesList()
        {
        }

        internal IList<Employee> GetEmployees()
        {

            foreach (var emp in originalList)
            {
                cloneList.Add(emp);
            }
            return cloneList;
        }
        internal IList<Employee> SortTheList(List<Employee> sList)
        {
            for (int i = 0; i < sList.Count; i++)
            {
                if (i < 100)
                {
                    sList = (List<Employee>)sList.OrderBy((x) => x.Id);
                }
                if (i < 201)
                {
                    sList = (List<Employee>)sList.OrderBy((x) => x.Name);
                }
                if (true)
                {
                    sList = (List<Employee>)sList.OrderBy((x) => x.Salary);
                }
                return sList;

            }
            return null;
        }

        public bool MoveNext()
        {
            pos++;
            return (pos < this.cloneList.Count);
        }

        public void Reset()
        {
            pos = 0;
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}