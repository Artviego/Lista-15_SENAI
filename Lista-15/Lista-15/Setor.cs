using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista_15
{
    public class Setor
    {
        private string id;
        private string nome;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Adicionar um setor
        public bool InserirSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string inserir = "insert into setores (idSetor, nome) values (@id, @nome);";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nome", Nome);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o setor - Método -> " + ex.Message, "Erro - Cadastrar Setor BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Verifica se o setor já existe
        public bool VerificarSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string consultaSetor = "SELECT COUNT(*) FROM setores WHERE idSetor = @id AND nome = @nome";
                    MySqlCommand comando = new MySqlCommand(consultaSetor, conexaoBanco);
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nome", Nome);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível verificar o setor -> " + ex.Message, "Erro - Verificar Setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AtualizarSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string atualizaSetor = "UPDATE setores SET nome = @nome WHERE idSetor = @id";

                    MySqlCommand comando = new MySqlCommand(atualizaSetor, conexaoBanco);
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nome", Nome);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível editar o setor -> " + ex.Message, "Erro - Atualizar Setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExcluirSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string excluirSetor = "DELETE FROM setores WHERE idSetor = @id AND nome = @nome";

                    MySqlCommand comando = new MySqlCommand(excluirSetor, conexaoBanco);
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nome", Nome);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível editar o setor -> " + ex.Message, "Erro - Excluir Setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<Setor> ListarSetores()
        {
            List<Setor> setores = new List<Setor>();
            using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
            {
                string listarSetores = "SELECT * FROM setores";
                MySqlCommand comando = new MySqlCommand(listarSetores, conexaoBanco);

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    setores.Add(new Setor
                    {
                        Id = reader["idSetor"].ToString(),
                        Nome = reader["nome"].ToString()
                    });
                }
            }
            return setores;
        }

        public static List<Setor> ListarSetorPorNome(string nome)
        {
            List<Setor> setores = new List<Setor>();
            using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
            {
                string listarSetorPorNome = "SELECT * FROM setores WHERE nome = @nome";
                MySqlCommand comando = new MySqlCommand(listarSetorPorNome, conexaoBanco);
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    setores.Add(new Setor
                    {
                        Id = reader["idSetor"].ToString(),
                        Nome = reader["nome"].ToString()
                    });
                }
            }
            return setores;
        }
    }
}
