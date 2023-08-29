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
        /// �������� �������� ������� ��� ���������� datagrid
        /// </summary>
        private void GenerateData() {

            GenerateUsersData();
            GenerateOrganizationsData();
            GenerateProfessionsData();
            GenerateCitiesData();
        }

        /// <summary>
        /// �������� �������� ��� �������������
        /// </summary>
        private void GenerateUsersData() {

            usersList = new BindingList<Users> {
                new Users(1, "������", "�����", 1, 7, 1),
                new Users(2, "����", "������", 8, 1, 2),
                new Users(3, "����", "������", 2, 1, 4),
                new Users(4, "������", "�����", 3, 3, 5),
                new Users(5, "��������", "�������", 7, 6, 3),
                new Users(6, "������", "�������", 4, 4, 2),
                new Users(7, "������", "�������", 5, 7, 1)
            };
        }

        /// <summary>
        /// �������� �������� ��� �����������
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
        /// �������� �������� ��� ���������
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
        /// �������� �������� ��� �������
        /// </summary>
        private void GenerateCitiesData() {

            citiesList = new BindingList<Cities> {
                new Cities(1, "������"),
                new Cities(2, "�����-���������"),
                new Cities(3, "�����������"),
                new Cities(4, "����"),
                new Cities(5, "������������"),
                new Cities(6, "������"),
                new Cities(7, "�����")
            };
        }

        /// <summary>
        /// �������� ������� � ���������� ������� ��� ���� datagrid
        /// </summary>
        private void FillDataGridColumns() {

            FillDataGridForUser();
            FillDataGridForOrganizations();
            FillDataGridForCities();
            FillDataGridForProfessions();
        }

        /// <summary>
        /// ��������� datagrid ��� �������������
        /// </summary>
        private void FillDataGridForUser() {

            // ���������� ������� � datagrid
            dataGridUser.Columns.Add("UserId", "Id ������������");
            dataGridUser.Columns.Add("UserFirstName", "��� ������������");
            dataGridUser.Columns.Add("UserLastName", "������� ������������");
            dataGridUser.Columns.Add("UserProfessionId", "Id ���������");
            dataGridUser.Columns.Add("UserCityId", "Id ������");
            dataGridUser.Columns.Add("UserOrganizationId", "Id �����������");

            // �������� ������ � ��������
            dataGridUser.Columns["UserId"].DataPropertyName = "Id";
            dataGridUser.Columns["UserFirstName"].DataPropertyName = "FirstName";
            dataGridUser.Columns["UserLastName"].DataPropertyName = "LastName";
            dataGridUser.Columns["UserProfessionId"].DataPropertyName = "ProfessionId";
            dataGridUser.Columns["UserCityId"].DataPropertyName = "CityId";
            dataGridUser.Columns["UserOrganizationId"].DataPropertyName = "OrganizationId";

            // �������� ���������� ������
            dataGridUser.DataSource = usersList;
        }

        /// <summary>
        /// ��������� datagrid ��� �����������
        /// </summary>
        private void FillDataGridForOrganizations() {

            // ���������� ������� � datagrid
            dataGridOrganization.Columns.Add("OrganizationId", "Id �����������");
            dataGridOrganization.Columns.Add("OrganizationName", "�������� �����������");
            dataGridOrganization.Columns.Add("OrganizationOGRN", "���� �����������");

            // �������� ������ � ��������
            dataGridOrganization.Columns["OrganizationId"].DataPropertyName = "Id";
            dataGridOrganization.Columns["OrganizationName"].DataPropertyName = "OrganizationName";
            dataGridOrganization.Columns["OrganizationOGRN"].DataPropertyName = "OGRN";

            // �������� ���������� ������
            dataGridOrganization.DataSource = organizationsList;
        }

        /// <summary>
        /// ��������� datagrid ��� �������
        /// </summary>
        private void FillDataGridForCities() {

            // ���������� ������� � datagrid
            dataGridCity.Columns.Add("CityId", "Id ������");
            dataGridCity.Columns.Add("CityName", "�����");

            // �������� ������ � ��������
            dataGridCity.Columns["CityId"].DataPropertyName = "Id";
            dataGridCity.Columns["CityName"].DataPropertyName = "CityName";

            // �������� ���������� ������
            dataGridCity.DataSource = citiesList;
        }

        /// <summary>
        /// ��������� datagrid ��� ���������
        /// </summary>
        private void FillDataGridForProfessions() {

            // ���������� ������� � datagrid
            dataGridProfession.Columns.Add("ProfessionId", "Id ���������");
            dataGridProfession.Columns.Add("ProfessionName", "���������");
            dataGridProfession.Columns.Add("ProfessionSalary", "���������� �����");

            // �������� ������ � ��������
            dataGridProfession.Columns["ProfessionId"].DataPropertyName = "Id";
            dataGridProfession.Columns["ProfessionName"].DataPropertyName = "Profession";
            dataGridProfession.Columns["ProfessionSalary"].DataPropertyName = "Salary";

            // �������� ���������� ������
            dataGridProfession.DataSource = professionsList;
        }
    }
}