using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goznak_test_task.Models {

    /// <summary>
    /// Класс для представления профессии
    /// </summary>
    public class Professions {

        /// <summary>
        /// Id профессии
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Название профессии
        /// </summary>
        public string Profession { get; private set; }

        /// <summary>
        /// Заработная плата для профессии
        /// </summary>
        public Decimal Salary { get; private set; }

        /// <summary>
        /// Профессия
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="profession">Название</param>
        /// <param name="salary">Заработная плата</param>
        public Professions(int id, string profession, decimal salary) {
            Id = id;
            Profession = profession;
            Salary = salary;
        }
    }
}
