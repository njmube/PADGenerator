using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TAlex.PADGenerator.Helpers
{
    public static class DataAnnotationsValidator
    {
        public static bool TryValidateObject(object o, List<ValidationResult> results)
        {
            ValidationContext context = new ValidationContext(o, null, null);
            return Validator.TryValidateObject(o, context, results, true);
        }

        public static bool TryValidateObjectRecursive<T>(T obj, List<ValidationResult> results)
        {
            bool result = TryValidateObject(obj, results);

            List<PropertyInfo> properties = obj.GetType().GetProperties().Where(prop => prop.CanRead).ToList();

            foreach (var property in properties)
            {
                PropertyInfo prop = obj.GetType().GetProperty(property.Name);
                object value = prop.GetValue(obj, null);

                if (value == null) continue;

                var asEnumerable = value as IEnumerable;
                if (asEnumerable != null)
                {
                    foreach (var enumObj in asEnumerable)
                    {
                        result = TryValidateObjectRecursive(enumObj, results) && result;
                    }
                }
                else
                {
                    result = TryValidateObjectRecursive(value, results) && result;
                }
            }

            return result;
        }
    }
}
