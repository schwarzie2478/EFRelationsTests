using ADF.Data.Repositories;
using System;

namespace EFRelationTests.Model
{
    public class ProcessingTicket : AuditableEntity<Guid>
    {
        public string ProcessorName { get; set; }
        public string ProcessingClass { get; set; } //TODO try enums...
        public virtual Order Order{get; set;}

    }
}