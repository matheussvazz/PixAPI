using System;


namespace Business.Models
{
    public class Key
    {
        public Guid Id { get; set; }
        public Enumerated ETypeKey { get; set; }
        public string Description { get; set; }
    }
}
