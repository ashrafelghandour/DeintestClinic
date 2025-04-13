
using Microsoft.Data.SqlClient;
using System.Data;


namespace DentistDataAccessLeyer
{
    public class PatinetDTO : PersonDTO
    {
        public PatinetDTO(PersonDTO personDTO , string note, int? patientID,  string patientTC, int state, DateTime patientdate, float cost, float paied, float remind)
            : base(personDTO.PersonID, personDTO.Name, personDTO.BirthDay, personDTO.Phone, personDTO.gender, personDTO.Email, personDTO.Image)
        {
            this.PatientID = patientID;
            this.PatientTC = patientTC;
            this.StateID = state;
            this.Patientdate = patientdate;
            this.cost = cost;
            this.Paied = paied;
            this.Remind = remind;
            this.Notes = note;
        }
        public PatinetDTO() { 
        
        
        }
        public int? PatientID { get; set; }

        public string PatientTC { get; set; }
        public int StateID { get; set; }

        public DateTime Patientdate { get; set; }
        public string Notes { get; set; }

        public float cost { get; set; }
        public float Paied { get; set; }
        public float Remind { get; set; }

       
    }


    public class clsPatientData  
    {


        public static PatinetDTO AddNewPatient(PatinetDTO patient) {



            try
            {

                using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand("SP_AddNewPatientAndPerson", con))
                    {



                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Name", patient.Name);
                        cmd.Parameters.AddWithValue("@Email", patient.Email);
                        cmd.Parameters.AddWithValue("@BirthDay", patient.BirthDay);
                        cmd.Parameters.AddWithValue("@Gonder", patient.gender);

                        if (patient.Image.Count() != 0 && patient.Image != null)

                            cmd.Parameters.AddWithValue("@Image", patient.Image);
                        else
                            cmd.Parameters.AddWithValue("@Image", System.DBNull.Value);



                        cmd.Parameters.AddWithValue("@Phone", patient.Phone);


                        cmd.Parameters.AddWithValue("@PatientTC", patient.PatientTC);
                        cmd.Parameters.AddWithValue("@StateID", patient.StateID);
                        cmd.Parameters.AddWithValue("@Patientdate", patient.Patientdate);
                        cmd.Parameters.AddWithValue("@cost", patient.cost);
                        cmd.Parameters.AddWithValue("@Paied", patient.Paied);
                        cmd.Parameters.AddWithValue("@Remind", patient.Remind);
                        cmd.Parameters.AddWithValue("@PatientNote", patient.Notes);


                        con.Open();

                        using (SqlDataReader red = cmd.ExecuteReader())
                        {

                            if (red.Read())
                            {

                                byte[] image = (red[4] == DBNull.Value) ? null : (byte[])red[4];

                                return new PatinetDTO(new PersonDTO(red.GetInt32(red.GetOrdinal("PersonID")),
                                       red.GetString(red.GetOrdinal("Name")),
                                       red.GetDateTime(red.GetOrdinal("BirthDay")),
                                       red.GetString(red.GetOrdinal("Phone")),
                                       red.GetBoolean(red.GetOrdinal("gender")),
                                       red.GetString(red.GetOrdinal("Email")),
                                       image)
                                        ,
                                       red.GetString(red.GetOrdinal("PatientNote")),
                                       red.GetInt32(red.GetOrdinal("PatientID")),
                                       red.GetString(red.GetOrdinal("PatientTC")),
                                       red.GetInt32(red.GetOrdinal("StateID")),
                                      red.GetDateTime(red.GetOrdinal("PatientDate")),
                                    (float)red.GetDouble(red.GetOrdinal("cost")),

                                    (float)red.GetDouble(red.GetOrdinal("Paied")),
                                    (float)red.GetDouble(red.GetOrdinal("Remind"))

                                       );





                            }

                        }



                    }
                }
            }



            //    using (var context = new AppDBContext())
            //    {



            //        //var Name = new SqlParameter("@Name", SqlDbType.NVarChar).Value = patient.Name;

