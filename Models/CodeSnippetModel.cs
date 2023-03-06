using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class CodeSnippetModel
    {
        [Key]
        public Guid IdCodeSnippet { get; set;}

        [StringLength(100, ErrorMessage= "Title may only contain up to 100 characters")]
        public string Title { get; set; }
        public string ContentCode { get; set;}
        public Guid IdMember { get; set;}

        [Range(0, int.MaxValue, ErrorMessage ="Revision must be positive")]
        public int Revision { get; set;}
        public bool IsPublished { get; set; }
        public DateTime DateTimeAdded { get; set;}
    }
}
