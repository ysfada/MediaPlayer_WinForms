using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WinFormsAppMediaPlayer
{
    /// <summary>
    /// This is a utily class. Put common methods here
    /// </summary>
    class Utils
    {
        /// <summary>
        /// Get absolute path relative to the current directory
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetAbsolutePath(string path)
        {
            return Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, path));
        }

        /// <summary>
        /// Concatenate two IEnumerable<string>
        /// </summary>
        /// <param name="enum1"></param>
        /// <param name="enum2"></param>
        /// <returns></returns>
        public static IEnumerable<string> ConcatEnumerable(IEnumerable<string> enum1, IEnumerable<string> enum2)
        {
            return (enum1 ?? Enumerable.Empty<string>()).Concat(enum2 ?? Enumerable.Empty<string>());
        }
    }
}
