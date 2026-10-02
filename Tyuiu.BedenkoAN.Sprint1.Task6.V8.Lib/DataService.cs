using System.Security.AccessControl;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BedenkoAN.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)


        {
            string[]  slovavmasiv= value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < slovavmasiv.Length; i++)
            {
                
                slovavmasiv[i] = slovavmasiv[i].Substring(1) + slovavmasiv[i][0];
            }

            return string.Join(" ", slovavmasiv);



        }
    }
}
