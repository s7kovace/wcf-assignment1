using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWcfService
    {

        [OperationContract]
        string CheckIfPrimeNumber(int value);

        [OperationContract]
        int AddDigits(int value);

        [OperationContract]
        string ReverseString(string value);

        [OperationContract]
        string PrintHtmlTag(string tag, string value);

        [OperationContract]
        int[] SortNumbers (int[] numbers, bool ascending);

    }

}
