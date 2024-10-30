namespace model {
    internal enum PieceType {
        KING = 6,
        QUEEN = 5,
        ROOK = 4,
        BISHOP = 3,
        KNIGHT = 2,
        PAWN = 1
    }

    internal class Piece {
        private PieceType type;
        private bool moved;

        Piece(PieceType newType) {
            type = newType;
            moved = false;
        }

        internal void Moved() => moved = true;
        internal bool IsMoved() => moved;
        internal PieceType GetPieceType() => type;
    }
}