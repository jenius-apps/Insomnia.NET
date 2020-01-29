using System.Collections.Generic;

namespace Insomnia.NET.Models
{
    public class RequestGroup : BaseResource
    {
        public long Created { get; set; }

        public long Modified { get; set; }

        public long MetaSortKey { get; set; }

        /// <summary>
        /// Environment override data.
        /// </summary>
        public Dictionary<string, string> Environment { get; set; }
    }
}
