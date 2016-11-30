using System;

namespace EFRelationTests.Contracts
{
    public class ProcessingTicketDto
    {
        public Guid Id { get; set; }
        public string ProcessorName { get; set; }
        public string ProcessingClass { get; set; } //TODO try enums...
        public virtual OrderDto Order { get; set; }
    }
}