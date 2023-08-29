using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goznak_test_task.Models {

    /// <summary>
    /// Класс для представления пользователя
    /// </summary>
    public class Users {
        
        /// <summary>
        /// Id пользователя
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// Id профессии
        /// </summary>
        public int ProfessionId { get; private set; }

        /// <summary>
        /// Id города
        /// </summary>
        public int CityId { get; private set; }

        /// <summary>
        /// Id организации
        /// </summary>
        public int OrganizationId { get; private set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="professionId">Id профессии</param>
        /// <param name="cityId">Id города</param>
        /// <param name="organizationId">Id организации</param>
        public Users(int id, string firstName, string lastName, int professionId, int cityId, int organizationId) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            ProfessionId = professionId;
            CityId = cityId;
            OrganizationId = organizationId;
        }   
    }
}
