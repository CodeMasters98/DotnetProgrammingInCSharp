using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PropertyInCSharp
{
    public class Student
    {
        //FirstName
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        //LastName
        public string LastName { get; set; }


        //Score
        public int Score { get; set; }


        //ScoreDescription
        private string _scoreDescription;

        public string ScoreDescription
        {
            get {
                if(Score > 0 && Score <= 50)
                {
                    return "Bad";
                }else if (Score > 51 && Score < 85)
                {
                    return "Good";
                }
                else
                {
                    return "Best";
                }
            }
        }


    }
}
