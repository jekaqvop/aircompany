using AvatradeTests.Model;
using AvatradeTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.Service
{
    class CreatorUser
    {
        public static User WithCredentialsFromProperty()
        {
            return TestDataParametr<User>.GetParametrs();
        }

        public static User JoiningNewAccountFromProperty()
        {
            return TestDataParametr<User>.GetParametrs("../../../Resources/JoiningNewAccount.json");
        }

        public static User JoiningMyAccountFromProperty()
        {
            return TestDataParametr<User>.GetParametrs("../../../Resources/JoiningMyAccount.json");
        }
    }
}
