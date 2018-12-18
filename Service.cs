using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel;
using Newtonsoft.Json;

using System.Collections.Generic;
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{

    public Response GetData(Request rData)
    {

        string json = JsonConvert.SerializeObject(rData);//convert to json string
        var hash = JsonConvert.DeserializeObject<Dictionary<string, string>>(json); //convert json string  to hashmap
       

        Response client = new Response();
       client.data = hash["name"] + " was here ..."; ///concatenates a string verifying the service succesfully executed
     

        return client;
	}

	
}
