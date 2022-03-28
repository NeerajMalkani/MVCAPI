using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using TrepupAPI.Models;

namespace TrepupAPI.Validations
{
    public static class CustomValidation
    {
        public static bool ValidatePropertyValue(object obj, string[] attributes)
        {
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                if (attributes.Contains(prop.Name))
                {
                    if (prop.PropertyType == typeof(string))
                    {
                        if (string.IsNullOrEmpty(Convert.ToString(prop.GetValue(obj))))
                        {
                            return false;
                        }
                    }
                    else if (prop.PropertyType == typeof(int))
                    {
                        if (Convert.ToInt32(prop.GetValue(obj)) == 0)
                            return false;
                    }
                    else if (prop.PropertyType == typeof(long))
                    {
                        if (Convert.ToInt64(prop.GetValue(obj)) == 0)
                            return false;
                    }
                    else if (prop.PropertyType == typeof(double) || prop.PropertyType == typeof(float))
                    {
                        if (Convert.ToDouble(prop.GetValue(obj)) == 0)
                            return false;
                    }
                    else if (prop.PropertyType == typeof(List<string>))
                    {
                        if (!(prop.GetValue(obj) is List<string> attObj)) return false;
                        if (attObj.Count == 0) return false;
                    }
                }
            }
            return true;
        }

        public static List<AttrErrorMessage> ValidateName(object obj)
        {
            string[] arrAttrCheck = new string[] { "firstname", "middlename", "lastname" };
            List<AttrErrorMessage> lstError = ValidateName(obj, arrAttrCheck);

            if (lstError == null) { lstError = new List<AttrErrorMessage>(); }

            if (lstError.Count.Equals(0))
            {
                string firstName = "", middleName = "", lastName = "";
                Type t = obj.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (var prop in props)
                {
                    switch (prop.Name.ToLower())
                    {
                        case "firstname":
                            firstName = Convert.ToString(prop.GetValue(obj));
                            break;
                        case "middlename":
                            middleName = Convert.ToString(prop.GetValue(obj));
                            break;
                        case "lastname":
                            lastName = Convert.ToString(prop.GetValue(obj));
                            break;
                    }
                }

                string fullString = (!string.IsNullOrEmpty(middleName) ? (firstName + middleName + lastName) : (firstName + lastName)).Replace(" ", "");

                bool isFullStringValid = true;

                if (Common.IsTrademark(fullString))
                {
                    isFullStringValid = false;
                }
                else if (fullString.ToLower().Equals("official"))
                {
                    isFullStringValid = false;
                }
                else if (Common.ValidateRestrictedNames(fullString))
                {
                    isFullStringValid = false;
                }

                if (!isFullStringValid)
                {
                    if (!string.IsNullOrEmpty(firstName)) { lstError.Add(new AttrErrorMessage { Attribute = arrAttrCheck[0], Message = "", }); }//Codes.dict[1049].Item2

                    if (!string.IsNullOrEmpty(middleName)) { lstError.Add(new AttrErrorMessage { Attribute = arrAttrCheck[1], Message = "", }); }//Codes.dict[1049].Item2

                    if (!string.IsNullOrEmpty(lastName)) { lstError.Add(new AttrErrorMessage { Attribute = arrAttrCheck[2], Message = Codes.dict[1049].Item2, }); }
                }
            }

            return lstError;
        }

