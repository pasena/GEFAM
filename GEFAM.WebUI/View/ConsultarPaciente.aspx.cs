using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GEFAM.Domain.Entities;

namespace GEFAM.WebUI.View
{
    public partial class ConsultarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Paciente> pacientes = new List<Paciente>
            {
                new Paciente { Nome="Paulo Alex Sena", CPF=00123054567, NomeMae="Maria Antônia de Jesus Sena"},
                new Paciente { Nome="Paulo Alex Sena", CPF=00123054567, NomeMae="Maria Antônia de Jesus Sena"}
            };

            this.grvResultado.DataSource = pacientes.Select(s => new { s.Nome, s.CPF, s.NomeMae });
            this.grvResultado.DataBind();
        }
    }
}