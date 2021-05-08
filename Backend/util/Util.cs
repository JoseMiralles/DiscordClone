namespace Intalk.Util
{
    static class Util
    {
        public static string ToCamelCase(this string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }
            return name.Substring(0, 1).ToLower() + name.Substring(1);
        }
    }
}