            //        //var Email = new SqlParameter("@Email", SqlDbType.NVarChar).Value = patient.Email;
            //        //var BirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime).Value = patient.BirthDay;
            //        //var Gonder = new SqlParameter("@Gonder", SqlDbType.Bit).Value = patient.gender;

            //        //var Image =  patient.Image.Count() != 0 && patient.Image != null ?
            //        //    new SqlParameter("@Image", SqlDbType.Image).Value = patient.Image : new SqlParameter("@Image", SqlDbType.Image).Value = DBNull.Value;

            //        //var Phone= new SqlParameter("@Phone", SqlDbType.VarChar).Value = patient.Phone;
            //        //var PatientTC = new SqlParameter("@PatientTC", SqlDbType.VarChar).Value = patient.PatientTC;
            //        //var StateID = new SqlParameter("@StateID", SqlDbType.Int).Value = patient.StateID;
            //        //var Patientdate = new SqlParameter("@Patientdate", SqlDbType.DateTime).Value = patient.Patientdate;
            //        //var cost = new SqlParameter("@cost", SqlDbType.Float).Value = patient.cost;
            //        //var Paied = new SqlParameter("@Paied", SqlDbType.Float).Value = patient.Paied;
            //        //var Remind = new SqlParameter("@Remind", SqlDbType.Float).Value = patient.Remind;
            //        //var PatientNote = new SqlParameter("@PatientNote", SqlDbType.VarChar).Value = patient.Notes;


            //        var patientWithAdd = context.PatientWithAdd.FromSqlRaw("EXEC SP_AddNewPatientAndPerson @Name,@Email ,@BirthDay ,@Gonder,@Image ,@Phone ,@PatientTC ,@StateID ,@Patientdate,@cost ,@Paied,@Remind ,@PatientNote", new SqlParameter("Name",patient.Name),

            //        new SqlParameter("Email",patient.Email) ,
            //       new SqlParameter("BirthDay", patient.BirthDay ),
            //        new SqlParameter("Gonder",patient.gender),

            //       new SqlParameter("Image",patient.Image),

            //      new SqlParameter("Phone",  patient.Phone),
            //        new SqlParameter("PatientTC",  patient.PatientTC),
            //        new SqlParameter("StateID",  patient.StateID),
            //         new SqlParameter("Patientdate", patient.Patientdate),
            //        new SqlParameter("cost",(float)(double) patient.cost),
            //        new SqlParameter("Paied", (float)(double)patient.Paied),
            //       new SqlParameter("Remind", (float)(double) patient.Remind),
            //        new SqlParameter("PatientNote", patient.Notes)).ToList().First();

            //         return new PatinetDTO(new PersonDTO(patientWithAdd.PersonID,
            //                            patientWithAdd.Name,
            //                               patientWithAdd.BirthDay,
            //                              patientWithAdd.Phone,
            //                              patientWithAdd.gender,
            //                             patientWithAdd.Email,
            //                            patientWithAdd.Image)
            //                              ,
            //                             patientWithAdd.PatientNote,
            //                            patientWithAdd.PatientID,
            //                            patientWithAdd.PatientTC,
            //                           patientWithAdd.StateID,
            //                       patientWithAdd.PatientDate,
            //                          (float)patientWithAdd.cost,

            //                          (float)patientWithAdd.Paied,
            //                          (float)patientWithAdd.Remind

