using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace OOP_Lab02_3
{
    public class UDKValidationAttribute : ValidationAttribute
    {
        Regex udk = new Regex(@"УДК [1-9]{3}.[0-9]{3}.[0-9]{2}");

        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string UDK = value.ToString();
                if (udk.IsMatch(UDK))
                    return true;
                else
                    return false;

            }
            else
                return false;
        }
    }
}
