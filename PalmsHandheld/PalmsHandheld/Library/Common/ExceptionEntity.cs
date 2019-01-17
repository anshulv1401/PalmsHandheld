#region Header Comment
/*------------------------------------------------------------------------------------ 
Author                          : Sagar Samag                             
Date                            : 20/05/2010
Created At                      : Technoforte
Purpose (Template), in Detail   : Different Exception Classes for Different Origin
Logic Structure                 : 
Modification History:                                                                  
Date         Modified By      Modified At      Revision Summary                                     
----------   ------------     -----------    ------------------------------------------         
-------------------------------------------------------------------------------------*/
#endregion Header Comment

using System;

namespace Technoforte.PALMS.Exceptions
{
	[Serializable]
	public abstract class PalmsException : Exception
	{
		private Object additionalData = null;

		public PalmsException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		public PalmsException(string message)
			: base(message)
		{
		}

		public PalmsException(string message, Exception innerException, Object additionalData)
			: base(message, innerException)
		{
			this.additionalData = additionalData;
		}

		public PalmsException(string message, Object additionalData)
			: base(message)
		{
			this.additionalData = additionalData;
		}

		public override string ToString()
		{
			string indentation = ">>>>";
			string error = this.GetType().ToString();
			error += ": " + Message;
			Exception inner = this.InnerException;

			while (inner != null)
			{
				error += "\r\n" + indentation + inner.Message;

				indentation += ">>>>";
				inner = inner.InnerException;
			}

			if (additionalData != null)
			{
				error += "\r\n Additional Data:\r\n";
				error += additionalData.ToString();
			}

			return error;
		}
	}

	[Serializable]
	public class DalException : PalmsException
	{
		public DalException(string message)
			: base(message)
		{
		}

		public DalException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		public DalException(string message, Object additionalData)
			: base(message, additionalData)
		{
		}

		public DalException(string message, Exception innerException, Object additionalData)
			: base(message, innerException, additionalData)
		{
		}
	}

    [Serializable]
    public class ComponentException : PalmsException
    {
        public ComponentException(string message)
            : base(message)
        {
        }

        public ComponentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ComponentException(string message, Object additionalData)
            : base(message, additionalData)
        {
        }

        public ComponentException(string message, Exception innerException, Object additionalData)
            : base(message, innerException, additionalData)
        {
        }
    }

    [Serializable]
    public class ServiceException : PalmsException
    {
        public ServiceException(string message)
            : base(message)
        {
        }

        public ServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ServiceException(string message, Object additionalData)
            : base(message, additionalData)
        {
        }

        public ServiceException(string message, Exception innerException, Object additionalData)
            : base(message, innerException, additionalData)
        {
        }
    }
}
