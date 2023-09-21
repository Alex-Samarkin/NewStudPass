// NewStudPass
// NewStudPass
// Metric.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 2:43 21 09 2023

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewStudPass
{
    public class Metric
    {
        public int MetricId { get; set; }

        ///head coverage
        ///head height
        /// neck coverage
        /// neck length
        /// arm length
        /// shoulder length
        /// elbow length
        /// hand length
        /// biceps reach
        /// distance from little finger to thumb
        /// torso length
        /// chest volume
        /// belly volume
        /// waist circumference
        /// leg length
        /// thigh length
        /// thigh circumference
        /// shin length
        /// shin coverage
        /// foot length
        ///
        public DateTime? DateOfMeasure { get; set; }

        public int Height { get; set; }
        public int Weight { get; set; }
        [NotMapped] public double IMT => (double)((double)Weight / ((Height * Height) / 10000.0));
        public int head_coverage { get; set; }
        public int head_height { get; set; }
        public int neck_coverage { get; set; }
        public int neck_length { get; set; }
        public int arm_length { get; set; }
        public int shoulder_length { get; set; }
        public int elbow_length { get; set; }
        public int hand_length { get; set; }
        public int biceps_reach { get; set; }
        public int distance_from_little_to_thumb { get; set; }
        public int torso_length { get; set; }
        public int chest_volume { get; set; }
        public int belly_volume { get; set; }
        public int waist_circumference { get; set; }
        public int leg_length { get; set; }
        public int thigh_length { get; set; }
        public int thigh_circumference { get; set; }
        public int shin_length { get; set; }
        public int shin_coverage { get; set; }
        public int foot_length { get; set; }

        /// 
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Person Person { get; set; }

    }
}