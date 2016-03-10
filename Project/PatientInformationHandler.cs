//PatientInformationHandler.cs
//Created: 2015-05-27 by Nicolas Kheirallah 

using System.Collections.Generic;
using Project.PatientFiles;

namespace Project
{
    class PatientInformationHandler
    {
        //Variable
        //A List of Patient Checkins
        List<PatientCheckinInformation> m_PatientInformation = new List<PatientCheckinInformation>();
        

        //Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public PatientInformationHandler()
        {
        }

        //Properties
        public int Count
        {
            get
            {
                return m_PatientInformation.Count;
            }
        }


        //Methods

        /// <summary>
        /// adds information and randomizes from the the amount of rooms
        /// </summary>
        /// <param name="PatientInput"></param>
        /// <param name="maxRooms"></param>
        /// <returns></returns>
        /// 
        public bool AddPatientInformation(PatientInformation PatientInput, int Rooms)
        {
            bool information = false;
            PatientCheckinInformation PatientInformationInput = new PatientCheckinInformation(PatientInput);
            if (PatientInput != null) 
            {
                m_PatientInformation.Add(PatientInformationInput);
                PatientInformationInput.RandomRoomNumber(Rooms);
                information = true;
            }

            return information;
        }

        /// <summary>
        /// Change already inputed patient
        /// </summary>
        /// <param name="index"></param>
        /// <param name="PatientInput"></param>
        /// <returns></returns>
        /// 
        public bool changePatientInformation(int index, PatientInformation PatientInput)
        {
            bool changed = false;
            PatientCheckinInformation PatientInformationInput = new PatientCheckinInformation(PatientInput);
            if (PatientInput != null)
            {
                PatientInformationInput.Room = m_PatientInformation[index].Room;
                m_PatientInformation.RemoveAt(index);
                m_PatientInformation.Insert(index, PatientInformationInput);
                changed = true;
            }

            return changed;
        }

        /// <summary>
        /// Deletes Patient
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeletePatient(int index) 
        {
            bool remove = false;
            if (index != -1)
            {
                m_PatientInformation.RemoveAt(index);
                remove = true;
            }

            return remove;  
        }

        /// <summary>
        /// Returns the data from the patient information.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// 
        public PatientCheckinInformation GetPatientInformation(int input)
        {  
            if (input >= 0 && input < m_PatientInformation.Count)
                return m_PatientInformation[input];
            else
            {
                return null;
            }
        }

        /// <summary>
        /// returns all the information from the list into the listbox
        /// </summary>
        /// <returns></returns>
        /// 
        public string[] GetPatientInformation() 
        {
            string[] information = new string[m_PatientInformation.Count];
            for (int index = 0; index < m_PatientInformation.Count; index++)
                information[index] = m_PatientInformation[index].ToString(); 
            return information;
        }
    }
}
