using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfServiceProxy
{
  public class WcfProxy : ClientBase<WcfService.IService1>, WcfService.IService1
  {
    public List<WcfContracts.Fish> GetFish()
    {
      return base.Channel.GetFish();
    }
  }
}
