using System.ComponentModel.DataAnnotations;

namespace ASP_RestAPI.Dtos{

    public record DeleteItemDto{

        [Required]
        public string Name {get;init;}
        
        [Required]
        [Range(1,1000)]
        public decimal Price {get;init;}
        
    }
}