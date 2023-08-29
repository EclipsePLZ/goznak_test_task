using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goznak_test_task.Work_With_Files.Interfaces {
    public interface IDialogService {

        /// <summary>
        /// Показать сообщение
        /// </summary>
        /// <param name="message">Сообщение</param>
        void ShowMessage(string message);

        /// <summary>
        /// Путь к файлу
        /// </summary>
        string FolderPath { get; set; }

        /// <summary>
        /// Диалог для сохранения файла
        /// </summary>
        /// <returns>Результат успешного сохранения файла</returns>
        bool SaveFolderDialog();
    }
}
