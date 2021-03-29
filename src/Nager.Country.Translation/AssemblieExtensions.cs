using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Nager.Country.Translation
{
    internal static class AssemblieExtensions
    {
        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {​​​​​​​​
            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }
    }
}
