using ProvaTecnica.Rh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaTecnica.Rh.DAL
{
    public class RhInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            var candidatos = new List<Candidato>  {
                new Candidato{idCandidato = 1, nomeCandidato = "Ricardo Aleixo", email ="ricardoaleixoo@gmail.com", telefoneCandidato = "(44) 9881-3556"},
                new Candidato{idCandidato = 2, nomeCandidato = "Patricia de Souza", email ="patricia@gmail.com", telefoneCandidato = "(11) 9988-7766"},
                new Candidato{idCandidato = 3, nomeCandidato = "Candidato de Jesus", email ="cand@gmail.com", telefoneCandidato = "(22) 9666-1266"}
            };

            candidatos.ForEach(s => context.Candidato.Add(s));
            context.SaveChanges();


            var tecnologias = new List<Tecnologia> { 
                new  Tecnologia { idTecnologia = 1 , nomeTecnologia = "JavaScript" , peso = 5}, 
                new  Tecnologia { idTecnologia = 2 , nomeTecnologia = "AngularJS" , peso = 5}, 
                new  Tecnologia { idTecnologia = 3 , nomeTecnologia = "C#" , peso = 4}, 
                new  Tecnologia { idTecnologia = 4 , nomeTecnologia = "MongoDB" , peso = 3}, 
                new  Tecnologia { idTecnologia = 5 , nomeTecnologia = "HTML" , peso = 4}, 
                new  Tecnologia { idTecnologia = 6 , nomeTecnologia = "CSS" , peso = 2}, 
                new  Tecnologia { idTecnologia = 7 , nomeTecnologia = "Delphi" , peso = 2} 
            };

            tecnologias.ForEach(s => context.Tecnologia.Add(s));
            context.SaveChanges();

            var vagas = new List<Vaga> { 
                new  Vaga { idVaga = 1 , nomeVaga = "Desenvolvedor Pleno"}, 
                new  Vaga { idVaga = 2 , nomeVaga = "Desenvolvedor Senior"}, 
                new  Vaga { idVaga = 3 , nomeVaga = "Desenvolvedor Treinee"}, 
                new  Vaga { idVaga = 4 , nomeVaga = "Analista de Testes"}, 
                new  Vaga { idVaga = 5 , nomeVaga = "Suporte Nivel 1"}, 
                new  Vaga { idVaga = 6 , nomeVaga = "Suporte Nivel 2"}, 
                new  Vaga { idVaga = 7 , nomeVaga = "Suporte Nivel 3"} 
            };

            vagas.ForEach(s => context.Vaga.Add(s));
            context.SaveChanges();
            
            /*var candidatoTecnologia = new List<CandidatoTecnologia> { 
                new  CandidatoTecnologia { idCandidatoTecnologia = 1,  idCandidato = 1, idTecnologia = 1, idVaga = 1}, 
            };*/


        }
    }
}