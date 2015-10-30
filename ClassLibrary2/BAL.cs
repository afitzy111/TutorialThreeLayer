using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace Service

{
    public class BAL
    {
        private int id;
        private int year_ref;
        private int rainfallFullYear;
        private int outflowFullYear;
        private int rainfallWinter;
        private int outflowWinter;
        private int rainfallSummer;
        private int outflowSummer;

        public int Id { get; set; }
        public int Year_ref { get; set; }
        public int RainfallFullYear { get; set; }
        public int OutflowFullYear { get; set; }
        public int RainfallWinter { get; set; }
        public int OutflowWinter { get; set; }
        public int RainfallSummer { get; set; }
        public int OutflowSummer { get; set; }

        public DataSet view()
        {
            try
            {
                DAL dbObject = new DAL();
                DataSet ds = dbObject.FetchView();
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
