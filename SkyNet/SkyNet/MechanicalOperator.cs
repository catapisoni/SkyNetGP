using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    public class MechanicalOperator
    {
        private string id;
        private Battery battery;
        private string status;
        private float maxLoad;
        private float optimalSpeed;
        private string currentLocation;
        private Location location;
        //agregue
        private double currentLoadBattery;
        private float currentLoadKg;


        public string Id { get; set; }
        public Battery Battery { get; set; }
        public string Status { get; set; }
        public float MaxLoad { get; set; }
        public float OptimalSpeed { get; set; }
        public string CurrentLocation { get; set; }

        public int CurrentLoadBattery { get; set; }
        public float CurrentoLoadKg { get; set; }

        public MechanicalOperator()
        {
            this.id = string.Empty;
            this.battery = new Battery();
            this.Status = string.Empty;
            this.maxLoad = 0;
            this.optimalSpeed = 0;
            this.currentLocation = string.Empty;
            this.currentLoadBattery = 0;
            this.currentLoadKg = 0;
        }

        public void MoveTo(string destination, double distance)
        {
            if (destination == this.currentLocation)
            {
                Console.WriteLine("No puede enviar el robot al mismo destino donde ya se encuentra");
            }
            if (destination != this.currentLocation)
            {

            }
        }
        //metodo para reducir bateria 
        public void ReduceChargeBaterryPerKm(double distance)
        {
            double distancePorcentage = 15;
            double decreasePorcentage = 5;

            currentLoadBattery -= (distance / distancePorcentage) * decreasePorcentage;

            Console.WriteLine($"Nivel actual de bateria {currentLoadBattery}");

        }

        public void TransferBattery(MechanicalOperator destination, int amount)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException($"La batería actual es de {this.currentLoadBattery}, no se puede hacer la transferencia");
            }

            // Compara las ubicaciones de los robots
            if (this.CurrentLocation == destination.currentLocation)
            {
                Console.WriteLine("Es posible realizar transferencia de bateria");
                Console.WriteLine($"La bateria del {this.Id} es {this.battery.ToString} con una carga actual de {this.currentLoadBattery}%");
                Console.WriteLine($"La bateria del {destination} es {destination.battery.ToString} con una carga actual de {destination.currentLoadBattery}%");

                // Verifica que la carga del robot no sea menor a 0
                if (amount > this.Battery.GetMAHCapacity())
                {
                    throw new InvalidOperationException("La cantidad a transferir excede la capacidad de la batería actual.");
                }


                // Actualizar la cantidad de bateria en la instancia actual
                this.currentLoadBattery -= amount;

                // Incrementar la cantidad de bateria en la instancia de destino
                destination.currentLoadBattery += amount;

                Console.WriteLine($"El robot {this} actualmente posee una carga de {this.currentLoadBattery}%, mientras que el robot {destination} " +
                    $"posee una carga de {destination.currentLoadBattery}%");
            }
            else
            {
                Console.WriteLine("Los robots se encuentran en ubicaciones diferentes, no es posible realizar la transferencia");
            }
        }

        public void TransferLoad(MechanicalOperator destination, float amount)
        {
            if (amount > this.maxLoad)
            {
                Console.WriteLine($"La capacidad maxima del robot {this.id} es de {this.maxLoad}, no es posible asignarle el peso que desea");
            }
            else if ((amount + currentLoadKg) < this.maxLoad && this.CurrentLocation == destination.currentLocation)
            {
                Console.WriteLine("Es posible realizar transferencia de carga");
                Console.WriteLine($"La capacidad maxima de carga de peso del robot {this.Id} es {this.maxLoad} " +
                    $"con una carga actual de {this.currentLoadKg} Kg.");
                Console.WriteLine($"La capacidad maxima de carga de peso del robot {destination} es {destination.maxLoad}" +
                    $" con una carga actual de {destination.currentLoadKg}");

                this.currentLoadKg -= amount;

                // Incrementar la cantidad de bateria en la instancia de destino
                destination.currentLoadKg += amount;

                Console.WriteLine($"El robot {this} actualmente posee una carga de {this.currentLoadKg}Kg, mientras que el robot {destination} " +
                    $"posee una carga de {destination.currentLoadKg}Kg");
            }
            else
            {
                Console.WriteLine("Los robots se encuentran en ubicaciones diferentes, no es posible realizar la transferencia");
            }
        }

        public void ReturnToHQandRemoveLoad()
        {

        }

        public void ReturnToHQandChargeBattery()
        {

        }

        public void LoadLoad(float carga)
        {

        }

    }
}
