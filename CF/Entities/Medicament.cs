using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CF.Entities
{
    public class Medicament
    {
        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

        public Medicament()
        {
            PrescriptionMedicaments = new HashSet<PrescriptionMedicament>();
        }
    }
}
