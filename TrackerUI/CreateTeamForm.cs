﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            // CreateSampleData();
            WireUpList();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Krz", LastName = "Kam" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Jan", LastName = "Kowalski" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Ewa", LastName = "Nowak" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Smith" });
        }

        private void WireUpList()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

        }

        private bool ValidateForm()
        {

            if (firstNameValue.Text.Length == 0) return false;
            if (lastNameValue.Text.Length == 0) return false;
            if (emailValue.Text.Length == 0) return false;
            if (cellPhoneValue.Text.Length ==0) return false;
            return true;
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAdress = emailValue.Text;
                p.CellPhoneNumber = cellPhoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);


            WireUpList();
            //selectTeamMemberDropDown.Refresh();

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {

        }
    }
}
