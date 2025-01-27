using Domain.Exceptions.AutomovilException;
using Domain.Exceptions.CarException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        
        public CarModel
            (
                int id,
                string name,
                string model
                
            )

        {
            Id = id;
            Name = name;
            Model = model;
            
        }


        public bool IsValidModelCar(string modelCar)
        {
            if (string.IsNullOrWhiteSpace(modelCar))
            {
                return false;
            }

            return ListModelsCar.ValidModels.Contains(modelCar);
        }

        public void ValidateModelCar(string modelCar)
        {
            if (!IsValidModelCar(modelCar))
            {
                throw new InvalidCarModelException($"Model car invalid: {modelCar}");
            }
        }


    }
}
