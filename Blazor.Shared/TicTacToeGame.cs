using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAndSignalR.Shared;

public class TicTacToeGame
{
    public string? PlayerXId { get; set; }
    public string? PlayerOId { get; set; }
    public string? CurrentPlayerId { get; set; }
    public string? CurrentPlayetSymbol => CurrentPlayerId == PlayerXId ? "X" : "O";
    public bool GameStarted { get; set; } = false; /*=> PlayerXId != null && PlayerOId != null;*/
    public bool GameOver { get; set; }
    public bool IsDraw { get; set; }
    public string? Winner { get; set; } = string.Empty;
    public List<List<string>> Board { get; set; } = new List<List<string>>(3);

    public TicTacToeGame()
    {
        InitializeBoard();
    }
    public void StartGame()
    {
        InitializeBoard();
        CurrentPlayerId = PlayerXId;
        GameStarted = true;
        GameOver = false;
        Winner = string.Empty;
        IsDraw = false;
    }
    private void InitializeBoard()
    {
        Board.Clear();
        for (int i = 0; i < 3; i++)
        {
            var row = new List<string>(3);
            for (int j = 0; j < 3; j++)
            {
                row.Add(string.Empty);
            }
            Board.Add(row);
        }

        //this one works as well. 
        //Board.Clear();
        //for (int i = 0; i < 3; i++)
        //{
        //    Board.Add(new List<string>(3));
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Board[i].Add(string.Empty);
        //    }
        //}  

    }
}
