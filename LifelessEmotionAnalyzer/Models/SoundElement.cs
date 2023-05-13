﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifelessEmotionAnalyzer.Models
{
    public class SoundElement
    {
        /// <summary>
        /// Амплитуда для АЧХ
        /// </summary>
        public double Amplitude = 0;

        /// <summary>
        /// Частота гармоники
        /// </summary>
        public double Frecuency = 0;

        public SoundElement(double Amplitude, double Frecuency)
        {
            this.Amplitude = Amplitude;
            this.Frecuency = Frecuency;
        }
    }
}
