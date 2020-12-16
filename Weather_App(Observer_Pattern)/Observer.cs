using System;
using System.Collections.Generic;
using System.Text;

namespace Weather_App_Observer_Pattern_
{
    public interface Observer
    {
        public void Update(double temp, double humidity, double pressure);
    }
}
