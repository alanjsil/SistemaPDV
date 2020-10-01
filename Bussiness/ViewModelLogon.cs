using MySql.Data.MySqlClient;

namespace Bussiness
{
    public class ViewModelLogon
    {
        public static bool Logar(string user, string pass)
        {
            string banco, login, senha;
            banco = "localhost";
            login = "root";
            senha = "Down1oad";

            MySqlConnection cx = new MySqlConnection("server =" + banco + "; user id=" + login + "; database = gestaonegocio; Password =" + senha);
            MySqlCommand cmd = new MySqlCommand();
            cx.Open();

            cmd.Connection = cx;
            cmd.CommandText = "SELECT * FROM users WHERE login  = @login AND password = @password";
            cmd.Parameters.Add("login", MySqlDbType.Text).Value = user;
            cmd.Parameters.Add("password", MySqlDbType.Text).Value = pass;
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                return true;
            }
            else
            {
                cx.Close();
                return false;
            }
        }
    }
}
