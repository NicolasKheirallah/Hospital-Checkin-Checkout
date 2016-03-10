//PatientDates.cs
//Created: 2015-05-27 by Nicolas Kheirallah 

/// Used for checking in and checking out patients
using System;

namespace Project.PatientFiles

{
    public class PatientDates
    {
        //Variable

        DateTime checkedIn = DateTime.Now.Date;
        DateTime checkedOut = DateTime.Now.Date;
        

        //Constructors
        /// <summary>
        /// Default Construtor
        /// </summary>
        /// 
        public PatientDates() 
        {
        }
        
        //Properties
                
        public DateTime CheckedIn {
            get
            {
                return checkedIn;
            }
            set
            {
                checkedIn = value;
            }
        }
        public DateTime CheckedOut {
            get
            {
                return checkedOut;
            }
            set
            {
                checkedOut = value;
            }
        }


        /// <summary>
        /// Gives us how many days the patient is in the hospital
        /// </summary>
        /// <returns></returns>
        /// 
        public double CalculateDaysInHospital() 
        {
            int amountOfDays = (checkedOut - checkedIn).Days;
            if (checkedIn.Date.Day == DateTime.Now.Day)
                return amountOfDays + 1;
            else
            {
                return amountOfDays;
            }
        }

        /// <summary>
        /// returns dates as a string
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {   
            string strOut = String.Format(" {0}     {1}", checkedIn.ToShortDateString(), checkedOut.ToShortDateString());
            return strOut;
        }
        
    }
}
