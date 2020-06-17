using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02_Structural._2._3_Composite
{
    public class ExecucaoComposite
    {
        public static void Executar()
        {
            var validacaoCadastro = new Mensagem("O cadastro não foi realizado");
            var usuarioFormErro = new Mensagem("O usuário informou um nome inválido");
            var tamanhoNomeForm = new InputFromMessage("O nome precisa possuir mais de 2 caracteres");
            var nomeVazioForm = new InputFromMessage("O nome não pode possuir numeros");

            usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usuarioFormErro.AdicionarFilha(nomeVazioForm);

            validacaoCadastro.AdicionarFilha(usuarioFormErro);

            var domainUsuarioErro = new Mensagem("Problemas ao processar o cadastro do usuário");
            var cpfUsuarioDomain = new DomainMessage("O CPF informado está em uso");
            var emailUsuarioDomain = new DomainMessage("O EMail informado está em uso");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            var msgNivel1 = new Mensagem("Nivel 1");
            var msgNivel2 = new Mensagem("Nivel 2");
            var msgNivel3 = new Mensagem("Nivel 3");
            var msgNivel4 = new Mensagem("Nivel 4");
            var msgNivel5 = new Mensagem("Nivel 5");
            var msgNivel6 = new Mensagem("Nivel 6");


            msgNivel4.AdicionarFilha(msgNivel5);
            msgNivel3.AdicionarFilha(msgNivel4);
            msgNivel2.AdicionarFilha(msgNivel3);
            msgNivel1.AdicionarFilha(msgNivel2);

            validacaoCadastro.AdicionarFilha(msgNivel1);
            
            validacaoCadastro.ExibirMensagens(2);

        }
    }
}
