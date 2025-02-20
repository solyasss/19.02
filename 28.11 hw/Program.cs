using System;
using System.Windows.Forms;

namespace hw
{
    static class program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            i_model model = new mod();   
            i_view view = new form1();

            presenter presenter = new presenter(view, model);
            presenter.initialize();

            Application.Run((Form)view);
        }
    }
}