//PatientPersonalInformation.cs
//Created: 2015-05-27 by Nicolas Kheirallah 

///Patient Personal Information
namespace Project.PatientFiles
{
    public class PatientPersonalInformation
    {
        //Variable
        string firstName;
        string lastName;
        string name;
        string id;

        //Constructors
        /// <summary>
        /// Default constructor 
        /// </summary>
        /// 
        public PatientPersonalInformation()
        { 
        }
        //Properties

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Name
        {
            get
            {
                return name = firstName +" " +lastName;
            }
        }

        public string PatientID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }


        /// <summary>
        /// personal Info as a string
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        { 
            string strOut = Name.PadLeft(20, ' ').Substring(0, 20);   
            return strOut;
        }
        
    }  
}
