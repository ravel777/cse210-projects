using system;
namespace csharp;

public class Message
{
    public int _radius;
    public int _height;
    public int CircleArea(){
        return 2*3.14*(_radius*_radius);
    }
    public int CylenderVolume(){
        return 2*3.14*(_radius*_radius)*_height
    }
}
