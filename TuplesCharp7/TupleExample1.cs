using System;

namespace TuplesCharp7
{
    public class TupleExample1
    {
        public static Tuple<string, string, int> GetNameBlogAndAge()
        {
           return new Tuple<string, string, int>(
                               "Nikola Zivkovic", "www.rubikscode.net", 30);
        }
    }
}
