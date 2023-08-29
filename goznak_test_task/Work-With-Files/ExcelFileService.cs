using goznak_test_task.Work_With_Files.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goznak_test_task.Work_With_Files {
    public class ExcelFileService : IFileService {

        /// <summary>
        /// Сохранить datagrid в excel file
        /// </summary>
        /// <param name="filename">Путь к файлу</param>
        /// <param name="dataGrid">DataGridView</param>
        public void Save(string filename, DataGridView dataGrid) {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Создание нового пакета Excel
            using (ExcelPackage package = new ExcelPackage()) {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Лист1");

                // Запись заголовков из DataGridView
                for (int i = 0; i < dataGrid.Columns.Count; i++) {
                    worksheet.Cells[1, i + 1].Value = dataGrid.Columns[i].HeaderText;
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                }

                // Запись данных из DataGridView
                for (int i = 0; i < dataGrid.Rows.Count; i++) {
                    for (int j = 0; j < dataGrid.Columns.Count; j++) {
                        worksheet.Cells[i + 2, j + 1].Value = dataGrid.Rows[i].Cells[j].Value;
                    }
                }

                // Автонастройка размеров столбцов
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Сохранение файла
                package.SaveAs(new FileInfo(filename));
            }

            // Открытие файла в приложении по умолчанию
            // Не получилось сделать через Interop, поэтому сделал через консоль
            System.Diagnostics.Process.Start("cmd.exe", "/c start \"\" \"" + filename + "\"");
        }
    }
}
