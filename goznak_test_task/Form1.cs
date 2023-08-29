using goznak_test_task.Models;
using System.ComponentModel;

namespace goznak_test_task {
    public partial class MainForm : Form {

        private BindingList<Users> usersList;
        private BindingList<Organizations> organizationsList;
        private BindingList<Professions> professionsList;
        private BindingList<Cities> citiesList;

        public MainForm() {
            InitializeComponent();

            GenerateData();
            FillDataGridColumns();
        }

        /// <summary>
        /// Создание объектов классов для заполнения datagrid
        /// </summary>
        private void GenerateData() {

            GenerateUsersData();
            GenerateOrganizationsData();
            GenerateProfessionsData();
            GenerateCitiesData();
        }

        /// <summary>
        /// Создание объектов для пользователей
        /// </summary>
        private void GenerateUsersData() {

            usersList = new BindingList<Users> {
                new Users(1, "Андрей", "Попов", 1, 7, 1),
                new Users(2, "Иван", "Петров", 8, 1, 2),
                new Users(3, "Петр", "Иванов", 2, 1, 4),
                new Users(4, "Леонид", "Орлов", 3, 3, 5),
                new Users(5, "Анатолий", "Сидоров", 7, 6, 3),
                new Users(6, "Сергей", "Новиков", 4, 4, 2),
                new Users(7, "Никита", "Сергеев", 5, 7, 1)
            };
        }

        /// <summary>
        /// Создание объектов для организаций
        /// </summary>
        private void GenerateOrganizationsData() {

            organizationsList = new BindingList<Organizations> {
                new Organizations(1, "Simpl", 6559751141667),
                new Organizations(2, "Sber", 1867824741459),
                new Organizations(3, "Mars", 8270862837356),
                new Organizations(4, "ANABAR", 9067263572551),
                new Organizations(5, "Mad Devs", 5809459412668)
            };
        }

        /// <summary>
        /// Создание объектов для профессий
        /// </summary>
        private void GenerateProfessionsData() {

            professionsList = new BindingList<Professions> {
                new Professions(1, "Backend-developer", 110000.00M),
                new Professions(2, "Data Scientist", 150000.00M),
                new Professions(3, "Product Manager", 120000.00M),
                new Professions(4, "Data Analyst", 100000.00M),
                new Professions(5, "Frontend-developer", 95000.00M),
                new Professions(6, "Android-developer", 115000.00M),
                new Professions(7, "IOS-developer", 130000.00M),
                new Professions(8, "Data Engineer", 125000.00M)
            };
        }

        /// <summary>
        /// Создание объектов для городов
        /// </summary>
        private void GenerateCitiesData() {

            citiesList = new BindingList<Cities> {
                new Cities(1, "Москва"),
                new Cities(2, "Санкт-Петербург"),
                new Cities(3, "Новосибирск"),
                new Cities(4, "Сочи"),
                new Cities(5, "Екатеринбург"),
                new Cities(6, "Казань"),
                new Cities(7, "Пермь")
            };
        }

        /// <summary>
        /// Создание колонок и заполнение данными для всех datagrid
        /// </summary>
        private void FillDataGridColumns() {

            FillDataGridForUser();
            FillDataGridForOrganizations();
            FillDataGridForCities();
            FillDataGridForProfessions();
        }

        /// <summary>
        /// Заполнить datagrid для пользователей
        /// </summary>
        private void FillDataGridForUser() {

            // Добавление колонок в datagrid
            dataGridUser.Columns.Add("UserId", "Id пользователя");
            dataGridUser.Columns.Add("UserFirstName", "Имя пользователя");
            dataGridUser.Columns.Add("UserLastName", "Фамилия пользователя");
            dataGridUser.Columns.Add("UserProfessionId", "Id профессии");
            dataGridUser.Columns.Add("UserCityId", "Id города");
            dataGridUser.Columns.Add("UserOrganizationId", "Id организации");

            // Привязка данных к столбцам
            dataGridUser.Columns["UserId"].DataPropertyName = "Id";
            dataGridUser.Columns["UserFirstName"].DataPropertyName = "FirstName";
            dataGridUser.Columns["UserLastName"].DataPropertyName = "LastName";
            dataGridUser.Columns["UserProfessionId"].DataPropertyName = "ProfessionId";
            dataGridUser.Columns["UserCityId"].DataPropertyName = "CityId";
            dataGridUser.Columns["UserOrganizationId"].DataPropertyName = "OrganizationId";

            // Привязка источников данных
            dataGridUser.DataSource = usersList;
        }

        /// <summary>
        /// Заполнить datagrid для организаций
        /// </summary>
        private void FillDataGridForOrganizations() {

            // Добавление колонок в datagrid
            dataGridOrganization.Columns.Add("OrganizationId", "Id организации");
            dataGridOrganization.Columns.Add("OrganizationName", "Название организации");
            dataGridOrganization.Columns.Add("OrganizationOGRN", "ОГРН организации");

            // Привязка данных к столбцам
            dataGridOrganization.Columns["OrganizationId"].DataPropertyName = "Id";
            dataGridOrganization.Columns["OrganizationName"].DataPropertyName = "OrganizationName";
            dataGridOrganization.Columns["OrganizationOGRN"].DataPropertyName = "OGRN";

            // Привязка источников данных
            dataGridOrganization.DataSource = organizationsList;
        }

        /// <summary>
        /// Заполнить datagrid для городов
        /// </summary>
        private void FillDataGridForCities() {

            // Добавление колонок в datagrid
            dataGridCity.Columns.Add("CityId", "Id города");
            dataGridCity.Columns.Add("CityName", "Город");

            // Привязка данных к столбцам
            dataGridCity.Columns["CityId"].DataPropertyName = "Id";
            dataGridCity.Columns["CityName"].DataPropertyName = "CityName";

            // Привязка источников данных
            dataGridCity.DataSource = citiesList;
        }

        /// <summary>
        /// Заполнить datagrid для профессий
        /// </summary>
        private void FillDataGridForProfessions() {

            // Добавление колонок в datagrid
            dataGridProfession.Columns.Add("ProfessionId", "Id профессии");
            dataGridProfession.Columns.Add("ProfessionName", "Профессия");
            dataGridProfession.Columns.Add("ProfessionSalary", "Заработная плата");

            // Привязка данных к столбцам
            dataGridProfession.Columns["ProfessionId"].DataPropertyName = "Id";
            dataGridProfession.Columns["ProfessionName"].DataPropertyName = "Profession";
            dataGridProfession.Columns["ProfessionSalary"].DataPropertyName = "Salary";

            // Привязка источников данных
            dataGridProfession.DataSource = professionsList;
        }
    }
}