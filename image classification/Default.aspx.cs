using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //Console.WriteLine("test");
            //Debug.Write("test");
            

        }

      

        public void validate_click(object sender, EventArgs e)
        {
            
            var distance = new ManhattanDistance();
            var classifier = new BasicClassifier(distance);
            var trainingPath = @Server.MapPath(".") + "/trainingsamples.csv";
            var training = DataReader.ReadObservations(trainingPath);
            classifier.Train(training);
            var validationPath = @Server.MapPath(".") + "/validationsample.csv";
            var validation = DataReader.ReadObservations(validationPath);
            var correct = Evaluator.Correct(validation, classifier);

            //Console.WriteLine("Correctly classified: {0:P2}",  correct);
            //Console.ReadLine();
            Debug.Write("Ok");
            Debug.Write("Correctly classified: {0:P2}", correct.ToString());
            
        }
     }
}
    
