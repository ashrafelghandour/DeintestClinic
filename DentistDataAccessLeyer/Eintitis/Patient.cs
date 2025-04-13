using System;
using System.Collections.Generic;

namespace DentistDataAccessLeyer.Eintitis;

public partial class Patient
{
    public int PatientId { get; set; }

    public int PersonId { get; set; }

    public string PatientNote { get; set; } = null!;

    public DateOnly PatientDate { get; set; }

    public int StateId { get; set; }

    public double Cost { get; set; }

    public double Paied { get; set; }

    public double Remind { get; set; }

    public string PatientTc { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
