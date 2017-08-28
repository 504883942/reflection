using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace reflection
{
    public class DescribeAttribute:Attribute
    {
        public string Name;
        public string Describe;
    }
    public static class Describe {
        public static DescribeAttribute GetAtrribute(Type a) {
            var ab = a.GetCustomAttributes(false).Where(p => p.GetType() == typeof(DescribeAttribute)).ToList();
            return ab.FirstOrDefault() as DescribeAttribute;
        }
        public static DescribeAttribute GetAtrribute(MethodInfo a)
        {
            var ab = a.GetCustomAttributes(false).Where(p => p.GetType() == typeof(DescribeAttribute)).ToList();
            return ab.FirstOrDefault() as DescribeAttribute;
        }
        public static DescribeAttribute GetAtrribute(ParameterInfo a)
        {
            var ab = a.GetCustomAttributes(false).Where(p => p.GetType() == typeof(DescribeAttribute)).ToList();
            return ab.FirstOrDefault() as DescribeAttribute;
        }
    }
}