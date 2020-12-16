﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_App_Observer_Pattern_
{
    public interface Subject
    {
        public void RegisterObserver(Observer o);
        public void RemoveObserver(Observer o);
        public void NotifyObservers();
    }
}
