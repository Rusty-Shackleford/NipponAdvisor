using System;

namespace NipponAdvisor.DarkUIExt
{
    #region [ StatusType ]
    public enum StatusType
    {
        Error,
        Ready,
        Info,
        Clear
    }
    #endregion


    #region [ StatusMessageArgs ]
    public class StatusMessageArgs : EventArgs
    {
        #region [ Members ]
        public string Message { get; set; }
        public StatusType Type { get; set; }
        #endregion


        #region [ Constructor ]
        public StatusMessageArgs(StatusType type) : this("", type) { }

        public StatusMessageArgs(string message)
            : this(message, StatusType.Info) { }

        public StatusMessageArgs(string message, StatusType type)
        {  
            Message = message;
            Type = type;
        }

        
        #endregion
    }
    #endregion

}
