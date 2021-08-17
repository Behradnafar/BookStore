using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStore.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public virtual string Name { get; set; }

        public virtual BookType Type { get; set; }

        public virtual DateTime PublishDate { get; set; }

        public virtual float Price { get; set; }
    }
}
