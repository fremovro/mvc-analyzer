using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Neuro.Learning;
using Accord.Neuro;

namespace LifelessEmotionAnalyzer.Models.Network
{
    public class NetworkModel
    {
        public const int inputCount = 10;
        public const int outputCount = 3;

        /// <summary>
        /// Массив входных значений для обчующей/тестовой выборки
        /// </summary>
        public double[][] input;
        /// <summary>
        /// Массив выходных значений для обчующей/тестовой выборки
        /// </summary>
        public double[][] output;
        /// <summary>
        /// Файл нейросети
        /// </summary>
        public ActivationNetwork network;
        /// <summary>
        /// Функция обучения обратного распространения
        /// </summary>
        public BackPropagationLearning teacher0;
        /// <summary>
        /// Функция обучения дельта-рул
        /// </summary>
        public DeltaRuleLearning teacher1;
        /// <summary>
        /// Функция обучения простейшего персептрона (только для сети с 1 слоем)
        /// </summary>
        public PerceptronLearning teacher2;
        /// <summary>
        /// Функция обучения устойчивоого обратноого распространения
        /// </summary>
        public ResilientBackpropagationLearning teacher3;
        /// <summary>
        /// Функция обучения Левенберга-Маркварда
        /// </summary>
        public LevenbergMarquardtLearning teacher4;
        /// <summary>
        /// Конструктор сети для обучения/тестирования
        /// </summary>
        /// <param name="input"></param>
        /// <param name="ouput"></param>
        public NetworkModel(double[][] input, double[][] ouput)
        {
            this.input = input;
            this.output = ouput;
        }
        ///// <summary>
        ///// Конструктор сети для открытия уже обученной сети
        ///// </summary>
        ///// <param name="_network"></param>
        //public NetworkModel(string _network)
        //{
        //    this.network = (ActivationNetwork)Network.Load(_network);
        //}
    }
}
