
using System.ComponentModel.DataAnnotations.Schema;

namespace AlgorithmicsAPI.Data.Models
{
    internal class DataBaseGeneratedAttribute : Attribute
    {
        private DatabaseGeneratedOption identity;

        public DataBaseGeneratedAttribute(DatabaseGeneratedOption identity)
        {
            this.identity = identity;
        }
    }
}