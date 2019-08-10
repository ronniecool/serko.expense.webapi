﻿using System;
using System.Collections.Generic;
using System.Text;

namespace serko.expense.models
{
    public static class Constants
    {
        public const decimal GST_PERCENT = 18;

        #region response

        public const string EMPTY_EMAIL_CONTENT = "Supply a valid email content";
        public const string GENERAL_EXCEPTION_RESPONSE = "An error occurred while processing your request";

        #endregion response
    }
}
