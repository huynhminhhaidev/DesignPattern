using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ManagerWater
{
    //Áp strategy pattern
    //Class strategy
    public interface ValidationStrategy
    {
        bool validate();
    }

    //Class ConceteStrategy
    class PhoneValidation: ValidationStrategy
    {
        private string phone;
        private Regex regex = new Regex(@"^0\d{9,10}$");

        public PhoneValidation(string phone)
        {
            this.phone = phone;
        }

        public bool validate()
        {
            return regex.IsMatch(phone);
        }
    }

    //Class ConceteStrategy
    class FullnameValidation : ValidationStrategy
    {
        private string fullname;
        private Regex regex = new Regex(@"^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$");

        public FullnameValidation(string fullname)
        {
            this.fullname = fullname;
        }

        public bool validate()
        {
            return regex.IsMatch(fullname);
        }
    }

    //Class ConceteStrategy
    class KindOfCustomerValidation : ValidationStrategy
    {
        private string kind;
        private string[] listKinds = { "Ho gia dinh", "Doanh nghiep", "Ho ngheo" };

        public KindOfCustomerValidation(string kind)
        {
            this.kind = kind;
        }

        public bool validate()
        {
            int index = Array.IndexOf(listKinds, kind);

            if (index > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //Class ConceteStrategy
    class PasswordValidation : ValidationStrategy
    {
        private string pw;

        public PasswordValidation(string pw)
        {
            this.pw = pw;
        }

        public bool validate()
        {
            if(pw.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    //Class ConceteStrategy
    class KindOfUnitValidation : ValidationStrategy
    {
        private string kind;

        private string[] listKinds = { "Vnd", "Dollar" };

        public KindOfUnitValidation(string kind)
        {
            this.kind = kind;
        }
        public bool validate()
        {
            int index = Array.IndexOf(listKinds, kind);

            if (index > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //Class strategy context
    class ValidationContext
    {
        public bool valid(ValidationStrategy validationStrategy)
        {
            return validationStrategy.validate();
        }
    }
}
