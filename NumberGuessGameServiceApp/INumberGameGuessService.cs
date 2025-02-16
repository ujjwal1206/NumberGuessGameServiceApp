using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NumberGuessGameServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //This is the partial implementation of two function using an interface where we only define the function namely SecretNumber and CheckNumber

    [ServiceContract]
    public interface INumberGameGuessService
    {
        // Defining of SecretNumber and CheckNumber
        [OperationContract]
        int SecretNumber(int lower, int upper);

        [OperationContract]
        string CheckNumber(int userNum, int secretNum);
    }


    
}
