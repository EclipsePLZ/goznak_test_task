using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goznak_test_task.Models {

    /// <summary>
    /// Класс для представления организации
    /// </summary>
    public class Organizations {

        /// <summary>
        /// Id организации
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Название организации
        /// </summary>
        public string OrganizationName { get; private set; }

        /// <summary>
        /// ОГРН организации
        /// </summary>
        public long OGRN { get; private set; }

        /// <summary>
        /// Организация
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="organizationName">Название организации</param>
        /// <param name="ogrn">ОГРН организации</param>
        public Organizations(int id, string organizationName, long ogrn) {
            Id = id;
            OrganizationName = organizationName;
            OGRN = ogrn;
        } 
    }
}
