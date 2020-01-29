using System.Collections.Generic;

namespace Insomnia.NET.Models
{
    public class Request : BaseResource
    {
        public long Created { get; set; }

        public long Modified { get; set; }

        public long MetaSortKey { get; set; }

        public string Method { get; set; }

        public string Url { get; set; }

        public Body Body { get; set; }

        public List<Parameter> Parameters { get; set; }

        public List<Parameter> Headers { get; set; }

        public Authentication Authentication { get; set; }
    }
}
