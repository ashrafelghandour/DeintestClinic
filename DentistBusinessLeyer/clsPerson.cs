using System.Dynamic;
using DentistDataAccessLeyer;

namespace DentistBusinessLeyer
{
    public class ClsPerson  : iPerson
    {

        public ClsPerson(iPerson person,enMode mode = enMode.AddNew )
        {
            this.PersonID = person.PersonID;
            this.Name = person.Name;
            this.BirthDay = person.BirthDay;
            this.Phone = person.Phone;
            this.gender = person.gender;
            this.Email = person.Email;
            this.Mode = mode;
            this.Image = person.Image;

        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public ClsPerson(){
            
            this.Mode = enMode.Update ;

        }
        public int? PersonID {get ;set;} 
        public string Name{get;set;}
         public string Email{get;set;}
        public DateTime BirthDay {get;set;}
        public string Phone{get;set;}
        public  bool gender {get;set;}
        public byte[]? Image { get; set; }

        public enum enMode {AddNew = 0, Update =1 ,Delete =2}
        public enMode Mode = enMode.AddNew;

        public PersonDTO PerDTO { get { return (new PersonDTO(this.PersonID, this.Name, this.BirthDay, this.Phone,this.gender,this.Email,this.Image));  } }

       
        public ClsPerson? FindPerson(int id , string name){

              iPerson? PersonDTO =  clsPersonData.Find(id,name);

                  if(PersonDTO != null){
                   this.PersonID = PersonDTO.PersonID;
                    this.Name = PersonDTO.Name;
                     this.Email = PersonDTO.Email;
                      this.BirthDay = PersonDTO.BirthDay;
                       this.Phone = PersonDTO.Phone;
                         this.gender = PersonDTO.gender;
                          this.Image = PersonDTO.Image;
                                     this.Mode = enMode.Update;

                         return this ;

                  }
                  else{
                    

                         return null;
                  }

            }
             public static ClsPerson? FindPerson(int? id){

            iPerson? PersonDTO =  clsPersonData.Find(id);

                  if(PersonDTO != null)

                         return new ClsPerson(PersonDTO,enMode.Update) ;
                  else 
                   return null;
                  

            }
      



           public ClsPerson? FindPersonDTO(int id , string name){

            iPerson? PersonDTO =  clsPersonData.Find(id,name);

                  if(PersonDTO != null){
                   this.PersonID = PersonDTO.PersonID;
                    this.Name = PersonDTO.Name;
                     this.Email = PersonDTO.Email;
                      this.BirthDay = PersonDTO.BirthDay;
                       this.Phone = PersonDTO.Phone;
                        this.gender = PersonDTO.gender;
                         this.Image = PersonDTO.Image;

                this.Mode = enMode.Update;

                         return this ;

                  }
                  else{
                    

                         return null;
                  }

            }
             public static iPerson? FindPersonDTO(int id){

            iPerson? PersonDTO =  clsPersonData.Find(id);

                  if(PersonDTO != null)
                         return PersonDTO ;
                  else 
                   return null;
                  

            }
           protected bool  _AddNewPerson(){

            iPerson newperson = clsPersonData.AddNewPerson(PerDTO);
            
            if(newperson != null){       
            this.PersonID = newperson.PersonID;
            this.Name = newperson.Name;
            this.BirthDay = newperson.BirthDay;
            this.Email = newperson.Email;
            this.gender = newperson.gender;
            this.Phone = newperson.Phone;
            this.Image = newperson.Image;

                return true;
            }
             else{
                return false;
             }

             

           }
           protected bool _UpdatePerson(){

            if(clsPersonData.UpdatePerson(PerDTO))
                return true;
                
                else
                return false;
           } 

            
            protected bool _DeletePerson(){

                return clsPersonData.DeletePerson(this.PersonID);

            }
           
    
            public bool Save(){
                switch(Mode){
                    case enMode.AddNew:
                    return  this._AddNewPerson();       
                    
                     case enMode.Update:
                      return this._UpdatePerson();
                         case enMode.Delete: 
                         return this._DeletePerson();

                }
                return false;
            }
        


    }
}