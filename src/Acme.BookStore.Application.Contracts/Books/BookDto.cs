using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    /// <summary>
    /// book的传输数据
    /// </summary>
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}
