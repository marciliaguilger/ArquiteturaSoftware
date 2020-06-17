using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamento_Arquitetura.InterfacexImplementacao
{
    #region Case1
    public class Pessoa
    {
        public string Nome;
        public DateTime DataNascimento;
    }

    //herança
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }
    }

    //composição
    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string  cpf { get; set; }
    }

    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Jorge Antonio",
                DataNascimento = DateTime.Now,
                cpf = "123123232"
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Jorge",
                    DataNascimento = DateTime.Now
                },
                cpf = "121212121"

            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }

    #endregion

    #region Caso2

    //repositorio generico
    public interface IRepositorio<T>
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    //repositorio especializado
    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepositorio<T>
    {

        public void Adicionar(T obj)
        {

        }

        public void Excluir(T obj)
        {

        }
    }

    //Repositorio especializado para pessoa (herança)
    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {

    }

    //composição
    public class RepositorioComposicaoPessoa: IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;
        
        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }
        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }
    }

    public class TestesHerancaComposicao2
    {
        public TestesHerancaComposicao2()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar( new Pessoa());
            repoH.Excluir(new Pessoa());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoC.Adicionar(new Pessoa());

        }
    }


    #endregion
}
