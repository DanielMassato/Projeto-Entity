using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LibFWGeral
{
    public class ExportDataTable
    {
        private DataTable _table;
        /// <summary>
        /// DataTable que contém os dados que serão exportados
        /// </summary>
        public DataTable Table
        {
            get { return _table; }
            set { _table = value; }
        }

        private bool _csvWithCollumNames;
        /// <summary>
        /// Indica se a primeira linha do arquivo CSV é formada pelos nomes dos campos
        /// </summary>
        public bool CsvWithCollumNames
        {
            get { return _csvWithCollumNames; }
            set { _csvWithCollumNames = value; }
        }

        private Exception _error;
        /// <summary>
        /// Erro ocorrido no processo de exportação
        /// </summary>
        public Exception Error
        {
            get { return _error; }
            set { _error = value; }
        }

        private string _fileName;
        /// <summary>
        /// Nome do arquivo que será gerado
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private string _tagRoot;
        /// <summary>
        /// Tag ou elemento principal do XML 
        /// </summary>
        public string TagRoot
        {
            get { return _tagRoot; }
            set { _tagRoot = value; }
        }

        private string _tagRow;
        /// <summary>
        /// Tag ou elemento que conterá cada linha do XML (registro)
        /// </summary>
        public string TagRow
        {
            get { return _tagRow; }
            set { _tagRow = value; }
        }

        /// <summary>
        /// Exporta para XML colocando os campos como atributos da tag de linha
        /// </summary>
        /// <returns>true se a exportação foi bem sucedida</returns>
        public bool ExportToXMLAttributes()
        {
            try
            {
                // cria a tag ou elemento principal do XML
                XElement docXML = new XElement(_tagRoot);
                // percorre as linhas do DataTable
                for (int i = 0; i < _table.Rows.Count; i++)
                {
                    // cria o elemento que representa cada linha do XML
                    XElement elemento = new XElement(_tagRow);
                    // percorre as colunas da linha atual
                    for (int j = 0; j < _table.Columns.Count; j++)
                    {
                        // cria um atributo para cada campo
                        elemento.SetAttributeValue(_table.Columns[j].ColumnName, _table.Rows[i][j]);
                    }
                    // adiciona ao elemento principal a linha que acaba de ser gerada
                    docXML.Add(elemento);
                }
                // salva o arquivo XML
                docXML.Save(_fileName);
                // define que não houve erro
                _error = null;
                return true;
            }
            catch (Exception ex)
            {
                // sinaliza ocorrência de erro
                _error = ex;
                return false;
            }
        }

        /// <summary>
        /// Exporta para XML colocando cada campo como elemento da tag de linha
        /// </summary>
        /// <returns>true se a exportação foi bem sucedida</returns>
        public bool ExportToXMLElements()
        {
            try
            {
                // cria a tag ou elemento principal do XML
                XElement docXML = new XElement(_tagRoot);
                // percorre as linhas do DataTable
                for (int i = 0; i < _table.Rows.Count; i++)
                {
                    // cria o elemento que representa cada linha do XML
                    XElement elemento = new XElement(_tagRow);
                    // percorre as colunas da linha atual
                    for (int j = 0; j < _table.Columns.Count; j++)
                    {
                        // cria um atributo para cada campo
                        elemento.Add(new XElement(_table.Columns[j].ColumnName, _table.Rows[i][j]));
                    }
                    // adiciona ao elemento principal a linha que acaba de ser gerada
                    docXML.Add(elemento);
                }
                // salva o arquivo XML
                docXML.Save(_fileName);
                // sinaliza que não houve erro
                _error = null;
                return true;
            }
            catch (Exception ex)
            {
                // sinaliza que houve erro
                _error = ex;
                return false;
            }
        }
        /// <summary>
        /// Exporta para o padrão CSV
        /// </summary>
        /// <returns>true se a exportação foi bem sucedida</returns>
        public bool ExportToCSV()
        {
            try
            {
                // cria objeto para salvar arquivo texto
                StreamWriter sw = new StreamWriter(_fileName,false,Encoding.Default);
                // variável para gerar cada linha do arquivo
                string linha = "";
                // se a primeira linha precisar ter os nomes dos campos
                if (_csvWithCollumNames)
                {
                    // percorre as colunas do DataTable
                    for (int j = 0; j < _table.Columns.Count; j++)
                    {
                        // concatena os nomes dos campos separando-os por ";"
                        linha += _table.Columns[j].ColumnName + ";";
                    }
                    // retira o último ";" do dinal da linha
                    linha = linha.Substring(0, linha.Length - 1);
                    // grava a linha no arquivo
                    sw.WriteLine(linha);
                }
                // percorre as linhas do DataTable
                for (int i = 0; i < _table.Rows.Count; i++)
                {
                    // inicializa a variável linha
                    linha = "";
                    // percorre as colunas de cada linha
                    for (int j = 0; j < _table.Columns.Count; j++)
                    {
                        // concatena o conteúdo de cada coluna separando-os por ";"
                        linha += _table.Rows[i][j].ToString() + ";";
                    }
                    // retira o último ";" do dinal da linha
                    linha = linha.Substring(0, linha.Length - 1);
                    // grava a linha no arquivo
                    sw.WriteLine(linha);
                }
                // fecha o manipulador de arquivo
                sw.Close();
                // libera o objeto da memória
                sw.Dispose();
                // sinaliza que não houve erro
                _error = null;
                return true;
            }
            catch (Exception ex)
            {
                // sinaliza que houve erro
                _error = ex;
                return false;
            }
        }

    }
}
