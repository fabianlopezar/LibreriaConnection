using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConnection.models;

namespace LibreriaConnection.controller
{
    class ControllerCuentas
    {
        /*internal List<Cuentas> SelectCuentas()
        {

        }*/
        internal List<Cuentas> SelectCuentas()
        {
            List<Cuentas> listaCuentas = null;
            ConnectDB objCBD = new ConnectDB();
            string sql = "select * from cuentas;";
            listaCuentas = objCBD.SelectCuentas(sql);

            return listaCuentas;
        }
    }
}
