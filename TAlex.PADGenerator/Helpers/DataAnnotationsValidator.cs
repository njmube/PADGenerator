using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;


namespace TAlex.PADGenerator.Helpers
{
    /// <summary>
    /// Defines a helper class that can be used to validate objects when it is included in their
    /// associated <see cref="System.ComponentModel.DataAnnotations.ValidationAttribute"/> attributes.
    /// </summary>
    public static class DataAnnotationsValidator
    {
        /// <summary>
        /// Determines whether the specified object is valid using the validation results collection.
        /// </summary>
        /// <param name="o">The object to validate.</param>
        /// <param name="results">A collection to hold each failed validation.</param>
        /// <returns>true if the object validates; otherwise, false.</returns>
        public static bool TryValidateObject(object o, List<ValidationResult> results)
        {
            ValidationContext context = new ValidationContext(o, null, null);
            return Validator.TryValidateObject(o, context, results, true);
        }

        /// <summary>
        /// Determines whether the specified object and its sub-objects is valid using the validation results collection.
        /// </summary>
        /// <typeparam name="T">The type of object to validate.</typeparam>
        /// <param name="obj">The object to validate.</param>
        /// <param name="results">A collection to hold each failed validation.</param>
        /// <returns>true if the object validates; otherwise, false.</returns>
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
