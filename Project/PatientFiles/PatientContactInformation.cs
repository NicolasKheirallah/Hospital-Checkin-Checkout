//PatientContactInformation.cs
//Created: 2015-05-27 by Nicolas Kheirallah 

//Get Phonenumber and email from patient

using System;

namespace Project.PatientFiles
{
    public class PatientContactInformation
    {
      
        //Variable 

        string phonenumber;
        string emailAdress;

        //Contructor
        /// <summary>
        /// Declaration of default Constructors  
        /// Should make another constructor.
        /// </summary>
        /// 
        public PatientContactInformation() 
        {
        }
        //Properties 
        public string PhoneNumber {
            get
            {
                return phonenumber;
            }
            set {
                phonenumber = value;
            }
        }
        public string EmailAdress {
            get
            {
                return emailAdress;
            }
            set
            {
                emailAdress = value;
            }
        }
        
        /// <summary>
        /// Patient Information a string
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {
            string strOut = String.Format("{0}   {1}", phonenumber, emailAdress);
            return strOut;
        }

    }   
}
