using System.Runtime.Serialization;

namespace SmartDigitalPsico.Domain.Helpers
{
    [Serializable]
    public class AppWarningException : Exception, ISerializable
    {
        public AppWarningException()
        {
        }

        public AppWarningException(string? message) : base(message)
        {
        }

        public AppWarningException(string? message, Exception? innerException) : base(message, innerException)
        {
        } 

        protected AppWarningException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
         
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }
            base.GetObjectData(info, context);
        }
    }
}
