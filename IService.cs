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

 [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare,  RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
   
	[OperationContract]
	Response GetData(Request rData);

	
	// TODO: Add your service operations here
}

[System.Runtime.Serialization.DataContractAttribute()]
public class Request
{
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string name { get; set; }
   
}

[System.Runtime.Serialization.DataContractAttribute()]
public class Response
{
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string data { get; set; }

}
// Use a data contract as illustrated in the sample below to add composite types to service operations.
/*[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
*/


