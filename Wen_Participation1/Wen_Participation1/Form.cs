using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen_Participation1
{
    class Form
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public double one { get; set; }
        public double two { get; set; }


        public Form()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
            one = 0;
            two = 0;
        }

        public Form(string name, string address, int zipcode)
        {
            Name = name;
            Address = address;
            ZipCode = zipcode;
        }

        public override string ToString()
        {
            //string result = $"Hello {Name}, your address is {Address}, and zipcode is {ZipCode}{one} {two} //{qwe()}";
            string result = $"Hello {Name}, your address is {Address}, and zipcode is {ZipCode}";
            //result = $"{two}";
            return result;
            string concat = "this" + Name + " is how you " + Address + " ";
        }

        //public double qwe()
        //{
        //    return one + two;
        //}
    }
}
