using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Game //En el enunciado sale que es un clase
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {
            Random random = new Random();
            players = new Player[2] { new Player(), new Player() };
            ActivePlayer = players[random.Next(0, 2)];
            boardGame = new Board();
            EndGame = false;

        }
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos que hay que editar
        //hay dos players [0] y [1]
        public bool CheckIfEndGame()
        {
            if (players[0].LifePoints == 0 or players[1].LifePoints == 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetWinner()

        {
            if CheckIfEndGame() == true
                {
                    //Hay un ganador
                }

        }
        public void Play()
            //Solo play?? 
        {
            throw new NotImplementedException();
        }
    }
}
