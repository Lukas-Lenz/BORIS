namespace BORIS.Models
{
    public class ProgramInfo
    {
        public ProgramInfo(string name, Dictionary<string, string> info)
        {
            Name = name;
            Info = info;
        }

        public string Name { get; set; }
        public Dictionary<string, string> Info { get; set; }
    }

}
