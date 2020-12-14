using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        //When setup this way, C# refers to these as "auto variables"
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        //Example getter/setter with some validation and using C# *backing variables*
        private string _twitterAddress;  //this is a "backing variable" stores the value, and the property ("TwitterAddress") exposes that value
        public string TwitterAddress
        {
            //makes sure the Twitter address starts with '@'
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        //Visual Studio Constructor quick command = "ctor" then tab three times
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "4795555555";
        }

        public School(string SchoolName, string SchoolPhoneNumer)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumer;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        //Function-bodied expression
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        //Overloading works the same as in Java
        public static int AverageThreeScores(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);

            return sb.ToString();

        }




    }
}
