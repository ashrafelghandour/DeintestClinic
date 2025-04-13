namespace DentistDataAccessLeyer
{
    public class PatientWithAdd
    {
        public int? PatientID { get; set; }

        public string PatientTC { get; set; }
        public int StateID { get; set; }

        public DateTime PatientDate { get; set; }
        public string PatientNote { get; set; }

        public float cost { get; set; }
        public float Paied { get; set; }
        public float Remind { get; set; }

        public int? PersonID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public bool gender { get; set; }

        public byte[]? Image { get; set; }



    }
}