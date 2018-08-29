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

        public string Serial;

        public DateTime Created;

    }
}
