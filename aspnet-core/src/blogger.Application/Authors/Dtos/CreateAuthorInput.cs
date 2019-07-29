using System;
using System.ComponentModel.DataAnnotations;

namespace blogger.Authors.Dtos
{
    public class CreateAuthorInput
    {
        [Required]
        [StringLength(Author.MaxNameLength)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(Author.MaxNameLength)]
        public string LastName { get; set; }
        
        [StringLength(Author.MaxEmailLength)]
        public string Email { get; set; }
    }
}