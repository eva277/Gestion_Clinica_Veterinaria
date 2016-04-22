using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    class PropertyValidateModel: IDataErrorInfo
    {
        // check for general model error    
        public string Error { get { return null; } }

        // check for property errors    
        public string this[string columnName]
        {
            get
            {
                var validationResults = new List<ValidationResult>();

                if (Validator.TryValidateProperty(
                        GetType().GetProperty(columnName).GetValue(this)
                        , new ValidationContext(this)
                        {
                            MemberName = columnName
                        }
                        , validationResults))
                    return null;

                return validationResults.First().ErrorMessage;
            }
        }
        public String errrores(Object obj)
        {
            String mensError = "";


            ValidationContext validationContext = new ValidationContext(obj, null, null);
            List<System.ComponentModel.DataAnnotations.ValidationResult> errores = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            Validator.TryValidateObject(obj, validationContext, errores, true);

            if (errores.Count() > 0)
            {

                string mensageErrores = string.Empty;
                foreach (var error in errores)
                {
                    error.MemberNames.First();

                    mensError += error.ErrorMessage + Environment.NewLine;
                }
                return mensError;
            }
            else
            {
                return mensError;


            }

        }
    }
}

