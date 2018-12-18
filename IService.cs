using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
//attributes for enabling Json requests and responses
 [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare,  RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
   
	[OperationContract]
	Response GetData(Request rData);

	
	// TODO: Add your service operations here
}

//data contract for responses and requests
//define arguments here
[System.Runtime.Serialization.DataContractAttribute()]
public class Request
{
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string name { get; set; }
   
}
//define output here
[System.Runtime.Serialization.DataContractAttribute()]
public class Response
{
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string data { get; set; }

}



