using Azure;
using DentistDataAccessLeyer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace DentistBusinessLeyer
{
     public class ClsPatinet : ClsPerson
    {
       

        public ClsPatinet(PersonDTO Person ,PatinetDTO patinet,enMode mode):
            base(Person,mode)
        {
            this.PatientID = patinet.PatientID;
            this.PatientTC = patinet.PatientTC;
            this.StateID = patinet.StateID;
            this.Patientdate = patinet.Patientdate;
            this.cost = patinet.cost;
            this.Paied = patinet.Paied;
            this.Remind = patinet.Remind;
            this.PersonID = patinet.PersonID;
            Notes = patinet.Notes;

            this.Mode = mode;


        }

        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public ClsPatinet()
        {

            this.Mode = enMode.AddNew;

        }
        public int? PatientID { get; set; }

        public int? PersonID { get; set; }
        public string PatientTC { get; set; }
        public int StateID { get; set; }

        public DateTime Patientdate { get; set; }

        public float cost { get; set; }
        public float Paied { get; set; }
        public float Remind { get; set; }
        public string Notes { get; set; }

        public PatinetDTO PatinetDTO{ get { return (new PatinetDTO(new PersonDTO(this.PersonID, this.Name, this.BirthDay, this.Phone, this.gender, this.Email, this.Image), this.Notes,this.PatientID,this.PatientTC
           , this.StateID,this.Patientdate,this.cost,this.Paied,this.Remind)); } }


        public PatinetDTO? FindPatientDTO(int id)
        {

            PatinetDTO patinetDTO = clsPatientData.FindPatinet(id);

            if (patinetDTO != null)
            {
                this.PersonID = patinetDTO.PersonID;
                this.Name = patinetDTO.Name;
                this.Email = patinetDTO.Email;
                this.StateID = patinetDTO.StateID;

                this.BirthDay = patinetDTO.BirthDay;
                this.Phone = patinetDTO.Phone;
                this.gender = patinetDTO.gender;
                this.Image = patinetDTO.Image;
                this.Notes = patinetDTO.Notes;

                this.cost = patinetDTO.cost;
                this.Remind = patinetDTO.Remind;
                this.Paied = patinetDTO.Paied;
                this.Patientdate = patinetDTO.Patientdate;
                this.PatientTC = patinetDTO.PatientTC;



                this.Mode = enMode.Update;

                return this.PatinetDTO;

            }
            else
            {


                return null;
            }

        }
        public static ClsPatinet? FindPatient(int id)
        {

            PatinetDTO? PatinetDTO = clsPatientData.FindPatinet(id);



            if (PatinetDTO != null)

                return new ClsPatinet(PatinetDTO, PatinetDTO, ClsPerson.enMode.Update);
            else
                return null;


        }


        public static bool DeletePatient(int PatientID)
        {
            return clsPatientData.DeletePatient(PatientID);
        }
    


        protected bool _AddNewPatient()
        {

            PatinetDTO patinetDTO = clsPatientData.AddNewPatient(PatinetDTO);

            if (patinetDTO != null && patinetDTO.PatientID!=0)
            {
                this.PersonID = patinetDTO.PersonID;
                this.Name = patinetDTO.Name;
                this.Email = patinetDTO.Email;
                this.StateID = patinetDTO.StateID;

                this.BirthDay = patinetDTO.BirthDay;
                this.Phone = patinetDTO.Phone;
                this.gender = patinetDTO.gender;
                this.Image = patinetDTO.Image;
                this.Notes = patinetDTO.Notes;

                this.cost = patinetDTO.cost;
                this.Remind = patinetDTO.Remind;
                this.Paied = patinetDTO.Paied;
                this.Image = patinetDTO.Image;
                this.Patientdate = patinetDTO.Patientdate;
                this.PatientTC = patinetDTO.PatientTC;


                return true;
            }
            else
            {
                return false;
            }



        }
        protected bool _UpdatePatient()
        {

            if (clsPatientData.UpdatePatient(this.PatinetDTO))
                return true;

            else
                return false;
        }


        protected bool _DeletePatient()
        {

            int patietnid = (this.PatientID != null)?(int)this.PatientID : 0;
            return clsPatientData.DeletePatient(patietnid);

        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return this._AddNewPatient();

                case enMode.Update:
                    return this._UpdatePatient();
                case enMode.Delete:
                    return this._DeletePatient();

            }
            return false;
        }
        public static DataTable GetAllPatient()
        {
            return clsPatientData.GetAllPatient();
        }
    }
}
