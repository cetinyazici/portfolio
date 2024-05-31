using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DToLayer.ContactDtos
{
    public class SendMessageDto
    {
        [Key]
        public int ContactId { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
    }
}
