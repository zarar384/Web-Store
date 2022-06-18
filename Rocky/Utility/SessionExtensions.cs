using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Rocky.Utility{
    public static class SessionExtensions{
        public static void Set<T>(this ISession session, string key, T value){
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T Get<T>(this ISession session, string key){

            var vallue = session.GetString(key);
            return vallue == null? default : JsonSerializer.Deserialize<T>(vallue);
        }
    }
}