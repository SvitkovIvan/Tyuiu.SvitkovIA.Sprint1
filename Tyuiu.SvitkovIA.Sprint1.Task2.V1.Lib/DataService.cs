﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SvitkovIA.Sprint1.Task2.V1.Lib
{
    public class DataService : ISprint1Task2V1
    {
        public double ConvertKmToM(int value)
        {
            return (value / 1.6);
        }
    }
}
