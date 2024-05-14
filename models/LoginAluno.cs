using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autenticacao.models
{
    public class LoginAluno
    {
        private string _AlunoNome;
        private string _AlunoSenha;
        public string UsuarioNome 
        {
            get => _AlunoNome.ToUpper();
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser  vazio");
                }
                _AlunoNome = value;
            }
        }

        public string AlunoSenha
        {
            get => _AlunoSenha.ToUpper();
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Senha inválida ou campo em branco! Por favor corriga seus dados.");
                }
            }
        }

    }
}