using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BattleshipPRJ.Models
{
    public class Jogo
    {
        private static int heidi = 0;

        [Required(ErrorMessage = "Por favor preenche o campo Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor seleciona a missão pretendida!")]
        public string Missao { get; set; }

        public int ID { get; set; } 

        public int Misseis { get; set; }

        public int Score { get; set; }

        public int Coordx { get; set; }

        public int Coordy { get; set; }

        public int Portaavioesrest { get; set; } 

        public int Quatrocanosrest { get; set; } 

        public int Trescanosrest { get; set; } 

        public int Doiscanosrest { get; set; } 

        public int Submanrinosrest { get; set; } 







        private int[,] grelha;



        public int[,] Grelha
        {
            get
            {
                return grelha;
            }

        }


        public void AltMissao()
        {
            if (Missao == "Antiaérea")
            {
                Misseis = 20;

            }
            else
            {

                Misseis = 50;

            }

        }

        //public int GerarID()
        //{
        //    Random rnd = new Random();

        //    int ID = rnd.Next(0, 1000);

        //    return ID;

        //}


        public Jogo()
        {
            heidi++;

            // criar um método gerar id que me vai gerar um id aleatório

            //ID = GerarID();

            ID=heidi;
            Portaavioesrest = 1;
            Quatrocanosrest = 1;
            Trescanosrest = 2;
            Doiscanosrest = 3;
            Submanrinosrest = 4;


            grelha = new int[10, 10]
            {
                //valores reservados:
                //-1=desconhecido (jogador não atirou aqui)
                //0=água; 1,2,3,4,5=barco de n canos
                //outros valores: não usados (pode definir o que quiser caso necessite)


                //nesta grelha de teste mostramos alguns quadrados marcados com água e outros com barcos
                //esta disposição não apareceria no jogo pois não há barcos de 4 canos com este formato
                { -1,-1,-1,-1,-1,-1,-1,-1,-1, -1},
                {-1, -1,-1,-1,-1,-1,-1,-1, -1,-1},
                {-1,-1, -1, -1, -1, -1, -1, -1,-1,-1},
                {-1,-1, -1,-1,-1,-1,-1, -1,-1,-1},
                {-1,-1, -1,-1, -1, -1,-1, -1,-1,-1},
                {-1,-1, -1,-1, -1, -1,-1, -1,-1,-1},
                {-1,-1, -1,-1,-1,-1,-1, -1,-1,-1},
                {-1,-1, -1, -1, -1, -1, -1, -1,-1,-1},
                {-1, -1,-1,-1,-1,-1,-1,-1, -1,-1},
                { -1,-1,-1,-1,-1,-1,-1,-1,-1, -1}
            };

        }











    }
}
