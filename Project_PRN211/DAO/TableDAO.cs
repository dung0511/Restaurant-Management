using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN211.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }


        public List<TableFood> LoadTableList()
        {
            List<TableFood> tableList = new List<TableFood>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.TableFood");

            foreach (DataRow item in data.Rows)
            {
                TableFood table = new TableFood(item);
                tableList.Add(table);
            }

            return tableList;
        }

    }
}
