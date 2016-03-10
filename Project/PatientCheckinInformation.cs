//PatientCheckinInformation.cs
//Created: 2015-05-27 by Nicolas Kheirallah 

///PatientCheckinInformation class which handles all the data
using System;

using Project.PatientFiles;

namespace Project
{
    public class PatientCheckinInformation
    {

        //Variable 
        PatientInformation patientInformationnData = new PatientInformation();
        Random FreeRoom = new Random(); // Randomizes which room
        string room;

        //Constructors
        /// <summary>
        /// Declaration of Constructor        
        /// </summary>
        /// 
        public PatientCheckinInformation(PatientInformation patientInformationData)
        {
            this.patientInformationnData = patientInformationData;
        }

        //Properties

        public PatientInformation patientInformationData
        {
            get {
                return
                    patientInformationnData;
            }
            set
            {
                patientInformationnData = value;
            }
        }

        public string Room
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
            }
        }


        /// <summary>
        /// Randomizes from a certain number of 0-> numberOfRooms
        /// </summary>
        /// <param name="numberOfRooms"></param>
        /// 
        public void RandomRoomNumber(int numberOfRooms) 
        {
            room = FreeRoom.Next(0, numberOfRooms).ToString();          
        }

        /// <summary>
        /// To string which shows information 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = room + " \t" + patientInformationnData.ToString();
            return strOut;
        }

    }
}
