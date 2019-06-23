namespace TestesCsharp8
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void Deconstruct(out int idade, out string nome, out string cpf)
        {
            idade = Idade;
            nome = Nome;
            cpf = CPF;
        }
    }
}
