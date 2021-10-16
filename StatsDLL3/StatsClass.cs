using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsDLL3
{
    public class StatsClass
    {
        List<float> myList;
        private float total;
        private float mean;

        public void AddData(float f) 
        {
            myList.Add(f);
            total += f;
        }
        public float Mean
        {
            get
            {
                if(myList.Count > 0)
                {
                    mean = total / myList.Count;
                }
                else
                {
                    total = 0;
                    mean = 0;
                }
                return mean;
            }
        }
        public StatsClass(float v1)
        {
            myList = new List<float>();
            total = v1;
            myList.Add(v1);
        }
    }
}
