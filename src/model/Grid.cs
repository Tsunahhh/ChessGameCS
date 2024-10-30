
namespace model {
    class Grid {

        private static int SIZE = 8;
        private const int WHITE_PAWNS_LINE = 1;
        private const int WHITE_COMPLEX_LINE = 0;
        private const int BLACK_PAWNS_LINE = 6;
        private const int BLACK_COMPLEX_LINE = 7;
        private Case[,] board;
        internal Grid() {
            board = new Case[SIZE, SIZE];
            for (int y = 0; y < SIZE; ++y) {
                for (int x = 0; x < SIZE; ++x) {
                    board[y, x] = new Case();
                }
            }     
            InitPieces();     
        }

        private void InitLines(PlayerColor plColor) {

            int complexLine = (plColor == PlayerColor.WHITE) ? WHITE_COMPLEX_LINE : BLACK_COMPLEX_LINE;
            int pawnsLine = (plColor == PlayerColor.WHITE) ? WHITE_PAWNS_LINE : BLACK_PAWNS_LINE;
        
            Piece[] complexPieces = {
                Piece.ROOK, Piece.KNIGHT, Piece.BISHOP, Piece.QUEEN,
                Piece.KING, Piece.BISHOP, Piece.KNIGHT, Piece.ROOK
            };

            // Initialisations of lines 

            for (int i = 0; i < complexPieces.Length; i++) {
                board[complexLine, i].SetPiece(new PiecePlayer(plColor, complexPieces[i]));
            }

            for (int i = 0; i < board.GetLength(1); i++) {
                board[pawnsLine, i].SetPiece(new PiecePlayer(plColor, PieceType.PAWN));
            }
        }

        private void InitPieces() {
            InitLines(PlayerColor.WHITE);
            InitLines(PlayerColor.BLACK);
        }


        internal void Move(Position src, Position dst) {
            if (board[dst.y, dst.x].GetPlayerColor() != board[dst.y, dst.x].GetPlayerColor() != )
        }



        public override string ToString() {
            string res = "";
            for (int y = 0; y < SIZE; ++y) {
                for (int x = 0; x < SIZE; ++x) {
                    if (!board[y, x].IsEmpty()) {
                        res += board[y, x].GetPiece().GetPieceType() switch {
                            PieceType.PAWN => "P",
                            PieceType.BISHOP => "B",
                            PieceType.KNIGHT => "C",
                            PieceType.ROOK => "R",
                            PieceType.QUEEN => "Q",
                            PieceType.KING => "K",
                            _ => " ",
                        };
                    }
                    res += " ";
                }
                res += "\n";
            }
            return res;
        }
    }
}