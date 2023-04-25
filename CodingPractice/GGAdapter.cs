using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public abstract class GGAvatar
    {
        List<GGAvatarComponent> m_avatarComponents;
        public abstract void LoadAvatarWithData(object data);
        public delegate void GGAvatarEvent();
        public event GGAvatarEvent m_avatarFinishedLoading;

        protected virtual void InvokeAvatarFinishedLoadingCallback()
        {
            m_avatarFinishedLoading();
        }

        public GGAvatarComponent GetAvatarsComponentOfType(GGAvatarComponent.ComponentType desiredComponentType)
        {
            GGAvatarComponent desiredComponent = null;
            foreach (GGAvatarComponent component in m_avatarComponents)
            {
                if (component.GetComponentType() == desiredComponentType)
                {
                    desiredComponent = component;
                }
            }
            return desiredComponent;
        }
    }

    public abstract class GGAvatarComponent
    {
        public enum ComponentType { LeftHand, RightHand, Head, VoiceSource, NameTag};
        public ComponentType m_type;

        public GGAvatarComponent(ComponentType componentType)
        {
            m_type = componentType;
        }

        public ComponentType GetComponentType()
        {
            return m_type;
        }

        public abstract void ConfigureGGFollower();
    }

    public class GGMetaAvatar : GGAvatar
    {
        ulong m_metaAvatarData;
        public override void LoadAvatarWithData(object data)
        {
            m_metaAvatarData = (ulong)data;
            Console.WriteLine("Gets Meta Avatar Entity, set _userId and calls LoadUser()");
        }
    }

    public class GGReadyPlayerMeAvatar : GGAvatar
    {
        string m_avatarUrl;
        public override void LoadAvatarWithData(object data)
        {
            m_avatarUrl = (string)data;
            Console.WriteLine("Using avatar url to use the AvatarLoader.LoadAvatar()");
            InvokeAvatarFinishedLoadingCallback();
        }
    }

    public class GGDynamicAvatar : GGAvatar
    {
        GGDynamicAvatarData m_avatarSelections;
        public override void LoadAvatarWithData(object data)
        {
            m_avatarSelections = (GGDynamicAvatarData)data;
            Console.WriteLine("Customising avatar based on selections made.");
            InvokeAvatarFinishedLoadingCallback();
        }
    }

    public struct GGDynamicAvatarData
    {
        public int m_headIndex;
        public int m_clothingIndex;
        public int m_hairIndex;
        public float m_skinLightness;
        public float m_hairHue;
        public float m_clothingHue;
    }


}
