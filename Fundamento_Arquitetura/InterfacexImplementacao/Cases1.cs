using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamento_Arquitetura.InterfacexImplementacao
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {

        }
    }

    public class RepositorioFake : IRepositorio
    {
        //Não vai realizar a persistencia, TESTE
        public void Adicionar()
        {

        }
    }

    public class UsoImplementacao
    {
        public void Processo()
        {
            //FORTE ACOPLAMENTO PELA IMPLEMENTAÇÃO DA CLASSE CONCRETA
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao
    {
        //Abstração do contrato
        private readonly IRepositorio _repositorio;

        //injeção de dependencia
        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }

    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            //TRÊS EXEMPLOS DE USO

            //ALTO ACOPLAMENTO
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            //CÓDIGO MAIS COESO 
            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new Repositorio());
            repoAbsFake.Processo();

        }
    }
}
