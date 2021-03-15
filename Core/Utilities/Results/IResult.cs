/*Created By Engin Yenice
enginyenice2626@gmail.com*/

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}