using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi
{
    public class Statistics 
    {
        #region instance
        private static Statistics instance = null;

        public static Statistics Instance
        {
            get
            {
                instance ??= new Statistics();
                return instance;
            }
        }
        #endregion

        #region get data from menu
        public void GetTodayMostSellingDishes(Type type)
        {

        }
        #endregion

        #region get data from database
        #endregion
    }
}
