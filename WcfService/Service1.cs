using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
  public class Service1 : IService1
  {

    [PrincipalPermission(SecurityAction.Demand, Role = "WcfUsers")]
    public List<WcfContracts.Fish> GetFish()
    {
      return new List<WcfContracts.Fish>{
        new WcfContracts.Fish{ FishName = "Clown", FishColor = "Orange"},
        new WcfContracts.Fish{ FishName = "Grouper", FishColor = "Black"},
        new WcfContracts.Fish{ FishName = "Angel", FishColor = "Yellow"},
        new WcfContracts.Fish{ FishName = "Bluefish", FishColor = "Blue"}
      };
    }
  }
}
