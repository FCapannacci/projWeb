using System.Diagnostics.Contracts;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string data { get; set; }
        public string tipoDePessoa { get; set; }
        public string cpfCnpj { get; set; } 
        public string dataInscricao { get; set; }
        public bool isento { get; set; }    
        public string genero { get; set; }
        public string nascimento { get; set; }
        public bool bloqueado { get; set; } 
        public string senha { get; set; }



    }
}
