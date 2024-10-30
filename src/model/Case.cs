namespace model {
    class Case {
        private bool empty;
        private PiecePlayer? piecePlayer;
        internal Case() {
            empty = true;
        }

        internal Case(PiecePlayer newPiece) {
            empty = false;
            piecePlayer = newPiece;
        }

        internal PlayerColor GetPlayerColor() => piecePlayer != null ? piecePlayer.PlColor : throw new Exception("This case is empty !");
        internal Piece GetPiece() => piecePlayer != null ? piecePlayer.Pc : throw new Exception("This case is empty !");
        internal bool IsContainedPieceMoved() => (piecePlayer != null) ? piecePlayer.Pc.IsMoved() : throw new Exception("This case is empty !");
        internal void SetPiece(PiecePlayer pcPlayer) {
            piecePlayer = pcPlayer;
            empty = false;
        }

        internal void Clear() {
            empty = true;
            piecePlayer = null;
        }

        internal bool IsEmpty() => empty;

        
    }
}