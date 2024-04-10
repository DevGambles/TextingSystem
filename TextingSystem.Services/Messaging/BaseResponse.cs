using System.Collections.Generic;

namespace TextingSystem.Services.Messaging
{
    [System.Serializable]
    public class BaseResponse
    {
        public BaseResponse()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; internal set; }
        public bool Success
        {
            get
            {
                return Errors.Count == 0;
            }
        }
    }
}
