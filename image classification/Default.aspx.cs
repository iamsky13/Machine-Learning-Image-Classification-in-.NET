using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace image_classification
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadProgram();
        }

        public void LoadProgram()
        {
           var trainingPath = @"PATH-ON-YOUR-MACHINE\trainingsample.csv";
                var training = DataReader.ReadObservations(trainingPath);
               // Console.ReadLine();
           
        }
    }
}