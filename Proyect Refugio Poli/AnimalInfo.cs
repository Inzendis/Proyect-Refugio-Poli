using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect_Refugio_Poli
{
    public class AnimalInfo
    {
        private string petName;
        private string petPhotoName;
        private string petType;
        private string petColor;
        private string gender;
        private bool isSterilized;
        private string pedigree;
        private DateTime dateEntry;
        private List<string> vaccine;


        public AnimalInfo()
        {
            PetName = string.Empty;
            PetPhotoName = string.Empty;
            PetType = string.Empty;
            PetColor = string.Empty;
            Gender = string.Empty;
            isSterilized = false;
            Pedigree = string.Empty;
            DateEntry = new DateTime();
            Vaccine = new List<string>();
        }

        public string PetName { get => petName; set => petName = value; }
        public string PetPhotoName { get => petPhotoName; set => petPhotoName = value; }
        public string PetType { get => petType; set => petType = value; }
        public string PetColor { get => petColor; set => petColor = value; }
        public string Gender { get => gender; set => gender = value; }
        public bool IsSterilized { get => isSterilized; set => isSterilized = value; }
        public string Pedigree { get => pedigree; set => pedigree = value; }
        public DateTime DateEntry { get => dateEntry; set => dateEntry = value; }

        public List<string> Vaccine { get => vaccine; set => vaccine = value; }
    }
}
