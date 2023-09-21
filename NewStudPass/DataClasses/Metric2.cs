// NewStudPass
// NewStudPass
// Metric2.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 4:58 21 09 2023

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewStudPass
{
    public class Metric2
    {
        public int Metric2Id { get; set; }

        [DisplayName("Дата обследования")]
        public DateTime? DateOfMeasure { get; set; }

        [DisplayName("Систолическое давление")]
        public int SistolicP_mmHg { get; set; }
        [DisplayName("Диастолическое давление")]
        public int DiastolicP_mmHg { get; set; }
        [DisplayName("Пульс (ударов в минуту)")]
        public int Pulse_bpm { get; set; }
        [DisplayName("Уровень кислорода")]
        public int SpO2 { get; set; }
        [DisplayName("Уровень глюкозы в крови")]
        public int Glu { get; set; }

        [DisplayName("Объем вдоха см3 (л*1000")]
        public int VolumeIn { get; set; }
        [DisplayName("Объем выдоха")]
        public int VolumeOut { get; set; }
        [DisplayName("Резервный объем на вдохе")]
        public int ReserveVolIn { get; set; }
        [DisplayName("Резервный объем на выдохе")]
        public int ReserveVolOut { get; set; }

        [NotMapped]
        [DisplayName("ЖЕЛ")]
        public int LiveVol => (VolumeIn+VolumeOut)/2 +ReserveVolIn+ReserveVolOut;

        /// 
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Person Person { get; set; }
    }
}