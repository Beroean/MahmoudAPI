using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahmoudAPI.Models
{
    public class Survey
    {
        /// <summary>
        /// Id to be used by SQL
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Message left by survey taker
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// City of the survey taker
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Date survey was taken
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime SurveyDate { get; set; }
    }
}
