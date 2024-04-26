using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Cuentas
    {
     private int idCuenta ;
     private string nombre1Cuenta;
     private string nombre2Cuenta;
     private string apellido1Cuenta;
     private string apellido2Cuenta;
     private string direccionCuenta;
     private string foto;
     private string fechaNacimiento;
     private string contraseniaCuenta;

        public Cuentas()
        {

        }
        public Cuentas(int idCuenta, string nombre1Cuenta, string nombre2Cuenta, string apellido1Cuenta, string apellido2Cuenta, string direccionCuenta, string foto, string fechaNacimiento, string contraseniaCuenta)
        {
            this.idCuenta=idCuenta;
            this.nombre1Cuenta= nombre1Cuenta;
            this.nombre2Cuenta= nombre2Cuenta;
            this.apellido1Cuenta=apellido1Cuenta;
            this.apellido2Cuenta=apellido2Cuenta;
            this.direccionCuenta=direccionCuenta;
            this.foto=foto;
            this.fechaNacimiento=fechaNacimiento;
            this.contraseniaCuenta=contraseniaCuenta;
        }
        public Cuentas(string nombre1Cuenta)
        {
            this.nombre1Cuenta=nombre1Cuenta;
        }
        public Cuentas(string idCuenta string nombre1Cuenta)
        {
            this.idCuenta=idCuenta;
            this.nombre1Cuenta=nombre1Cuenta;
        }
    }
}
