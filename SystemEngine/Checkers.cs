using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemEngine
{
    public class Checkers
    {
        public enum eGameStatus
        {
            OnGoing,
            EndedWithWin,
            EndedWithDraw
        }

        private readonly Player[] r_PlayersArray;
        private readonly Board r_GameBoard;
        private eGameStatus m_GameStatus;
        private readonly ArtificialIntelligence.eComputerLevel r_Difficulty;
        public event Action<Player, int, int> GameEnded;
        public event Action<GameMove, bool> MoveWasDone;
        public event Action<Pawn> PawnBecameKing;

        public Checkers(string i_FirstPlayerName, string i_SecondPlayerName, Player.ePlayerType i_RivalType,
                        int i_BoardSize, ArtificialIntelligence.eComputerLevel i_Difficulty)
        {
            r_PlayersArray = new Player[2];
            r_PlayersArray[0] = new Player(Player.ePlayerType.Human, Player.ePlayerColor.White, i_FirstPlayerName);
            r_PlayersArray[1] = new Player(i_RivalType, Player.ePlayerColor.Black, i_SecondPlayerName);
            r_GameBoard = new Board(i_BoardSize, i_BoardSize);
            m_GameStatus = eGameStatus.OnGoing;
            r_Difficulty = i_Difficulty;

            r_PlayersArray[0].InitializePlayerPawns(r_GameBoard);
            r_PlayersArray[1].InitializePlayerPawns(r_GameBoard);
            GenerateValidMovesToPawns();
        }

        public Board GameBoard
        {
            get { return r_GameBoard; }
        }

        public eGameStatus GameStatus
        {
            get { return m_GameStatus; }
            set { m_GameStatus = value; }
        }

        public Player[] PlayersArray
        {
            get { return r_PlayersArray; }
        }

        public Player GetPlayerInTurn()
        {
            return PlayersArray[0].IsPlayerTurn ? PlayersArray[0] : PlayersArray[1];
        }

        public Player GetPlayerNotInTurn()
        {
            return PlayersArray[0].IsPlayerTurn ? PlayersArray[1] : PlayersArray[0];
        }

        public int CalcAddedPointsToWinner(Player i_Winner, Player i_Loser)
        {
            int addedPoints = 0;

            foreach(Pawn pawn in i_Winner.PawnsArray)
            {
                addedPoints += pawn.IsKing ? 4 : 1;
            }
            foreach(Pawn pawn in i_Loser.PawnsArray)
            {
                addedPoints -= pawn.IsKing ? 4 : 1;
            }

            return addedPoints;
        }

        public void GenerateValidMovesToPawns(Pawn i_DoubleMovePawn = null)
        {
            bool isDoubleMove = i_DoubleMovePawn !=  null;

            if(isDoubleMove)
            {
                foreach(Player player in r_PlayersArray)
                {
                    foreach(Pawn pawn in player.PawnsArray)
                    {
                        pawn.PossibleMoves.Clear();
                    }                    
                }

                i_DoubleMovePawn.GeneratePawnPossibleMoves(r_GameBoard);
            }
            else
            {
                foreach(Player player in r_PlayersArray)
                {
                    foreach(Pawn pawn in player.PawnsArray)
                    {
                        pawn.GeneratePawnPossibleMoves(r_GameBoard);
                    }                    
                }   
            }
        }

        public bool DoMoveAndCheckIfDoubleMoveIsNeeded(GameMove i_Move = null, bool i_IsRealMove = true)
        {
            bool isDoubleMoveNeeded = false;
            bool didBecameKing = false;
              
            if(i_Move != null)
            {
                Pawn movingPawn = i_Move.SourceCell.PawnOnCell;

                GetPlayerInTurn().PlayedMovesHistory.Add(i_Move);
                movingPawn.PawnCurrentCell = i_Move.DestinationCell;
                i_Move.DestinationCell.PawnOnCell = movingPawn;
                i_Move.SourceCell.PawnOnCell = null;
                if(!movingPawn.IsKing && r_GameBoard.CheckIfPawnAtKingRow(movingPawn))
                {
                    movingPawn.IsKing = true;
                    didBecameKing = true;
                }

                if(i_Move.EatenPawn != null)
                {
                    i_Move.EatenPawn.PawnCurrentCell.PawnOnCell = null;
                    GetPlayerNotInTurn().PawnsArray.Remove(i_Move.EatenPawn);
                    movingPawn.GeneratePawnPossibleMoves(r_GameBoard);
                    isDoubleMoveNeeded = movingPawn.GetPossibleEatingMoves().Count > 0;
                }

                if (!isDoubleMoveNeeded)
                {
                    PlayersArray[0].IsPlayerTurn = !PlayersArray[0].IsPlayerTurn;
                    PlayersArray[1].IsPlayerTurn = !PlayersArray[1].IsPlayerTurn;
                    GenerateValidMovesToPawns();
                }
                else
                {
                    GenerateValidMovesToPawns(movingPawn);
                }

                if(i_IsRealMove)
                { 
                    OnMoveDone(i_Move, isDoubleMoveNeeded);
                    if(didBecameKing)
                    {
                        OnPawnBecameKing(movingPawn);
                    }
                    checkIfGameHasEndedAndUpdateAccordingly();
                }
            }
            else
            {
                DoMoveAndCheckIfDoubleMoveIsNeeded(ArtificialIntelligence.GenerateValidMovesToComputer(this, r_Difficulty));
            }

            return isDoubleMoveNeeded;
        }

        protected virtual void OnMoveDone(GameMove i_Move, bool i_IsDoubleMoveNeeded)
        {
            MoveWasDone?.Invoke(i_Move, i_IsDoubleMoveNeeded);
        }

        protected virtual void OnGameEnded
            (int i_FirstPlayerScore, int i_SecondPlayerScore, Player i_Winner = null)
        {
            GameEnded?.Invoke(i_Winner, i_FirstPlayerScore, i_SecondPlayerScore);
        }

        protected virtual void OnPawnBecameKing(Pawn i_Pawn)
        {
            PawnBecameKing?.Invoke(i_Pawn);
        }

        public void UnDoMove(GameMove i_Move, bool i_IsPlayerReplacementNeeded, bool i_IsKingDemotionNeeded)
        {
            Pawn movingPawn = i_Move.DestinationCell.PawnOnCell;
            if (GameStatus != eGameStatus.OnGoing)
            {
                if(GameStatus == eGameStatus.EndedWithWin)
                {
                    GetPlayerNotInTurn().Points -= CalcAddedPointsToWinner(GetPlayerNotInTurn(), GetPlayerInTurn());
                }

                GameStatus = eGameStatus.OnGoing;
            }

            if (i_IsPlayerReplacementNeeded)
            {
                PlayersArray[0].IsPlayerTurn = !PlayersArray[0].IsPlayerTurn;
                PlayersArray[1].IsPlayerTurn = !PlayersArray[1].IsPlayerTurn;
            }

            GetPlayerInTurn().PlayedMovesHistory.Remove(i_Move);
            movingPawn.PawnCurrentCell = i_Move.SourceCell;
            i_Move.SourceCell.PawnOnCell = movingPawn;
            i_Move.DestinationCell.PawnOnCell = null;

            if (i_Move.EatenPawn != null)
            {
                GetPlayerNotInTurn().PawnsArray.Add(i_Move.EatenPawn);
                i_Move.EatenPawn.PawnCurrentCell.PawnOnCell = i_Move.EatenPawn;
            }

            if(i_IsKingDemotionNeeded)
            {
                movingPawn.IsKing = false;
            }

            GenerateValidMovesToPawns();
        }

        public void ReloadNewGame()
        {
            r_GameBoard.ClearAllPawnsOnCells();
            foreach(Player player in PlayersArray)
            {
                player.IsPlayerTurn = player.PlayerColor == Player.ePlayerColor.White;
                player.PawnsArray.Clear();
                player.InitializePlayerPawns(r_GameBoard);
                player.PlayedMovesHistory.Clear();
            }
            GenerateValidMovesToPawns();
            m_GameStatus = eGameStatus.OnGoing;
        }

        private void checkIfGameHasEndedAndUpdateAccordingly()
        {
            bool firstPlayerHaveNoMoves = r_PlayersArray[0].GetPossibleMovesOfPlayer().Count == 0;
            bool secondPlayerHaveNoMoves = r_PlayersArray[1].GetPossibleMovesOfPlayer().Count == 0;
            bool firstPlayerLose = firstPlayerHaveNoMoves && r_PlayersArray[0].IsPlayerTurn;
            bool secondPlayerLose = secondPlayerHaveNoMoves && r_PlayersArray[1].IsPlayerTurn;

            if(firstPlayerHaveNoMoves && secondPlayerHaveNoMoves)
            {
                GameStatus = eGameStatus.EndedWithDraw;
                OnGameEnded(r_PlayersArray[0].Points, r_PlayersArray[1].Points);
            }
            else if(firstPlayerLose)
            {
                GameStatus = eGameStatus.EndedWithWin;
                CalcAndAddPointsToWinner(r_PlayersArray[1],r_PlayersArray[0]);
                OnGameEnded(r_PlayersArray[0].Points, r_PlayersArray[1].Points, r_PlayersArray[1]);
            }
            else if(secondPlayerLose)
            {
                GameStatus = eGameStatus.EndedWithWin;
                CalcAndAddPointsToWinner(r_PlayersArray[0],r_PlayersArray[1]);
                OnGameEnded(r_PlayersArray[0].Points, r_PlayersArray[1].Points, r_PlayersArray[0]);
            }
        }

        public void CalcAndAddPointsToWinner(Player i_Winner, Player i_Loser)
        {
            i_Winner.Points += CalcAddedPointsToWinner(i_Winner, i_Loser);
        }
    }
}
