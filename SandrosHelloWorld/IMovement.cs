using System.Security.Cryptography.X509Certificates;

namespace SandrosHelloWorld
{
    public class Point
    {
        public int X, Y;
    }

    public interface IMovement
    {
        void Move(Point location);

        Point CurrentLocation { get; }
    }
}