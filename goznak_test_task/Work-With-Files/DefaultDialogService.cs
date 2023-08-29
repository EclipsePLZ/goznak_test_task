using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goznak_test_task.Work_With_Files.Interfaces {
    public class DefaultDialogService : IDialogService {

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FolderPath { get; set; }

        /// <summary>
        /// Диалог для сохранения файла .xls
        /// </summary>
        /// <returns>Результат успешного сохранения файла</returns>
        public bool SaveFolderDialog() {
            using (FolderBrowserDialog saveFolderDialog = new FolderBrowserDialog()) {
                if (saveFolderDialog.ShowDialog() == DialogResult.OK) {
                    FolderPath = saveFolderDialog.SelectedPath;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Показать сообщение
        /// </summary>
        /// <param name="message">Сообщение</param>
        public void ShowMessage(string message) {
            MessageBox.Show(message);
        }
    }
}
