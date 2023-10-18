using System.Reflection;

namespace FizzBuzz
{
    internal static class Utility
    {
        public static List<T> GetImplementations<T>()
        {
            // Get the type of the class
            Type classType = typeof(T);

            // Get all the types in the current assembly
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            // Create a list to store the instances
            List<T> instances = new List<T>();

            // Loop through the types
            foreach (Type type in types)
            {
                // Check if the type is a subclass of the base class and is not abstract
                if (classType.IsAssignableFrom(type) && !type.IsAbstract)
                {
                    // Create an instance of the type
                    T instance = (T)Activator.CreateInstance(type);

                    // Add the instance to the list
                    instances.Add(instance);
                }
            }

            // Return the list of instances
            return instances;
        }
    }
}