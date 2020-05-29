using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class ConnectionSQLite
    {

        private static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection(@"Data Source = D:\SQL\Avaliacaodbo.db");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        #region Cidade
        public static void Add(Cidadee cidade)
        {
            try
            {

                string sql = "INSERT INTO Cidade  (cidade, estado) values (@Cidade, @Estado)";

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Cidade", cidade.NomeCidade);
                    cmd.Parameters.AddWithValue("@EStado", cidade.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

       
       
        public static DataTable GetCidadeAll()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT cl.IdCidade, ");
            sb.Append("        cl.Cidade, ");
            sb.Append("        cl.Estado ");
            sb.Append("   FROM cidade cl ");
          

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                da.Fill(dt);
            }
            return dt;
        }
        #endregion

        #region Especialidade
        public static void AddEsp(Especialidadee especialidadee)
        {
            try
            {
                
                string sql = "INSERT INTO Esp (    Especialidade )  values (@Especialidade)";
                //INSERT INTO Especialidade(


                //              [Especialidade]
                //          )
                //          VALUES(

                //              'Psico '
                //          );
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Especialidade", especialidadee.NomeEspecialidade);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }


        public static DataTable GetEspecialidadeAll()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT es.IdEsp,");
            sb.Append(" es.Especialidade ");
           sb.Append("   FROM Esp es ");
            

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                da.Fill(dt);
            }
            return dt;
        }
        #endregion

        #region Profissionais 

        public static void AddProfissionais(Profissionaise profissionais)
        {
            try
            {

                string sql = "INSERT INTO Profissional ( Profissional, Cpf, Especialista, Cidade) values (@Profissional, @Cpf, @IdCidade, @IdEsp)";

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Profissional", profissionais.Profissional);
                    cmd.Parameters.AddWithValue("@Cpf", profissionais.Cpf);
                    cmd.Parameters.AddWithValue("@IdCidade", profissionais.Cidade.Id);
                    cmd.Parameters.AddWithValue("@IdEsp", profissionais.Especialidade.IdEspecialidade);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public static DataTable GetProfissionaisAll()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            using (var cmd = DbConnection().CreateCommand())
            { 
                cmd.CommandText = "SELECT IdProfissionais, Profissional, Cpf,Cidade, Especialista from Profissional";
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetProfissionailAll()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT pr.IdProfissional, ");
            sb.Append("        pr.NomeProfissional, ");
            sb.Append("        pr.Cpf,  ");
            sb.Append("        pr.Cidade Cidade, ");
            sb.Append("        pr.Especialidade Especialidade, ");
            sb.Append("        pr.fone ");
            sb.Append("   FROM Profissional pr ");
            sb.Append("        cidade cl ");
              
            sb.Append("  WHERE cl.IdCidade = pr.Cidade ");
            sb.Append("        Especialidade es ");
            sb.Append("  WHERE es.IdEsp= pr.Especialidade ");
           
            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                da.Fill(dt);
            }
            return dt;
        }



        #endregion

        #region Paciente
        public static void AddPaciente(Pacientee paciente)
        {
            try
            {

                string sql = "INSERT INTO Pac  (nomepac, cpf, fone) values (@NomePac, @Cpf, @Fone)";

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@NomePac", paciente.Nome);
                    cmd.Parameters.AddWithValue("@Cpf", paciente.Cpf);
                    cmd.Parameters.AddWithValue("@Fone", paciente.Fone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }


        public static DataTable GetPacienteAll()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT pa.IdPaciente, ");
            sb.Append("        pa.NomePac, ");
            sb.Append("        pa.Fone ");
            sb.Append("   FROM Pac pa ");


            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                da.Fill(dt);
            }
            return dt;
        }
        #endregion

        #region Agenda 

        public static void AddAgenda(Agendae agenda)
        {
            try
            {

                string sql = "INSERT INTO Agenda ( Paciente, Profissional, Valor, Horario, Data) values (@IdPac, @IdProfissionais, @Valor, @Horario, @Data) ";

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@IdPaciente", agenda.NomePaciente.IdPaciente);
                    cmd.Parameters.AddWithValue("@IdProfissionais", agenda.NomeProfissional.IdProfissional);
                    cmd.Parameters.AddWithValue("@Valor", agenda.Valor);
                    cmd.Parameters.AddWithValue("@Horario", agenda.Horario);
                    cmd.Parameters.AddWithValue("@Data", agenda.Data);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public static DataTable GetAgendaAll()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT IdAg, Paciente, Profissional, Valor, Horario, Data from Agenda ";
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetAgendasAll()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT ag.IdAg, ");
            sb.Append("        ag.Paciente Pac, ");
            sb.Append("        ag.Profissional Profissional,  ");
            sb.Append("        ag.Valor, ");
            sb.Append("       ag.Horario, ");
            sb.Append("       ag.Data ");
            sb.Append("   FROM Agenda ag ");
            sb.Append("        Pac pc ");
            sb.Append("  WHERE pc.IdPaciente = ag.Paciente ");
            sb.Append("        Profissional pr ");
            sb.Append("  WHERE pr.IdProfissionais = ag.Profissional ");

            using (var cmd = DbConnection().CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, DbConnection()); 
                da.Fill(dt);
            }
            return dt;
        }



        #endregion

    }
}
