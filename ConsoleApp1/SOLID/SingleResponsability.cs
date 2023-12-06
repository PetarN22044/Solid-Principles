﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressName { get; set; }
        public string City { get; set; }
        public int AddressNumber { get; set; }
        public Person BestFriend { get; set; }
        public List<Person> Friends { get; set; }
        public List<Person> Siblings { get; set; }

        public string PrintPerson()
        {
            return $"{FirstName} {LastName} {Age}";
        }
        public bool ValidateAddressNumber(int addressNumber)
        {
            if (addressNumber < 0) return false;
            if (addressNumber > 999) return false;
            return true;
        }
        public string PrintAddress()
        {
            return $"{AddressName} No.{AddressNumber} - {City}";
        }
        public bool HasRelations()
        {
            int friends = Friends.Count + Siblings.Count;
            if (friends == 0 && BestFriend == null) return false;
            return true;
        }
        public bool IsBestFriendSibling()
        {
            return Siblings.Exists(x => x == BestFriend);
        }
        public void PrintFriends()
        {
            foreach (Person friend in Friends)
            {
                Console.WriteLine($"{friend.FirstName} {friend.LastName}");
            }
        }

    }
    public class PersonGood
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Adress Address { get; set; }
        public Relatives Relatives { get; set; }
        public string PrintPerson()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
    public class Adress
    {
        public string AddressName { get; set; }
        public string City { get; set; }
        public int AddressNumber { get; set; }
        public bool ValidateAddressNumber(int addressNumber)
        {
            if (addressNumber < 0) return false;
            if (addressNumber > 999) return false;
            return true;
        }
        public string PrintAddress()
        {
            return $"{AddressName} No.{AddressNumber} - {City}";
        }
    }

    public class Relatives
    {
        public Person BestFriend { get; set; }
        public List<Person> Friends { get; set; }
        public List<Person> Siblings { get; set; }

        public bool HasRelations()
        {
            int friends = Friends.Count + Siblings.Count;
            if (friends == 0 && BestFriend == null) return false;
            return true;
        }
        public bool IsBestFriendSibling()
        {
            return Siblings.Exists(x => x == BestFriend);
        }
        public void PrintFriends()
        {
            foreach (Person friend in Friends)
            {
                Console.WriteLine($"{friend.FirstName} {friend.LastName}");
            }
        }

    }
}