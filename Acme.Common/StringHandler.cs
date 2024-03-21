﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    // Insert spaces before each capital letter in a string
    public static class StringHandler
    {
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if(!string.IsNullOrWhiteSpace(source)) 
            { 
                foreach(char letter in source) 
                {
                    if (char.IsUpper(letter))
                    {
                        // Trim any spaces already there
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
