using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        private static List<Equipment> equipments = new List<Equipment>();
        public static IQueryable<Equipment> Equipments
        {
            get
            {
                return equipments.AsQueryable();
            }
        }

        static Equipment()
        {
            Equipment.equipments.Add(new Equipment { Id = 1, Name = "Training Bench", Price = 125}
                );
            Equipment.equipments.Add(new Equipment { Id = 2, Name = "Treadmill", Price = 100 }
                );
            Equipment.equipments.Add(new Equipment { Id = 3, Name = "Barbell Set", Price = 97 }
                );
            Equipment.equipments.Add(new Equipment { Id = 4, Name = "Rowing Machine", Price = 84 }
                );
            Equipment.equipments.Add(new Equipment { Id = 5, Name = "Dumbbell Set", Price = 33 }
                );
        }

        public static void Save(Equipment equipment)
        {
            Equipment existingEquipment = Equipment.equipments.Find(e => e.Id == equipment.Id);
            if(existingEquipment != null)
            {
                existingEquipment.Name = equipment.Name;
                existingEquipment.Price = equipment.Price;
            }
            else
            {
                int biggestId = Equipment.Equipments.Max(e => e.Id);
                equipment.Id = biggestId + 1;
                equipments.Add(equipment);
            }
        }

        public static bool Delete(int id)
        {
            var existingEquipment = Equipment.equipments.Find(e => e.Id == id);
            if(existingEquipment != null)
            {
                return Equipment.equipments.Remove(existingEquipment);
            }
            return false;
        }
    }
}
