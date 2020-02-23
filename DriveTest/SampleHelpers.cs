using System;
using System.Collections.Generic;
using System.Text;

namespace DriveTest
{
    public static class SampleHelpers
    {

        /// 

        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// 
        /// The request. 
        /// The optional parameters. 
        /// 
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
                if (property.GetValue(optional, null) != null) 
                    // TODO Test that we do not add values for items that are null
                    piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}
