using LibFWGeral;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidosDAL
{
    public class Clientes: SqlQuery
    {
        public Clientes() { }

        public Clientes(SqlConnection conn): base(conn)
        { }

        public int ConsultaGrid(string nome, string cidade,
                                string uf)
        {
            Command.CommandText =
                 @"SELECT CODCLI,NOME,ENDERECO,BAIRRO,CIDADE,ESTADO,CEP, 
                             FONE1,FAX,E_MAIL,CNPJ,INSCRICAO 
                    FROM CLIENTES 
                    WHERE NOME LIKE @nome AND CIDADE LIKE @cidade 
                          AND ESTADO LIKE @estado 
                    ORDER BY NOME";

            Command.Parameters.AddWithValue("@nome", "%" + nome + "%");
            Command.Parameters.AddWithValue("@cidade", "%" + cidade + "%");
            Command.Parameters.AddWithValue("@estado", uf + "%");

            return Fill();
        }
    }
}
