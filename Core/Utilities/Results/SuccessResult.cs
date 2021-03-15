/*Created By Engin Yenice
enginyenice2626@gmail.com*/

namespace Core.Utilities.Results
{
    public class SuccessResult : Result, IResult
    {
        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}