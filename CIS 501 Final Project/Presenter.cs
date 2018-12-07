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

        UserInterface ui;

        public Presenter(UserInterface ui)
        {
            this.ui = ui;
        }
        public void LoadLocal(string filename)
        {
            Load load = new Load(filename);
            try
            {
                local = load.Execute();
            }
            catch (FormatException) { ui.ShowUser("Bad Local File"); }
            ui.ShowLocalFilename(filename);

        }

        public void Verify(string filename)
        {
            Load load = new Load(filename);
            ksis = load.Execute();
            try
            {
                if (local != null && ksis != null)
                {
                    Verify verify = new Verify(local, ksis);
                    string vstr = verify.Execute();
                    ui.ShowVerify(vstr, filename);
                }
            }
            catch (FormatException) { ui.ShowUser("Bad KSIS File"); }
        }

        public void Reload(string localFile, string KsisFile)
        {
            if (!localFile.Equals(""))
            {
                LoadLocal(localFile);
                if (!KsisFile.Equals(""))
                {
                    Verify(KsisFile);
                    ui.ShowReload();
                }
            }
        }

        public void Clear()
        {
            new Clear(out local, out ksis);
            ui.ClearUI();
        }

        public void About()
        {
            About about = new About();
            string[] versionData = about.Execute();
            string version = versionData[0];
            string versionDate = versionData[1];
            ui.DisplayVersions(version, versionDate);
        }
    }
}
