using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Rest_String_Analyser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : AnalyseString
    {
        public StringProperties Analyse(string value)
        {
            int digCount = 0;
            int uppCount = 0;
            int lowCount = 0;
            string analyseString = value.ToString();
            for (int i = 0; i < analyseString.Length; i++)
            {
                if (analyseString[i] >= 48 && analyseString[i] <= 57)
                    digCount++;
                else if (analyseString[i] >= 65 && analyseString[i] <= 90)
                    uppCount++;
                else if (analyseString[i] >= 97 && analyseString[i] <= 122)
                    lowCount++;
            }
            StringProperties prop = new StringProperties();
            prop.digit_count = digCount;
            prop.lowercase_count = lowCount;
            prop.uppercase_count = uppCount;
            return prop;


            //return string.Format("digit_count: {0}, uppercase_count: {1}, lowercase_count: {2} ", digCount,uppCount,lowCount);
        }

    }
}
