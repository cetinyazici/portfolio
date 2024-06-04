using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DToLayer.ProfileDtos
{
    public class ProfileEditDTO
    {
        public string? ImageUrl { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
        public string Email { get; set; }
    }
}
