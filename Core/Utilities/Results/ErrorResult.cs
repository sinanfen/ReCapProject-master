/*Created By Engin Yenice
enginyenice2626@gmail.com*/

namespace Core.Utilities.Results
{
    public class ErrorResult : Result, IResult
    {
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}