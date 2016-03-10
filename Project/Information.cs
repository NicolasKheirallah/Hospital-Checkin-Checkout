//Information.cs
//Created: 2015-05-27 by Nicolas Kheirallah 

///Here is where we input the information and fill the data 
using System;
using System.Windows.Forms;
using Project.PatientFiles;

namespace Project
{
    public partial class Information : Form
    {
        //Variable 
        PatientInformation currentPatientInformation = new PatientInformation();
        ToolTip info = new ToolTip();
        bool closeForm;


        //Constructor 
        public Information()
        {
            InitializeComponent();
            InitializeGUI();
        }

        //Properties
        public PatientInformation InformationData
        {
            get { return currentPatientInformation; }
            set
            {
                if (value != null)
                {
                    currentPatientInformation = value;
                    UpdateGUI();
                }
            }
        }



        /// <summary>
        /// InitializeGUI
        /// </summary>
        private void InitializeGUI()
        {
            PopulateComboBox();
            closeForm = false;
            cmbRoomCategory.SelectedIndex = 0;
            toolTip1.SetToolTip(textPhoneNumber, "This field only takes in numbers");
            toolTip1.SetToolTip(buttonExit, "Exiting without saving information ");
        }

        /// <summary>
        /// Populates combobox
        /// </summary>
        private void PopulateComboBox()
        {
            cmbRoomCategory.Items.Clear();

            foreach (var category in Enum.GetValues(typeof(MedicalCategory)))
                cmbRoomCategory.Items.Add(category);

        }

        /// <summary>
        /// UpdateGUI
        /// </summary>
        private void UpdateGUI()
        {
            textFirstName.Text = currentPatientInformation.PersonalInfo.FirstName;
            textLastName.Text = currentPatientInformation.PersonalInfo.LastName;
            textId.Text = currentPatientInformation.PersonalInfo.PatientID;

            textPhoneNumber.Text = currentPatientInformation.Contact.PhoneNumber;
            textEmail.Text = currentPatientInformation.Contact.EmailAdress;

            dateTimeCheckIn.Value = currentPatientInformation.Dates.CheckedIn;
            dateTimeCheckOut.Value = currentPatientInformation.Dates.CheckedOut;

            cmbRoomCategory.SelectedIndex = (int)currentPatientInformation.Category;
        }

        private void PatientPersonalInfo()
        {
            currentPatientInformation.PersonalInfo.FirstName = textFirstName.Text;
            currentPatientInformation.PersonalInfo.LastName = textLastName.Text;
            currentPatientInformation.PersonalInfo.PatientID = textId.Text;
        }
        private void PatientContactInfo()
        {
            currentPatientInformation.Contact.PhoneNumber = textPhoneNumber.Text;
            currentPatientInformation.Contact.EmailAdress = textEmail.Text;
        }


        private void PatientInOut()
        {
            currentPatientInformation.Dates.CheckedIn = dateTimeCheckIn.Value;
            currentPatientInformation.Dates.CheckedOut = dateTimeCheckOut.Value;
        }


        private void PatientCategory()
        {
            currentPatientInformation.Category = (MedicalCategory)cmbRoomCategory.SelectedIndex;
        }

        /// <summary>
        /// Unedible when showing information
        /// </summary>
        /// 
        public void Uneditible()
        {
            grbCategory.Enabled = false;
            grbContactInfo.Enabled = false;
            grbDates.Enabled = false;
            grbCustomerInfo.Enabled = false;
            buttonOkey.Enabled = false;
            buttonExit.Text = "Exiting";
        }

        //Event Handlers

        /// <summary>
        /// all the information will be inputed and the form will close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnOK_Click(object sender, EventArgs e)
        {
            PatientPersonalInfo();
            PatientContactInfo();
            PatientInOut();
            PatientCategory();
            if (currentPatientInformation.CheckData() && !currentPatientInformation.CheckDates())
            {
                closeForm = true;
            }
            else MessageBox.Show("Make sure everything is valid");
        }


        /// <summary>
        /// Forces uses too just input numbers in phone
        ///  </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void textPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Select a valid date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dateTime_CheckOut_ValueChanged(object sender, EventArgs e)
        {
            PatientInOut();
            if (currentPatientInformation.CheckDates())
            {
                MessageBox.Show("Check that the dates are correct in Date<Out Date ");
            }
        }

        /// <summary>
        /// If data is correct the form will close else it wont.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void InformationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Closes without saving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            closeForm = true;
            this.Close();
        }
    }
}
