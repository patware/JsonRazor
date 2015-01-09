using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonRazor.Model
{
    public class DataItem
    {
        public DataItem(string model, string template)
        {
            Model = model;
            Template = template;
        }

        public string Model
        {
            get;
            private set;
        }

        public string Template
        {
            get;
            private set;
        }
    }
}
