using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifelessEmotionAnalyzer.Models
{
    public static class MusIntervals
    {
        public static Dictionary<double, Color> musIntervals = new Dictionary<double, Color>()
        {
            { 0.89, Color.FromArgb(102, 255, 153) }, // Большая секунда
            { 0.84, Color.FromArgb(153, 204, 255) }, // Малая терция
            { 0.79, Color.FromArgb(102, 255, 153) }, // Большая терция
            { 0.75, Color.FromArgb(255, 153, 255) }, // Кварта (чистая)
            { 0.67, Color.FromArgb(255, 153, 255) }, // Квинта (чистая)
            { 0.63, Color.FromArgb(191, 191, 191) }, // Малая секста
            { 0.6, Color.FromArgb(255, 153, 153) }, // Большая секста
            { 0.56, Color.FromArgb(255, 255, 153) }, // Маля септима
            { 0.53, Color.FromArgb(191, 191, 191) }, // Большая септима
            { 0.5, Color.FromArgb(191, 191, 191) } // Октава
        };
    }
}