        public static List<AttrErrorMessage> ValidateName(object obj, string[] attributes)
        {
            List<AttrErrorMessage> lstErrorMessage = new List<AttrErrorMessage>();
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                if (attributes.Contains(prop.Name))
                {
                    if (prop.PropertyType == typeof(string))
                    {
                        string inputString = Convert.ToString(prop.GetValue(obj));
                        string errorText = "";

                        if (!string.IsNullOrEmpty(inputString))
                        {
                            if (prop.Name.ToLower().Equals("lastname"))
                            {
                                if (Common.IsBeginingEndChar(inputString, new char[] { '\'', '´', '‘', '’' }))//Your name cannot start or end with an apostrophe (')
                                {
                                    errorText = Codes.dict[1064].Item2;
                                }
                                else if (Common.IsBeginingChar(inputString, new char[] { '.' }))//Your name cannot start with a period (.)
                                {
                                    errorText = Codes.dict[1065].Item2;
                                }
                            }
                            else
                            {
                                if (Common.IsBeginingEndChar(inputString, new char[] { '.', '\'', '´', '‘', '’' }))//Your name cannot start or end with a period (.) or apostrophe (')
                                {
                                    errorText = Codes.dict[1045].Item2;
                                }
                            }

                            if (string.IsNullOrEmpty(errorText))
                            {
                                if (Common.IsMaxWords(inputString, 3))//Your name cannot contain more than three words
                                {
                                    errorText = Codes.dict[1046].Item2;
                                }
                                else if (Common.IsSepcialCharacters(inputString))//Your name cannot contain special characters or numbers
                                {
                                    errorText = Codes.dict[1044].Item2;
                                }
                                else if (Common.IsMaxFullStops(inputString, 3))//Your name cannot contain more than three periods (.)
                                {
                                    errorText = Codes.dict[1047].Item2;
                                }
                                else if (Common.IsConsecutiveChar(inputString, new char[] { '.', '\'', '´', '‘', '’' }))//Your name cannot contain consecutive periods (.) or apostrophes (')
                                {
                                    errorText = Codes.dict[1048].Item2;
                                }
                                else if (Common.IsMaxChar(inputString, '´', 1) || Common.IsMaxChar(inputString, '\'', 1) || Common.IsMaxChar(inputString, '‘', 1) || Common.IsMaxChar(inputString, '’', 1))//Your name cannot contain two or more apostrophes (')
                                {
                                    errorText = Codes.dict[1050].Item2;
                                }
                                else if (Common.IsFullStopWithoutSpace(inputString))//Your name cannot contain a period (.) without a space
                                {
                                    errorText = Codes.dict[1051].Item2;
                                }
                                else if (Common.IsTrademark(inputString) || Common.IsContainWords(inputString, new string[] { "official" }))//We require everyone to use the name that they use in everyday life
                                {
                                    errorText = Codes.dict[1049].Item2;
                                }
                                else if (Common.CheckSymbolsNEmojis(inputString))
                                {
                                    SuggestedText objSuggestText = new SuggestedText() { TxtSuggestion = Common.RemoveEmoji(inputString) };

                                    if (!Common.IsValidList(ValidateName(objSuggestText, new string[] { "TxtSuggestion" })))
                                    {
                                        errorText = string.Format(Codes.dict[1041].Item2, inputString);//The name "{N}" is invalid.
                                    }
                                    else
                                    {
                                        errorText = string.Format(Codes.dict[1019].Item2, inputString, objSuggestText.TxtSuggestion);//The name "{0}" is invalid. We suggest "{1}"."
                                    }
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(errorText))
                        {
                            lstErrorMessage.Add(new AttrErrorMessage { Attribute = prop.Name, Message = errorText });
                        }
                    }
                }
            }

            return lstErrorMessage;
        }


        public static List<AttrErrorMessage> ValidatePassword(string password, string firstName, string middleName, string lastName)
        {
            List<AttrErrorMessage> lstErrorMessage = new List<AttrErrorMessage>();
            int passwordMinLength = 8, passwordMaxLength = 20;
            string errorText = "";

            if (password.Length < passwordMinLength || password.Length > passwordMaxLength)//Choose a longer password
            {
                errorText = Codes.dict[1055].Item2;
            }
            else if (Common.IsBeginingEndChar(password, new char[] { ' ' }))//Your password cannot start or end with a blank space
            {
                errorText = Codes.dict[1056].Item2;
            }
            else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))//Your password cannot contain your name
            {
                string nameCombo = !string.IsNullOrEmpty(middleName) ? (firstName + middleName + lastName) : (firstName + lastName);
                string nameComboReverse = !string.IsNullOrEmpty(middleName) ? (lastName + middleName + firstName) : (lastName + firstName);
                string firstLastCombo = firstName + lastName;
                string firstLastComboReverse = lastName + firstName;
                nameCombo = nameCombo.Replace(" ", string.Empty);
                nameComboReverse = nameComboReverse.Replace(" ", string.Empty);
                firstLastCombo = firstLastCombo.Replace(" ", string.Empty);
                firstLastComboReverse = firstLastComboReverse.Replace(" ", string.Empty);
                if (password == nameCombo || password == nameComboReverse || password == firstLastCombo || password == firstLastComboReverse)
                {
                    errorText = Codes.dict[1058].Item2;
                }
            }

            if (!string.IsNullOrEmpty(errorText))
            {
                lstErrorMessage.Add(new AttrErrorMessage { Attribute = "newPwd", Message = errorText });
            }
            return lstErrorMessage;
        }
    }
}
