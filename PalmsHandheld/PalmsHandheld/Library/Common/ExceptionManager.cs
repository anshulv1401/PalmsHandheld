/*------------------------------------------------------------------------------------------- 
Author                          : Venkatesh Salla
Date                            : 06-12-2007  
Created At                      : Technoforte
Purpose (Template), in Detail   : Log Exceptions to Log File and Event Logger                                                 
Logic Structure                 : 

Modification History                                                                              
Date              Name           Modified At     Revision Summary                                     
----------        ----------     -----------     --------------------------------------------         
28-02-2009      Sujeesh Soman   Technoforte      Modified LoggingException() function
11-04-2009      Venkatesh       Technoforte      Modified LoggingException() function
---------------------------------------------------------------------------------------------*/
using System;
using System.Configuration;
using System.IO;

namespace Technoforte.PALMS.Exceptions
{
	public static class ExceptionManager
	{
		#region Variable Declaration

		static FileStream fileStreamWriter;
		static StreamWriter streamWriter;

		#endregion Variable Declaration

		#region Methods

		/// <summary>
		///     Function to Log Exception to Log file(text file)
		/// </summary>
		/// <param name="obj_Exp">object of Exception Occured</param>
		public static void Log(Exception exp, string customErrorMsg)
		{
			try
			{
                string directorylogPath = ""; // ConfigurationSettings.AppSettings["LogFilePath"] + "\\";
				directorylogPath = directorylogPath + "PALMS Logs\\Error Log";

				if (!Directory.Exists(directorylogPath))
				{
					Directory.CreateDirectory(directorylogPath);
				}

                string filePath = directorylogPath + "\\PALMSErrorLog " + DateTime.Today.ToString("yyyy-MM-dd") + ".xls";
				bool fileExists = File.Exists(filePath);

				fileStreamWriter = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
				streamWriter = new StreamWriter(fileStreamWriter);
				streamWriter.BaseStream.Seek(0, SeekOrigin.End);

				if (!fileExists)
				{
					streamWriter.WriteLine("Date Time:" + "\t" + "ClassName:" + "\t" + "MethodName:" + "\t" + "Error Message:" + "\t" + "Exception Trace:" + "\t");
				}

                string methodName = "";// (exp.TargetSite == null ? "" : exp.TargetSite.ToString());
                string className = ""; //  (exp.Source == null ? "" : exp.Source.ToString());
				string exceptionTrace = exp.ToString();
				string errorMsg = customErrorMsg + ". " + exp.Message.ToString();

				errorMsg = errorMsg.Replace("\r\n", ". ");
				errorMsg = errorMsg.Replace("\r\n", ". ");

				string exceptionTraceResult = exceptionTrace.Replace("\r\n", ". ");
				exceptionTraceResult += exceptionTrace.Replace("\r\n", ". ");

				streamWriter.BaseStream.Seek(0, SeekOrigin.End);
				streamWriter.WriteLine(DateTime.Now.ToString() + "\t" + className + "\t" + methodName + "\t" + errorMsg + "\t" + exceptionTraceResult + "\t");
				streamWriter.Flush();
			}
			catch
			{
                try
                {
                   // System.Diagnostics.EventLog.WriteEntry(exp.Source.ToString(), customErrorMsg + exp.ToString(), System.Diagnostics.EventLogEntryType.Error);
                }
                catch
                {
                    // Cannot write to System Log.
                    // Do nothing
                }
			}
			finally
			{
				if (streamWriter != null)
				{
					try
					{
						streamWriter.Close();
					}
					catch
					{
						//Do nothing
					}
				}

				if (fileStreamWriter != null)
				{
					try
					{
						fileStreamWriter.Close();
					}
					catch
					{
						//Do nothing
					}
				}
			}
		}

		/// <summary>
		///     Displays the exception to user.
		/// </summary>
		/// <param name="obj_Exp">The objexp.</param>
		/// <returns></returns>
		public static string GetDisplayableMessage(Exception exp)
		{
			string message = "";

			if (exp != null)
			{
				message = exp.Message.ToString();
				Exception expInnerException = exp.InnerException;

				while (expInnerException != null)
				{
					if (exp.Message != expInnerException.Message)
					{
						message += "--->" + expInnerException.Message;
						expInnerException = expInnerException.InnerException;
					}
				}

				message = message.Replace("\r\n", "-->");
				message = message.Replace("\r\n", "-->");
				message = message.Replace("\t", "-->");
			}

			message = message.Replace("'", " ");
			message = message.Replace(Environment.NewLine, " ");

			return message;
		}

		#endregion Methods
	}
}
