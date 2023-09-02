using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _010923
{
    public class User
    {
        private string name;
        private int age;
        private double monyAvailable;
        private List<Aplication> listAplication;
        public List<Aplication> ListAplication { get{return listAplication;} set{listAplication = value;} }
        public double MonyAvailable { get{return monyAvailable;} set{monyAvailable = value;} }
        public int Age { get{return age;} set{age = value;}}
        public string Name { get{return name;} set{name = value;} }

        public User(List<Aplication> listAplication, string name, int age, double monyAvailable)
        {
            this.Name = name;
            this.Age = age;
            this.MonyAvailable = monyAvailable;
            this.ListAplication = listAplication;
        }
    }
}