            //                             );
            //    }
            //}
            catch
            {
                return null;

            }
            return null;
        }





       public static PatinetDTO FindPatinet(int patinetID)
       {


              try
              {

                using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand("SP_GetPatientByID", con))
                    {



                        cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@PatientID", patinetID);


                        con.Open();

                        using (SqlDataReader red = cmd.ExecuteReader())
                        {

                            if (red.Read())
                            {

                                byte[] image = (red[5] == DBNull.Value) ? null : (byte[])red[5];
                                return new PatinetDTO(new PersonDTO(red.GetInt32(red.GetOrdinal("PersonID")),
                                        red.GetString(red.GetOrdinal("Name")),
                                        red.GetDateTime(red.GetOrdinal("BirthDay")),
                                        red.GetString(red.GetOrdinal("Phone")),
                                        red.GetBoolean(red.GetOrdinal("gender")),
                                        red.GetString(red.GetOrdinal("Email")),
                                        image)
                                         ,
                                        red.GetString(red.GetOrdinal("PatientNote")),
                                        red.GetInt32(red.GetOrdinal("PatientID")),
                                        red.GetString(red.GetOrdinal("PatientTC")),
                                        red.GetInt32(red.GetOrdinal("StateID")),
                                       red.GetDateTime(red.GetOrdinal("PatientDate")),
                                     (float)red.GetDouble(red.GetOrdinal("cost")),

                                     (float)red.GetDouble(red.GetOrdinal("Paied")),
                                     (float)red.GetDouble(red.GetOrdinal("Remind"))

                                        );


                            }

                        }



                    }
                }


              }
              catch
              {
                return null;

              }
                       return null;

       }

        public static bool UpdatePatient(PatinetDTO patinet)
        {
            int rowsAffected = 0;

            try
            {

                using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString))
                {

             
                    using (SqlCommand cmd = new SqlCommand("SP_UpdatePatient", con))
                    {
                        con.Open();


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", patinet.PersonID);
                        cmd.Parameters.AddWithValue("@Name", patinet.Name);
                        cmd.Parameters.AddWithValue("@BirthDay", patinet.BirthDay);
                        cmd.Parameters.AddWithValue("@Phone", patinet.Phone);
                        cmd.Parameters.AddWithValue("@gender", patinet.gender);
                        cmd.Parameters.AddWithValue("@Email", patinet.Email);
                        cmd.Parameters.AddWithValue("@image", patinet.Image);
                        cmd.Parameters.AddWithValue("@PatientNote", patinet.Notes);
                        cmd.Parameters.AddWithValue("@PatientID", patinet.PatientID);
                        cmd.Parameters.AddWithValue("@PatientTC", patinet.PatientTC);
                        cmd.Parameters.AddWithValue("@StateID", patinet.StateID);
                        cmd.Parameters.AddWithValue("@PatientDate", patinet.Patientdate);
                        cmd.Parameters.AddWithValue("@cost", patinet.cost);
                        cmd.Parameters.AddWithValue("@Paied", patinet.Paied);
                        cmd.Parameters.AddWithValue("@Remind", patinet.Remind);

                        rowsAffected = cmd.ExecuteNonQuery();

                        return (rowsAffected > 0);





                    }
                }


            }
            catch
            {
                return (rowsAffected > 0);

            }

        }

        public static DataTable GetAllPatient()
        {
            using (var con = new SqlConnection(clsUtility._ConnectionString))
            {
                var dtAllPatient = new DataTable();

                try
                {
                  using (var com = new SqlCommand("SP_GetAllPatient", con))
                  {


                    com.CommandType = CommandType.StoredProcedure;


                        con.Open();

                        using (var reader = com.ExecuteReader())
                        {
                       


                            if (reader.HasRows)

                            {
                                dtAllPatient.Load(reader);
                            }

                            reader.Close();


                      

                           return dtAllPatient;

                        }

                  }

               
               }

               catch (Exception ex)
               {
                    return dtAllPatient ?? null;
               }


            }
        }

        public static bool DeletePatient(int patientID)
        {
            using (var con = new SqlConnection(clsUtility._ConnectionString))
            {
                int rowsAffected = 0;

                try
                {
                    using (var com = new SqlCommand("SP_DeletePaTient", con))
                    {


                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@PaientID", patientID);
                        con.Open();

                        rowsAffected = com.ExecuteNonQuery();
                        

                       return (rowsAffected > 0);

                        

                    }


                }

                catch (Exception ex)
                {
                    return (rowsAffected > 0);
                }

            }


        }

    }
}