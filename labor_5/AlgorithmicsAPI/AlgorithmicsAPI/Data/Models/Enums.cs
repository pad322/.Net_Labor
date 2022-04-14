using System.ComponentModel.DataAnnotations;

namespace AlgorithmicsAPI.Data.Models
{
    public class Enums
    {
        public enum AlgorithmType
        {
            [Display(Name = "Sorting algorithm")]
            Sorting,
            [Display(Name = "Searching algorithm")]
            Searching,
            [Display(Name = "Backtracking algorithm")]
            BackTracking
        }
    }
}
