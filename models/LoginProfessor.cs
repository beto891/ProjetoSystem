using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Professor.models
{
    public class Professor
    {
        private string _ProfessorNome;
        private string _ProfessorSenha;

        public string ProfessorNome
        {
            get => _ProfessorNome.ToUpper();
            set
            {
                if(value == "")
                {
                    throw new ArgumentException ("Digite um nome válido");
                }
                value = _ProfessorNome;
            }
        }

        public string ProfessorSenha
        {
            get => _ProfessorSenha.ToUpper();
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Digite uma senha válida!");
                }
                value = _ProfessorSenha;
            }
        } 
    }
}