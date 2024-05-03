using Libreria.Models;
using LibreriaConnection.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.controller
{    // Luis
    internal class ControllerPaises
    {
        internal List<Paises> SelectPais()
        {
            List<Paises> listaP = null;
            ConnectDB objCBD = new ConnectDB();
            string sql = "select * from paises;";
            listaP = objCBD.SelectPais(sql);
            return listaP;
        }

        internal bool UpdatePaises(Paises objPaises)
        {
            bool result = false;

            string sql = "update paises set nombrePais='" + objPaises.NombrePais + "' WHERE idPais=" + objPaises.IdPais;

            ConnectDB objCBD = new ConnectDB();
            result = objCBD.ExecuteQuery(sql);

            return result;  
        }

        internal List<Paises> SelectPaisC()
        {
            List<Paises> listaPC = null;
            
            string sql = "select * from paises;";
            Paises objP = new Paises();
            listaPC=objP.SelectPaisC(sql);
            
            return listaPC;
        }
    }
}
