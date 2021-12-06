using System.Globalization;

namespace ConsolePrimeiro
{
    //Modificadores de acesso: INTERNAl - somente será acessada por aqrquivos dentro do mesmo assembly( ConsolePrimeiro)
    internal class Produto
    {
        private string _nome;
        //private double _preco;
        //private int _quantidade;

        //----------- PROPRIEDADES AUT0-IMPLEMENTADAS------------------
        public int Quantidade { get; set; }
        //NEssa implementação. a propriedade preço não poderá ter o preço modificado por outros arquivos!!!
        public double Preco { get; private set; }
       //---------------------------------------------------------------


        public Produto(string nome, double preco, int quantidade)
        {
            Nome = _nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome 
        {
            get 
            { 
                return _nome;
            }
            set 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //public double Preco { get { return _preco; } }
        //public int Quantidade { get { return _quantidade; } }
        /*
        public string GetNome()
        {
            return _nome;  
        }
        public void SetNome(string n) 
        { 
            if (n != null && n.Length > 1)
            {
                _nome = n;
            }
            
        }  */

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public Produto() { }

        public void AdicionaQtd(int a)
        {
            Quantidade += a;
        }
        public void DiminuiQtd(int a)
        {
            Quantidade -= a;
        }

        //------------------   SOBREPOSIÇÃO - override
        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + ", " + Quantidade.ToString() + 
                " unidades, TOTAL: $ " + ValorTotalEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
