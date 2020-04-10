namespace BunLab.Client.Models.UA
{
    public class UAPageItem
    {
        public UAPageItem(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public string Name { get; set; }

        public string Value { get; set; }

        public string Url { get; set; }
    }
}
