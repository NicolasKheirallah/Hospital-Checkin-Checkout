//MainForm.cs
//Created: 2015-05-27 by Nicolas Kheirallah 

///MainForm
///This class is able too add , delete and edit Patients
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        //Variable
        //Maximum numbers of rooms are 250
        PatientInformationHandler manageInformation= new PatientInformationHandler();
        int rooms = 250;
       
        //Constructor 
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// InitializeGUI
        /// </summary>
        /// 
        private void InitializeGUI() 
        {
            listPatient.Items.Clear();
            labelFreeRooms.Text = rooms.ToString();
        }

        /// <summary>
        ///UpdateGUI
        /// </summary>
        private void UpdateGUI() 
        {

            labelName.Text = string.Empty;
            LabelID.Text = string.Empty;
            labelDays.Text = string.Empty;
            labelCategory.Text = string.Empty;
            listPatient.Items.Clear();
            listPatient.Items.AddRange(manageInformation.GetPatientInformation());
            labelFreeRooms.Text = rooms.ToString();
        }

        /// <summary>
        /// Adds information
        /// </summary>
        /// <param name="index"></param>
        /// 
        private void PopulateForm(int index) 
        {
            labelName.Text = manageInformation.GetPatientInformation(index).patientInformationData.PersonalInfo.Name;
            labelDays.Text = manageInformation.GetPatientInformation(index).patientInformationData.Dates.CalculateDaysInHospital().ToString();
            labelCategory.Text = manageInformation.GetPatientInformation(index).patientInformationData.Category.ToString();
            LabelID.Text = manageInformation.GetPatientInformation(index).patientInformationData.PersonalInfo.PatientID;
        }

        //Event Handlers
        /// <summary>
        /// Creates a new form that make it possible too input patient information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            Information fromInforamtion = new Information(); 
            if (fromInforamtion.ShowDialog() == DialogResult.OK)
            {
                manageInformation.AddPatientInformation(fromInforamtion.InformationData, rooms);
                rooms--;
                UpdateGUI();
            }
        }

        /// <summary>
        /// Comfirm exiting the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You want too exiting program","Exit Application " , MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) 
            {                
                Application.Exit();
            }

        }

        /// <summary>
        /// Deletes selected patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Delete_Click(object sender, EventArgs e)
        {
            if (manageInformation.DeletePatient(listPatient.SelectedIndex))
            {
                rooms++;
                UpdateGUI();
            }
            else
                MessageBox.Show("Select a patient too delete");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }
        public static bool CloseCancel()
        {
            var result = MessageBox.Show("You want too exiting program", "Exit Application ",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Shows Patient information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void buttonShowInfo_Click(object sender, EventArgs e)
        {            
            Information formInformation = new Information();

            int index = listPatient.SelectedIndex;

            if (index != -1)        
            {
                formInformation.InformationData = manageInformation.GetPatientInformation(index).patientInformationData;
                formInformation.Uneditible();              
                formInformation.Show();
            }

            else MessageBox.Show("Select an Patient too show information");            
        }

        /// <summary>
        /// Edit patient information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Information changeInformation = new Information();
            int index = listPatient.SelectedIndex;
            if (index != -1)
            {
                changeInformation.InformationData = manageInformation.GetPatientInformation(index).patientInformationData;

                if (changeInformation.ShowDialog() == DialogResult.OK)
                {
                    manageInformation.changePatientInformation(index, changeInformation.InformationData);
                    UpdateGUI();
                }
            }

            else MessageBox.Show("Select an Patient to Edit");   
        }

        /// <summary>
        /// Populate the field with the correct data when Listbox item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void lastSavedInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listPatient.SelectedIndex;
            if (index != -1)
            {
                PopulateForm(index);
            }
        }

    }
}
