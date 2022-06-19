using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap Command pattern
    //Command
    public interface ICommand
    {
        //void execute();
        void turnOn();

        void turnOff();

        string getName();
    }
}
