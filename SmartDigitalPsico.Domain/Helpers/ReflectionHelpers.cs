﻿namespace SmartDigitalPsico.Domain.Helpers
{
    public class ReflectionHelpers
    {
        public static IOrderedEnumerable<System.Reflection.PropertyInfo> GetProperties(object dataObject, List<string> propertiesToIgnore)
        {
            return dataObject.GetType().GetProperties()
                        .Where(p => !propertiesToIgnore.Contains(p.Name))
                        .OrderBy(p => p.GetCustomAttributes(typeof(OrderAttribute), false)
                        .Cast<OrderAttribute>().FirstOrDefault()?.Order ?? int.MaxValue);
        } 
    }
}