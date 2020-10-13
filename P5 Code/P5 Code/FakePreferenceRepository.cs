using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public class FakePreferenceRepository
    {
        public static Dictionary<string, Preference> Prefered;

        public static string SetPreference(string usrnme, string pref, string val)
        {
            Prefered = new Dictionary<string, Preference>();
            Prefered.Add(usrnme, new Preference
            {
                UserName = usrnme,
                Name = pref,
                Value = val,
            });

            return "done";
        }
        public static string GetPreference(string usrnme, string pref)
        {
            if (Prefered == null)
            {
                return "ERROR";
            }
            else
            {
                var result = Prefered.FirstOrDefault(x => x.Value.UserName == usrnme);
                return result.Value.Name;
            }
        }
    }
}
