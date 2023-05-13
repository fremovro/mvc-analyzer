using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifelessEmotionAnalyzer.Models.File
{
    public class WavFileModel
    {
        #region Заголовок Wav-файла
        /// <summary>
        /// Имя файла
        /// </summary>
        public string fileName;

        /// <summary>
        /// Номер эмоции
        /// </summary>
        public int emotionNum;

        /// <summary>
        /// Частота дискретизации
        /// </summary>
        public int sampleRate;

        /// <summary>
        /// Размер 1-го сэмпла (в байтах)
        /// </summary>
        public int blockAlign;

        /// <summary>
        /// Битрейт
        /// </summary>
        public int bitsPerSample;
        #endregion

        #region Содержимое Wav-файла
        public double[] soundData;
        #endregion

        public WavFileModel(string fileName, int emotionNum, int sampleRate, int blockAlign, int bitsPerSample, double[] soundData)
        {
            this.fileName = fileName;
            this.emotionNum = emotionNum;
            this.sampleRate = sampleRate;
            this.blockAlign = blockAlign;
            this.bitsPerSample = bitsPerSample;
            this.soundData = soundData;
        }
    }
}
