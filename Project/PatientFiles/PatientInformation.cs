//PatientInformation.cs
//Created: 2015-05-27 by Nicolas Kheirallah 

///This class manages all the information needed too check in a patient
using System;

namespace Project.PatientFiles
{
    public class PatientInformation
    {

        //Variables
        PatientPersonalInformation personalInfo;
        PatientContactInformation contact;
        PatientDates dates;
        MedicalCategory category;

        //Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// 
        public PatientInformation() 
        {
            Initialize();
        }

        //Properties 
        public PatientPersonalInformation PersonalInfo {
            get
            {
                return personalInfo;
            }
            set {
                personalInfo = value;
            }
        }
        public PatientContactInformation Contact {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
            }
        }
        public PatientDates Dates {
            get
            {
                return dates;
            }
            set
            {
                dates = value;
            }
        }
        public MedicalCategory Category {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }


        /// <summary>
        /// Initialize too create instances of objects .
        /// </summary>
        /// 
        private void Initialize() 
        {
            personalInfo = new PatientPersonalInformation();
            contact = new PatientContactInformation();
            dates = new PatientDates();
        }

        /// <summary>
        /// Checks that all required fields are inputed
        /// </summary>
        /// <returns></returns>
        /// 
        public bool CheckData()
        {
            bool Input = false;

            if (!String.IsNullOrWhiteSpace(personalInfo.FirstName)
                && !String.IsNullOrWhiteSpace(personalInfo.LastName)
                && !String.IsNullOrWhiteSpace(personalInfo.PatientID)
                &&!String.IsNullOrWhiteSpace(contact.PhoneNumber))
                Input = true;

            return Input;
        }

        /// <summary>
        /// Check if user as inputed a valid date.
        /// </summary>
        /// <returns></returns>
        /// 
        public bool CheckDates() 
        {
            bool ValiedDate = false;
            if (Dates.CheckedIn.Date >= Dates.CheckedOut.Date)
                ValiedDate = true;

            return ValiedDate;
        }

        /// <summary>
        /// To string that shows information
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {
            string strOut = String.Format(" {0}   {1} ", personalInfo.ToString(), dates);
            return strOut;
        }

    }

}
