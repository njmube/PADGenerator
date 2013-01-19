using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAlex.PADGenerator.Models
{
    internal static class Patterns
    {
        /// <summary>
        /// Email address 2-30@2-63.2-20 characters
        /// </summary>
        public const string Email = @"^.{2,30}\@.{2,63}\..{2,20}$";

        /// <summary>
        /// Numeric with punctuations (allowed: #*()-/_) 7-40 characters
        /// </summary>
        public const string Phone = @"^\+{0,2}(([0-9#*()-\/_] *){7,40})?$";

        public const string OptionalMonth = @"^(0[1-9]|1[0-2])?$";

        public const string OptionalDay = @"^(0[1-9]|[12][0-9]|3[01])?$";

        public const string OptionalYear = @"^((19|20|21)[0-9]{2})?$";
    }
}
