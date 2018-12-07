using System;
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

        Load load;
        Verify verify;
        Reload reload;
        Clear clear;
        About about;

        string verifystr;
        UserInterface ui;

        public Presenter(UserInterface ui)
        {
            this.ui = ui;
        }
        public void LoadLocal(string filename)
        {
            try {
                load = new Load();
                local = load.Execute(filename);
                ui.ShowLocalFilename(filename);
            }
            catch (Exception) { ui.ShowUser("Bad Local File"); }
            
        }

        public void Verify(string filename)
        {
            try
            {
                verify = new Verify(local, ksis);
                string vstr = verify.Execute();
                if (local != null && ksis != null)
                {
                    ui.ShowKsisFilename(filename);
                    ui.ShowVerify(vstr);
                }
            }
            catch(Exception) { ui.ShowUser("Bad KSIS File"); }
        }

        public void Reload(string localFile, string KsisFile)
        {
            LoadLocal(localFile);
            Verify(KsisFile);
            ui.ShowReload();
        }

        public void Clear()
        {
            new Clear(out local, out ksis);
            ui.ClearUI();
        }

        public void About()
        {
            about = new About();
            string[] versions = about.Execute();
            string version = versions[0];
            string versionDate = versions[1];
            ui.DisplayVersions(version, versionDate);
        }
    }
}
