using System.Collections.Generic;

namespace zork.common
{
    public static class Extension
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue = default) => (dictionary != null && key != null && dictionary.TryGetValue(key, out TValue value)) ? value : defaultValue;
    }
}
