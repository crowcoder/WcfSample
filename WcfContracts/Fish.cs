using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfContracts
{
  [DataContract]
  public class Fish
  {
    [DataMember]
    public string FishName { get; set; }
    [DataMember]
    public string FishColor { get; set; }
  }
}
