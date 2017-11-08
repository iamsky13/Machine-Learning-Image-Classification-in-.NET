using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image_classification
{
    public interface IClassifier
    {
        void Train(IEnumerable<Observation> trainingSet);
        string Predict(int[] pixels);
    }
}
