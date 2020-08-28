using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace testingTemp.Shared.Models
{
    public class Contact
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        [JsonPropertyName("phonenumber")]
        public string PhoneNumber { get; set; }
    }
}
