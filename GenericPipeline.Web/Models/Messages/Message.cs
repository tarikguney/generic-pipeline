using System;

namespace GenericPipeline.Web.Models.Messages
{
    public class Message
    {
        public Guid Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address HomeAddress { get; set; }
    }
}