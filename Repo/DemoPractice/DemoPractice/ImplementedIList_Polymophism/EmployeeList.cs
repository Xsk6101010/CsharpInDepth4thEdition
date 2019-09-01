using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    public class EmployeeList : IList
    {
        public EmployeeList()
        {

        }

        public EmployeeList(ICollection EmployeeLists)
        {

        }

        private ICollection employeeList;

        public ICollection EmployeeLists
        {
            get
            {
                return employeeList;
            }
            set
            {
                if (value.Count > 0)
                {
                    employeeList = value;
                }
                else
                {
                    throw new Exception(" The numeber of Employees cannot less than 0");
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return EmployeeLists.GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public object SyncRoot { get; }
        public bool IsSynchronized { get; }
        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public bool IsReadOnly { get; }
        public bool IsFixedSize { get; }
    }
}
