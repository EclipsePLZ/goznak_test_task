using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goznak_test_task.Models {

    /// <summary>
    /// Класс для представления городов
    /// </summary>
    public class Cities {

        /// <summary>
        /// Id города
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Название города
        /// </summary>
        public string CityName { get; private set; }

        /// <summary>
        /// Город
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="cityName">Название</param>
        public Cities (int id, string cityName) {
            Id = id;
            CityName = cityName;
        }   
    }
}
