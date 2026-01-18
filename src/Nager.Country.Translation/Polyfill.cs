using System.Collections.Generic;

namespace Nager.Country.Translation
{
    #if !NET8_0_OR_GREATER

    internal static partial class PolyfillMembers
    {
        internal static System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dictionary) where TKey : notnull => new(dictionary);
    }

    #endif
}