using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.AutomovilException
{
    public class ListModelsCar
    {

        public static readonly HashSet<string> ValidModels = new HashSet<string>
    {
        "Sedan",
        "SUV",
        "Truck",
        "Hatchback",
        "Coupe",
        "Convertible",
        "Wagon",
        "Van",
        "Electric",
        "Hybrid"
    };

    }
}
