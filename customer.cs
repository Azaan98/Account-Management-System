using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class customer
    {
        private string fname, mname, lname, address, gender,marriagestat, dob,
            country, city, nationality, rescon, nice, occupation, imgurl;

        public string Imgurl
        {
            get { return imgurl; }
            set { imgurl = value; }
        }

        public string Marriagestat
        {
            get { return marriagestat; }
            set { marriagestat = value; }
        }

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public string Nice
        {
            get { return nice; }
            set { nice = value; }
        }

        public string Rescon
        {
            get { return rescon; }
            set { rescon = value; }
        }

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Mname
        {
            get { return mname; }
            set { mname = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        private string nic;

        
        public string Nic
        {
            get { return nic; }
            set { nic = value; }
        }

        double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public customer()
        {

        }


    }
}
