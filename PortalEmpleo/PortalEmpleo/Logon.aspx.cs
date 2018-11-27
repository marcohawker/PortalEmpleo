using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;

namespace PortalEmpleo
{
	public partial class Logon : System.Web.UI.Page
	{
		private bool ValidateUser(string userName, string passWord)
		{
			SqlConnection conn;
			SqlCommand cmd;
			string lookupPassword = null;

			// Buscar nombre de usuario no válido.
			// el nombre de usuario no debe ser un valor nulo y debe tener entre 1 y 15 caracteres.
			if ((null == userName) || (0 == userName.Length) || (userName.Length > 15))
			{
				System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of userName failed.");
				return false;
			}

			// Buscar contraseña no válida.
			// La contraseña no debe ser un valor nulo y debe tener entre 1 y 25 caracteres.
			if ((null == passWord) || (0 == passWord.Length) || (passWord.Length > 25))
			{
				System.Diagnostics.Trace.WriteLine("[ValidateUser] Input validation of passWord failed.");
				return false;
			}

			try
			{
				// Consultar con el administrador de SQL Server para obtener una conexión apropiada
				// cadena que se utiliza para conectarse a su SQL Server local.
				conn = new SqlConnection("server=localhost; Initial Catalog = PortaEmpleo; Integrated Security=SSPI;database=PortalEmpleo");
				conn.Open();

				// Crear SqlCommand para seleccionar un campo de contraseña desde la tabla de usuarios dado el nombre de usuario proporcionado.
				cmd = new SqlCommand("Select UsrClave from Usuario where UsrRut=@userName", conn);
				cmd.Parameters.Add("@userName", SqlDbType.VarChar, 25);
				cmd.Parameters["@userName"].Value = userName;

				// Ejecutar el comando y capturar el campo de contraseña en la cadena lookupPassword.
				lookupPassword = (string)cmd.ExecuteScalar();

				// Comando de limpieza y objetos de conexión.
				cmd.Dispose();
				conn.Dispose();
			}
			catch (Exception ex)
			{
				// Agregar aquí un control de errores para la depuración.
				// Este mensaje de error no debería reenviarse al que realiza la llamada.
				System.Diagnostics.Trace.WriteLine("[ValidateUser] Exception " + ex.Message);
			}

			// Si no se encuentra la contraseña, devuelve false.
			if (null == lookupPassword)
			{
				// Para más seguridad, puede escribir aquí los intentos de inicio de sesión con error para el registro de eventos.
				return false;
			}

			// Comparar lookupPassword e introduzca passWord, usando una comparación que distinga mayúsculas y minúsculas.
			return (0 == string.Compare(lookupPassword, passWord, false));

		}

		private void cmdLogin_ServerClick(object sender, System.EventArgs e)
		{
			if (ValidateUser(txtUserName.Value, txtUserPass.Value))
				FormsAuthentication.RedirectFromLoginPage(txtUserName.Value,
				chkPersistCookie.Checked);
			else
				Response.Redirect("Logon.aspx", true);
			this.cmdLogin.ServerClick += new System.EventHandler(this.cmdLogin_ServerClick);
		}
	}
}