using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifelessEmotionAnalyzer.Models.File;
using System.Windows.Forms;

namespace LifelessEmotionAnalyzer.Entities
{
    internal class FileManager
    {
        /// <summary>
        /// Считывание файла (формат .wav)
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="numUpTimeStart"></param>
        /// <param name="numUpTimeRange"></param>
        /// <param name="dataContext"></param>
        public Dictionary<int, WavFileModel> ReadWavFiles(OpenFileDialog fileDialog, NumericUpDown numUpTimeStart, NumericUpDown numUpTimeRange, ProgressBar fileProgressBar)
        {
            var index = 0;
            var result = new Dictionary<int, WavFileModel>();

            fileProgressBar.Value = 0;
            fileProgressBar.Maximum = fileDialog.FileNames.Length;
            foreach (var file in fileDialog.FileNames)
            {
                using (FileStream fileStream = new FileStream(file, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(fileStream))
                {

                    #region Считывание заголовка
                    var chunkID = reader.ReadInt32();
                    var chunkSize = reader.ReadInt32();
                    var format = reader.ReadInt32();
                    var subchunk1ID = reader.ReadInt32();
                    var subchunk1Size = reader.ReadInt32();
                    var audioFormat = reader.ReadInt16();
                    var numChannels = reader.ReadInt16();
                    var sampleRate = reader.ReadInt32();
                    var byteRate = reader.ReadInt32();
                    var blockAlign = reader.ReadInt16();
                    var bitsPerSample = reader.ReadInt16();

                    if (subchunk1Size == 18)
                    {
                        var fmtExtraSize = reader.ReadInt16();
                        reader.ReadBytes(fmtExtraSize);
                    }
                    #endregion

                    #region Считываение данных
                    var dataID = reader.ReadInt32();
                    var dataSize = reader.ReadInt32();
                    var tempData = reader.ReadBytes(chunkSize);
                    #endregion

                    // Номер начального байта
                    var i = (int)((double)numUpTimeStart.Value * sampleRate * blockAlign);

                    // Номер конечного байта
                    var endByteNum = i + (int)((double)numUpTimeRange.Value * sampleRate * blockAlign);

                    var sound = 0;
                    var tempSoundData = new List<double>();

                    // Преобразование массива байтов в последовательность сигналов
                    while (i < tempData.Length && i < endByteNum)
                    {
                        if (bitsPerSample == 8)
                            sound = Convert.ToInt16(tempData[i]);
                        else if (bitsPerSample == 16)
                            sound = BitConverter.ToInt16(tempData, i);
                        else if (bitsPerSample == 32)
                            sound = BitConverter.ToInt32(tempData, i);

                        tempSoundData.Add(sound);
                        i += blockAlign;
                    }
                    reader.Close();
                    fileStream.Close();

                    result.Add(index,
                        new WavFileModel(file.Split('\\')[file.Split('\\').Length - 1].Split('.')[0].Split('-')[0],
                        Convert.ToInt32(file.Split('\\')[file.Split('\\').Length - 1].Split('.')[0].Split('-')[1]),
                        sampleRate, blockAlign, bitsPerSample, tempSoundData.ToArray()));

                    index++;
                }
                fileProgressBar.PerformStep();
            }

            return result;
        }
    }
}
