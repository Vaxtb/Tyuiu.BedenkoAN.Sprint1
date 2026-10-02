using System.Security.AccessControl;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BedenkoAN.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            char w = value[0];
            string r = value.Substring(1);
            return r + w;

            
        }
    }
}
