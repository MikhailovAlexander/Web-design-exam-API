using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace NotebookAPI.Models
{
    public class Contact : BaseEntity
    {
        public int PersonId { get; set; }
        public int ContactTypeId { get; set; }
        public string Value { get; set; }

        [JsonIgnore]
        public virtual Person Person { get; set; }
        [JsonIgnore]
        public virtual ContactType ContactType { get; set; }
    }
}