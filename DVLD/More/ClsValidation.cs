using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD.More
{
    internal class ClsValidation
    {
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }

        public static bool IsNumber(char c)
        {
            if(!char.IsNumber(c))
                return false;

            return true;
        }

        public static bool IsControl(char c)
        {
            if (!char.IsControl(c))
                return false;

            return true;
        }

        public static bool IsNumberOrControl(char c)
        {
            if (!char.IsControl(c) && !char.IsNumber(c))
            
                return false;
            
            return true;
        }
        public static bool IsLetterOrControl(char c)
        {
            if (!char.IsLetter(c) && !char.IsControl(c))
            
                return false;
            
            return true;
        }

        public static bool IsLetterOrControlOrSpace(char c)
        {
            if (!char.IsLetter(c) && !char.IsControl(c) && !char.IsWhiteSpace(c))

                return false;

            return true;
        }

        public static bool IsLetterOrControlOrNumber(char c)
        {
            if (!char.IsLetter(c) && !char.IsControl(c) && !char.IsNumber(c))
                return false;

            return true;
        }

        public static bool IsWhiteSpace(char c)
        {
            if(char.IsWhiteSpace(c))
            
                return true;
            
            return false;
        }

        public static bool IsCharInFirstIndexAndNotExistsInTheSentence(char AddedChar ,char CharCanAdd, string TheSentence , int SelectionStartOfTxtBox )
        {
            if ((AddedChar.Equals(CharCanAdd) && SelectionStartOfTxtBox == 0 && !TheSentence.Contains(CharCanAdd))) return true ;
            return false;
        }

        public static bool IsAtOrDotAndNotExistsInTheSentence(char c, string s)
        {
            if (((c == '@' && !s.Contains("@")) || (c == '.' && !s.Contains("."))))

                return true;

            return false;
        }

        public static bool Email_PressKeyValidation(char c , string s)
        {
            bool y = false;
            if (IsLetterOrControlOrNumber(c) && !IsWhiteSpace(c))   
            {
                y = true;
            }
            if (IsAtOrDotAndNotExistsInTheSentence(c, s))
            {
                y = true;
            }
            return y;
            
        }

        public static bool Phone_PressKeyValidation(char c , string s , int SelectionStartOfTxtBox)
        {
            bool y = false;
            if(IsNumberOrControl(c))
            {
                y = true;
            }
            if(IsCharInFirstIndexAndNotExistsInTheSentence(c, '+', s, SelectionStartOfTxtBox))
            {
                y = true;
            }
            return y;
            
        }

    }
}
