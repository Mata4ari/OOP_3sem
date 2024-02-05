using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal partial class Abiturient
    {
        readonly int id;
        string name;
        string surname;
        string lastname;
        string adress;
        string telnumber;
        int[] grades = null;
        static int count;
        const int postIndex = 333555;

        static Abiturient()
        {
            count = 0;
        }

        private Abiturient(int id)
        {
            this.id = id;
        }

        public Abiturient()
        {
            ++count;
            this.id = 11111 + count;
            this.name = "userName";
            this.surname = "userSurname";
            this.lastname = "userLastname";
            this.adress = "userAdress";
            this.telnumber = "userTelnumber";
        }

        public Abiturient(string name, string surname, string lastname, int[] grades, string adress = "no info", string telnumber = "no info")
        {
            ++count;
            this.id = 11111 + count;
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
            this.adress = adress;
            this.telnumber = telnumber;
            this.grades = grades;
        }

        public Abiturient(string name, string surname, string lastname, string adress = "no info", string telnumber = "no info")
        {
            ++count;
            this.id = 11111 + count;
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
            this.adress = adress;
            this.telnumber = telnumber;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname
        {
            get => surname;
            set => surname = value;
        }
        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }
        public string Adress
        {
            get => adress;
            set => adress = value;
        }
        public string Telnumber
        {
            get => telnumber;
            set => telnumber = value;
        }
        public int[] Grades
        {
            get => grades;
            set => grades = value;
        }
        public int Id
        { get; }
        public int Postindex
        { get; }
    }
}
