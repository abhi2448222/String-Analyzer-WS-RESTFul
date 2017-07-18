using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Rest_String_Analyser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface AnalyseString
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Analyse?value={value}")]
        StringProperties Analyse(string value);

      

        // TODO: Add your service operations here
    }
    [DataContract]
    public class StringProperties
    {
        [DataMember]
        public int digit_count { get; set; }
        [DataMember]
        public int uppercase_count { get; set; }
        [DataMember]
        public int lowercase_count { get; set; }
    }


}
