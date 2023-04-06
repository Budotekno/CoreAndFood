using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Models
{
    public class Service
    {
        [Key]
        public int ServicesId{ get; set; }
        public string ServicesHeadding { get; set; }
        public string ServicesHeaddingDepCommet { get; set; }
        public string ServicesHeaddingPicture1 { get; set; }
        public string ServicesHeaddingPicture2 { get; set; }
        public string ServicesHeaddingPicture3 { get; set; }
        public string ServicesMatterPicture { get; set; }
        public string ServicesMatter1Number { get; set; }
        public string ServicesMatter1Name { get; set; }
        public string ServicesMatter2Number { get; set; }
        public string ServicesMatter2Name { get; set; }  
        public string ServicesMatter3Number { get; set; }
        public string ServicesMatter3Name { get; set; }
        public string ServicesMatter4Number { get; set; }
        public string ServicesMatter4Name { get; set; }
        public string ServicesWriting1Name { get; set; }
        public string ServicesWriting1Commet { get; set; }
        public string ServicesWriting2Name { get; set; }
        public string ServicesWriting2Commet { get; set; }
        public string ServicesWriting3Name { get; set; }
        public string ServicesWriting3Commet { get; set; }
    }
}
