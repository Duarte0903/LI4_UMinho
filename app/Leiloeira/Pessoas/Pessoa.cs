using app.Leiloeira.Leiloes;
using app.Leiloeira.Transacoes;

namespace app.Leiloeira.Pessoas
{
    public class Pessoa
    {
        private int id;
        private TipoDePessoa tipo;
        private string email;
        private string password;
        private decimal saldo;
        private string telemovel;
        private string nickname;
        private Dictionary<int, Leilao> leiloesFavoritos;
        private Dictionary<int, Transacao> transacoesFeitas;

        //CONSTRUTORES//

        public Pessoa(int id, decimal saldo, string email, string password, string telemovel, string nickname, TipoDePessoa tipo, Dictionary<int, Leilao> leiloesFavoritos, Dictionary<int, Transacao> transacoesFeitas)
        {
            this.id = id;
            this.saldo = saldo;
            this.email = email;
            this.password = password;
            this.telemovel = telemovel;
            this.nickname = nickname;
            this.tipo = tipo;
            this.leiloesFavoritos = leiloesFavoritos;
            this.transacoesFeitas = transacoesFeitas;
        }

        //MÉTODOS DE ACESSO AOS ATRIBUTOS//

        public int getID()
        {
            return this.id;
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public decimal getSaldo()
        {
            return this.saldo;
        }

        public void setSaldo(decimal novoSaldo)
        {
            this.saldo = novoSaldo;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string novoEmail)
        {
            this.email = novoEmail;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string novaPassword)
        {
            this.password = novaPassword;
        }

        public string getTelemovel()
        {
            return this.telemovel;
        }

        public void setTelemovel(string novoTelemovel)
        {
            this.telemovel = novoTelemovel;
        }

        public string getNickname()
        {
            return this.nickname;
        }

        public void setNickname(string novoNickname)
        {
            this.nickname = novoNickname;
        }

        public TipoDePessoa getTipo()
        {
            return this.tipo;
        }

        public void setTipo(TipoDePessoa novoTipo)
        {
            this.tipo = novoTipo;
        }

        public Dictionary<int, Leilao> getLeiloesFavoritos()
        {
            return this.leiloesFavoritos;
        }

        public void setLeiloesFavoritos(Dictionary<int, Leilao> l)
        {
            this.leiloesFavoritos = l;
        }

        public Dictionary<int, Transacao> getTransacoesFeitas()
        {
            return this.transacoesFeitas;
        }

        public void setTransacoesFeitas(Dictionary<int, Transacao> t)
        {
            this.transacoesFeitas = t;
        }

        //OPERAÇÕES//
    }
}