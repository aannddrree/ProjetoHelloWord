namespace ProjetoHelloWord.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return "Id: " + this.Id + "\nNome: " + this.Nome;
        }
    }
}