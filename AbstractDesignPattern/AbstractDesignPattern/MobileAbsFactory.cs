using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    class MobileAbsFactory
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public MobileAbsFactory(IMobileClient factory)
        {
            smartPhone = factory.GetSmartPhone();
            normalPhone = factory.GetNormalPhone();
        }

        public void GetSmartPhoneModelDetails()
        {
             smartPhone.GetModelDetail();
        }

        public void GetNormalPhoneModelDetails()
        {
             normalPhone.GetModelDetail();
        }
    }
}
