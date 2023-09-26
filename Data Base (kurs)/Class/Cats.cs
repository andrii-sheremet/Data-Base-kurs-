using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Base__kurs_.Class
{
    internal struct Cat
    {
        // Основні властивості кота
        public int Id { get; set; }
        public int FotoId { get; set; }
        public string Name { get; set; } // Ім'я кота
        public string Breed { get; set; } // Порода
        public int Age { get; set; } // Вік
        public string Color { get; set; } // Колір шерсті
        public string Description { get; set; } // Опис кота

        // Додаткові властивості для характеристик породи
        public string Origin { get; set; } // Походження породи
        public string Temperament { get; set; } // Темперамент
        public string Lifespan { get; set; } // Тривалість життя
        public string Width { get; set; } // Вага
        public string Size { get; set; } // Розмір
        public string Grooming { get; set; } // Догляд за шерстю
    }
}
