using Chess;
using Chess.Drawers;

IDrawer drawer = new ConsoleDrawer();
IDrawer fileDrower = new FileDrawer();
ChessGame chess  = new ChessGame(fileDrower);

chess.Start();