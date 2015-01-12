#region Last Revised: 2011-06-08
/****************************************************************************************************
 * Library
 * Author: 				Yang Xin
 * Class description:   Exception interface
 * Creation date:       2011-06-08
 ====================================================================================================
 * Update history:
 * 2011-06-08 1.0         
 *          
 * 
 * 
 *
 ****************************************************************************************************/
#endregion

using System;
using System.Collections;

namespace logEncapsulation
{
    public interface IException
    {
        /// <summary>
        /// 不再抛出异常
        /// </summary>
        void HandleException();

        /// <summary>
        /// 用新的信息替换后抛出异常
        /// </summary>
        void HandleException(string msg);

        /// <summary>
        /// 直接抛出异常
        /// </summary>
        /// <param name="ex"></param>
        void HandleException(Exception ex);

    }
}
