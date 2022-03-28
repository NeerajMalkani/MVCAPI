using System;
using System.Collections.Generic;

namespace TrepupAPI.Models
{
    public class Response
    {
        public string code { get; set; }
        public string status { get; set; }
        public object data { get; set; }
        public string message { get; set; }
    }

    public static class Codes
    {
        public static Dictionary<int, Tuple<string, string>> dict = new Dictionary<int, Tuple<string, string>>
        {
            {9001, new Tuple<string, string>("nodata", "No data available")},
            {1000, new Tuple<string, string>("success", "success")},
            {1001, new Tuple<string, string>("error", "authorization required/Invalid API Key")},
            {1002, new Tuple<string, string>("error", "missing required argument")},
            {1003, new Tuple<string, string>("error", "unable to find API Key")},
            {1004, new Tuple<string, string>("error", "Invalid API Key")},
            {1005, new Tuple<string, string>("error", "Internal server error")},
            {1006, new Tuple<string, string>("exists", "Already exists")},
            {1007, new Tuple<string, string>("error", "Your request could not be processed. Try again later.")},
            {1008, new Tuple<string, string>("error","You have entered an invalid template name.Please check your entry and try again.")},
            {1009, new Tuple<string, string>("error","You've exceeded your test email sending limits of 25 per day. Try again after 24 hours.")},
            {1010, new Tuple<string, string>("error", "Enter a valid email address")},
            {1012, new Tuple<string, string>("error", "A list with the same name already exists. Try another name.")},
            {1013, new Tuple<string, string>("error", "Enter a valid postal code")},           
            {1015, new Tuple<string, string>("error", "A template with the same name already exists. Try another name.")},

            #region store name
             {1016, new Tuple<string, string>("err_invalid", "Enter a store name")},
             {1017, new Tuple<string, string>("err_length", "Enter a valid store name")},
             {1018, new Tuple<string, string>("err_sp_char", "The store name cannot start with special characters")},
             {1019, new Tuple<string, string>("err_emoji_official", "The name \"{0}\" is invalid. We suggest \"{1}\".")},
             {1020, new Tuple<string, string>("err_trademark", "The store name infringes on a registered mark. Choose a different name.")},
             {1021, new Tuple<string, string>("err_keyword", "The store name cannot be the same as a store or product keyword")},
             {1022, new Tuple<string, string>("err_geoloc", "Stores with generic location names are not allowed")},
            #endregion
            
            #region store username
             {1023, new Tuple<string, string>("err_invalid", "Enter your username")},
             {1024, new Tuple<string, string>("err_not_available", "Username is not available")},
             {1025, new Tuple<string, string>("err_length_min", "Enter at least 5 characters")},
             {1026, new Tuple<string, string>("err_invalid_domain", "Your username cannot contain a domain name")},
             {1027, new Tuple<string, string>("err_alpha_num", "Your username can only contain alphanumeric characters (letters A-Z, numbers 0-9) with the exception of full stops")},
             {1028, new Tuple<string, string>("err_invalid", "Your username cannot contain only numbers")},
             {1029, new Tuple<string, string>("err_invalid", "Your username cannot start or end with special characters")},
             {1030, new Tuple<string, string>("err_invalid", "Your username cannot contain consecutive full stops")},
             {1031, new Tuple<string, string>("err_invalid", "Your username cannot contain special characters")},
	        #endregion
            
            #region store posting tool
             {1032, new Tuple<string, string>("err_desc_length", "A post cannot be longer than 70,000 characters.")},
             {1033, new Tuple<string, string>("err_desc_blank", "This post appears to be blank. Write something or attach a link or photo to post.")},
	         #endregion
            
            #region Login
             {1034, new Tuple<string, string>("error", "You cannot use a blank password")},
             {1035, new Tuple<string, string>("error", "The email address you entered isn't connected to an account.")},
             {1036, new Tuple<string, string>("error", "You entered an email address that is already associated with a Trepup account")},
             {1037, new Tuple<string, string>("error", "Password is incorrect")},
             {1038, new Tuple<string, string>("login_attempt_blocked", "Your account has been blocked because of an unusual number of login attempts. Please try again in 30 minutes.")},
            #endregion
            
            #region Store Opening Date
            {1039, new Tuple<string, string>("error", "Enter an opening date that is within a year")},
            #endregion
            
            #region Settings
            
            {1040, new Tuple<string, string>("account_deletion_scheduled", "Trepup account is scheduled for deletion")},
             {1041, new Tuple<string, string>("error", "The name \"{0}\" is invalid")},
             {1042, new Tuple<string, string>("error_name", "Enter your first name")},
             {1043, new Tuple<string, string>("error_name", "Enter your last name")},
             {1044, new Tuple<string, string>("error_name", "Your name cannot contain special characters or numbers")},
             {1045, new Tuple<string, string>("error_name", "Your name cannot start or end with a period (.) or apostrophe (')")},
             {1046, new Tuple<string, string>("error_name", "Your name cannot contain more than three words")},
             {1047, new Tuple<string, string>("error_name", "Your name cannot contain more than three periods (.)")},
             {1048, new Tuple<string, string>("error_name", "Your name cannot contain consecutive periods (.) or apostrophes (')")},
             {1049, new Tuple<string, string>("error_name", "We require everyone to use the name that they use in everyday life")},
             {1050, new Tuple<string, string>("error_name", "Your name cannot contain two or more apostrophes (')")},
             {1051, new Tuple<string, string>("error_name", "Your name cannot contain a period (.) without a space")},

             {1052, new Tuple<string, string>("error_birthday", "You must be at least {0} years old to create an account on Trepup")},
             {1053, new Tuple<string, string>("error_birthday",  "Enter a valid birthday") },

            {1054, new Tuple<string, string>("error_gender",  "Select your gender") },

            {1055, new Tuple<string, string>("error",  "Choose a longer password") },
            {1056, new Tuple<string, string>("error",  "Your password cannot start or end with a blank space") },
            {1057, new Tuple<string, string>("error",  "Password is incorrect") },
            {1058, new Tuple<string, string>("error",  "Your password cannot contain your name") },

            {1060, new Tuple<string, string>("success",  "A link to verify your email address has been sent to {0}.") },
            {1061, new Tuple<string, string>("error_email",  "You have reached a limit for sending mail. Try again in 30 minutes.") },
            {1062, new Tuple<string, string>("error_email",  "You are trying too often. Please try again in 30 minutes.") },
                        
            #endregion
            {1063, new Tuple<string, string>("error", "Enter a verified email address")},
            {1064, new Tuple<string, string>("error", "Your name cannot start or end with an apostrophe (')")},
            {1065, new Tuple<string, string>("error", "Your name cannot start with a period (.)")},

            {1066, new Tuple<string, string>("error_custom_gender", "Select your gender identity")},
            
            {1067, new Tuple<string, string>("error", "This domain is blocked. Enter another email address.")},

            #region product post tool 
            {2000, new Tuple<string, string>("success", "success")},
            {2100, new Tuple<string, string>("error", "error")},
            //Basic Information
            {2001, new Tuple<string, string>("error", "Enter a valid title")},
            {2002, new Tuple<string, string>("error", "Do not create duplicate content") },
            //Offer- One price/Uniform price
            {2011, new Tuple<string, string>("error", "End date cannot be before the start date") },
            {2012, new Tuple<string, string>("error", "The difference between the start and end dates must be <= 2 months") },
            {2013, new Tuple<string, string>("error", "Start date must be <= 2 years") },
            {2014, new Tuple<string, string>("error", "Discount percentage must be < 100") },
            #endregion
            
            #region store location
             {3001, new Tuple<string, string>("err_country", "Enter your country")},
             {3002, new Tuple<string, string>("err_city", "Enter your city")},
             {3003, new Tuple<string, string>("err_pincode", "")},
            #endregion
        };
    }
}