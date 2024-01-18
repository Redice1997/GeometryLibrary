namespace GeometryLibrary.Exceptions
{
    public class LessThanZeroException : ArgumentOutOfRangeException
    {
        public LessThanZeroException(object? actualValue, string parameterName) 
            : base(parameterName, actualValue, "Parameter must be greater than zero")
        {
            
        }
    }
}
