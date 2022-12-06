using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Assignment1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public Boolean Adult { get 
            {
                if( (DateTime.Now.Year - DateOfBirth.Year) >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }

        public string ZodiacSign { get 
            {
                var returnVal = "";
                if((DateOfBirth.Month == 3 && DateOfBirth.Day >= 21) || (DateOfBirth.Month == 4 && DateOfBirth.Day <= 19))
                {
                    returnVal = "Aries";
                }
                else if ((DateOfBirth.Month == 4 && DateOfBirth.Day >= 20) || (DateOfBirth.Month == 5 && DateOfBirth.Day <= 20))
                {
                    returnVal = "Taurus";
                }
                else if ((DateOfBirth.Month == 5 && DateOfBirth.Day >= 21) || (DateOfBirth.Month == 6 && DateOfBirth.Day <= 21))
                {
                    returnVal = "Gemini";
                }
                else if ((DateOfBirth.Month == 6 && DateOfBirth.Day >= 22) || (DateOfBirth.Month == 7 && DateOfBirth.Day <= 22))
                {
                    returnVal = "Cancer";
                }
                else if ((DateOfBirth.Month == 7 && DateOfBirth.Day >= 23) || (DateOfBirth.Month == 8 && DateOfBirth.Day <= 22))
                {
                    returnVal = "Leo";
                }
                else if ((DateOfBirth.Month == 8 && DateOfBirth.Day >= 23) || (DateOfBirth.Month == 9 && DateOfBirth.Day <= 22))
                {
                    returnVal = "Virgo";
                }
                else if ((DateOfBirth.Month == 9 && DateOfBirth.Day >= 23) || (DateOfBirth.Month == 10 && DateOfBirth.Day <= 23))
                {
                    returnVal = "Libra";
                }
                else if ((DateOfBirth.Month == 10 && DateOfBirth.Day >= 24) || (DateOfBirth.Month == 11 && DateOfBirth.Day <= 21))
                {
                    returnVal = "Scorpius";
                }
                else if ((DateOfBirth.Month == 11 && DateOfBirth.Day >= 22) || (DateOfBirth.Month == 12 && DateOfBirth.Day <= 22))
                {
                    returnVal = "Sagittarius";
                }
                else if ((DateOfBirth.Month == 12 && DateOfBirth.Day >= 22) || (DateOfBirth.Month == 1 && DateOfBirth.Day <= 19))
                {
                    returnVal = "Capricornus";
                }
                else if ((DateOfBirth.Month == 1 && DateOfBirth.Day >= 20) || (DateOfBirth.Month == 2 && DateOfBirth.Day <= 18))
                {
                    returnVal = "Aquarius";
                }
                else if ((DateOfBirth.Month == 2 && DateOfBirth.Day >= 19) || (DateOfBirth.Month == 3 && DateOfBirth.Day <= 20))
                {
                    returnVal = "Pisces";
                }

                return returnVal;
            }
        }

        public string ChineseZodiac { get 
            {
                var returnVal = "";
                if(DateOfBirth.Year == 1981 || DateOfBirth.Year == 1993 || DateOfBirth.Year == 2005 || DateOfBirth.Year == 2017)
                {
                    returnVal = "Rooster";
                }
                else if (DateOfBirth.Year == 1982 || DateOfBirth.Year == 1994 || DateOfBirth.Year == 2006 || DateOfBirth.Year == 2018)
                {
                    returnVal = "Dog";
                }
                else if (DateOfBirth.Year == 1983 || DateOfBirth.Year == 1995 || DateOfBirth.Year == 2007 || DateOfBirth.Year == 2019)
                {
                    returnVal = "Pig";
                }
                else if (DateOfBirth.Year == 1984 || DateOfBirth.Year == 1996 || DateOfBirth.Year == 2008 || DateOfBirth.Year == 2020)
                {
                    returnVal = "Rat";
                }
                else if (DateOfBirth.Year == 1985 || DateOfBirth.Year == 1997 || DateOfBirth.Year == 2009 || DateOfBirth.Year == 2021)
                {
                    returnVal = "Ox";
                }
                else if (DateOfBirth.Year == 1986 || DateOfBirth.Year == 1998 || DateOfBirth.Year == 2010 || DateOfBirth.Year == 2022)
                {
                    returnVal = "Tiger";
                }
                else if (DateOfBirth.Year == 1987 || DateOfBirth.Year == 1999 || DateOfBirth.Year == 2011 || DateOfBirth.Year == 2023)
                {
                    returnVal = "Rabbit";
                }
                else if (DateOfBirth.Year == 1988 || DateOfBirth.Year == 2000 || DateOfBirth.Year == 2012 || DateOfBirth.Year == 2024)
                {
                    returnVal = "Dragon";
                }
                else if (DateOfBirth.Year == 1989 || DateOfBirth.Year == 2001 || DateOfBirth.Year == 2013 || DateOfBirth.Year == 2025)
                {
                    returnVal = "Snake";
                }
                else if (DateOfBirth.Year == 1990 || DateOfBirth.Year == 2002 || DateOfBirth.Year == 2014 || DateOfBirth.Year == 2026)
                {
                    returnVal = "Horse";
                }
                else if (DateOfBirth.Year == 1991 || DateOfBirth.Year == 2003 || DateOfBirth.Year == 2015 || DateOfBirth.Year == 2027)
                {
                    returnVal = "Goat";
                }
                else if (DateOfBirth.Year == 1992 || DateOfBirth.Year == 2004 || DateOfBirth.Year == 2016 || DateOfBirth.Year == 2028)
                {
                    returnVal = "Monkey";
                }
                return returnVal;
            }
        }

        public Boolean Birthday { get 
            {
                if(DateOfBirth.Month == DateTime.Now.Month && DateOfBirth.Day == DateTime.Now.Day)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }

        public string Username { get 
            {
                return $"{FirstName.Substring(0,1).ToLower()}{LastName.ToLower()}{DateOfBirth.Month}{DateOfBirth.Day}";
            }
            set 
            {
                Username = value;
            } 
        }

        public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            DateOfBirth = dateOfBirth;
        }
    }
}
