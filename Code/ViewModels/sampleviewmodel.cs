using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linde.Feature.BasicContent.ViewModels
{
    public class Sampleviewmodel
    {
        public string TheDate
        {
            get
            {
                return DateTime.Now.ToString();
            }
        }
    }
}