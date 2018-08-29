using MechBuilder.Base;
using System;
using System.ComponentModel;

namespace MechBuilder {
    public class Mecha : BaseMecha {
        public Mecha() {
            this.Created = new DateTime();
            this.Name = "New Mecha";
            this.Serial = "New Serial";
        }
        private string serial;
        private DateTime _created;

        [Category("Mecha"),
        DefaultValueAttribute("New Serial"),
        DescriptionAttribute("Serial Number (Campaign dependent)")]
        public string Serial { get => serial; set => serial = value; }


        [Category("Mecha"),
        DescriptionAttribute("DateTime object was created")]
        public DateTime Created { get => _created; set => _created = value; }


    }
}
