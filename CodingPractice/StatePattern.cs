using System;
using System.Web;

namespace CodingPractice
{
    public interface AvatarState
    {
        public void Load(GGAvatar avatar);

        public void OnLoaded(GGAvatar avatar);

        public string toString();
    }

    public class NotLoaded : AvatarState
    {
        public void Load(GGAvatar avatar)
        {
            throw new NotImplementedException();
        }

        public void OnLoaded(GGAvatar avatar)
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            throw new NotImplementedException();
        }
    }

    public class Loading : AvatarState
    {
        public void Load(GGAvatar avatar)
        {
            Console.WriteLine("Cannot load a new avatar while one is currently loading.");
        }

        public void OnLoaded(GGAvatar avatar)
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            throw new NotImplementedException();
        }
    }

    public class Loaded : AvatarState
    {
        public void Load(GGAvatar avatar)
        {
            throw new NotImplementedException();
        }

        public void OnLoaded(GGAvatar avatar)
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            throw new NotImplementedException();
        }
    }

    public interface ForetellAppState
    {
        public string GetOculusAppId();

        public string GetAppId();

        public string GetFederatedAppId();
    }

    public class GGAvatarsForForetell : ForetellAppState
    {
        public string GetAppId()
        {
            return "7820u52nio545f";
        }

        public string GetFederatedAppId()
        {
            return "jgopijsrgs8";
        }

        public string GetOculusAppId()
        {
            return "nlkshdng8s7gs";
        }
    }

    public class ForetellUnified : ForetellAppState
    {
        public string GetAppId()
        {
            return "7820u52nio545f";
        }

        public string GetFederatedAppId()
        {
            return "jgopijsrgs8";
        }

        public string GetOculusAppId()
        {
            return "nlkshdng8s7gs";
        }
    }
}