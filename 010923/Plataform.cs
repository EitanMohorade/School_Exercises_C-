using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _010923
{
    public class Plataform
    {
        private string name;
        private List<Aplication> listAplication;
        private List<User> listUser;
        public List<Aplication> ListAplication { get{return listAplication;} set{listAplication = value;} }
        public string Name { get{return name;} set{name = value;} }
        public List<User> ListUser { get{return listUser;} set{listUser = value;} }

        public Plataform(List<User> listUser, string name, List<Aplication> listAplication)
        {
            this.ListUser = listUser;
            this.Name = name;
            this.ListAplication = listAplication;
            this.listUser = listUser;
        }
    }
}