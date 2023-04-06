using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Model
{
    [Table("BMIResult")]
    public class BMIResult
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }
        
        [MaxLength(250)]
        public double Height { get; set; }
        [MaxLength(250)]
        public double Weight { get; set; }
        [MaxLength(250)]
        public double BMISCORE { get; set; }
        [MaxLength(250)]
        public string BMIRESULT { get; set; }
    }
}
