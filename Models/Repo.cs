namespace Hrpage.Models
{
    public class Repo
    {
        private static List<empl> emplist = new List<empl>();
        public static IEnumerable<empl> Getemp()
        {
            return emplist;
        }
        public static void ADDemp(empl emp1)
        {
            emplist.Add(emp1);
        }
    }
}
