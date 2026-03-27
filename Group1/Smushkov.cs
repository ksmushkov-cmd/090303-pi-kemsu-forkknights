using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForkKnights.Group1 {
  public class Smushkov : IKnight {

    public string Archetype { get; set; }
    public string Name { get; set; }
    public string Superpower { get; set; }
    public double RealityDistortionPercent { get; set; }  // Мощность искажения реальности
    public int QuantumCoherenceMinutes { get; set; }      // Длительность действия
    public int NeuralChipVersion { get; set; }            // Версия нейрочипа
    public bool IsLicensed { get; set; }                  // Лицензия на использование суперсилы
    public List<string> QuantumAnomalies { get; set; }    // Зафиксированные квантовые аномалии

    public Smushkov() {

      Archetype = "Cyber Detective";
      HasLicense = true;

      PastYearLicenseList = new List<string> { "2517", "2312", "2099" };
      PastYearLicenseList.Add("2075");
      Name = "Декард-2077";
      Specialization = "идентификация репликантов, работа с нейросетями класса «Оракул»";
      AccuracyRate = 0.003;
      NeuroDeckCharge = 42;
    }

    public string GetJobApplication() {

    }

  }
}
