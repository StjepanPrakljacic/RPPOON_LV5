using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RPPOON_LV5
{
    class LoggingProxy
    {
        private string filePath;
        private Dataset dataset;

        List<string> DataMessages;
            public LoggingProxy(string filePath)
            {
            this.DataMessages = new List<string>();
            this.filePath = filePath;
            }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }

            DataMessages.Add("Data access requested : " + DateTime.Now.ToString());

            return dataset.GetData();
        }

    }
}
