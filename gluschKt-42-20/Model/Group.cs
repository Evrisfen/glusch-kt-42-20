using System.Dynamic;
using System.Text.RegularExpressions;

namespace gluschKt_42_20.Model
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public bool IsValidGroupName()
        {

            return Regex.Match(GroupName, @"\D\D-\d\d-\d\d").Success;
            /*if(GroupName.Length == 0 || GroupName.Length <= 1)
            {
                return false;
            }
            return true;*/
        }
    }
}
