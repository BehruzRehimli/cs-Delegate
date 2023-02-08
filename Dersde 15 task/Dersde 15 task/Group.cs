using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_15_task
{
    internal class Group
    {
        public string GroupNo;
        public List<Student> Students=new List<Student>() ;
        public List<Student> telebe( Func<double,bool> method)
        {
            List<Student> newlist=new List<Student>() ;
            foreach (var item in Students)
            {
                if (method(item.No))
                {
                    newlist.Add(item) ;
                }
            }
            return newlist ;
        }
    }
}
