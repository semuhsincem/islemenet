using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Datatable
{
    public class DataTableAjaxPostModel
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<Column> columns { get; set; }
        public Search search { get; set; }
        public List<Order> order { get; set; }
        public DataTableAjaxPostModel()
        {
            columns = new List<Column>();
            order = new List<Order>();
            search = new Search();
        }
    }
}
