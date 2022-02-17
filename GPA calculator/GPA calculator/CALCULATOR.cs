using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_calculator
{
    internal class CALCULATOR
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 4;
        private string name = string.Empty; //""  
        private string alldata = string.Empty;

        /// <summary>
        /// Add new GPAx of class
        /// </summary>
        /// <param name="gpa"></param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + " " + gpa + Environment.NewLine ;

            if (this.max < gpa)
            {
                this.max = gpa;
                this.name = name;


            }
            if (this.min > gpa)
            {
                this.min = gpa;
                this.name = name;

            }

        }
        public double getMin()
        {
            return min;
        }
        public string getMinName()
        {
            return name;
        }
        internal void addGPA(double dInput, object name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return GPAx of class
        /// </summary>
        /// <returns>GPAx</returns>
        public double getGPAx()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return name;
        }
        public string getAlldata()
        {
            return alldata;
        }

    }
}
