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
        ArrayList opera = new ArrayList();
        Presenter thePresenter;
        private Presenter()
        {
        }
        public Presenter instance()
        {
            if (thePresenter == null)
                thePresenter = new Presenter();
            return thePresenter;
        }
        public void executeLoad(string filename)
        {
            Load_File f = new Load_File(filename);
            opera.Add(f);
        }
        public void finishLoad(Load_File f)
        {
            opera.Remove(f);
            //do View things
        }

    }
}
