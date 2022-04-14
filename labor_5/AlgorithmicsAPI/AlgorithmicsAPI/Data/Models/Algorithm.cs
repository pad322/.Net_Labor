using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlgorithmicsAPI.Data.Models
{
    public class Algorithm
    {
        [Key] 
        [DataBaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name="Algorithm Name")]
        public string Description { get; set; }

        public string Icon { get; set; }

        public string Url { get; set; }

        public bool isPublished { get; set; }

        public DateTime CreationDate { get; set; }

        public string AlgorithmNickName { get; set; }

        public AlgorithmType Type { get; set; }

    }
}
