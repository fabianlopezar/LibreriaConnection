using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConnection.models
{
    class Editoriales
    {
        private int idEditoriales;
        private string nombreEditorial;

        public string NombreEditorial { get => nombreEditorial; set => nombreEditorial = value; }
        public int IdEditoriales { get => idEditoriales; set => idEditoriales = value; }

        public Editoriales()
        {
        }

        public Editoriales(string nombreEditorial)
        {
            this.nombreEditorial = nombreEditorial;
        }

        public Editoriales(int idEditoriales, string nombreEditorial)
        {
            this.idEditoriales = idEditoriales;
            this.nombreEditorial = nombreEditorial;
        }
    }
}
