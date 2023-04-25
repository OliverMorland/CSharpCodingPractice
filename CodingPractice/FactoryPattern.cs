using System;

namespace CodingPractice
{
    public class ShapeFactory
    {
        public Shape CreateShape(string shapeType)
        {
            if (shapeType == "RECTANGLE")
            {
                return new Rectangle();
            }
            else if (shapeType == "CIRCLE")
            {
                return new Circle();
            }
            else if (shapeType == "PENTAGON")
            {
                return new Pentagon();
            }
            else
            {
                return new NoShape();
            }
        }
    }


    public interface Shape
    {
        public void Draw();
    }

    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("______");
            Console.WriteLine("|     |");
            Console.WriteLine("|     |");
            Console.WriteLine("|_____|");
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("O");
        }
    }

    public class Pentagon : Shape
    {
        public void Draw()
        {
            Console.WriteLine("  ____ ");
            Console.WriteLine(" /    |");
            Console.WriteLine("/     |");
            Console.WriteLine("|_____|");
        }
    }

    public class NoShape : Shape
    {
        public void Draw()
        {
            Console.WriteLine("That is not a valid shape..");
        }
    }

    public interface GGAvatarFactory
    {
        public object GetMyUsersAvatarData();

        public GGAvatar InstantiateAvatar();
    }

    public class GGAvatarManager
    {
        public GGAvatar m_myAvatar;
        GGAvatarFactory m_avatarFactory;

        public GGAvatarManager(GGAvatarFactory _avatarFactory)
        {
            m_avatarFactory = _avatarFactory;
        }

        public void CreateMyAvatar()
        {
            object myUsersAvatarData = m_avatarFactory.GetMyUsersAvatarData();
            GGAvatar myAvatar = m_avatarFactory.InstantiateAvatar();
            m_myAvatar = myAvatar;
            myAvatar.LoadAvatarWithData(myUsersAvatarData);
        }

        public void CreateAndLoadAvatarWithData(object avatarData)
        {
            GGAvatar avatar = m_avatarFactory.InstantiateAvatar();
            avatar.LoadAvatarWithData(avatarData);
        }
    }

    public class GGMetaAvatarFactory : GGAvatarFactory
    {
        ulong m_userId = 896966;

        public object GetMyUsersAvatarData()
        {
            return m_userId;
        }

        public GGAvatar InstantiateAvatar()
        {
            return new GGMetaAvatar();
        }
    }

    public class GGReadyPlayerMeAvatarFactory : GGAvatarFactory
    {
        string m_avatarUrl = "sdg678s67hkjhg98789.glb";

        public object GetMyUsersAvatarData()
        {
            return m_avatarUrl;
        }

        public GGAvatar InstantiateAvatar()
        {
            return new GGReadyPlayerMeAvatar();
        }
    }

}
