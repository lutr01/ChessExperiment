namespace ChessGameByLu.Pieces
{
    /// <summary>
    /// describes the chess piece
    /// </summary>
    public class ChessPiece
    {
        public ChessPiece(string name, string color)
        {
            this.Color = color;
            this.Name = name;
        }

        public string Color { get; set; }
        public string Name { get; set; }

    }
}
