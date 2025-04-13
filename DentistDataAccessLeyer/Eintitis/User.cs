using System;
using System.Collections.Generic;

namespace DentistDataAccessLeyer.Eintitis;

public  class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPasswred { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public int PersonId { get; set; }

    public  Person Person { get; set; } = null!;
}
