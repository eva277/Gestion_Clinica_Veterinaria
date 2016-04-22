using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    [PropertyChanged.ImplementPropertyChanged]
    public class Mascota : PropertyValidateModel
    {
        public int MascotaId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        public string Nombre { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(30)]
        public string Especie { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(40)]
        public string Raza { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Sexo { get; set; }
        public string Pelaje { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        
        public string Edad
        {
            get
            {
                return GetAge(FechaNacimiento);
            }
        }
        public byte[] Foto { get; set; }
        [Required]
        public bool Activo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual ICollection<AvisoCita> ListaAvisosCita { get; set; }
        public virtual ICollection<RegistroHotel_Hospital> ListaRegistroHotel_Hospital { get; set; }

        public Mascota()
        {
            ListaAvisosCita = new Collection<AvisoCita>();
            ListaRegistroHotel_Hospital = new Collection<RegistroHotel_Hospital>();
        }
        private string GetAge(DateTime Bday)
        {
            int Years;
            int Months;
            int Days;
            DateTime Cday=DateTime.Today;

            if ((Cday.Year - Bday.Year) > 0 ||
                (((Cday.Year - Bday.Year) == 0) && ((Bday.Month < Cday.Month) ||
                  ((Bday.Month == Cday.Month) && (Bday.Day <= Cday.Day)))))
            {
                int DaysInBdayMonth = DateTime.DaysInMonth(Bday.Year, Bday.Month);
                int DaysRemain = Cday.Day + (DaysInBdayMonth - Bday.Day);

                if (Cday.Month > Bday.Month)
                {
                    Years = Cday.Year - Bday.Year;
                    Months = Cday.Month - (Bday.Month + 1) + Math.Abs(DaysRemain / DaysInBdayMonth);
                    Days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                }
                else if (Cday.Month == Bday.Month)
                {
                    if (Cday.Day >= Bday.Day)
                    {
                        Years = Cday.Year - Bday.Year;
                        Months = 0;
                        Days = Cday.Day - Bday.Day;
                    }
                    else
                    {
                        Years = (Cday.Year - 1) - Bday.Year;
                        Months = 11;
                        Days = DateTime.DaysInMonth(Bday.Year, Bday.Month) - (Bday.Day - Cday.Day);
                    }
                }
                else
                {
                    Years = (Cday.Year - 1) - Bday.Year;
                    Months = Cday.Month + (11 - Bday.Month) + Math.Abs(DaysRemain / DaysInBdayMonth);
                    Days = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                }
            }
            else
            {
                throw new ArgumentException("Birthday date must be earlier than current date");
            }

            return Years + " años, " + Months + " meses, " + Days + " dias"; ;
        }

    }
}
