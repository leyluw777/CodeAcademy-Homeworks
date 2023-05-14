//using HttpClientExtensionMethods;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace VCard.Models
//{
//    class Result 
//    {
//        public string Gender { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//        public string Cell { get; set; }
//        public string Nat { get; set; }
//        public Name Name { get; set; }
//        public Dob Dob { get; set; }
//    }


//    class Name
//    {
//        private string _title;
//        private string _first;
//        private string _last;

//        public string Title {
//            get => _title;
//            set
//            {
//                _title = value;
//            }
//        }
//        public string First {
//            get => _first;
//            set
//            {
//                _first = value;
//            }
//        }
//        public string Last {  get => _last; set
//            {
//                _last = value;
//            }
//        }

//        public string FullName => $"{_first} {_last}";
//    }

//    class Info
//    {
//        public string Seed { get; set; }
//        public int Results { get; set; }
//        public int Page { get; set; }
//        public string Version { get; set; }
//    }


//}


namespace VCard.Models
{
    public class Result
    {
        public string Gender { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public Login Login { get; set; }
        public Dob Dob { get; set; }
        public Registered Registered { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public Id Id { get; set; }
        public Picture Picture { get; set; }
        public string Nat { get; set; }
        
    }

    public class Name
    {
        private string _title;
        private string _first;
        private string _last;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
            }
        }
        public string First
        {
            get => _first;
            set
            {
                _first = value;
            }
        }
        public string Last
        {
            get => _last; set
            {
                _last = value;
            }
        }

        public string FullName => $"{_first} {_last}";
    }

    public class Location
    {
        public Street Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Postcode { get; set; }
        public Coordinates Coordinates { get; set; }
        public Timezone Timezone { get; set; }
    }

    public class Street
    {
        public int _number;
        public string _name;
        public int Number { get => _number; set
            {
                _number = value;
            }
                
                }
        public string Name { get => _name; set
            {
                _name = value;
            }
        }

        public string StreetName => $"{_name} {_number}";
    }

    public class Coordinates
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class Timezone
    {
        public string Offset { get; set; }
        public string Description { get; set; }
    }

    public class Login
    {
        public string Uuid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
    }

    public class Dob
    {
        public DateTime Date { get; set; }
        public int Age { get; set; }
    }

    public class Registered
    {
        public DateTime Date { get; set; }
        public int Age { get; set; }
    }

    public class Id
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Picture
    {
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }

    public class Info
    {
        public string Seed { get; set; }
        public int Results { get; set; }
        public int Page { get; set; }
        public string Version { get; set; }
    }
}