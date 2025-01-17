﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections
            //TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);
            //Application.Run(new CreatePrizeForm());
            //Application.Run(new CreateTeamForm());
            //Application.Run(new CreateTournamentForm());
            Application.Run(new TournamentDashboardForm());
        }
    }
}
