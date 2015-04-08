using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nesjartun.Utility
{
    public class ResourceHelper
    {
        public static string GetEmbeddedResource(Assembly assembly, string resourceName)
        {
            if(assembly == null) throw new ArgumentNullException("assembly");
            if(string.IsNullOrEmpty(resourceName)) throw new ArgumentNullException("resourceName");

            string content;

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if(stream == null) throw new ArgumentException(string.Format("Could not find resource: '{0}' in assembly: '{1}'", resourceName, assembly.FullName));
                using (var reader = new StreamReader(stream))
                {
                    content = reader.ReadToEnd();
                }
            }

            return content;

        }
    }
}
