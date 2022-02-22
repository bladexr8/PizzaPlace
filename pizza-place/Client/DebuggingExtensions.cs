using System.Text.Json;

/** Debugging Support Class **/

namespace pizza_place.Client {
    public static class DebuggingExtensions {
        public static string ToJson(this object obj)
            => JsonSerializer.Serialize(obj, obj.GetType());
    }
}