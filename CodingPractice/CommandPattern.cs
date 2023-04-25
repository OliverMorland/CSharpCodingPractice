using System;

namespace CodingPractice
{
    //Useful for when you have several vendor classes and you want to trigger their functions from a single controller
    //Like the GG Tablet apps
    //For the avatars 
    public class CommandInvoker
    {
        Command command;
        public void SetCommand(Command _command)
        {
            command = _command;
        }

        public void InvokeCommand()
        {
            command.Execute();
        }

        public void UndoCommand()
        {
            command.Undo();
        }
    }

    public interface Command
    {
        public void Execute();
        public void Undo();
    }

    public class Light
    {
        public void TurnLightOn()
        {
            Console.WriteLine("Light On..");
        }

        public void TurnLightOff()
        {
            Console.WriteLine("Turn Light Off..");
        }
    }


    public class OpenSpatialDrawingAppCommand : Command
    {
        GGSpatialDrawingApp spatialDrawingApp;

        public OpenSpatialDrawingAppCommand(GGSpatialDrawingApp _spatialDrawingApp)
        {
            spatialDrawingApp = _spatialDrawingApp;
        }

        public void Execute()
        {
            spatialDrawingApp.LaunchBrush();
            spatialDrawingApp.enabled = true;
        }

        public void Undo()
        {
            spatialDrawingApp.HideBrush();
            spatialDrawingApp.enabled = false;
        }
    }


    public class GGSpatialDrawingApp
    {
        public void LaunchBrush()
        {
            Console.WriteLine("Launching Spatial Drawing Brush");
        }

        public bool enabled = false;

        public void HideBrush()
        {
            Console.WriteLine("HidingBrush");
        }
    }

}
