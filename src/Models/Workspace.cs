namespace Insomnia.NET.Models
{
    public class Workspace : BaseResource
    {
        public long Created { get; set; }

        public long Modified { get; set; }

        public string Description { get; set; }
    }
}
