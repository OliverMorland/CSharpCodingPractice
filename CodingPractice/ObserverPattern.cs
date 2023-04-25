using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public class GGRecordingManager
    {
        List<GGRecordable> m_recordables;
        GGRecordingMenu m_recordingMenu;

        public GGRecordingManager(GGRecordingMenu _recordingMenu)
        {
            m_recordingMenu = _recordingMenu;
            m_recordingMenu.startRecordingButtonClicked += OnStartRecordingButtonClicked;
            m_recordingMenu.stopRecordingButtonClicked += OnStopRecordingButtonClicked;
        }

        public void RegisterRecordable(GGRecordable recordable)
        {
            m_recordables.Add(recordable);
        }

        public void UnRegisterRecordable(GGRecordable recordable)
        {
            m_recordables.Remove(recordable);
        }

        void OnStartRecordingButtonClicked()
        {
            foreach (GGRecordable recordable in m_recordables)
            {
                recordable.StartRecording();
            }
        }

        void OnStopRecordingButtonClicked()
        {
            foreach (GGRecordable recordable in m_recordables)
            {
                recordable.StopRecording();
            }
        }
    }

    public class GGRecordingMenu
    {
        public delegate void UIEvent();
        public event UIEvent startRecordingButtonClicked;
        public event UIEvent stopRecordingButtonClicked;

        public void ClickStart()
        {
            startRecordingButtonClicked();
        }

        public void ClickStop()
        {
            stopRecordingButtonClicked();
        }
        
    }

    public interface GGRecordable
    {
        public void StartRecording();

        public void StopRecording();
    }

    public class GGAudioRecorder : GGRecordable
    {
        public void StartRecording()
        {
            Console.WriteLine("Starting to record Audio");
        }

        public void StopRecording()
        {
            Console.WriteLine("Stop to record Audio");
        }
    }

    public class GGTransformRecorder : GGRecordable
    {
        public void StartRecording()
        {
            Console.WriteLine("Starting to record position and rotation");
        }

        public void StopRecording()
        {
            Console.WriteLine("Stopping recording of position and rotation");
        }
    }

    public class RecordAnimations : GGRecordable
    {
        public void StartRecording()
        {
            Console.WriteLine("Start Recording animations");
        }

        public void StopRecording()
        {
            Console.WriteLine("Stop Recording animations");
        }
    }


}
