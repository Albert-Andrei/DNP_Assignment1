using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace Assignment.Model {
    public class Adult : Person
    {
        [Required, MaxLength(20)] [NotNull] public string JobTitle { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public void Update(Adult toUpdate)
        {
            JobTitle = toUpdate.JobTitle;
            base.Update(toUpdate);
        }
    }
}