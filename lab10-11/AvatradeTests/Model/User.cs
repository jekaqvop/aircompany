using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.Model
{
    class User
    {
        private string _tradingАccount;
        public string TradingAccount
        {
            get
            {
                return _tradingАccount;
            }
            set
            {
                _tradingАccount = value;
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public User() { }

        public User(string tradingАccount, string password)
        {
            _tradingАccount = tradingАccount;
            Password = password;
        }

        public override string ToString()
        {
            return $"User[_tradingАccount = {_tradingАccount}, password = {Password}]";
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (!(typeof(User).IsInstanceOfType(obj))) return false;
            User user = (User)obj;

            return Equals(_tradingАccount, user._tradingАccount) &&
                Equals(Password, user.Password);
        }

        public override int GetHashCode()
        {
            return _tradingАccount.GetHashCode() + Password.GetHashCode();
        }
    }
}
