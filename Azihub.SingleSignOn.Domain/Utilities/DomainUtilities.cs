using Azihub.SingleSignOn.Domain.Utilities.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Azihub.SingleSignOn.Domain.Utilities
{
    public static class DomainUtilities
    {
        /// <summary>
        /// This method gives an instance of a class and a property of this class.
        /// Then we ask it return minlenght or maxlenght value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static T GetAttributeFrom<T>(this object instance, string propertyName) where T : Attribute
        {
            // Check instance is null
            if (instance == null)
                throw new InstanceiIsNullException();

            //Check propertyName is null
            if (string.IsNullOrEmpty(propertyName))
                throw new PropertyNameIsNullException();

            // Specify the type of attribute
            var attrType = typeof(T);
            var property = instance.GetType().GetProperty(propertyName);

            // Get Attribute value
            var attributeResult = (T)property.GetCustomAttributes(attrType, false).FirstOrDefault();

            // Check Attribute is null
            if (attributeResult == null)
                throw new PropertyHasNotAttributeException();

            return attributeResult;
        }

        /// <summary>
        /// This method returns the MaxLength Attribute value of the property
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static int GetMaxLength(this object instance, string propertyName)
        {
            return GetAttributeFrom<MaxLengthAttribute>(instance, propertyName).Length;
        }

        /// <summary>
        /// This method returns the MinLength Attribute value of the property.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static int GetMinLength(this object instance, string propertyName)
        {
            return GetAttributeFrom<MinLengthAttribute>(instance, propertyName).Length;
        }

    }
}