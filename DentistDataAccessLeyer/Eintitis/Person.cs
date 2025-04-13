using System;
using System.Collections.Generic;

namespace DentistDataAccessLeyer.Eintitis;

public partial class Person
{
    public int PersonId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateOnly BirthDay { get; set; }

    public byte[]? Image { get; set; }

    public bool Gender { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
