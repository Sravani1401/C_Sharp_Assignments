using System;
using System.Collections.Generic;
namespace DataTlayer
{
    public class DataFactory
    {
        public DataAuthentication DataAuthenticationmethod()
        {
            return new DataAuthentication();
        }
       
    }
}
