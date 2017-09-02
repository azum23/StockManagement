using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.BL
{
    public static class CommonPart
    {
        public static string GetConnectionString()
        {
            //  TODO: сделать через конфигурационный файл
            return @"Data Source=DESKTOP-9F1EJ9L;Initial Catalog=Stock;Integrated Security=True";
        }
    }
}
