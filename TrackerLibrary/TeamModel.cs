using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tournament tracker

//Technology:
//  Multi-form WinForms application

//  In-depth Class Library
//  SQL Database
//  Text File Storage

//  Dapper
//  Linq

//  Interfaces
//  Emailing from C#
//  Custom Events
//  Advanced Debugging
//  More...

//Structure: Windows Forms Application and Class Library
//Data: SQL and/or Text File
//Users: One at a time on one application

//Key concepts:
//- Email
//- SQL
//- Custom Events
//- Error Handling
//- Interfaces
//- Random Ordering
//- Texting


namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName  { get; set; }


    }
}
