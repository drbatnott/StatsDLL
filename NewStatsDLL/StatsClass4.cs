using System;
using System.Collections.Generic;

namespace NewStatsDLL
{
    public class StatsClass4
    {
        // A single line comment
        /*
         * This is a multiple line comment
         * in auto documenting comments <> surround XML codes <float></float> 
         * would surround the definition of a float
         */
        /// <summary>
        /// The following are the set of Fields
        /// dataList is a List<float>() of data that will be stored in the class
        /// In statistics we have 3 sort of Average
        /// mean will be the mean of the data in the list - the one that most people think of as average
        /// mode which is the most common value in the list
        /// median which is the middle value in the list
        /// If there were 13 items in a list the median would be the seventh item that will be item 6 
        /// if we start at zero - which is what most arrays etc in programming languages start at
        /// total will be the sum of the elements in the list
        /// </summary>
        List<float> dataList;
        float mean;
        float total;
        float mode;
        float median;
        /// <summary>
        /// StatsClass constructor creates a StatsClass4 empty list
        /// </summary>
        public StatsClass4()
        {
            dataList = new List<float>();
        }

        /// <summary>
        /// Add a piece of Data to the list
        /// </summary>
        /// <param name="f">The value that is added to the list</param>
        /// <returns> 
        ///     0 if the data was OK to add
        ///     1 if the data fails because the list does not exist
        /// </returns>
        public int AddData(float f)
        {
            if (!dataList.Equals(null))
            {
                dataList.Add(f);
                dataList.Sort();
                return 0;
            }
            return 1;
        }

        /// <summary>
        /// Mean is a Parameter
        /// Calculates the mean as the sum of the variables in the list divided by
        /// the length of the list
        /// </summary>
        public float Mean
        {
            get
            {
                total = 0;
                foreach(float f in dataList)
                {
                    total += f;
                }
                mean = total / dataList.Count;
                return mean;
            }
        }

        /// <summary>
        /// By sorting the list the middle vaue should be the median.
        /// Count/2 is the middle of the list if list has an odd length
        /// median is half way between two items if list has even length
        /// </summary>
        public float Median
        {
            get {
                dataList.Sort();
                int m = dataList.Count / 2;
                median = dataList[m];
                if ((dataList.Count % 2) == 0)
                {
                    float aboveAndBelowMedian = median + dataList[m - 1];//median is currently the number above  
                    median = aboveAndBelowMedian / 2;
                }
                return median;
            }
        }
    }
}
