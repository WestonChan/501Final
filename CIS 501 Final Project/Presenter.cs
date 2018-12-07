﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CIS_501_Final_Project
{
    class Presenter
    {
        Semester local;
        Semester ksis;
        UserInterface ui;
        public Presenter(UserInterface ui)
        {
            this.ui = ui;
        }
        public void LoadLocal(string filename)
        {
            try {
                new LoadFile(filename, out local);
                ui.ShowLocalFilename(filename);
            }
            catch (Exception) { ui.ShowUser("Bad File"); }
            
        }

        public void Verify(string filename)
        {
            try
            {
                new Verify(filename, out ksis);
                ui.ShowKsisFilename(filename);
            }
            catch(Exception) { ui.ShowUser("Bad File"); }
        }

        public void About()
        {
            new About(out string[] versions);
            string version = versions[0];
            string versionDate = versions[1];
            ui.DisplayVersions(version, versionDate);
        }
    }
}
