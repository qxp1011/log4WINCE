using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Web;
//using System.Web.Caching;
using System.Configuration;
using System.Collections;

namespace logEncapsulation
{


    public class ExceptionDefault : IException
    {

        public void HandleException()
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        public void HandleException(string msg)
        {
            throw new Exception(msg);
        }

        public void HandleException(Exception ex)
        {
            //throw new Exception("The method or operation is not implemented.");
            throw ex;
        }

    }
}
