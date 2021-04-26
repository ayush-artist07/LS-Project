using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class ApplicantsInfo
    {
        private int _age;
        private string  _name;
        private double _percentage;
        /// <summary>
        /// Default Constructor to give initial values
        /// </summary>
        public ApplicantsInfo()
        {
            this._age = 0;
            this._name = "";
            this._percentage = 0.0;
        }
        /// <summary>
        /// Parametrized Constructor for new instance of the ApplicantsInfo class with values
        /// </summary>
        /// <param name="age">Student's Present age</param>
        /// <param name="name">Student's Name</param>
        /// <param name="percentage">Student's present Percentage</param>
        public ApplicantsInfo(int age,string name,double percentage)
        {
            this._age = age;
            this._name = name;
            this._percentage = percentage;
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        } 
        public double Percentage
        {
            get
            {
                return _percentage;
            }
            set
            {
                _percentage = value;
            }
        }
    }
}
