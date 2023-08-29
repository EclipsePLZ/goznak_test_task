using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goznak_test_task.Work_With_Files.Interfaces {
    public interface IFileService {
        void Save(string filename, DataGridView dataGrid);
    }
}
